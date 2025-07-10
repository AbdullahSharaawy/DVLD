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
    public partial class ManageTestType : UserControl
    {
        public ManageTestType()
        {
            InitializeComponent();
        }
        clsTestTypeManagement Management = new clsTestTypeManagement();
        public delegate void dgSendTestData(int ID = -1, string Title = "", int Fees = 0, string Description = "");
        public static event dgSendTestData evSendTestData;


      
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new EditTestTypeForm();
            evSendTestData(Convert.ToInt32(dgManageTestTypes.CurrentRow.Cells[0].Value), dgManageTestTypes.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dgManageTestTypes.CurrentRow.Cells[3].Value), dgManageTestTypes.CurrentRow.Cells[2].Value.ToString());
            form.ShowDialog();
            dgManageTestTypes.DataSource = Management.GetAll("All Test Types");
        }

        private void ManageTestType_Load(object sender, EventArgs e)
        {
            dgManageTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgManageTestTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgManageTestTypes.DataSource = Management.GetAll("All Test Types");
            lbRecordsNo.Text = "Records No  " + dgManageTestTypes.RowCount.ToString();
        }
    }
}
