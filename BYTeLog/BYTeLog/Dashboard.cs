using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BYTeLog.Views;

namespace BYTeLog
{
    public partial class Dashboard : Form
    {
        private FontAwesome.Sharp.IconButton currentBtn;

        public Dashboard()
        {
            InitializeComponent();
            lblPageTitle.Text = "Dashboard";
            LoadPage(new DashboardView());
            currentBtn = btnDashboard;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }


        //---------------------- SIDEBAR - MAIN BUTTONS EVENTS ------------------//
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Dashboard";
            LoadPage(new DashboardView());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Members";
            LoadPage(new MembersView());
        }

        private void btnActivities_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Activities";
            LoadPage(new ActivitiesView());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Attendance";
            LoadPage(new AttendanceView());
        }


        //---------------------- SIDEBAR - FINANCE BUTTONS EVENTS ------------------//
        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Payments";
            LoadPage(new PaymentsView());
        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Fines";
            LoadPage(new FinesView());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Reports";
            LoadPage(new ReportsView());
        }


        //---------------------- SIDEBAR - OPERATIONS BUTTONS EVENTS ------------------//
        private void btnClearance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Clearance";
            LoadPage(new ClearanceView());
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Archive";
            LoadPage(new ArchiveView());
        }

        private void btnAuditLog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Audit Log";
            LoadPage(new AuditLogView());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Calendar";
            LoadPage(new CalendarView());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblPageTitle.Text = "Settings";
            LoadPage(new SettingsView());
        }


        //---------------------- SIDEBAR - ACTIVE AND INACTIVE BUTTON LOGIC ------------------//
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                if (currentBtn == (FontAwesome.Sharp.IconButton)senderBtn)
                {
                    return;
                }

                DisableButton();

                currentBtn = (FontAwesome.Sharp.IconButton)senderBtn;

                currentBtn.BackColor = Color.FromArgb(239, 239, 255);
                currentBtn.ForeColor = Color.FromArgb(58, 99, 232);
                currentBtn.IconColor = Color.FromArgb(58, 99, 232);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(82, 82, 91);
                currentBtn.IconColor = Color.FromArgb(161, 161, 170);
            }
        }


        //---------------------- TESTING ------------------//
        private void TestMethod() 
        {
            MessageBox.Show("Test");
        }
    }
}
