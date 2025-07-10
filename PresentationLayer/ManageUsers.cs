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
using static DVLD.FilterUsers;

namespace DVLD
{
    public partial class ManageUsers : Form
    {
        public delegate void dgGetUserID(int UserID);
        public static event dgGetUserID evGetUserID;
        public delegate void dgSetPersonID(int PersonID);
        public static event dgSetPersonID evSetPersonID;

        private clsPersonManagement _ManagementUsers=new clsUsersManagement();

        public ManageUsers()
        {
            InitializeComponent();
            FilterUsers.evUsersData += GetUsersData;
            AddNewUserForm.evUsersData += GetUsersData;
            dgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void GetUsersData(DataTable UsersData)
        {
            dgUsers.DataSource = UsersData;
            lbRecordsNo.Text= "Records No "+dgUsers.Rows.Count.ToString();
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            

            dgUsers.DataSource=_ManagementUsers.GetAll();
            lbRecordsNo.Text ="Records No "+ dgUsers.Rows.Count.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            Form form = new AddNewUserForm();
            evSetPersonID(Convert.ToInt32(dgUsers.CurrentRow.Cells[0].Value));
            form.ShowDialog();
        }
        private void RefreshTable()
        {
            dgUsers.DataSource = _ManagementUsers.GetAll();
            lbRecordsNo.Text = "Records No " + dgUsers.RowCount.ToString();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ManagementUsers.delete(Convert.ToInt16(dgUsers.CurrentRow.Cells[0].Value)))
                MessageBox.Show("This Record is deleted successfuly ", "Message");
            else MessageBox.Show("You cann`t delete this record ", "Message");

            dgUsers.Rows.Remove(dgUsers.CurrentRow);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AddNewUserForm();
            
            form.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form form = new AddNewUserForm();
            int UserID = Convert.ToInt16(dgUsers.CurrentRow.Cells[0].Value);
            evGetUserID(UserID);
            form.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void changePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.UserID= Convert.ToInt16(dgUsers.CurrentRow.Cells[0].Value);
            form.PersonID = Convert.ToInt16(dgUsers.CurrentRow.Cells[1].Value);

            form.ShowDialog();
        }
    }
}
