using BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class AddNewUser : UserControl
    {
        DataTable LicenseClasses;
        public  enum enMode { LocalDrivingLicense,ManageUsers}
        public static enMode Mode=enMode.ManageUsers;

        private bool EnableNext=false;
        
        private clsPersonManagement _Management =new clsUsersManagement();
        private clsLicenseClassManagement _LicenseClassManagement;
        
        private bool UserName = false, Password = false, ConfirmPass=false; // these variables to know is Form is filled with data
        
        public delegate void dgPersonInfo(int personId, string Name, string NationalNo, string Gendor, string Email, string Address, string Phone, string Country, DateTime DateOfBirth, string ImagePath);
        public static event dgPersonInfo evPerson;
        public delegate void dgSetMode(clsPersonManagement.enMode mode);
        public static event dgSetMode evSetMode;
        
        private  void GetUserID(int UserID)
        {
            if(_Management is clsUsersManagement _ManagementRef)
                _ManagementRef.user._UserID = UserID;
        }
        private void GetPersonID(int PersonID)// must be work in Local Driving License Status
        {
            if (_Management is clsUsersManagement _ManagementRef)
                _ManagementRef.user._UserID = PersonID;
        }
        public AddNewUser()
        {
            
            ManageUsers.evGetUserID += GetUserID;
            ManageUsers.evSetPersonID += GetPersonID;
            AddNewUser_Filter.evPerson += GetPersonInfo;
            MainForm.evLocalDrivingLicenseInfo += SendDataToLocalDrivingLicenseInfo;
            MainForm.evSetFormMode += SetFormMode;
            LocalDrivingLicenseApplicationsForm.evSetFormMode+= SetFormMode;
            LocalDrivingLicenseApplicationsForm.evLocalDrivingLicenseInfo+= SendDataToLocalDrivingLicenseInfo;
            InitializeComponent();

        }
        private void VisibleOff()
        {
            if(Mode==enMode.LocalDrivingLicense)
            {
                cbIsActive.Visible = false;
                tbPass.Visible = false;
                tbConfirmPass.Visible = false;
                lbID.Visible = false;
                lbName.Visible = false;
                lbPass.Visible = false;
                lbConfirmPass.Visible = false;
                tbConfirmPass.Visible = false;
                lbUserID.Visible = false;
                tbUserName.Visible = false;

                pbConfirmPass.Visible = false;
                pbPass.Visible = false;
                pbUserName.Visible = false;
                pbUserID.Visible = false;
            }
            else if(Mode==enMode.ManageUsers)
            {
                cbItemsClasses.Visible = false;
                lbAppID.Visible = false;
                lbApplicationID.Visible = false;
                lbApplicationDate.Visible = false;
                lbDate.Visible = false;
                lbCreated.Visible = false;
                lbWhoCreated.Visible = false;
                lbLicenseClass.Visible = false;
                lbApplicationFees.Visible = false;
                lbFeesPaid.Visible = false;
                pbAppID.Visible=false;
                pbCreatedBy.Visible = false;
                pbDate.Visible=false;
                pbFees.Visible=false;
                pbLicenseClass.Visible=false;
            }
        }
        private void GetPersonInfo(int personId, string Name, string NationalNo, string Gendor, string Email, string Address, string Phone, string Country, DateTime DateOfBirth, string ImagePath)
        {
            if(personId!=-1)
            {
                _Management = new clsPeopleManagement();
                clsPeopleManagement _ManagementRef = _Management as clsPeopleManagement;
                _ManagementRef.person.Address = Address;
                _ManagementRef.person.Phone = Phone;
                _ManagementRef.person.Gendor = Gendor == "Female" ? 1 : 0;
                _ManagementRef.person.Email = Email;
                _ManagementRef.person.PersonID = personId;
                _ManagementRef.person.DateOfBirth = DateOfBirth;
                _ManagementRef.person.NationalNo = NationalNo;
                _ManagementRef.person.FirstName = Name.Split(' ')[0];
                _ManagementRef.person.FirstName = Name.Split(' ')[1];
                _ManagementRef.person.FirstName = Name.Split(' ')[2];
                _ManagementRef.person.FirstName = Name.Split(' ')[3];
                _ManagementRef.person.ImagePath = ImagePath;
                _ManagementRef.person.NationalityCountryID = clsPeopleManagement.GetCountryID(Country);

            }
        }
      

        private void GetDataFromForm()
        {
           clsUsersManagement _ManagementRef = new clsUsersManagement();
           _ManagementRef=_Management as clsUsersManagement;

        _ManagementRef.user._UserName = tbUserName.Text;
        _ManagementRef.user._Password = clsGlobalMethods.ComputeHash(tbPass.Text);

                if (cbIsActive.Checked)
                    _ManagementRef.user._IsActive = 1;

                else _ManagementRef.user._IsActive = 0;
                
           
        }
        private void SendDataToPersonInfoPage()
        {
            AddNewUser_Filter personInfo = new AddNewUser_Filter();
            DataTable dataTable = new DataTable();
            dataTable = _Management.GetAll("Person ID", _Management is clsUsersManagement _ManagementRef? _ManagementRef.user._PersonID.ToString():null);
            personInfo.GetPersonInfo(dataTable);
            //PersonInfo FormInfo = new PersonInfo();
            
            evPerson(personInfo._PersonInfo._PersonID, personInfo._PersonInfo._Name, personInfo._PersonInfo._NationalNo, personInfo._PersonInfo._Gender, personInfo._PersonInfo._Email, personInfo._PersonInfo._Address, personInfo._PersonInfo._Phone, personInfo._PersonInfo._Country, personInfo._PersonInfo._DateOfBirth, personInfo._PersonInfo._ImagePath);
        }
        private void SendDataToLogInInfo()
        {
            clsUsersManagement _ManagementRef = new clsUsersManagement();
            _ManagementRef = _Management as clsUsersManagement;

            tbUserName.Text = _ManagementRef.user._UserName;
                tbPass.Text = _ManagementRef.user._Password;
                tbConfirmPass.Text = _ManagementRef.user._Password;
                if (_ManagementRef.user._IsActive == 1)
                    cbIsActive.Checked = true;
                else cbIsActive.Checked = false;
                lbUserID.Text = _ManagementRef.user._UserID.ToString();
                lbAddNewUser.Text = "Update User";
                UserName = true;
                Password = true;
                ConfirmPass = true;
                _ManagementRef.Mode = clsUsersManagement.enMode.Update;
           
        }
        private void CopyColumnValues(string ColumnName,ref string[]array,DataTable dt)// to copy the data from specific column in data table to array
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                array[i] = dt.Rows[i][ColumnName].ToString();
            }
        }
        private void setItemsTocbClasses()
        {
            string[] ClassesData = new string[LicenseClasses.Rows.Count];
            CopyColumnValues("ClassName", ref ClassesData, LicenseClasses);
            cbItemsClasses.Items.AddRange(ClassesData);
            cbItemsClasses.SelectedIndex = 0;
        }
        private void SendDataToLocalDrivingLicenseInfo()
        {
            LicenseClasses = new DataTable();
            
            _LicenseClassManagement=new clsLicenseClassManagement();
            LicenseClasses=_LicenseClassManagement.GetAll("All License Classes", "");
            setItemsTocbClasses();

            lbAddNewUser.Text = "New Local Driving License Application";
            tcAddNewUser.TabPages[0].Text = "Person Info";
            tcAddNewUser.TabPages[1].Text = "Application Info";
            lbWhoCreated.Text =clsLogInInfo.UserName;

            lbDate.Text = DateTime.Now.ToShortDateString();
            
            
            
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            int PersonID = -1;

            if (Mode==enMode.ManageUsers)
            {
                if(_Management.Mode==clsPersonManagement.enMode.AddNew)
                {
                    clsPeopleManagement _ManagementPersonRef = new clsPeopleManagement();
                    _ManagementPersonRef = _Management as clsPeopleManagement;
                    PersonID=_ManagementPersonRef.person.PersonID;
                }else
                {
                    clsUsersManagement _ManagementUserRef = new clsUsersManagement();
                    _ManagementUserRef = _Management as clsUsersManagement;
                    PersonID=_ManagementUserRef.user._PersonID;
                }

                if ((UserName && Password && ConfirmPass && !Convert.ToBoolean(clsGlobalMethods.IsExist("Is User Exists",PersonID.ToString(),""))) || (UserName && Password && ConfirmPass && _Management.Mode == clsUsersManagement.enMode.Update))
                {
                    if(_Management.Mode==clsPersonManagement.enMode.AddNew)
                    {
                        _Management = new clsUsersManagement();

                        GetDataFromForm();

                        clsUsersManagement _ManagementUserRef = new clsUsersManagement();
                        _ManagementUserRef = _Management as clsUsersManagement;

                        _ManagementUserRef.user._PersonID = PersonID;

                    }else
                        GetDataFromForm();

                    _Management.save();
                    
                    lbAddNewUser.Text = " Update User";
                    clsUsersManagement _ManagementRef=new clsUsersManagement();
                    _ManagementRef = _Management as clsUsersManagement;
                    lbUserID.Text = _ManagementRef.user._UserID.ToString();

                    if (_Management.Mode == clsUsersManagement.enMode.AddNew)
                        MessageBox.Show($"You added a new user his user ID = {_ManagementRef.user._UserID}", "Message", MessageBoxButtons.OK);
                    else
                        MessageBox.Show($"User Info updated successfuly", "Message", MessageBoxButtons.OK);

                    _Management.Mode = clsUsersManagement.enMode.Update;
                }
                else if (Convert.ToBoolean(clsGlobalMethods.IsExist("Is User Exists", PersonID.ToString(), "")))
                {
                    MessageBox.Show("This User already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Enter your data correctly ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsPeopleManagement _ManagementRef = new clsPeopleManagement();
                _ManagementRef = _Management as clsPeopleManagement;
                int ApplicationID = clsGlobalMethods.IsExist("Is Local Driving License Application Exists", _ManagementRef.person.PersonID.ToString(), (cbItemsClasses.SelectedIndex+1).ToString());
                if (ApplicationID==0)
                {
                    
                    if (clsApplicationsManagement.Mode == clsApplicationsManagement.enMode.New)
                    {

                        lbAppID.Text = clsApplicationsManagement.AddNewContact(_ManagementRef.person.PersonID, DateTime.Now, 1, 1, DateTime.Now, Convert.ToDouble(lbFeesPaid.Text), clsLogInInfo.UserID).ToString();
                        clsLocalDrivingLicenseApplicationManagement.AddNewContact(Convert.ToInt32(lbAppID.Text), (cbItemsClasses.SelectedIndex + 1));
                        MessageBox.Show("the operation done successfuly", "Message", MessageBoxButtons.OK);
                    }
                }else
                    MessageBox.Show($"you introduced Local Driving License Applicatioin where ApplicationID='{ApplicationID}'\nYou can introduce the order only once","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text.Trim()))
            {
                Password = false;
                epAddNewUser.SetError(tbPass, "The password is required");

            }
            else
            {
                Password = true;
                epAddNewUser.SetError(tbPass, "");
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void SetFormMode(enMode _Mode)
        {
            Mode= _Mode;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            VisibleOff();

            if (Mode == enMode.ManageUsers)
            {
                clsUsersManagement _ManagementRef = new clsUsersManagement();
                _ManagementRef = _Management as clsUsersManagement;

                if (_ManagementRef.user._UserID != -1)
                {

                    _Management = _Management.find(_ManagementRef.user._UserID);
                    _Management.Mode = clsUsersManagement.enMode.Update;
                    tcAddNewUser.SelectedIndex = 1;

                    SendDataToLogInInfo();

                    SendDataToPersonInfoPage();
                    filterPeople1.Enabled = false;
                    btAddNewPerson.Enabled = false;
                }

            }

        }

       

        private void tcAddNewUser_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if(_Management.Mode==clsUsersManagement.enMode.AddNew && Mode==enMode.ManageUsers && !EnableNext)
                 e.Cancel=true;  
            else if(Mode==enMode.LocalDrivingLicense && !EnableNext)
                e.Cancel = true;
        
            if(tcAddNewUser.SelectedIndex==0)
                EnableNext = false;
        }

        private void btAddNewPerson_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePeopleForm();
            evSetMode(clsPersonManagement.enMode.AddNew);
            form.ShowDialog();
        }

        private void cbItemsClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item=cbItemsClasses.SelectedIndex;
            string LicenseClass;
            LicenseClass = cbItemsClasses.Items[item].ToString();
            foreach(DataRow row in LicenseClasses.Rows)
            {
                if (row["ClassName"].ToString() == LicenseClass)
                {
                    lbFeesPaid.Text = row["ClassFees"].ToString();
                    break;
                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.ManageUsers)
            {
                clsPeopleManagement _ManagementRef = new clsPeopleManagement();
                _ManagementRef = _Management as clsPeopleManagement;
                if (personInfo1.IsDataCompleted() && (!Convert.ToBoolean(clsGlobalMethods.IsExist("Is User Exists", _ManagementRef.person.PersonID.ToString(), "")) || _Management.Mode == clsUsersManagement.enMode.Update))
                {
                    EnableNext=true;
                    tcAddNewUser.SelectedIndex = 1;
                }
                else if (!personInfo1.IsDataCompleted())
                    MessageBox.Show("Please Enter Your Data Completely ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("This User already Exist ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                   if( _Management != null)
                {
                    tcAddNewUser.SelectedIndex = 1;
                    EnableNext = true;
                }
            }
        }

        private void tbConfirmPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPass.Text.Trim()))
            {
                ConfirmPass = false;
                epAddNewUser.SetError(tbConfirmPass, "Confirm Your Password ");
            }
            else if (tbConfirmPass.Text!=tbPass.Text)
            {
                ConfirmPass = false;
                epAddNewUser.SetError(tbConfirmPass, "rewrite your password correctly");
            }
            else
            {
                ConfirmPass = true;
                epAddNewUser.SetError(tbConfirmPass, "");
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                UserName = false;
                epAddNewUser.SetError(tbUserName, "The UserName is required");

            }
            else if (clsUsersManagement.IsValidUserName(tbUserName.Text))
            {
                UserName = false;
                epAddNewUser.SetError(tbUserName, "This UserName already Exist , choose another UserName ");
            }
            else
            {
                UserName = true;
                epAddNewUser.SetError(tbUserName, "");
            }
        }
    }
}
