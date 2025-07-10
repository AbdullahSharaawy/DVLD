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
    public partial class EditTestType : UserControl
    {
        clsTestTypeManagement Management = new clsTestTypeManagement();

        public EditTestType()
        {
            ManageTestType.evSendTestData += Management.getTestData;

            InitializeComponent();

        }
        private void sendDataToForm()
        {
            lbID.Text =  Management.  _TestType.ID.ToString();
            tbFees.Text = Management._TestType.Fees.ToString();
            tbTitle.Text =Management._TestType.Title;
            tbDescription.Text =Management._TestType.Description;
        }
        private void updateDataFromForm()
        {
            Management._TestType.ID = Convert.ToInt32(lbID.Text);
            Management._TestType.Fees = Convert.ToInt32(tbFees.Text);
            Management._TestType.Title = tbTitle.Text;
            Management._TestType.Description = tbDescription.Text;
        }

       

        private void EditTestType_Load(object sender, EventArgs e)
        {
            if (Management._TestType != null)
            {
                sendDataToForm();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            updateDataFromForm();
            if (Management.update())
                MessageBox.Show("your operation done successfully");
            else MessageBox.Show("your operation failed");
        }
    }
}
