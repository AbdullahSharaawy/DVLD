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
    public partial class FilterUsers : UserControl
    {
        public delegate void UsersData(DataTable UsersData);
        public static event UsersData evUsersData;
        private clsPersonManagement _Management;
       
        public FilterUsers()
        {
            InitializeComponent();
            
        }

        public static DataTable dataTable = new DataTable();
        
        
        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.SelectedIndex == 0 || cbFilterItems.SelectedIndex == -1)
            {
                dataTable = null;
                tbSelectorItem.Visible = false;
                cbIsActive.Visible = false;
                tbSelectorItem.Text = "";
                evUsersData(dataTable);
            }
           
            else if(cbFilterItems.SelectedItem.ToString()=="Is Active")
            {
                tbSelectorItem.Visible=false ;
                cbIsActive.Visible = true;
            }

            else tbSelectorItem.Visible = true;
        }

        private void tbSelectorItem_TextChanged(object sender, EventArgs e)
        {
            _Management=new clsPeopleManagement();
            object SelectedItem = cbFilterItems.SelectedItem;
            string _SelectedItem;
            if (SelectedItem != null)
                _SelectedItem = SelectedItem.ToString();
            else
                _SelectedItem = "";

            dataTable = _Management.GetAll(_SelectedItem, tbSelectorItem.Text);
            evUsersData(dataTable);

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbIsActive.SelectedIndex == 0)
            {
                _Management=new clsUsersManagement();
                dataTable = _Management.GetAll("All Users", tbSelectorItem.Text); 
            }
            else if (cbIsActive.SelectedIndex == 1)
            {
                _Management=new clsPeopleManagement();
                dataTable = _Management.GetAll("Is Active", "1");
            }
            else if (cbIsActive.SelectedIndex == 2)
            {
                _Management=new clsPeopleManagement();
                dataTable = _Management.GetAll("Is Active", "0");

            }
            evUsersData(dataTable);
        }
    }
}
