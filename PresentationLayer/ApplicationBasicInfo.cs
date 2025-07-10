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
    public partial class ApplicationBasicInfo : UserControl
    {
        public delegate void dgSetNationalNo(string nationalNo);
        public static event dgSetNationalNo evSetNationalNo;
        private  string NationalNo;// use it in link label only
        
        public ApplicationBasicInfo()
        {
            InitializeComponent();
        }
       
        public  void ShowApplicationBasicInfo(string NationalNumber,string ClassName,string Status, string Applicant)
        {
           this.NationalNo = NationalNumber;

           DataTable dt= clsLocalDrivingLicenseApplicationManagement.GetApplicationBasicInfo(NationalNumber, ClassName);
            if (dt != null)
            {
                lbApplicationStatus.Text = Status;
                lbApplicant.Text = Applicant;
                lbApplicationID.Text = dt.Rows[0]["ApplicationID"].ToString();
                lbApplicationType.Text = dt.Rows[0]["ApplicationTypeTitle"].ToString();
                lbCreatedBy.Text = dt.Rows[0]["UserName"].ToString();
                lbPaidFees.Text = dt.Rows[0]["PaidFees"].ToString();
                lbStartDate.Text = dt.Rows[0]["ApplicationDate"].ToString();
                lbLastDate.Text = dt.Rows[0]["LastStatusDate"].ToString();
                
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new PersonInfoForm();
            evSetNationalNo(this.NationalNo);
            form.ShowDialog();
        }
    }
}
