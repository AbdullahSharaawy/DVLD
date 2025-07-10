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
    public partial class PersonAndLoginInfoForm : Form
    {
        public delegate void dgLogInInfo(Int32 ID);
        public static event dgLogInInfo evSetPersonID;
        public static event dgLogInInfo evSetUserID;
        public bool LogInInfo=false;
        public PersonAndLoginInfoForm()
        {
            InitializeComponent();

        }

        private void personInfo1_Load(object sender, EventArgs e)
        {

        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {
            if (LogInInfo)
            {
                evSetPersonID(clsLogInInfo.PersonID);
                evSetUserID(clsLogInInfo.UserID);

            }
        }
    }
}
