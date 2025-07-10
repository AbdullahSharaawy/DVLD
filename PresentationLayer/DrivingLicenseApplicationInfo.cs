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
    public partial class DrivingLicenseApplicationInfo : UserControl
    {
         public DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }


        public void UpdateInfo(string LicenseID, string LicenseClass,string NoTestPassed)
        {
            lbDLAppID.Text = LicenseID;
            lbClass.Text = LicenseClass;
            lbNoTests.Text = NoTestPassed;
        }
    }
}
