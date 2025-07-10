using DVLD.Properties;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
namespace DVLD
{
    public partial class LogIn : Form
    {
        //private string FilePath = @"D:\TheBigProject\DVLD\RememberMe.txt"; 
        //private string[]_RememberMe=new string[2];
        //private Int32 counter = 0;
        public LogIn()
        {
            InitializeComponent();
            //_RememberMe[0] = "";
            //_RememberMe[1] = "";
           
        }


        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                epLogIn.SetError(tbUserName, "Please Enter Your User Name");
            }
            else if(!clsUsersManagement.IsValidUserName(tbUserName.Text))
            {
                epLogIn.SetError(tbUserName, "Your User Name doesn`t Exist");
            }
            else
            {
                epLogIn.SetError(tbUserName, string.Empty);
            }
        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                epLogIn.SetError(tbPass, "Please Enter Your Password");
            }
            else if (!clsUsersManagement.IsValidPassword(tbPass.Text))
            {
                epLogIn.SetError(tbPass, "Please enter a valid Password");
            }
            else
            {
                epLogIn.SetError(tbPass, string.Empty);
            }
            
        }
        private void RemeberMe(string UserName,string Password)
        {
                //_RememberMe[0] = tbUserName.Text;
                //_RememberMe[1]= tbPass.Text;
                //File.Delete(FilePath);
                //File.AppendAllLines(FilePath, _RememberMe);
                try
                {
                    Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\DVLD", "UserName", $"{UserName}", RegistryValueKind.String);
                    Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\DVLD", "Password", $"{Password}", RegistryValueKind.String);
                 
                }
                catch (Exception ex) { throw ex; }
                
            
        }
        private void saveLogInInfo()
        {
            clsPersonManagement Management=new clsUsersManagement();
            clsUsersManagement ManagementRef=Management as clsUsersManagement;
            ManagementRef.user._UserName = tbUserName.Text;// where it will use the user name to find User Info
            Management = Management.find(-1);
            ManagementRef = Management as clsUsersManagement;// ManagementRef is a refrence to Management but Management is not refrence to ManagementRef 
            clsLogInInfo.UserName = tbUserName.Text;
            clsLogInInfo.UserID=ManagementRef.user._UserID;
            clsLogInInfo.IsActive = ManagementRef.user._IsActive;
            clsLogInInfo.PersonID = ManagementRef.user._PersonID;
            clsLogInInfo.Password=ManagementRef.user._Password;
        }
        private void btLogIn_Click(object sender, EventArgs e)
        {
             
            if (clsUsersManagement.IsValidLogIn(tbUserName.Text,clsGlobalMethods.ComputeHash(tbPass.Text)) && clsUsersManagement.IsActiveUser(tbUserName.Text))
            {
                if (cbRemeberMe.Checked)
                    RemeberMe(tbUserName.Text,tbPass.Text);
                else
                {
                    RemeberMe("","");

                    //File.WriteAllText(FilePath,string.Empty);    
                }

                saveLogInInfo();
                Form form = new MainForm();
                form.ShowDialog();
            }
            else if(clsUsersManagement.IsValidLogIn(tbUserName.Text, clsGlobalMethods.ComputeHash(tbPass.Text)) && !clsUsersManagement.IsActiveUser(tbUserName.Text))
            {
                MessageBox.Show("This User isn`t Active","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Enter a valid Data","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                epLogIn.SetError(tbPass, "Please enter a valid Password");
                epLogIn.SetError(tbUserName, "Please enter a valid User Name");
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                tbPass.PasswordChar = '*'; // Hide password
            }
        }
        private void LoadLogInInfo()
        {
            //foreach (string line in File.ReadLines(FilePath))
            //{
            //    _RememberMe[counter] = line;
            //    counter++;
            //}
            //if (_RememberMe[0].Length > 0)
            //{
            //    cbRemeberMe.Checked = true;
            //    tbUserName.Text = _RememberMe[0];
            //    tbPass.Text = _RememberMe[1];
            //}

        }
        private void ReadLogInInfoFromRegistery()
        {
            try
            {
                tbUserName.Text = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\DVLD", "UserName", null) as string;
                tbPass.Text = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\DVLD", "Password", null) as string;
                if (tbUserName.Text.Length > 0)
                {
                    cbRemeberMe.Checked = true;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            
           pLogIn.BackColor=Color.FromArgb(124,Color.White);
            //LoadLogInInfo();
            ReadLogInInfoFromRegistery();
        }
    }
}
