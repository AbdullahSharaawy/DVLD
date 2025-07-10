using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using PresentationLayer;
using BusinessLayer;

namespace DVLD
{
    public partial class PersonInfo : UserControl
    {
        private clsPersonManagement _Management =new clsUsersManagement();
        public delegate void dgPersonInfo(Int32 ID);
        public static event dgPersonInfo evSetPersonID;
        public delegate void dgModeInfo(clsPersonManagement.enMode Mode);
        public static event dgModeInfo evSetMode;

        public PersonInfo()
        {
            InitializeComponent();
            AddNewUser_Filter.evPerson += GetPersonInfo;
            AddNewUser.evPerson += GetPersonInfo;
            changePassword.evSetPersonID += GetInfoUsingID;
            PersonAndLoginInfoForm.evSetPersonID += GetInfoUsingID;
            ApplicationBasicInfo.evSetNationalNo += GetInfoUsingNationalNo;
        }
        private int PersonID=-1;
        private   void GetPersonInfo(int personId,string Name , string NationalNo, string Gendor , string Email, string Address,string Phone,string Country,DateTime DateOfBirth,string ImagePath)
        {

            lbID.Text=personId.ToString();
            lbName.Text=Name;
            lbNationalNo.Text=NationalNo;
            lbGendor.Text=Gendor;
            lbEmail.Text=Email;
            lbAddress.Text=Address;
            lbPhone.Text=Phone;
            lbCountry.Text=Country;
            lbDateOfBirth.Text=DateOfBirth.ToString();
            if(personId==-1)
            {
               lbName.Text = "???";
               lbNationalNo.Text = "???";
               lbGendor.Text = "???";
               lbPhone.Text = "???";
               lbEmail.Text = "???";
               lbAddress.Text = "???";
               lbCountry.Text = "???";
                lbDateOfBirth.Text = "???";
               lbID.Text ="???";
            }
            PersonID = personId;
        }
        public bool IsDataCompleted()
        {
            if(PersonID!=-1 )
                 return true;

            return false;
        }
        public void GetInfoUsingID(int ID)
        {
            AddNewUser_Filter personInfo = new AddNewUser_Filter();
            DataTable dataTable = new DataTable();
            dataTable = _Management.GetAll("Person ID", ID.ToString());
            personInfo.GetPersonInfo(dataTable);
            GetPersonInfo(personInfo._PersonInfo._PersonID, personInfo._PersonInfo._Name, personInfo._PersonInfo._NationalNo, personInfo._PersonInfo._Gender, personInfo._PersonInfo._Email, personInfo._PersonInfo._Address, personInfo._PersonInfo._Phone, personInfo._PersonInfo._Country, personInfo._PersonInfo._DateOfBirth, personInfo._PersonInfo._ImagePath);
        }
        public void GetInfoUsingNationalNo(string NationalNumber)
        {
            AddNewUser_Filter personInfo = new AddNewUser_Filter();
            DataTable dataTable = new DataTable();
            dataTable = _Management.GetAll("National Number", NationalNumber);
            personInfo.GetPersonInfo(dataTable);
            GetPersonInfo(personInfo._PersonInfo._PersonID, personInfo._PersonInfo._Name, personInfo._PersonInfo._NationalNo, personInfo._PersonInfo._Gender, personInfo._PersonInfo._Email, personInfo._PersonInfo._Address, personInfo._PersonInfo._Phone, personInfo._PersonInfo._Country, personInfo._PersonInfo._DateOfBirth, personInfo._PersonInfo._ImagePath);
        }

        private void lbEditPersonInfo_Click(object sender, EventArgs e)
        {

            Form Form=new UpdatePeopleForm();
            evSetPersonID(PersonID);
            evSetMode(clsPersonManagement.enMode.Update);
            Form.ShowDialog();
            GetInfoUsingID(PersonID);
        }

        
        private void lbEditPersonInfo_MouseHover(object sender, EventArgs e)
        {
            lbEditPersonInfo.ForeColor = Color.Red;
        }

        private void lbEditPersonInfo_MouseLeave(object sender, EventArgs e)
        {
            lbEditPersonInfo.ForeColor = Color.Blue;
            this.Cursor = Cursors.Default;
        }

        private void lbEditPersonInfo_MouseMove(object sender, MouseEventArgs e)
        {
            lbEditPersonInfo.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void lbEditPersonInfo_MouseEnter(object sender, EventArgs e)
        {
            lbEditPersonInfo.ForeColor = Color.Red;

        }

        private void lbEditPersonInfo_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
