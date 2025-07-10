using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddNewUserForm : Form
    {
        public delegate void UsersData(DataTable UsersData);
        public static event UsersData evUsersData;
        clsPersonManagement _Management=new clsUsersManagement();
        public AddNewUserForm()
        {
            InitializeComponent();
            
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DataTable dt = new DataTable();
            dt = _Management.GetAll();
            evUsersData(dt);
        }

        private void addNewUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
