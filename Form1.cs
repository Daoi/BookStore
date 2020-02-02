using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmUserIdPrompt : Form
    {
        EmployeeList employeeInfo;
        Employee currentUser;

        public frmUserIdPrompt()
        {
            InitializeComponent();
        }
        
        //Load employee data on form load.
        private void frmUserIdPrompt_Load(object sender, EventArgs e)
        {
            employeeInfo = new EmployeeList();

        }
        
        //Check for correct user name
        //This is a bit of a security flaw
        //A user can confirm a real ID by guessing
        //And the system will tell them whether its valid because its moves to a different screen. 
        private void btnUserIDEntry_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUserID.Text);

            if (!Regex.IsMatch(txtUserID.Text, @"^[0-9]{5}$")) {
                MessageBox.Show("Please enter your 5 digit User ID", "Invalid ID");
                txtUserID.Focus();
            }
            else if(employeeInfo.DoesIdExist(txtUserID.Text))
            {
                currentUser = employeeInfo.LookUpEmployee(id);
                pnlUserLogin.Enabled = false;
                pnlUserLogin.Visible = false;
                pnlPasswordScreen.Enabled = true;
                pnlPasswordScreen.Visible = true;
                txtPassword.Focus();
            }
            
        }

        //Counter for password attempts
        int attempts = 0;
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

            if ((!Regex.IsMatch(txtPassword.Text, @"^[0-9]{4}$")))
            {
                MessageBox.Show("Please enter your 4 digit pin", "Invalid Pin");
                txtPassword.Focus();
            }
            else if (currentUser.getPin() == txtPassword.Text)
            {
                MessageBox.Show("Pin entered correctly", "Correct pin");
            }
            else
            {
                MessageBox.Show("Pin entered incorrectly", "Incorrect pin");
                attempts++;
            }

        }
    }
}
