using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    //Models books, handles the creation of strings/storing info of a book record.
    public class Book
    {   
        private string isbn;
        private string title;
        private string author;
        private decimal price;
        private int numberOnHand;
        private DateTime lastTransaction; //Use ToString("d") for displaying in correct format

        //Default book values if we need
        public Book()
        {
            isbn = "000-000";
            title = "";
            author = "";
            price = 0.00m;
            numberOnHand = 0;
            lastTransaction = DateTime.Today;
        }
        //Try to validate the data, sets to default value and asks user to update record if theres an issue. 
        //The alternative is just canceling the process.
        public Book(string[] bookInfo)
        {
            isbn = bookInfo[0];
            title = bookInfo[1];
            author = bookInfo[2];
            if (bookInfo[3].Contains("$"))
            {
                bookInfo[3] = bookInfo[3].Replace("$", "");
            }
            if (!Decimal.TryParse(bookInfo[3], out price) || Decimal.Parse(bookInfo[3]) <= 0)
            {
                MessageBox.Show("Book list data valid, ISBN: " + isbn + ". Price error. Check sticker and update.", "Data Corruption");
                price = 0.00m;
            }
            if (!int.TryParse(bookInfo[4], out numberOnHand) || int.Parse(bookInfo[4]) < 0)
            {
                MessageBox.Show("Book list data invalid, ISBN: " + isbn + ". Inventory Count Error. Recount and Update record.", "Data Corruption");
                numberOnHand = 0;
            }
            if (!DateTime.TryParse(bookInfo[5], out lastTransaction))
            {
                MessageBox.Show("Book list data invalid, ISBN: " + isbn + ". Transaction Date Error.", "Data Corruption");
                lastTransaction = DateTime.Today.Date;
            }
        }

        //Put the strings properties in a single "line" for writing to a file.
        override public string ToString() {
            StringBuilder sb = new StringBuilder();
            string[] info = BookInfo();
            if(info[3].Contains('$'))//Remove added dollar sign added to textbox used to display salary
            {
                info[3] = info[3].Replace("$", "");
            }
            foreach(var value in info)
            {
                sb.Append(value + '|');
            }
            sb.Remove(sb.Length - 1, 1); //Remove last '|'
            return sb.ToString();
        }
        //Put the book's properties in a string array
        public string[] BookInfo()
        {

            string[] info = {isbn,
                            title,
                            author,
                            price.ToString("c"),
                            numberOnHand.ToString(),
                            lastTransaction.ToString("d")
                            };
            return info;
           
        }

        public static bool ValidateISBNFormat(string isbn)
        {
            return Regex.IsMatch(isbn, @"^\d{3}(?:-\d{3})$");
        }
    }
}