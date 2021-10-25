using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hydroponics_GUI
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
          (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
       
          );


        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavigate.Height = btn_dashboard.Height;
            pnlNavigate.Top = btn_dashboard.Top;
            pnlNavigate.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            //intial form Dashboard
            lblTitle.Text = "Dashboard";
            this.pnlFormloader.Controls.Clear();
            FrmDashboard FrmDashboard_Vrp = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            FrmDashboard_Vrp.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormloader.Controls.Add(FrmDashboard_Vrp);
            FrmDashboard_Vrp.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btn_dashboard.Height;
            pnlNavigate.Top = btn_dashboard.Top;
            pnlNavigate.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            //To show form Dashboard
            lblTitle.Text = "Dashboard";
            this.pnlFormloader.Controls.Clear();
            FrmDashboard FrmDashboard_Vrp = new FrmDashboard() {Dock = DockStyle.Fill,TopLevel=false,TopMost=true };

            FrmDashboard_Vrp.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormloader.Controls.Add(FrmDashboard_Vrp);
            FrmDashboard_Vrp.Show();
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btnTrigger.Height;
            pnlNavigate.Top = btnTrigger.Top;
            pnlNavigate.Left = btnTrigger.Left;
            btnTrigger.BackColor = Color.FromArgb(46, 51, 73);

            //To show trigger form
            lblTitle.Text = "Triggers";
            this.pnlFormloader.Controls.Clear();
            frmTrigger frmTrigger_Hydro = new frmTrigger() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            frmTrigger_Hydro.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormloader.Controls.Add(frmTrigger_Hydro);
            frmTrigger_Hydro.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btn_settings.Height;
            pnlNavigate.Top = btn_settings.Top;
            pnlNavigate.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

            //To show Settigns
            lblTitle.Text = "Settings";
            this.pnlFormloader.Controls.Clear();
            frmSettings frmSettings_Hydro = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            frmSettings_Hydro.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormloader.Controls.Add(frmSettings_Hydro);
            frmSettings_Hydro.Show();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            pnlNavigate.Height = btn_signout.Height;
            pnlNavigate.Top = btn_signout.Top;
            pnlNavigate.Left = btn_signout.Left;
            btn_signout.BackColor = Color.FromArgb(46, 51, 73);

            
        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTrigger_Leave(object sender, EventArgs e)
        {
            btnTrigger.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_signout_Leave(object sender, EventArgs e)
        {
            btn_signout.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
