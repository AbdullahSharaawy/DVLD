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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DVLD
{
    public partial class LocalDrivingLicenseApplicationsForm : Form
    {
       
        public delegate void dgLocalDrivingLicense();
        public static event dgLocalDrivingLicense evLocalDrivingLicenseInfo;
        public delegate void dgSetFormMode(AddNewUser.enMode Mode);
        public static event dgSetFormMode evSetFormMode;

        public LocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
            
        }

        private void LocalDrivingLicenseApplicationsForm_Load(object sender, EventArgs e)
        {
            dgLocalDrivingLicenseApplications.DataSource=clsLocalDrivingLicenseApplicationManagement.GetAll();
            dgLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLocalDrivingLicenseApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Filter._LocalDrivingLicenseApplications = (DataTable)dgLocalDrivingLicenseApplications.DataSource;
        }

        private void localDrivingLicenseApplications_Filter1_evFilterResult(object sender, DataTable e)
        {
            if(e!=null)
            {
                dgLocalDrivingLicenseApplications.DataSource = e;
               

            }

        }

        private void btNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            clsApplicationsManagement.Mode = clsApplicationsManagement.enMode.New;
            Form form = new NewLocalDrivingLicenseApplicationForm();
            evSetFormMode(AddNewUser.enMode.LocalDrivingLicense);
            evLocalDrivingLicenseInfo();
            form.ShowDialog();
        }

        private void dgLocalDrivingLicenseApplications_MouseDown(object sender, MouseEventArgs e)
        {
            if(dgLocalDrivingLicenseApplications.DataSource!=null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Loop through the items of the ContextMenuStrip
                    foreach (ToolStripItem item in cmsLocalDrivingLicenseApplications.Items)
                    {
                        if (Convert.ToInt32(dgLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value) == 0)
                        {
                            if (item is ToolStripMenuItem subMenuItem && subMenuItem.Text.Contains("Issue Driving License(First Time)"))
                            {
                                subMenuItem.Enabled = false; // Disable it
                            }
                            if (item is ToolStripMenuItem subMenuItem2 && subMenuItem2.Text.Contains("Show License"))
                            {
                                subMenuItem2.Enabled = false; // Disable it
                            }
                         
                        }
                        if (item is ToolStripMenuItem menuItem && menuItem.Text.Contains("Sechdule Test"))
                        {
                            foreach (ToolStripItem subItem in menuItem.DropDownItems)
                            {
                                if (Convert.ToInt32(dgLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value) == 0)
                                {
                                    if (subItem is ToolStripMenuItem subMenuItem && subMenuItem.Text.Contains("Street Test"))
                                    {
                                        subMenuItem.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem2 && subMenuItem2.Text.Contains("Written Test"))
                                    {
                                        subMenuItem2.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem3 && subMenuItem3.Text.Contains("Vision Test"))
                                    {
                                        subMenuItem3.Enabled = true; // able it
                                    }

                                }


                                else if (Convert.ToInt32(dgLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value) == 1)
                                {

                                    if (subItem is ToolStripMenuItem subMenuItem && subMenuItem.Text.Contains("Street Test"))
                                    {
                                        subMenuItem.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem2 && subMenuItem2.Text.Contains("Vision Test"))
                                    {
                                        subMenuItem2.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem3 && subMenuItem3.Text.Contains("Written Test"))
                                    {
                                        subMenuItem3.Enabled = true; // able it
                                    }

                                }
                                else if (Convert.ToInt32(dgLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value) == 2)

                                {
                                    if (subItem is ToolStripMenuItem subMenuItem && subMenuItem.Text.Contains("Vision Test"))
                                    {
                                        subMenuItem.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem2 && subMenuItem2.Text.Contains("Written Test"))
                                    {
                                        subMenuItem2.Enabled = false; // Disable it
                                    }
                                    if (subItem is ToolStripMenuItem subMenuItem3 && subMenuItem3.Text.Contains("Street Test"))
                                    {
                                        subMenuItem3.Enabled = true; // able it
                                    }

                                }
                                else if (Convert.ToInt32(dgLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value) == 3)

                                {

                                    if (subItem is ToolStripMenuItem subMenuItem)
                                    {
                                        subMenuItem.Enabled = false; // Disable it
                                    }

                                }
                                
                            }
                        }
                    }

                    
                }
                }
            
            }

        private void secheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form=new VisionTestForm(dgLocalDrivingLicenseApplications.CurrentRow);
            form.ShowDialog();
        }
    }
    }

