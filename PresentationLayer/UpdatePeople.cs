using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLD
{
    public partial class UpdatePeople : UserControl
    {
        private clsPersonManagement PersonData = new clsPeopleManagement();
        
        private ErrorProvider errorProvider = new ErrorProvider();
        
        private bool FirstName, SecondName, ThirdName, LastName, NationalNo, Email, Phone, Country, Address;// to check for all text boxes
        
        public UpdatePeople( )
        {
            InitializeComponent();
            PersonInfo.evSetPersonID += FillUpdateFormWithData;
            PersonInfo.evSetMode += getMode;
            MainForm.evSetPersonID += FillUpdateFormWithData;
            MainForm.evSetMode += getMode;
            AddNewUser.evSetMode += getMode;
        }
        private void getMode(clsPersonManagement.enMode Mode)
        {
            PersonData.Mode = Mode;
        }
        private void FillcbCountries()
        {
            DataTable dt = clsPeopleManagement.GetAllCountriesName();
            foreach (DataRow row in dt.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }
         private void GetDataFromForm(clsPeopleManagement Person)
        {
            Person.person.NationalNo = tbNationalNo.Text;
            Person.person.Email = tbEmail.Text;
            Person.person.FirstName = tbFirstName.Text;
            Person.person.SecondName = tbSecondName.Text;
            Person.person.ThirdName = tbThirdName.Text;
            Person.person.LastName = tbLastName.Text;
            Person.person.Phone = tbPhone.Text; 
            Person.person.Address = tbAddress.Text;
            Person.person.Phone = tbPhone.Text;
            Person.person.DateOfBirth = dtDateOfBirth.Value;
            
            if(cbCountries.SelectedIndex>=0)
            Person.person.NationalityCountryID=clsPeopleManagement.GetCountryID(cbCountries.SelectedItem.ToString());

            if (rdFemale.Checked)
            {
                Person.person.Gendor = 1;
            }
            else
            {
                Person.person.Gendor = 0;
            }

            if (pbPersonImage.Location != null)
                    Person.person.ImagePath = pbPersonImage.ImageLocation;
                else Person.person.ImagePath = "";

            Person.person.DateOfBirth = dtDateOfBirth.Value;
        }
        private void FillUpdateFormWithData(int _PersonID)
        {
        clsPeopleManagement PersonDataRef = new clsPeopleManagement();

        PersonData = PersonData.find(_PersonID);
        PersonDataRef=PersonData as clsPeopleManagement;    
            lbStatusForm.Text = "Update Person";
                lbID.Text = _PersonID.ToString();
               
                tbAddress.Text = PersonDataRef.person.Address;
                tbFirstName.Text = PersonDataRef.person.FirstName;
                tbSecondName.Text = PersonDataRef.person.SecondName;
                tbPhone.Text = PersonDataRef.person.Phone;
                tbThirdName.Text = PersonDataRef.person.ThirdName;
                tbLastName.Text = PersonDataRef.person.LastName;
                tbEmail.Text = PersonDataRef.person.Email;
                dtDateOfBirth.Value = PersonDataRef.person.DateOfBirth;
                tbNationalNo.Text = PersonDataRef.person.NationalNo;
      
                cbCountries.SelectedItem= clsPeopleManagement.GetCountryName(PersonDataRef.person.NationalityCountryID);
                if (PersonDataRef.person.Gendor == 0)
                    rdMale.Checked = true;
                else rdFemale.Checked = true;

                if (PersonDataRef.person.ImagePath != "")
                    pbPersonImage.Load(PersonDataRef.person.ImagePath);

        }
        private void UpdatePeople_Load(object sender, EventArgs e)
        {
            FillcbCountries();

            //if (PersonData.Mode == clsManagement.enMode.Update)
            //{
            //    FillUpdateFormWithData();
            //}

        }

        private void GetDataFromForm()
        {
            {
                clsPeopleManagement PersonDataRef = new clsPeopleManagement();
                PersonDataRef=PersonData as clsPeopleManagement;
                PersonDataRef.person.FirstName = tbFirstName.Text;
                PersonDataRef.person.SecondName = tbSecondName.Text;
                PersonDataRef.person.ThirdName = tbThirdName.Text;
                PersonDataRef.person.LastName = tbLastName.Text;
                PersonDataRef.person.Phone = tbPhone.Text;
                PersonDataRef.person.Email = tbEmail.Text;
                PersonDataRef.person.Address = tbAddress.Text;
                PersonDataRef.person.NationalNo = tbNationalNo.Text;
                PersonDataRef.person.DateOfBirth = dtDateOfBirth.Value;
                PersonDataRef.person.NationalityCountryID = clsPeopleManagement.GetCountryID(cbCountries.SelectedItem.ToString());

                if (rdFemale.Checked)
                    PersonDataRef.person.Gendor = 1;
                else PersonDataRef.person.Gendor = 0;

            }        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if( (FirstName && SecondName && ThirdName && LastName && Phone && Email && Address && NationalNo && Country) || PersonData.Mode ==clsPersonManagement.enMode.Update)
           
            {
                if (PersonData.Mode == clsPersonManagement.enMode.Update)
                {
                    GetDataFromForm();

                    if (PersonData.update())
                        MessageBox.Show("Your Data is Updated Successfuly", "Messsage");
                    else MessageBox.Show("Your Data isn`t Updated ", "Messsage");

                }
                else
                {
                    {
                        clsPeopleManagement PersonDataRef = new clsPeopleManagement();
                        PersonDataRef=PersonData as clsPeopleManagement;
                        GetDataFromForm(PersonDataRef);
                        PersonData.save();
                        PersonData.Mode = clsPersonManagement.enMode.Update;
                        lbID.Text = PersonDataRef.person.PersonID.ToString();
                        lbStatusForm.Text = "Update Person";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter your Data Completely", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
                pbPersonImage.Image = Properties.Resources.Female_512;
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {   
                pbPersonImage.Image = Properties.Resources.Male_512;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            ((UpdatePeopleForm)Parent).CloseForm();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression for email validation
            var regex = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+([a-zA-Z]{2,})))$";

            return Regex.IsMatch(email, regex);
        }

      
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text.Trim()))
            {
                FirstName = false;
                errorProvider.SetError(tbFirstName, "The First Name is required");

            }else
            {
                FirstName=true;
                errorProvider.SetError(tbFirstName, "");
            }

        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSecondName.Text.Trim()))
            {
                SecondName = false;
                errorProvider.SetError(tbSecondName, "The Second Name is required");

            }
            else
            {
                SecondName=true; 
                errorProvider.SetError(tbSecondName, "");
            }
        }

        

        private void tbThirdName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbThirdName.Text.Trim()))
            {
                ThirdName = false;
                errorProvider.SetError(tbThirdName, "The Third Name is required");

            }
            else
            {
                ThirdName=true;
                errorProvider.SetError(tbThirdName, "");
            }
        }

       

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                Phone = false;
                errorProvider.SetError(tbPhone, "The Phone Number is required");

            }
            else
            {
                Phone=true;
                errorProvider.SetError(tbPhone, "");
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text.Trim()))
            {
                Address = false;
                errorProvider.SetError(tbAddress, "The Address is required");

            }
            else
            {
                Address=true;
                errorProvider.SetError(tbAddress, "");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(tbEmail.Text))
            {
                // Display an error message or prevent the user from entering invalid characters
                Email = false;
                errorProvider.SetError(tbEmail, "Enter a valid Formate for Your Email");
            }
            else if (string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                Email=false;
                errorProvider.SetError(tbEmail, "Your Email is required");
            }
            else
            {
                Email=true;
                errorProvider.SetError(tbEmail, "");
            }
        }

        private void cbCountries_Validating(object sender, CancelEventArgs e)
        {
            if (cbCountries.SelectedItem==null)
            {
                Country = false;
                errorProvider.SetError(cbCountries, "Your Country is required");

            }
            else
            {
                Country=true;
                errorProvider.SetError(cbCountries, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                LastName = false;
                errorProvider.SetError(tbLastName, "The Last Name is required");

            }
            else
            {
                LastName=true;
                errorProvider.SetError(tbLastName,"");
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToBoolean(clsGlobalMethods.IsExist("Is National No Exists",tbNationalNo.Text, "")))
            {
                NationalNo=false;
                errorProvider.SetError(tbNationalNo, "this National No is Exist ");
            }
            else if(string.IsNullOrEmpty(tbNationalNo.Text.Trim()))
            {
                NationalNo=false;
                errorProvider.SetError(tbNationalNo, "The National No is required");
            }
            else
            {
                NationalNo=true;
                errorProvider.SetError(tbNationalNo, "");
            }
        }
    }
}
