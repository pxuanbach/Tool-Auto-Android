using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;

namespace AutoLDWinform
{
    public partial class MainForm : Form
    {
        LoadBmpCloseAD closeAD;
        List<string> deviceID;
        ToolTip toolTip = new ToolTip();
        public MainForm()
        {
            InitializeComponent();
            cbBdevicesID.DataSource = listDevices();
            dGV.ReadOnly = true;
            closeAD = new LoadBmpCloseAD();
            lbNumImages.Text = closeAD.imageClose.Count.ToString();

            toolTip.SetToolTip(btReload, "Reload list devices");
            toolTip.SetToolTip(btAddID, "Add device ID to Datatable");
            toolTip.SetToolTip(btDeleteRow, "Delete selected row in Datatable");
            toolTip.SetToolTip(btReloadImage, "Reload list Images");
            toolTip.SetToolTip(btExit, "Exit application");
        }

        List<string> listDevices()
        {
            deviceID = new List<string>();
            deviceID = KAutoHelper.ADBHelper.GetDevices();
            return deviceID;
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            cbBdevicesID.DataSource = listDevices();
        }

        private void btAddID_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = ListToDatatable.ConvertListToDataTable(deviceID, "deviceID");
                dGV.DataSource = table;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void btB_Click(object sender, EventArgs e)
        {
            try
            {
                Task t = new Task(() =>
                {
                    for (int i = 0; i < dGV.Rows.Count; i++)
                    {
                        string dvID = dGV.Rows[i].Cells["dvID"].Value.ToString();
                        AutoBProgram.Start(dvID, dGV.Rows[i], closeAD.imageClose);
                    }

                });
                t.Start();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btMvL_Click(object sender, EventArgs e)
        {
            try
            {
                Task t = new Task(() =>
                {
                    for (int i = 0; i < dGV.Rows.Count; i++)
                    {
                        string dvID = dGV.Rows[i].Cells["dvID"].Value.ToString();
                        AutoMvL.Start(dvID, dGV.Rows[i], closeAD.imageClose);
                    }
                        
                });
                t.Start();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbInfor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linklbInfor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/xuanbach.pham.10/");
        }

        private void btDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dGV.SelectedRows[0].Index;
                dGV.Rows.RemoveAt(index);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btReloadImage_Click(object sender, EventArgs e)
        {
            try
            {
                closeAD.imageClose.Clear();
                closeAD = new LoadBmpCloseAD();
                lbNumImages.Text = closeAD.imageClose.Count.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
