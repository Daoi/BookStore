﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{

    public partial class frmUserIdPrompt : Form
    {
        EmployeeList employeeInfoDB = new EmployeeList();
        Employee currentUser;
        const string employeeFile = "employeeList.txt";

        public frmUserIdPrompt()
        {
            InitializeComponent();
        }
        
        //Load employee data on form load.
        private void frmUserIdPrompt_Load(object sender, EventArgs e)
        {
            string filePath = Path.GetFullPath(employeeFile);
            if (!FileHandler.ReadFile(filePath, ref employeeInfoDB))
            {//What to do if theres a problem

            }

        }
        int attempts = 0;

        //Check for correct user name
        //This is a bit of a security flaw
        //A user can confirm a real ID by guessing
        //And the system will tell them whether its valid because its moves to a different screen. 
        private void btnUserIDEntry_Click(object sender, EventArgs e)
        {
            int id;
            if (!Regex.IsMatch(txtUserID.Text, @"^[0-9]{5}$")) {
                MessageBox.Show("Please enter your 5 digit User ID", "Invalid ID");
                txtUserID.Focus();
                attempts++;
            }
            else if(employeeInfoDB.DoesIdExist(txtUserID.Text))
            {
                id = Convert.ToInt32(txtUserID.Text);
                currentUser = employeeInfoDB.LookUpEmployee(id);
                pnlUserLogin.Enabled = false;
                pnlUserLogin.Visible = false;
                pnlPasswordScreen.Enabled = true;
                pnlPasswordScreen.Visible = true;
                AcceptButton = btnPasswordEntry;
                txtPassword.Focus();
                attempts = 0;
            }
            
        }

        //Counter for password attempts
        //Pin validation
        private void btnPasswordEntry_Click(object sender, EventArgs e)
        {
             
            
            if (attempts == 3)
            {
                MessageBox.Show("Too many incorrect tries, contact supervisor", "Incorrect pin");
                btnPasswordEntry.Enabled = false;
                txtPassword.Enabled = false;
                return;
            }

            if ((!Regex.IsMatch(txtPassword.Text, @"^[0-9]{4}$"))) //Bad format
            {
                MessageBox.Show("Please enter your 4 digit pin", "Invalid Pin");
                txtPassword.Focus();
            }
            else if (currentUser.getPin() == txtPassword.Text) //Succesful Login
            {
                attempts = 0;
                MessageBox.Show("Pin entered correctly", "Correct pin");
                frmMain mainStorePage = new frmMain(currentUser, employeeInfoDB);
                this.Hide();
                mainStorePage.Show();

            }
            else
            {
                MessageBox.Show("Invalid pin", "Incorrect pin"); //Bad pin
                txtPassword.Focus();
                attempts++;
            }

        }
    }
}
