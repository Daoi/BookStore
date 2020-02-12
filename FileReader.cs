using System.IO;
using System.Text.RegularExpressions;

namespace BookStore
{
    //Handle file stuff
    public class FileReader
    {
        public static string[] findLine(string isbn)
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

        public static bool ReadFile(string path, ref Book book, string isbn)
        {
            StreamReader sr = new StreamReader(path);
            string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] bookInfo = line.Split('|');
                    //ISBN ID Validatio(Two groups of 3 digits delimited by hyphen)
                    if (Book.ValidateISBNFormat(bookInfo[0]))
                    {
                        if (bookInfo[0] == isbn)
                        {
                            book = new Book(bookInfo);
                            sr.Close();
                            return true;
                        }
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
    }
}
