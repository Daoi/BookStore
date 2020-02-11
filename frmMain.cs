using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            StreamReader bookInfoFile = new StreamReader(filepath);

            string line;
            while ((line = bookInfoFile.ReadLine()) != null)
            {
                string[] bookInfo = line.Split('|');
                //ISBN ID Validatio(Two groups of 3 digits delimited by hyphen)
                if (Book.ValidateISBNFormat(bookInfo[0]))
                {
                    if (bookInfo[0] == txtISBNNumLookUp.Text)
                    {
                        currentBook = new Book(bookInfo);
                        UpdateDisplayInfo(currentBook.BookInfo());
                    }
                }
                else//What to do if we have invalid entry in txt file/data corruption
                {

                }
            }
            bookInfoFile.Close();
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
    }
}
