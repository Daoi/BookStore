using System;
using System.Collections.Generic;

namespace BookStore
{
    //Handles employee roster, using a Map<int(UserID), Employee(Obj)>
    public class EmployeeList
    {
        private Dictionary<int, Employee> employeeInfoDB = new Dictionary<int, Employee>();

        //Get employee data file. Using temporary static file path for testing convenience 
        public EmployeeList()
        {
        }
        //Check for valid IDs
        public bool DoesIdExist(int id)
        {
            return employeeInfoDB.ContainsKey(id);
        }
        public bool DoesIdExist(string id)
        {
            return employeeInfoDB.ContainsKey(Convert.ToInt32(id));
        }

        public void AddEmployee(Employee employee) 
        {
            employeeInfoDB[employee.getId()] = employee;
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