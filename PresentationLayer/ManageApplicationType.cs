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
    public partial class ManageApplicationType : UserControl
    {
        clsServiceManagement Management=new clsApplicationTypeManagement();
        public delegate void dgSendApplicationData(int ID=-1, string Title="", int Fees = 0);
        public static event dgSendApplicationData evSendApplicationData;
        public ManageApplicationType()
        {
            InitializeComponent();
           
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            dgManageApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgManageApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgManageApplicationTypes.DataSource = Management.GetAll("All Application Types");
            lbRecordsNo.Text = "Records No  " + dgManageApplicationTypes.RowCount.ToString();
            }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new EditApplicationTypeForm();
            evSendApplicationData(Convert.ToInt32(dgManageApplicationTypes.CurrentRow.Cells[0].Value), dgManageApplicationTypes.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dgManageApplicationTypes.CurrentRow.Cells[2].Value));
            form .ShowDialog();
            dgManageApplicationTypes.DataSource = Management.GetAll("All Application Types");
        }
    }
}
