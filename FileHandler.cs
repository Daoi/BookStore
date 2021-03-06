﻿using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    //Handles all the reading/writing of files involved in the project.
    public class FileHandler
    {
        private static string tempFile = Path.Combine(Path.GetTempPath(), "BSTempFile.txt");
        private static string backUpFile = "bookList.bak";
        private static string sourceFile = "bookList.txt";
        private static Book currentBook;
        private static StreamWriter sw;// new StreamWriter(tempFile);
        private static StreamReader sr;

        public FileHandler(string path)
        {
            sourceFile = path;

        }
        //Remove empty lines from the file.
        public void RemoveEmptyLines()
        {
            try
            {
                using (sr = new StreamReader(sourceFile))
                using (sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                File.Copy(tempFile, sourceFile, true);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        //Append the line to the end of the bookList file to add a new book.
        public bool addBook(string line)
        {
            try
            {
                using (sw = File.AppendText(sourceFile))
                {
                    sw.Write("\r\n" + currentBook.ToString());
                }
                RemoveEmptyLines();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Add error!");
                return false;
            }
        }

        //Read the employee file and create the list(Dictionary) of employees. Key = User ID, Value = Employee object. No search needed.
        public static bool ReadEmployeeFile(string path, ref EmployeeList employeeInfoDB)
        {
            sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] employeeInfo = line.Split('|');
                //User ID Validation(Doesn't exist, is in right format)
                if (Regex.IsMatch(employeeInfo[0], @"^[0-9]{5}$") && !employeeInfoDB.DoesIdExist(employeeInfo[0]))
                {

                    Employee currentEmployee = Employee.CreateAndPopulateEmployeeObject(employeeInfo, employeeInfoDB);
                    employeeInfoDB.AddEmployee(currentEmployee);

                }
                else//What to do if we have invalid entry in txt file/data corruption
                {
                    sr.Close();
                    MessageBox.Show("Employee file invalid data error.", "Data error");
                    return false;
                }
            }

            sr.Close();
            return true;
        }
        //Copy our temp file to the location of our source file and over write. Also create a back up(Not really used atm.)
        public bool UpdateFile()
        {     
            try
            {
                File.Replace(tempFile, sourceFile, backUpFile);
                RemoveEmptyLines();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "File Error");
                return false;
            }
        }

        public static bool updateEmployeeFile(EmployeeList employeeInfoDB, string path) {

                sw = new StreamWriter(tempFile);
            try
            {
                foreach (var employee in employeeInfoDB.GetList().Values)
                {
                    sw.WriteLine((employee.ToString()));
                }

                sw.Close();

                File.Replace(tempFile, path, "employeeList.bak");
                StringBuilder sb = new StringBuilder();

                foreach (var employee in employeeInfoDB.GetList().Values)
                {
                    sb.Append(employee.ToString(true));
                    sb.Append("\r\n");
                }

                MessageBox.Show(sb.ToString(), "Updated Employee List");
                return true;
            }
            catch(Exception e)
            {
                sw.Close();
                MessageBox.Show("Error updating employee file" + e.ToString(),"File Error");
                return false;
            }
        }


        //Handles searching the book file for the specified book, as well as deleting/updating files.
        //Flags are "delete"/"update". Add is handled with a boolean and then calling the addBook method.
        //Doing it this way prevents having to re-search/scan the file for deleting/updating. 
        //While you could do delete/update in similar ways it revolves around constantly keeping track
        //of the Reader/Writer which I feel is more difficult to follow than this method.
        //However, this method does kind of do a lot and is a pain to read through.
        public bool bookSearch(ref Book book, string isbn, string flag = "")
        {
            sw = new StreamWriter(tempFile);
            sr = new StreamReader(sourceFile);
            currentBook = book; //Store original book passed
            string line;
            bool found = false;
            flag.ToLower();

                while ((line = sr.ReadLine()) != null)
                {
                    string[] bookInfo = line.Split('|');
                    //ISBN ID Validatio(Two groups of 3 digits delimited by hyphen)
                    if (Book.ValidateISBNFormat(bookInfo[0]))
                    {
                        if (bookInfo[0] == isbn && flag == "")//Just a search, return the book that was being looked for/dont modify file
                        {
                            book = new Book(bookInfo);
                            found = true;
                            sw.Close();
                            sr.Close();
                            return found;
                        }
                        else if(bookInfo[0] == isbn && flag == "delete")//Record found, delete it? If yes, just skip writing.
                        {
                            Book deleteBook = new Book(bookInfo);
                            DialogResult dr = MessageBox.Show("Book with ISBN: " + isbn + " found.\r\n" +
                                          String.Join(Environment.NewLine,deleteBook.BookInfo()) + "\r\nIs this the book you wish to delete?",
                                         "Delete Book", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                found = true;
                            }
                            
                        }
                        else if (bookInfo[0] == isbn && flag == "update")//Update a record
                        {
                            sw.WriteLine(currentBook.ToString());
                            found = true;
                        }
                        else//This book doesn't match the book being searched for, safe to just write it.
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                    else//What to do if we have invalid entry in txt file/data corruption
                    {
                        if (!string.IsNullOrEmpty(line)) {
                            MessageBox.Show("Inventory file has issue at ISBN: " + bookInfo[0], 
                                "Data Corruption");//Move to form code probably
                                return false;
                        }
                    }
            }
            sr.Close();
            sw.Close();
            return found;
        }
    }
}
