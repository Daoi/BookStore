using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    //The login form. Handles entering of UserIDs and Pins
    //Validates Data, limits tries. Also makes sure the employee file is initalized/updated 
    public partial class frmUserIdPrompt : Form
    {
        EmployeeList employeeInfoDB = new EmployeeList();
        Employee currentUser;
        const string employeeFile = "employeeList.txt";
        int attempts = 0;

        public frmUserIdPrompt()
        {
            InitializeComponent();
        }
        
        //Load employee data on form load.
        private void frmUserIdPrompt_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.GetFullPath(employeeFile);
                if (!FileHandler.ReadEmployeeFile(filePath, ref employeeInfoDB))
                {
                    MessageBox.Show("employeeList file unable to be opened or missing.", "File error");
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("employeeList file error: " + ex.ToString(), "File error");
                Application.Exit();
            }

        }

        //Check for correct user name
        //This is a bit of a security flaw
        //A user can confirm a real ID by guessing
        //And the system will tell them whether its valid because its moves to a different screen. 
        private void btnUserIDEntry_Click(object sender, EventArgs e)
        {
            
            int id;
            if (!Regex.IsMatch(txtUserID.Text, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Please enter your 5 digit User ID", "Invalid ID");
                txtUserID.Focus();
                attempts++;
            }
            else
            {
                if (employeeInfoDB.DoesIdExist(txtUserID.Text))
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
                else//Correct ID format, Invalid ID
                {
                    MessageBox.Show("Please enter your 5 digit User ID", "Invalid ID");
                    attempts++;
                }
                if (attempts == 3)
                {
                    MessageBox.Show("Too many incorrect tries, contact supervisor", "Incorrect ID");
                    btnUserIDEntry.Enabled = false;
                    txtUserID.Enabled = false;
                    return;
                }
            }
        }

        //Pin validation
        private void btnPasswordEntry_Click(object sender, EventArgs e)
        {

            if ((!Regex.IsMatch(txtPassword.Text, @"^[0-9]{4}$"))) //Bad format - Doesn't count against attempts
            {
                MessageBox.Show("Please enter your 4 digit pin", "Invalid Pin");
                txtPassword.Focus();
            }
            else if (currentUser.getPin() == txtPassword.Text) //Succesful Login
            {
                //attempts = 0;
                MessageBox.Show("Pin entered correctly", "Correct pin");
                frmMain mainStorePage = new frmMain(currentUser, employeeInfoDB);
                currentUser.LogAccess();
                if (FileHandler.updateEmployeeFile(employeeInfoDB, employeeFile))
                {
                    Hide();
                    mainStorePage.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid pin", "Incorrect pin"); //Bad pin
                txtPassword.Focus();
                attempts++;
            }

            if (attempts == 3)
            {
                MessageBox.Show("Too many incorrect tries, contact supervisor", "Incorrect ID");
                btnPasswordEntry.Enabled = false;
                txtPassword.Enabled = false;
                return;
            }

        }
    }
}
