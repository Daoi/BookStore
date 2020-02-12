using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace BookStore
{
    public partial class frmMain : Form
    {
        const string bookFile = "bookList.txt";
        Employee currentUser;
        EmployeeList employeeInfo;
        Book currentBook;

        public frmMain(Employee user, EmployeeList info)
        {
            InitializeComponent();
            currentUser = user;
            employeeInfo = info;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            txtISBNNumLookUp.Mask = "000-000";
            txtISBNNumInfo.Mask = "000-000";
            lblWelcome.Text = "Welcome " + currentUser.getName();
            
        }

        private void btnISBNSearch_Click(object sender, EventArgs e)
        {
            FindAndSaveBook(txtISBNNumLookUp.Text);
        }

        public void FindAndSaveBook(string isbn)
        {
            string filepath = Path.GetFullPath(bookFile);
            if(FileHandler.bookSearch(bookFile, ref currentBook, txtISBNNumLookUp.Text)){

                UpdateDisplayInfo(currentBook.BookInfo());

            }
            else//There was a problem with something, do stuff?
            {

            }
        }

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

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            //string[] info = add info text boxes text
            //Convert to string, write to file 
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            
        }
        //I wish i put these text boxes on a panel so I didnt have to keep typing all of them out :[
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string[] info = {txtISBNNumInfo.Text,
                            txtTitleInfo.Text,
                            txtAuthorInfo.Text,
                            txtPriceInfo.Text,
                            txtOnHandInfo.Text,
                            txtDateInfo.Text
                            };
            if (info.Contains(""))//Make sure all fields have a value.
            {
                MessageBox.Show("Please fill out all of the book info fields", "Invalid data");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are you sure you'd like to add the book displayed to the inventory?",
                                      "Add Book", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Book addBook = new Book(info);
                    if (FileHandler.bookSearch(bookFile, ref addBook, info[0], "add"))
                    {
                        MessageBox.Show("The book has been succesfully added.", "Success!");
                    }
                }
                else
                {
                    MessageBox.Show("Action cancled.", "Cancled");
                    return;
                }
            }
        }
    }
}
