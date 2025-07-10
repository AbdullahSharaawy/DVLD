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
    public partial class UpdatePeopleForm : Form
    {
        public enum enMode { Update = 0, AddNew = 1 };
        public UpdatePeopleForm( )
        {
            InitializeComponent();
        }
        public  void CloseForm()
        {
            Close();
        }

        
    }
}
