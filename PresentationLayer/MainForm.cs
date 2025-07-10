using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using PresentationLayer;
namespace DVLD
{
    public partial class MainForm : Form
    {
        private clsPersonManagement _ManagementPeople=new clsPeopleManagement();
        public delegate void dgPersonInfo(clsPersonManagement.enMode Mode);
        public static event dgPersonInfo evSetMode;
        public delegate void dgPersonID(Int32 ID);
        public static event dgPersonID evSetPersonID;
        public delegate void dgLocalDrivingLicense();
        public static event dgLocalDrivingLicense evLocalDrivingLicenseInfo;
        public delegate void dgSetFormMode(AddNewUser.enMode Mode);
        public static event dgSetFormMode evSetFormMode;
        public MainForm()
        {
            InitializeComponent();
            dgPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgPeople.Visible = false;
            
        }
        
        private void ResizeToolStripMenuItem(ToolStripMenuItem _ToolStripMenuItem)
        {
            _ToolStripMenuItem.Image=new Bitmap(_ToolStripMenuItem.Image,new Size(60,60));
            _ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.SizeToFit;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmsApplications.ImageScalingSize=new Size(50,50);
            cmsAccountSettings.ImageScalingSize = new Size(50, 50);
            cbFilterItems.DropDownStyle = ComboBoxStyle.DropDownList;
            
            ResizeToolStripMenuItem(tsmiNewDrivingLicense);
            ResizeToolStripMenuItem(tsmiInternationalLicense);
            ResizeToolStripMenuItem(tsmiLocalLicense);
           
        }

        private void btManagePeople_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Manage People", btManagePeople,10);
        }
        private void VisibleOn()
        {
            lbFilter.Visible = true;
            cbFilterItems.Visible = true;
            btClose.Visible = true;
            dgPeople.Visible = true;
            tbSelectorItem.Visible = true;
            lbRecords.Visible = true;
            btAdd.Visible = true;
        }
        
        private void btManagePeople_Click(object sender, EventArgs e)
        {
            VisibleOn();
            PeopleFilter();
        }
        private void VisibleOff()
        {
            lbFilter.Visible = false;
            btClose.Visible = false;
            dgPeople.Visible = false;
            cbFilterItems.Visible = false;
            tbSelectorItem.Visible = false;
            lbRecords.Visible = false;
            btAdd.Visible = false;  
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            VisibleOff();
        }

        

        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.SelectedIndex == 0 || cbFilterItems.SelectedIndex == -1)
            {
                dgPeople.Visible = false;
                dgPeople.DataSource = null;
                lbRecords.Text = "Records No " + 0;
                tbSelectorItem.ReadOnly = true;
                tbSelectorItem.Text = string.Empty;
            }
            else if (cbFilterItems.SelectedIndex == 1)
            {
                dgPeople.Visible = true;
                PeopleFilter();
            }

            else
            {
                dgPeople.Visible = true;
                tbSelectorItem.ReadOnly = false;
            }
         }
        private void PeopleFilter()
        {
           
            object SelectedItem = cbFilterItems.SelectedItem;
            string _SelectedItem;
            if (SelectedItem != null)
            {
                _SelectedItem = SelectedItem.ToString();
                dgPeople.DataSource = _ManagementPeople.GetAll(_SelectedItem, tbSelectorItem.Text);
                lbRecords.Text = "Records No " + dgPeople.RowCount.ToString();

            }
           
        }
        private void tbSelectorItem_TextChanged(object sender, EventArgs e)
         {
            PeopleFilter();            
        }

        private void btAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Add New People", btAdd, 10);
            Form form = new Form();

        }

       

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePeopleForm();
            evSetMode(clsPersonManagement.enMode.AddNew);
            form.ShowDialog();
            RefreshTable();
        }
        private void RefreshTable()
        {
            dgPeople.DataSource = _ManagementPeople.GetAll();
            lbRecords.Text = "Records No " + dgPeople.RowCount.ToString();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ManagementPeople.delete(Convert.ToInt16(dgPeople.CurrentRow.Cells[0].Value)))
                MessageBox.Show("This Record is deleted successfuly ", "Message");
            else MessageBox.Show("You cann`t delete this record ", "Message"); 
            dgPeople.Rows.Remove(dgPeople.CurrentRow);
            
        }

        

        

        private void btUsers_Click(object sender, EventArgs e)
        {
            Form form = new ManageUsers();
            AddNewUser.Mode=AddNewUser.enMode.ManageUsers;

            form.ShowDialog();
        }

        private void btAccountSettings_Click(object sender, EventArgs e)
        {
            cmsAccountSettings.Show(btAccountSettings,0, btAccountSettings.Height-5);
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonAndLoginInfoForm form = new PersonAndLoginInfoForm();
            form.LogInInfo = true;
            form.Show();
            
        }

        private void drivingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btApplications_Click(object sender, EventArgs e)
        {
            cmsApplications.Show(btApplications,5,btApplications.Height-5);
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form=new ApplicationsTypesForm();
            form.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new TestTypesForm();
            form.ShowDialog();
        }

        private void dgPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsNewLocalLicense_Click(object sender, EventArgs e)
        {
            clsApplicationsManagement.Mode = clsApplicationsManagement.enMode.New;
            Form form = new NewLocalDrivingLicenseApplicationForm();
            evSetFormMode(AddNewUser.enMode.LocalDrivingLicense);
            evLocalDrivingLicenseInfo();
            form.ShowDialog();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePeopleForm();
            evSetMode(clsPersonManagement.enMode.Update);
            evSetPersonID(Convert.ToInt16(dgPeople.CurrentRow.Cells[0].Value));

            form.ShowDialog();
            RefreshTable();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new UpdatePeopleForm();
            evSetMode(clsPersonManagement.enMode.AddNew);
            form.ShowDialog();
            RefreshTable();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form=new ChangePasswordForm();
            form.PersonID=clsLogInInfo.PersonID;
            form.UserID=clsLogInInfo.UserID;
            form.ShowDialog();
        }

       
        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form=new LocalDrivingLicenseApplicationsForm();
            form.ShowDialog();
        }
    }
}
