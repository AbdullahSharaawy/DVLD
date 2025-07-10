using PresentationLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class LogInInfo : UserControl
    {
       
        clsPersonManagement _Management=new clsUsersManagement();
        
        public LogInInfo()
        {
            InitializeComponent();
            changePassword.evSetUserID += sendDataToTheForm;
            PersonAndLoginInfoForm.evSetUserID += sendDataToTheForm;
        }
        private void sendDataToTheForm(Int32 UserID)
        {

               clsUsersManagement _ManagementRef=new clsUsersManagement();
            
                _ManagementRef.user._UserID =UserID;
                _Management = _Management.find(_ManagementRef.user._UserID);
                if (_Management != null)
                {
                    _ManagementRef=_Management as clsUsersManagement;
                    lbUserID.Text = _ManagementRef.user._UserID.ToString();
                    lbUserName.Text = _ManagementRef.user._UserName;
                    lbIsActive.Text = Convert.ToBoolean(_ManagementRef.user._IsActive) ? "Yes" : "No";
                }
            }
            
        }
    }

