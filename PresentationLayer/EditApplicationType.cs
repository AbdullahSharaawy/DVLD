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
    public partial class EditApplicationType : UserControl
    {
        clsApplicationTypeManagement Management=new clsApplicationTypeManagement();

        public EditApplicationType()
        {
            ManageApplicationType.evSendApplicationData += Management.getApplicationData;

            InitializeComponent();
            
        }
        private void sendDataToForm()
        {
            lbID.Text  =Management._ApplicationType.ID.ToString();
            tbFees.Text=Management._ApplicationType.Fees.ToString();
            tbTitle.Text=Management._ApplicationType.Title;
        }
        private void updateDataFromForm()
        {
              Management._ApplicationType.ID   =Convert.ToInt32(lbID.Text )  ;
              Management._ApplicationType.Fees =Convert.ToInt32(tbFees.Text) ;
              Management._ApplicationType.Title= tbTitle.Text;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            updateDataFromForm();
            if (Management.update())
                MessageBox.Show("your operation done successfully");
            else MessageBox.Show("your operation failed");
        }

        private void EditApplicationTypes_Load(object sender, EventArgs e)
        {
            if(Management._ApplicationType!=null)
            {
                sendDataToForm();
            }
        }
    }
}
