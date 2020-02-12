using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    public class Book
    {
        private string isbn;
        private string title;
        private string author;
        private decimal price;
        private int numberOnHand;
        private DateTime lastTransaction; //Use ToString("d") for displaying in correct format

        public Book()
        {
            isbn = "000-000";
            title = "";
            author = "";
            price = 0.00m;
            numberOnHand = 0;
            lastTransaction = DateTime.Today;
        }

        public Book(string[] bookInfo)
        {
            isbn = bookInfo[0];
            title = bookInfo[1];
            author = bookInfo[2];
            if (bookInfo[3].Contains("$"))
            {
                bookInfo[3] = bookInfo[3].Replace("$", "0");
            }
            if (!Decimal.TryParse(bookInfo[3], out price))
            {
                MessageBox.Show("Book list data corrupted, ISBN: " + isbn + ". Price error. Check sticker and update.", "Data Corruption");
                price = 0.00m;
            } 
            if (!int.TryParse(bookInfo[4], out numberOnHand))
            {
                MessageBox.Show("Book list data corrupted, ISBN: " + isbn + ". Inventory Count Error. Recount and Update.", "Data Corruption");
                numberOnHand = 0;
            }
            if (!DateTime.TryParse(bookInfo[5], out lastTransaction))
            {
                MessageBox.Show("Book list data corrupted, ISBN: " + isbn + ". Transaction Date Error.", "Data Corruption");
                lastTransaction = DateTime.Today;
            }

        }

        public Boolean IsMatch(string isbn)
        {
            return false;
        }

        override public string ToString() {
            StringBuilder sb = new StringBuilder("\r\n");
            string[] info = BookInfo();
            if(info[3].Contains('$'))
            {
                info[3] = info[3].Replace("$", "");
            }
            foreach(var value in info)
            {
                if(value is string)
                {
                    sb.Append(value + '|');
                }
                else
                {
                    MessageBox.Show("I don't think this can happen", "I hope this can't happen");
                }
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

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

        public static Boolean ValidateISBNFormat(string isbn)
        {
            return Regex.IsMatch(isbn, @"^\d{3}(?:-\d{3})$");
        }




    }
}