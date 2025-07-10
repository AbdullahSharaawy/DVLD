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
    public partial class VisionTestForm : Form
    {
        private DataGridViewRow currentRow;

       

        public VisionTestForm(DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisionTestForm_Load(object sender, EventArgs e)
        {
            visionTest1.RaiseApplicationBasicInfo(this.currentRow.Cells[1].Value.ToString(), this.currentRow.Cells[5].Value.ToString(), this.currentRow.Cells[4].Value.ToString(), this.currentRow.Cells[0].Value.ToString());
            visionTest1.RaiseDrivingLicenseInfo(this.currentRow.Cells[2].Value.ToString(), this.currentRow.Cells[5].Value.ToString(), this.currentRow.Cells[6].Value.ToString());

        }

        private void visionTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
