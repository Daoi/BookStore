using System;
using System.Collections.Generic;

namespace BookStore
{
    //Handles employee information
    public class Employee
    {
        private int employeeId;
        private string employeePin;
        private string employeeName;
        private decimal AnnualPay;
        private DateTime lastAccess;
        private DateTime startDate;
        
        public Employee(int id, string pin, string name, decimal salary, DateTime startDate)
        {
            //If value already in database, return invalid 
            employeeId = id;

            employeeName = name;
            
            employeePin = pin;

            AnnualPay = salary;

            this.startDate = startDate;

        }
        public Employee()
        {
            employeeId = 0;
            employeePin = "";
            employeeName = "";
            AnnualPay = 0.0m;
           
        }
        //Convert all the attributes into a proper string format, 
        //perhaps create a flag for Readable/vs writing to file formats
        override public string ToString()
        {

            return "";
        }
        //Update date of last access
        public void LogAccess()
        {
            lastAccess = DateTime.Today;
        }

        //Create an individual employee object, parse string data into appropriate fields
        //Ensure the employee ID isn't already on the list of employees
        public static Employee CreateAndPopulateEmployeeObject(string[] employeeInfo, EmployeeList empInfoDb)
        {
            //User ID conflict
            if (empInfoDb.DoesIdExist((employeeInfo[0])))
            {
                return null;
            }

            Employee newEmp = new Employee(Convert.ToInt32(employeeInfo[0]), employeeInfo[1], employeeInfo[2], Convert.ToDecimal(employeeInfo[3]), DateTime.Parse(employeeInfo[4]));
            return newEmp;
            

        }
        
        public int getId()
        {
            return employeeId;
        }

        public string getPin()
        {
            return employeePin;
        }

        public string getName()
        {
            return employeeName;
        }

    }
}