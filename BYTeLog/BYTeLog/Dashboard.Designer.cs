using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ReaLTaiizor.Controls;

namespace BYTeLog
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainHostPanel = new System.Windows.Forms.Panel();
            contentPanel = new System.Windows.Forms.Panel();
            topHeaderPanel = new System.Windows.Forms.Panel();
            logoDivider2 = new System.Windows.Forms.Panel();
            headerDivider = new System.Windows.Forms.Panel();
            lblSemester = new Label();
            lblPageTitle = new Label();
            sidebarPanel = new System.Windows.Forms.Panel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            logoDivider = new System.Windows.Forms.Panel();
            lblTagline = new Label();
            lblBrand = new Label();
            sidebarFooterPanel = new System.Windows.Forms.Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            lblAvatar = new Label();
            scrollableNavPanel = new System.Windows.Forms.Panel();
            btnSettings = new IconButton();
            lblSystem = new Label();
            btnCalendar = new IconButton();
            btnAuditLog = new IconButton();
            btnArchive = new IconButton();
            btnClearance = new IconButton();
            lblOperations = new Label();
            btnReports = new IconButton();
            btnFines = new IconButton();
            btnPayments = new IconButton();
            lblFinance = new Label();
            btnAttendance = new IconButton();
            btnActivities = new IconButton();
            btnMembers = new IconButton();
            btnDashboard = new IconButton();
            lblMain = new Label();
            mainHostPanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            sidebarFooterPanel.SuspendLayout();
            scrollableNavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainHostPanel
            // 
            mainHostPanel.BackColor = Color.FromArgb(244, 239, 231);
            mainHostPanel.Controls.Add(contentPanel);
            mainHostPanel.Controls.Add(topHeaderPanel);
            mainHostPanel.Controls.Add(sidebarPanel);
            mainHostPanel.Dock = DockStyle.Fill;
            mainHostPanel.Location = new Point(0, 0);
            mainHostPanel.Margin = new Padding(4);
            mainHostPanel.Name = "mainHostPanel";
            mainHostPanel.Size = new Size(1280, 720);
            mainHostPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(244, 239, 231);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(325, 105);
            contentPanel.Margin = new Padding(4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(955, 615);
            contentPanel.TabIndex = 2;
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.White;
            topHeaderPanel.Controls.Add(logoDivider2);
            topHeaderPanel.Controls.Add(headerDivider);
            topHeaderPanel.Controls.Add(lblSemester);
            topHeaderPanel.Controls.Add(lblPageTitle);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(325, 0);
            topHeaderPanel.Margin = new Padding(4);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(955, 105);
            topHeaderPanel.TabIndex = 1;
            // 
            // logoDivider2
            // 
            logoDivider2.BackColor = Color.FromArgb(236, 230, 222);
            logoDivider2.Location = new Point(0, 0);
            logoDivider2.Margin = new Padding(4);
            logoDivider2.Name = "logoDivider2";
            logoDivider2.Size = new Size(1, 106);
            logoDivider2.TabIndex = 4;
            // 
            // headerDivider
            // 
            headerDivider.BackColor = Color.FromArgb(236, 230, 222);
            headerDivider.Dock = DockStyle.Bottom;
            headerDivider.Location = new Point(0, 104);
            headerDivider.Margin = new Padding(4);
            headerDivider.Name = "headerDivider";
            headerDivider.Size = new Size(955, 1);
            headerDivider.TabIndex = 3;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Poppins", 10F);
            lblSemester.ForeColor = Color.FromArgb(122, 122, 128);
            lblSemester.Location = new Point(25, 55);
            lblSemester.Margin = new Padding(4, 0, 4, 0);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(272, 30);
            lblSemester.TabIndex = 1;
            lblSemester.Text = "S.Y. 2025-2026 · 2nd Semester";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblPageTitle.Location = new Point(22, 15);
            lblPageTitle.Margin = new Padding(4, 0, 4, 0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(163, 44);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.White;
            sidebarPanel.Controls.Add(panel1);
            sidebarPanel.Controls.Add(logoDivider);
            sidebarPanel.Controls.Add(lblTagline);
            sidebarPanel.Controls.Add(lblBrand);
            sidebarPanel.Controls.Add(sidebarFooterPanel);
            sidebarPanel.Controls.Add(scrollableNavPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(325, 720);
            sidebarPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources._462188993_504834578979683_7612540065311618134_n;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.EdgeColor = Color.Transparent;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(28, 25);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(52, 52);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 23;
            panel1.Text = "logoMark";
            // 
            // logoDivider
            // 
            logoDivider.BackColor = Color.FromArgb(236, 230, 222);
            logoDivider.Location = new Point(0, 105);
            logoDivider.Margin = new Padding(4);
            logoDivider.Name = "logoDivider";
            logoDivider.Size = new Size(325, 1);
            logoDivider.TabIndex = 3;
            // 
            // lblTagline
            // 
            lblTagline.AutoSize = true;
            lblTagline.Font = new Font("Poppins", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(156, 163, 175);
            lblTagline.Location = new Point(95, 52);
            lblTagline.Margin = new Padding(4, 0, 4, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(100, 23);
            lblTagline.TabIndex = 1;
            lblTagline.Text = "BYTE TRACKER";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(20, 20, 20);
            lblBrand.Location = new Point(88, 23);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(127, 44);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "BYTeLog";
            // 
            // sidebarFooterPanel
            // 
            sidebarFooterPanel.BackColor = Color.White;
            sidebarFooterPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarFooterPanel.Controls.Add(lblUserRole);
            sidebarFooterPanel.Controls.Add(lblUserName);
            sidebarFooterPanel.Controls.Add(lblAvatar);
            sidebarFooterPanel.Dock = DockStyle.Bottom;
            sidebarFooterPanel.Location = new Point(0, 616);
            sidebarFooterPanel.Margin = new Padding(4);
            sidebarFooterPanel.Name = "sidebarFooterPanel";
            sidebarFooterPanel.Size = new Size(325, 104);
            sidebarFooterPanel.TabIndex = 22;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Poppins", 9F);
            lblUserRole.ForeColor = Color.FromArgb(126, 126, 132);
            lblUserRole.Location = new Point(95, 58);
            lblUserRole.Margin = new Padding(4, 0, 4, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(82, 26);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "President";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Poppins", 10F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(20, 20, 20);
            lblUserName.Location = new Point(95, 28);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(93, 30);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Prins Doe";
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.FromArgb(231, 232, 255);
            lblAvatar.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.FromArgb(88, 77, 216);
            lblAvatar.Location = new Point(30, 28);
            lblAvatar.Margin = new Padding(4, 0, 4, 0);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(50, 50);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "PD";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scrollableNavPanel
            // 
            scrollableNavPanel.AutoScroll = true;
            scrollableNavPanel.AutoScrollMargin = new Size(0, 20);
            scrollableNavPanel.Controls.Add(btnSettings);
            scrollableNavPanel.Controls.Add(lblSystem);
            scrollableNavPanel.Controls.Add(btnCalendar);
            scrollableNavPanel.Controls.Add(btnAuditLog);
            scrollableNavPanel.Controls.Add(btnArchive);
            scrollableNavPanel.Controls.Add(btnClearance);
            scrollableNavPanel.Controls.Add(lblOperations);
            scrollableNavPanel.Controls.Add(btnReports);
            scrollableNavPanel.Controls.Add(btnFines);
            scrollableNavPanel.Controls.Add(btnPayments);
            scrollableNavPanel.Controls.Add(lblFinance);
            scrollableNavPanel.Controls.Add(btnAttendance);
            scrollableNavPanel.Controls.Add(btnActivities);
            scrollableNavPanel.Controls.Add(btnMembers);
            scrollableNavPanel.Controls.Add(btnDashboard);
            scrollableNavPanel.Controls.Add(lblMain);
            scrollableNavPanel.Location = new Point(0, 104);
            scrollableNavPanel.Name = "scrollableNavPanel";
            scrollableNavPanel.Size = new Size(325, 512);
            scrollableNavPanel.TabIndex = 24;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.White;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(82, 82, 91);
            btnSettings.IconChar = IconChar.Cog;
            btnSettings.IconColor = Color.FromArgb(161, 161, 170);
            btnSettings.IconFont = IconFont.Auto;
            btnSettings.IconSize = 24;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(22, 785);
            btnSettings.Margin = new Padding(4);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(15, 0, 0, 0);
            btnSettings.Size = new Size(275, 50);
            btnSettings.TabIndex = 19;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblSystem
            // 
            lblSystem.AutoSize = true;
            lblSystem.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblSystem.ForeColor = Color.FromArgb(161, 161, 170);
            lblSystem.Location = new Point(28, 750);
            lblSystem.Margin = new Padding(4, 0, 4, 0);
            lblSystem.Name = "lblSystem";
            lblSystem.Size = new Size(68, 25);
            lblSystem.TabIndex = 18;
            lblSystem.Text = "SYSTEM";
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.White;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnCalendar.ForeColor = Color.FromArgb(82, 82, 91);
            btnCalendar.IconChar = IconChar.Calendar;
            btnCalendar.IconColor = Color.FromArgb(161, 161, 170);
            btnCalendar.IconFont = IconFont.Auto;
            btnCalendar.IconSize = 26;
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(22, 675);
            btnCalendar.Margin = new Padding(4);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(15, 0, 0, 0);
            btnCalendar.Size = new Size(275, 50);
            btnCalendar.TabIndex = 17;
            btnCalendar.Text = "Calendar";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.White;
            btnAuditLog.FlatAppearance.BorderSize = 0;
            btnAuditLog.FlatStyle = FlatStyle.Flat;
            btnAuditLog.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnAuditLog.ForeColor = Color.FromArgb(82, 82, 91);
            btnAuditLog.IconChar = IconChar.ClockRotateLeft;
            btnAuditLog.IconColor = Color.FromArgb(161, 161, 170);
            btnAuditLog.IconFont = IconFont.Auto;
            btnAuditLog.IconSize = 26;
            btnAuditLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditLog.Location = new Point(22, 625);
            btnAuditLog.Margin = new Padding(4);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Padding = new Padding(15, 0, 0, 0);
            btnAuditLog.Size = new Size(275, 50);
            btnAuditLog.TabIndex = 16;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.White;
            btnArchive.FlatAppearance.BorderSize = 0;
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnArchive.ForeColor = Color.FromArgb(82, 82, 91);
            btnArchive.IconChar = IconChar.Archive;
            btnArchive.IconColor = Color.FromArgb(161, 161, 170);
            btnArchive.IconFont = IconFont.Auto;
            btnArchive.IconSize = 26;
            btnArchive.ImageAlign = ContentAlignment.MiddleLeft;
            btnArchive.Location = new Point(22, 575);
            btnArchive.Margin = new Padding(4);
            btnArchive.Name = "btnArchive";
            btnArchive.Padding = new Padding(15, 0, 0, 0);
            btnArchive.Size = new Size(275, 50);
            btnArchive.TabIndex = 15;
            btnArchive.Text = "Archive";
            btnArchive.TextAlign = ContentAlignment.MiddleLeft;
            btnArchive.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArchive.UseVisualStyleBackColor = false;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnClearance
            // 
            btnClearance.BackColor = Color.White;
            btnClearance.FlatAppearance.BorderSize = 0;
            btnClearance.FlatStyle = FlatStyle.Flat;
            btnClearance.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnClearance.ForeColor = Color.FromArgb(82, 82, 91);
            btnClearance.IconChar = IconChar.CheckCircle;
            btnClearance.IconColor = Color.FromArgb(161, 161, 170);
            btnClearance.IconFont = IconFont.Auto;
            btnClearance.IconSize = 26;
            btnClearance.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearance.Location = new Point(22, 525);
            btnClearance.Margin = new Padding(4);
            btnClearance.Name = "btnClearance";
            btnClearance.Padding = new Padding(15, 0, 0, 0);
            btnClearance.Size = new Size(275, 50);
            btnClearance.TabIndex = 14;
            btnClearance.Text = "Clearance";
            btnClearance.TextAlign = ContentAlignment.MiddleLeft;
            btnClearance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearance.UseVisualStyleBackColor = false;
            btnClearance.Click += btnClearance_Click;
            // 
            // lblOperations
            // 
            lblOperations.AutoSize = true;
            lblOperations.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblOperations.ForeColor = Color.FromArgb(161, 161, 170);
            lblOperations.Location = new Point(28, 490);
            lblOperations.Margin = new Padding(4, 0, 4, 0);
            lblOperations.Name = "lblOperations";
            lblOperations.Size = new Size(102, 25);
            lblOperations.TabIndex = 13;
            lblOperations.Text = "OPERATIONS";
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnReports.ForeColor = Color.FromArgb(82, 82, 91);
            btnReports.IconChar = IconChar.FileText;
            btnReports.IconColor = Color.FromArgb(161, 161, 170);
            btnReports.IconFont = IconFont.Auto;
            btnReports.IconSize = 26;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(22, 365);
            btnReports.Margin = new Padding(4);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(15, 0, 0, 0);
            btnReports.Size = new Size(275, 50);
            btnReports.TabIndex = 12;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnFines
            // 
            btnFines.BackColor = Color.White;
            btnFines.FlatAppearance.BorderSize = 0;
            btnFines.FlatStyle = FlatStyle.Flat;
            btnFines.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnFines.ForeColor = Color.FromArgb(82, 82, 91);
            btnFines.IconChar = IconChar.CircleExclamation;
            btnFines.IconColor = Color.FromArgb(161, 161, 170);
            btnFines.IconFont = IconFont.Auto;
            btnFines.IconSize = 26;
            btnFines.ImageAlign = ContentAlignment.MiddleLeft;
            btnFines.Location = new Point(22, 415);
            btnFines.Margin = new Padding(4);
            btnFines.Name = "btnFines";
            btnFines.Padding = new Padding(15, 0, 0, 0);
            btnFines.Size = new Size(275, 50);
            btnFines.TabIndex = 11;
            btnFines.Text = "Fines";
            btnFines.TextAlign = ContentAlignment.MiddleLeft;
            btnFines.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFines.UseVisualStyleBackColor = false;
            btnFines.Click += btnFines_Click;
            // 
            // btnPayments
            // 
            btnPayments.BackColor = Color.White;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnPayments.ForeColor = Color.FromArgb(82, 82, 91);
            btnPayments.IconChar = IconChar.CreditCard;
            btnPayments.IconColor = Color.FromArgb(161, 161, 170);
            btnPayments.IconFont = IconFont.Auto;
            btnPayments.IconSize = 26;
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(22, 315);
            btnPayments.Margin = new Padding(4);
            btnPayments.Name = "btnPayments";
            btnPayments.Padding = new Padding(15, 0, 0, 0);
            btnPayments.Size = new Size(275, 50);
            btnPayments.TabIndex = 10;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // lblFinance
            // 
            lblFinance.AutoSize = true;
            lblFinance.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblFinance.ForeColor = Color.FromArgb(161, 161, 170);
            lblFinance.Location = new Point(28, 280);
            lblFinance.Margin = new Padding(4, 0, 4, 0);
            lblFinance.Name = "lblFinance";
            lblFinance.Size = new Size(75, 25);
            lblFinance.TabIndex = 9;
            lblFinance.Text = "FINANCE";
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.White;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.FromArgb(82, 82, 91);
            btnAttendance.IconChar = IconChar.ClockFour;
            btnAttendance.IconColor = Color.FromArgb(161, 161, 170);
            btnAttendance.IconFont = IconFont.Auto;
            btnAttendance.IconSize = 26;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(22, 205);
            btnAttendance.Margin = new Padding(4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(15, 0, 0, 0);
            btnAttendance.Size = new Size(275, 50);
            btnAttendance.TabIndex = 8;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnActivities
            // 
            btnActivities.BackColor = Color.White;
            btnActivities.FlatAppearance.BorderSize = 0;
            btnActivities.FlatStyle = FlatStyle.Flat;
            btnActivities.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnActivities.ForeColor = Color.FromArgb(82, 82, 91);
            btnActivities.IconChar = IconChar.Calendar;
            btnActivities.IconColor = Color.FromArgb(161, 161, 170);
            btnActivities.IconFont = IconFont.Auto;
            btnActivities.IconSize = 26;
            btnActivities.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivities.Location = new Point(22, 155);
            btnActivities.Margin = new Padding(4);
            btnActivities.Name = "btnActivities";
            btnActivities.Padding = new Padding(15, 0, 0, 0);
            btnActivities.Size = new Size(275, 50);
            btnActivities.TabIndex = 7;
            btnActivities.Text = "Activities";
            btnActivities.TextAlign = ContentAlignment.MiddleLeft;
            btnActivities.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActivities.UseVisualStyleBackColor = false;
            btnActivities.Click += btnActivities_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.White;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnMembers.ForeColor = Color.FromArgb(82, 82, 91);
            btnMembers.IconChar = IconChar.Users;
            btnMembers.IconColor = Color.FromArgb(161, 161, 170);
            btnMembers.IconFont = IconFont.Auto;
            btnMembers.IconSize = 26;
            btnMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnMembers.Location = new Point(22, 105);
            btnMembers.Margin = new Padding(4);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(15, 0, 0, 0);
            btnMembers.Size = new Size(275, 50);
            btnMembers.TabIndex = 6;
            btnMembers.Text = "Members";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(233, 239, 255);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(58, 99, 232);
            btnDashboard.IconChar = IconChar.House;
            btnDashboard.IconColor = Color.FromArgb(58, 99, 232);
            btnDashboard.IconFont = IconFont.Auto;
            btnDashboard.IconSize = 26;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(22, 55);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(275, 50);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblMain.ForeColor = Color.FromArgb(161, 161, 170);
            lblMain.Location = new Point(28, 20);
            lblMain.Margin = new Padding(4, 0, 4, 0);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(50, 25);
            lblMain.TabIndex = 4;
            lblMain.Text = "MAIN";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(mainHostPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximumSize = new Size(2400, 1350);
            MinimumSize = new Size(190, 40);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardNiLeader";
            mainHostPanel.ResumeLayout(false);
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            sidebarFooterPanel.ResumeLayout(false);
            sidebarFooterPanel.PerformLayout();
            scrollableNavPanel.ResumeLayout(false);
            scrollableNavPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private System.Windows.Forms.Panel mainHostPanel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel sidebarFooterPanel;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAvatar;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.Label lblSystem;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton btnAuditLog;
        private FontAwesome.Sharp.IconButton btnArchive;
        private FontAwesome.Sharp.IconButton btnClearance;
        private System.Windows.Forms.Label lblOperations;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnFines;
        private FontAwesome.Sharp.IconButton btnPayments;
        private System.Windows.Forms.Label lblFinance;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnActivities;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel logoDivider;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel topHeaderPanel;
        private System.Windows.Forms.Panel headerDivider;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel contentPanel;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.Panel scrollableNavPanel;
        private System.Windows.Forms.Panel logoDivider2;
    }

}
