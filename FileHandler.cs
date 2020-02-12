using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    //Handle file stuff
    public class FileHandler
    {
        private static string tempFile = Path.Combine(Path.GetTempPath(), "SaveFile.txt");
        private const string sourceFile = "bookList.txt";
        private static Book currentBook;
        public static void WriteFile(string line, string flag = "")
        {

            if (flag == "add")
            {
                StreamWriter sw = File.AppendText(sourceFile);
                sw.Write(currentBook.ToString());
                sw.Close();
            }
            else {
                StreamWriter sw = new StreamWriter(tempFile);
                sw.Write(line + "\r\n");
                sw.Close();
            }
        }


        public static string[] FindLine(string isbn)
        {
            return null;
        }

        public static bool ReadFile(string path, ref EmployeeList employeeInfoDB)
        {
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] employeeInfo = line.Split('|');
                //User ID Validation(Doesn't exist, is in right format)
                if (Regex.IsMatch(employeeInfo[0], @"^[0-9]{5}$") && !employeeInfoDB.DoesIdExist(employeeInfo[0]))
                {

                    Employee currentEmployee = Employee.CreateAndPopulateEmployeeObject(employeeInfo, employeeInfoDB);
                    employeeInfoDB.AddEmployee(currentEmployee);
                    return true;

                }
                else//What to do if we have invalid entry in txt file/data corruption
                {
                    sr.Close();
                    return false;
                }
            }

            sr.Close();
            return false;

        }

        private static bool updateFile()
        {
            try
            {
                File.Move(tempFile, sourceFile);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool bookSearch(string path, ref Book book, string isbn, string flag = "")
        {
            currentBook = book;
            StreamReader sr = new StreamReader(path);
            string line;
            bool update = false;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] bookInfo = line.Split('|');
                    //ISBN ID Validatio(Two groups of 3 digits delimited by hyphen)
                    if (Book.ValidateISBNFormat(bookInfo[0]))
                    {
                        if (bookInfo[0] == isbn)
                        {
                            if(flag == "add")//They're trying to add a book but it already exists.
                            {
                                MessageBox.Show("The book you're trying to add already exists", "Book already exists");//Move to form code probably
                                return false;
                            }
                            else if(flag == "update")//File exists, update it and write new lines
                            {
                                WriteFile(book.ToString());
                                update = true;
                            }
                            else if(flag == "delete")//File exists, don't copy it to tempFile
                            {
                                break;
                            }
                            else { //No special flags, must be a look up.
                                book = new Book(bookInfo);
                                WriteFile(line);
                                sr.Close();
                                return true;
                            }
                        }
                        else//No matches, just write
                        {
                        WriteFile(line);
                        }
                    }
                    else//What to do if we have invalid entry in txt file/data corruption
                    {
                        MessageBox.Show("Inventory file has issue at ISBN: " + bookInfo[0], "Data Corruption");//Move to form code probably
                        sr.Close();
                        return false;
                    }

                }
            if (flag == "delete")//ISBN trying to be deleted wasn't found, return error
            {
                MessageBox.Show("No book with ISBN: " + isbn + " exists in inventory file", "Missing data");//Move to form code probably
                return false;
            }
            if (flag == "add")//The ISBN trying to be added wasn't found, we can append it to end of file
            {
                sr.Close();
                WriteFile(book.ToString(), flag);
                return true;
            }
            if(flag == "update")
            {
                return update;
            }

            if (updateFile())
            {
                MessageBox.Show("Changes succesful.", "Success!");//Move to form code probably
                sr.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Could not make changes, file write error.", "Error!");//Move to form code probably
                return false;
            }

        }


    }
}
