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
    public partial class VisionTest : UserControl
    {
        public VisionTest()
        {
            InitializeComponent();
           
        }
        private string LocalDrivingLicenseID;// use it in add appoinment to check if the test exists or not
        private string Status;// use it in add appoinment to check if the test exists or not
        public void RaiseApplicationBasicInfo(string NationalNumber, string ClassName, string Status, string Applicant)
        {
            this.Status = Status;
            applicationBasicInfo1.ShowApplicationBasicInfo(NationalNumber, ClassName, Status, Applicant);
        
        }
        public void RaiseDrivingLicenseInfo(string LocalDrivingLicenseID, string LicenseClassName, string NoTestPassed)
        {
            this.LocalDrivingLicenseID = LocalDrivingLicenseID;
            drivingLicenseApplicationInfo1.UpdateInfo(LocalDrivingLicenseID,LicenseClassName,NoTestPassed);
        }

        private void btnAddAppoinment_Click(object sender, EventArgs e)
        {
            if (clsSechduleTestManagement.IsTestExists(LocalDrivingLicenseID, Status))
                MessageBox.Show("Person already have an active appointment for this test, you can`t add new appoinment", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {

            }
        }
    }
}
