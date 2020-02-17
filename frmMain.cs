using System;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

namespace BookStore
{   //TODO: Put validation in method.
    //The "Main" form. Handles all the actions related to books. Search/Add/Delete/Update a record. Display relevant info.
    public partial class frmMain : Form
    {
        const string bookFile = "bookList.txt";
        Employee currentUser;
        EmployeeList employeeInfo;
        Book currentBook;
        FileHandler fh;
        string[] validation = new string[] //String array of regex to validate user data
                                           { @"^\d{3}(?:-\d{3})$", //ISBN (3 digits - 3 digits)
                                             @"(.*?)", //Title (Matches any string)
                                             @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", //Author(Start alphabetical, allow special character/space, end Alphabetical)
                                             @"^[$]?(0|[1-9]\d*)(\.\d+)?$", //Price(Positive fractional or whole numbers, with period seperator)
                                             @"^(0|[1-9]\d*)$"};//Number on hand(Positive whole numbers)
        //Retrieve the currentUser and Employee List from form1. Initialize our file handler.
        public frmMain(Employee user, EmployeeList info)
        {
            InitializeComponent();
            currentUser = user;
            employeeInfo = info;
            fh = new FileHandler(bookFile);

        }

        //Greet user
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + currentUser.getName();   
        }
        //Look up an ISBN number in our bookList file. Calls bookSearch in FileHandler class. Updates display for users.
        private void btnISBNSearch_Click(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtISBNNumLookUp.Text, validation[0]))
            {
                MessageBox.Show("Invalid ISBN number, please re enter." + validation[0], "Invalid ISBN");
                return;
            }

            if (fh.bookSearch(ref currentBook, txtISBNNumLookUp.Text))
            {

                UpdateDisplayInfo(currentBook.BookInfo());

            }
            else//There was a problem with something, do stuff?
            {
                MessageBox.Show("ISBN not valid or file corrupted", "File Error");
            }
        }
       //Display relevant values in the textboxes at bottom of the form
        public void UpdateDisplayInfo(string[] info)
        {

            txtISBNNumInfo.Text = info[0];
            txtTitleInfo.Text = info[1];
            txtAuthorInfo.Text = info[2];
            txtPriceInfo.Text = info[3];
            txtOnHandInfo.Text = info[4];
            txtDateInfo.Text = info[5];
        }

        private void btnExitSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Find a record and update it based on textboxes at bottom of form.
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            updateDate();
            string[] info = getInfo();
            if (validateInfo())
            {
                DialogResult dr = MessageBox.Show("Are you sure you'd like to update the book displayed to the inventory?",
                                    "Update Book", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Book updateBook = new Book(info);
                    string updatedInfo = updateBook.ToString();
                    if (fh.bookSearch(ref updateBook, info[0], "update"))
                    {
                        fh.updateFile();
                        MessageBox.Show("The book has been succesfully updated.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("ISBN: " + info[0] + " couldn't be updated.", "Error!");
                    }
                }
                else//No or exited prompt.
                {
                    MessageBox.Show("Action cancled.", "Cancled");
                    return;
                }
            }
        }
        //Search for an ISBN, if we find it, delete it. 
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string[] info = getInfo();
            Book deleteBook = new Book(info);
            if(!Regex.IsMatch(info[0], validation[0])){//Only need the isbn for delete
                MessageBox.Show("Invalid ISBN number please re enter.","ISBN error");
                return;
            }
            if (fh.bookSearch(ref deleteBook, info[0], "delete"))
            {
                fh.updateFile();
                MessageBox.Show("Book with ISBN: " + info[0] + " has been deleted.", "Succesful Delete");
                info.ToList().ForEach(x => x = "");
            }
            else
            {
                MessageBox.Show("Book with ISBN: " + info[0] + " was not deleted or didn't exist", "Action cancled");
            }

        }
        //I wish i put these text boxes on a panel so I didnt have to keep typing all of them out :[
        //Add a record to the file, if the ISBN already exists, don't add it.
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            updateDate();
            string[] info = getInfo();
            if (validateInfo())
            {
                DialogResult dr = MessageBox.Show("Are you sure you'd like to add the book displayed to the inventory?",
                                          "Add Book", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Book addBook = new Book(info);
                    if (!fh.bookSearch(ref addBook, info[0]))
                    {
                        if (fh.addBook(addBook.ToString()))
                        {

                            MessageBox.Show("The book has been succesfully added.", "Success!");
                        }
                        else
                        {
                            MessageBox.Show("Error adding book", "File Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book with ISBN: " + info[0] + " already exists. Recheck your info.", "Duplicate Record");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Action cancled.", "Cancled");
                    return;
                }
            }
        }
        //Stop people from using the space key for ISBN numbers.
        //Can still "enter" white spaces with arrow keys
        //But an extra attempt at data validation.
        private void txtISBNNumLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void txtISBNNumInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }
        //Utility stuff
        public string[] getInfo() {

            string[] info = {
                            txtISBNNumInfo.Text,
                            txtTitleInfo.Text,
                            txtAuthorInfo.Text,
                            txtPriceInfo.Text,
                            txtOnHandInfo.Text,
                            txtDateInfo.Text
                            };
            return info;
        }

        public bool validateInfo() {

            string[] info = getInfo();

            for (int i = 0; i < info.Length; i++)
            {
                if (i < 5)
                {
                    if (!Regex.IsMatch(info[i], validation[i]))
                    {
                        MessageBox.Show("Invalid data input, please recheck the fields at the bottom." + validation[i], "Data Error");
                        return false;
                    }
                }
                else
                {
                    try
                    {
                        DateTime.Parse(info[5]);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid date input, please recheck the fields at the bottom.", "Data Error");
                        return false;
                    }
                }
            }//Validation End
            return true;
        }

        private void updateDate()
        {
            if (txtDateInfo.Text != DateTime.Today.ToString("MM/dd/yyyy"))
            {
                DialogResult dr = MessageBox.Show("The last transaction date field doesn't have todays date." + "\r\n" + 
                    "Would you like to use todays date: " + DateTime.Today.ToString("MM/dd/yyyy") + "?",
                        "Update Date", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    txtDateInfo.Text = DateTime.Today.ToString("MM/dd/yyyy");
                }
            }
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
