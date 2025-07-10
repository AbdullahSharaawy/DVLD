using BusinessLayer;
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
    public partial class AddNewUser_Filter : UserControl
    {
        public clsPersonInfo _PersonInfo=new clsPersonInfo();
        public delegate void dgPersonInfo(int personId, string Name, string NationalNo, string Gendor, string Email, string Address, string Phone, string Country, DateTime DateOfBirth, string ImagePath);
        public static event dgPersonInfo evPerson;
        public static DataTable dataTable = new DataTable();
        private clsPersonManagement _ManagementPeople = new clsPeopleManagement();
        
       
        public AddNewUser_Filter()
        {
            InitializeComponent();
            cbFilterItems.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void RemoveSomeFilterItems()
        {
            cbFilterItems.Items.Remove("Full Name");
            cbFilterItems.Items.Remove("Phone");
            cbFilterItems.Items.Remove("Email");
        }

   public void GetPersonInfo(DataTable dataTable)
        {
            if (  dataTable!=null && dataTable.Rows.Count > 0)
            {
                DataRow PersonInfo = dataTable.Rows[0];
                _PersonInfo._Name = PersonInfo["FirstName"].ToString()+ " " + PersonInfo["SecondName"].ToString()+ " " + PersonInfo["ThirdName"].ToString()+ " " + PersonInfo["LastName"].ToString();
                _PersonInfo._NationalNo = PersonInfo["NationalNo"].ToString();
                if (Convert.ToInt16(PersonInfo["Gendor"]) == 1)
                    _PersonInfo._Gender = "Female";
                else _PersonInfo._Gender = "Male";
                _PersonInfo._Phone = PersonInfo["Phone"].ToString();
                _PersonInfo._Email = PersonInfo["Email"].ToString();
                _PersonInfo._Address = PersonInfo["Address"].ToString();
                _PersonInfo._PersonID = Convert.ToInt16(PersonInfo["PersonID"]);
                _PersonInfo._Country = clsPeopleManagement.GetCountryName(Convert.ToInt16(PersonInfo["NationalityCountryID"]));
                _PersonInfo._DateOfBirth = Convert.ToDateTime(PersonInfo["DateOfBirth"]);
                _PersonInfo._ImagePath = PersonInfo["ImagePath"].ToString();
                }
            else _PersonInfo._PersonID = -1;
        }
        
       

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.SelectedIndex == 0 || cbFilterItems.SelectedIndex == -1)
            {
                dataTable = null;
                tbSelectorItem.Visible = false;
                tbSelectorItem.Text = "";
            }
            else tbSelectorItem.Visible = true;
        }

        private void tbSelectorItem_TextChanged(object sender, EventArgs e)
        {
            object SelectedItem = cbFilterItems.SelectedItem;
            string _SelectedItem;
            if (SelectedItem != null)
                _SelectedItem = SelectedItem.ToString();
            else
                _SelectedItem = "";

            dataTable = _ManagementPeople.GetAll(_SelectedItem, tbSelectorItem.Text);
            GetPersonInfo(dataTable);
            evPerson(_PersonInfo._PersonID, _PersonInfo._Name, _PersonInfo._NationalNo, _PersonInfo._Gender, _PersonInfo._Email, _PersonInfo._Address, _PersonInfo._Phone, _PersonInfo._Country, _PersonInfo._DateOfBirth, _PersonInfo._ImagePath);
        }
    }
}
