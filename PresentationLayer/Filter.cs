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
    public partial class Filter : UserControl
    {
        public static DataTable _LocalDrivingLicenseApplications;// all data
        private DataTable _CurrentDrivingLicenseApplications;// result of filter
        public event EventHandler<DataTable> evFilterResult;
        public Filter()
        {
            InitializeComponent();
            cbFilterItems.DropDownStyle=ComboBoxStyle.DropDownList;
        }
        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterItems.SelectedIndex > 0)
            {
                FilterProcess();
                tbSelectorItem.Visible = true;
            }
            else
            {
                _CurrentDrivingLicenseApplications = _LocalDrivingLicenseApplications;
                evFilterResult?.Invoke(this, _CurrentDrivingLicenseApplications);
                tbSelectorItem.Visible = false;
                tbSelectorItem.Text = "";
            }
        }
        private void tbSelectorItem_TextChanged(object sender, EventArgs e)
        {
            FilterProcess();
        }
        private void FilterProcess()
        {
            if (cbFilterItems.SelectedIndex > 0 && (tbSelectorItem.Text != null && tbSelectorItem.Text != ""))
            {
                try
                {
                    DataView view = new DataView(_LocalDrivingLicenseApplications);
                    string FilterType = cbFilterItems.SelectedItem.ToString().Replace(" ", "");
                    view.RowFilter = $"{FilterType}='{tbSelectorItem.Text}'";
                    _CurrentDrivingLicenseApplications = view.ToTable();

                }
                catch { }
            }
            else
            {
                _CurrentDrivingLicenseApplications = _LocalDrivingLicenseApplications;
            }
            evFilterResult?.Invoke(this, _CurrentDrivingLicenseApplications);
        }
    }
}
