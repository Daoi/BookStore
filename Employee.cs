using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

        
        public Employee(int id, string pin, string name, decimal salary, DateTime lastAccess)
        {
            //If value already in database, return invalid 
            employeeId = id;

            employeeName = name;
            
            employeePin = pin;

            AnnualPay = salary;

            this.lastAccess = lastAccess;

        }
        public Employee()
        {
            employeeId = 0;
            employeePin = "";
            employeeName = "";
            AnnualPay = 0.0m;
           
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
            try
            {
                Employee newEmp = new Employee(Convert.ToInt32(employeeInfo[0]), employeeInfo[1], employeeInfo[2], Convert.ToDecimal(employeeInfo[3]), DateTime.Parse(employeeInfo[4]));
                return newEmp;
            }
            catch (Exception e)
            {
                MessageBox.Show("Employee file data contains invalid information.", "Data error");
                return new Employee();
            }

        }

        public string ToString(bool flag = false)//false for file, true for display
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (!flag)
                {
                    sb.Append(employeeId.ToString() + "|");
                    sb.Append(employeePin + "|");
                    sb.Append(employeeName + "|");
                    sb.Append(AnnualPay.ToString() + "|");
                    sb.Append(lastAccess.ToString("MM/dd/yyyy"));
                }
                else
                {
                    sb.Append("Id: " + employeeId.ToString() + "\r\n");
                    sb.Append("Pin: " + employeePin + "\r\n");
                    sb.Append("Name: " + employeeName + "\r\n");
                    sb.Append("Salary: " + AnnualPay.ToString("c") + "\r\n");
                    sb.Append("Last Access: " + lastAccess.ToString("MM/dd/yyyy") + "\r\n");
                }
            }
            catch
            {
                MessageBox.Show("Employee record: " + employeeId + " has invalid data", "Data Error");
                return "";
            }
            return sb.ToString();
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