using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class changePassword : UserControl
    {
        public delegate void dgLogInInfo(Int32 UserID);
        public static event dgLogInInfo evSetUserID;
        public static event dgLogInInfo evSetPersonID;
        private static Int32 _UserID;
        private static Int32 _PersonID;
        private clsPersonManagement Management;
        private clsUsersManagement ManagementRef;
        public changePassword()
        {
            InitializeComponent();
            
        }
        public static void setUserID(Int32 UserID, Int32 PersonID)
        {
             _UserID = UserID;
            _PersonID = PersonID;
            // set it to user control LogInInfo and PersonInfo
            evSetUserID(UserID);        
            evSetPersonID(PersonID);
        }

        private void tbCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPass.Text))
            {
                epValidPass.SetError(tbCurrentPass, "Please Enter Your Password");
            }
            else if (!clsUsersManagement.IsValidPassword(tbCurrentPass.Text))
            {
                epValidPass.SetError(tbCurrentPass, "Your Password doesn`t Exist");
            }
            else
            {
                epValidPass.SetError(tbCurrentPass, string.Empty);
            }
        }

        private void tbNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPass.Text))
            {
                epValidPass.SetError(tbNewPass, "Please Enter Your Password");
            }
            else if (clsUsersManagement.IsValidPassword(tbNewPass.Text))
            {
                epValidPass.SetError(tbNewPass, "This Password Exists, Please choose another password");
            }
            else
            {
                epValidPass.SetError(tbNewPass, string.Empty);
            }
        }

        private void tbConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPass.Text))
            {
                epValidPass.SetError(tbConfirmPass, "Please Enter Your Password");
            }
            else if (tbConfirmPass.Text!=tbNewPass.Text)
            {
                epValidPass.SetError(tbConfirmPass, "Your Password is Invalid");
            }
            else
            {
                epValidPass.SetError(tbConfirmPass, string.Empty);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(!clsUsersManagement.IsValidPassword(tbNewPass.Text) &&  tbConfirmPass.Text==tbNewPass.Text )
            {
 
                Management = new clsUsersManagement();
                
                Management = Management.find(_UserID);
              
                Management.Mode = clsPersonManagement.enMode.Update;

                ManagementRef = Management as clsUsersManagement;

                if (clsUsersManagement.IsValidLogIn(ManagementRef.user._UserName,tbCurrentPass.Text))
                {
                    ManagementRef.user._Password = tbNewPass.Text;
                     
                    ManagementRef.save();
                    MessageBox.Show("change password done successfuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    epValidPass.SetError(tbCurrentPass, "Please enter a Valid Password");
                    MessageBox.Show("Error in Your Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            MessageBox.Show("Error in Your Data","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

    }
}
