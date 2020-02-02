using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace BookStore
{
    internal class EmployeeList
    {
        private string fileName = "employeeList.txt";
        private string fullPath;
        private string temporaryPath = "C:\\Users\\Mrah\\Desktop\\employeeList.txt";
        private Dictionary<int, Employee> employeeInfoDB = new Dictionary<int, Employee>();

        //Get employee data file. Using temporary static file path for testing convenience 
        public EmployeeList()
        {
            //fullpath = Path.GetFullPath(fileName);
            //System.Console.WriteLine(fullPath);
            //employeeInfo = File.ReadAllLines(fullPath);
            //employeeInfo = File.ReadAllLines(temporaryPath);
            StreamReader employeeInfoFile = new StreamReader(temporaryPath);
            string line;
            while ((line = employeeInfoFile.ReadLine()) != null)
            {
                string[] employeeInfo = line.Split('|');
                //User ID Validation(Doesn't exist, is in right format)
                if (!DoesIdExist(employeeInfo[0]) && Regex.IsMatch(employeeInfo[0], @"^[0-9]{5}$"))
                {
                    
                    employeeInfoDB[Convert.ToInt32(employeeInfo[0])] = Employee.CreateAndPopulateEmployeeObject(employeeInfo, this);

                }
                else//What to do if we have invalid entry in txt file/data corruption
                {

                }
            }
        }

        public bool DoesIdExist(int id)
        {
            return employeeInfoDB.ContainsKey(id);
        }
        public bool DoesIdExist(string id)
        {
            return employeeInfoDB.ContainsKey(Convert.ToInt32(id));
        }

        
        public Dictionary<int, Employee> GetList()
        {
            return employeeInfoDB;
        }

        //Look up employee info by ID
        public Employee LookUpEmployee(int id)
        {
            if (employeeInfoDB.ContainsKey(id))
            {
                return employeeInfoDB[id];
            }
            else
            {
                return null;
            }
        }




    }
}