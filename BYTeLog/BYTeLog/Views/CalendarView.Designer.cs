using FontAwesome.Sharp;

namespace BYTeLog.Views
{
    partial class CalendarView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            outerScrollPanel = new Panel();
            innerContentPanel = new Panel();
            cardNavBar = new Panel();
            pnlCalIconBox = new Panel();
            iconCalendar = new IconPictureBox();
            lblPageTitle = new Label();
            dividerNav = new Panel();
            btnPrevMonth = new IconButton();
            lblMonthYear = new Label();
            btnNextMonth = new IconButton();
            btnToday = new IconButton();
            btnViewMonth = new IconButton();
            btnViewWeek = new IconButton();
            btnViewList = new IconButton();
            cardLegend = new Panel();
            pnlLegendActivity = new Panel();
            lblLegendActivity = new Label();
            pnlLegendAttendance = new Panel();
            lblLegendAttendance = new Label();
            pnlLegendMembership = new Panel();
            lblLegendMembership = new Label();
            pnlLegendPenalty = new Panel();
            lblLegendPenalty = new Label();
            pnlLegendClearance = new Panel();
            lblLegendClearance = new Label();
            pnlLegendCheckpoint = new Panel();
            lblLegendCheckpoint = new Label();
            cardCalendarGrid = new Panel();
            pnlDayHeaders = new Panel();
            lblDaySun = new Label();
            lblDayMon = new Label();
            lblDayTue = new Label();
            lblDayWed = new Label();
            lblDayThu = new Label();
            lblDayFri = new Label();
            lblDaySat = new Label();
            dividerDayHeader = new Panel();
            pnlCalendarCells = new Panel();
            cardUpcoming = new Panel();
            pnlUpcomingIconBox = new Panel();
            iconUpcoming = new IconPictureBox();
            lblUpcomingTitle = new Label();
            dividerUpcoming = new Panel();
            pnlUpcomingList = new Panel();
            pnlUpItem1 = new Panel();
            pnlUpItem1Accent = new Panel();
            lblUpItem1Date = new Label();
            lblUpItem1Title = new Label();
            lblUpItem1Badge = new Label();
            pnlUpItem2 = new Panel();
            pnlUpItem2Accent = new Panel();
            lblUpItem2Date = new Label();
            lblUpItem2Title = new Label();
            lblUpItem2Badge = new Label();
            pnlUpItem3 = new Panel();
            pnlUpItem3Accent = new Panel();
            lblUpItem3Date = new Label();
            lblUpItem3Title = new Label();
            lblUpItem3Badge = new Label();
            pnlUpItem4 = new Panel();
            pnlUpItem4Accent = new Panel();
            lblUpItem4Date = new Label();
            lblUpItem4Title = new Label();
            lblUpItem4Badge = new Label();
            pnlUpItem5 = new Panel();
            pnlUpItem5Accent = new Panel();
            lblUpItem5Date = new Label();
            lblUpItem5Title = new Label();
            lblUpItem5Badge = new Label();
            lblNoUpcoming = new Label();
            cardEventDetail = new Panel();
            pnlEventDetailIconBox = new Panel();
            iconEventDetail = new IconPictureBox();
            lblEventDetailTitle = new Label();
            btnCloseEventDetail = new IconButton();
            dividerEventDetail = new Panel();
            pnlEventDetailAccentBar = new Panel();
            lblEdTypeBadge = new Label();
            lblEdEventNameLbl = new Label();
            lblEdEventName = new Label();
            lblEdDateLbl = new Label();
            lblEdDate = new Label();
            lblEdTimeLbl = new Label();
            lblEdTime = new Label();
            lblEdModuleLbl = new Label();
            lblEdModule = new Label();
            lblEdStatusLbl = new Label();
            lblEdStatus = new Label();
            lblEdLocationLbl = new Label();
            lblEdLocation = new Label();
            lblEdDescLbl = new Label();
            txtEdDesc = new TextBox();
            btnEdViewRecord = new IconButton();
            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            cardNavBar.SuspendLayout();
            pnlCalIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCalendar).BeginInit();
            cardLegend.SuspendLayout();
            cardCalendarGrid.SuspendLayout();
            pnlDayHeaders.SuspendLayout();
            cardUpcoming.SuspendLayout();
            pnlUpcomingIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUpcoming).BeginInit();
            pnlUpcomingList.SuspendLayout();
            pnlUpItem1.SuspendLayout();
            pnlUpItem2.SuspendLayout();
            pnlUpItem3.SuspendLayout();
            pnlUpItem4.SuspendLayout();
            pnlUpItem5.SuspendLayout();
            cardEventDetail.SuspendLayout();
            pnlEventDetailIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconEventDetail).BeginInit();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 1330);
            outerScrollPanel.BackColor = Color.FromArgb(244, 239, 231);
            outerScrollPanel.Controls.Add(innerContentPanel);
            outerScrollPanel.Dock = DockStyle.Fill;
            outerScrollPanel.Location = new Point(0, 0);
            outerScrollPanel.Name = "outerScrollPanel";
            outerScrollPanel.TabIndex = 0;
            // 
            // innerContentPanel
            // 
            innerContentPanel.BackColor = Color.FromArgb(244, 239, 231);
            innerContentPanel.Controls.Add(cardNavBar);
            innerContentPanel.Controls.Add(cardLegend);
            innerContentPanel.Controls.Add(cardCalendarGrid);
            innerContentPanel.Controls.Add(cardUpcoming);
            innerContentPanel.Controls.Add(cardEventDetail);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Padding = new Padding(30);
            innerContentPanel.Size = new Size(934, 1800);
            innerContentPanel.TabIndex = 0;
            // 
            // cardNavBar
            // 
            cardNavBar.BackColor = Color.White;
            cardNavBar.Controls.Add(pnlCalIconBox);
            cardNavBar.Controls.Add(lblPageTitle);
            cardNavBar.Controls.Add(dividerNav);
            cardNavBar.Controls.Add(btnPrevMonth);
            cardNavBar.Controls.Add(lblMonthYear);
            cardNavBar.Controls.Add(btnNextMonth);
            cardNavBar.Controls.Add(btnToday);
            cardNavBar.Controls.Add(btnViewMonth);
            cardNavBar.Controls.Add(btnViewWeek);
            cardNavBar.Controls.Add(btnViewList);
            cardNavBar.Location = new Point(30, 30);
            cardNavBar.Name = "cardNavBar";
            cardNavBar.Size = new Size(878, 80);
            cardNavBar.TabIndex = 0;
            // 
            // pnlCalIconBox
            // 
            pnlCalIconBox.BackColor = Color.FromArgb(233, 239, 255);
            pnlCalIconBox.Controls.Add(iconCalendar);
            pnlCalIconBox.Location = new Point(20, 18);
            pnlCalIconBox.Name = "pnlCalIconBox";
            pnlCalIconBox.Size = new Size(44, 44);
            pnlCalIconBox.TabIndex = 0;
            // 
            // iconCalendar
            // 
            iconCalendar.BackColor = Color.Transparent;
            iconCalendar.ForeColor = Color.FromArgb(58, 99, 232);
            iconCalendar.IconChar = IconChar.CalendarDays;
            iconCalendar.IconColor = Color.FromArgb(58, 99, 232);
            iconCalendar.IconFont = IconFont.Auto;
            iconCalendar.IconSize = 22;
            iconCalendar.Location = new Point(11, 11);
            iconCalendar.Name = "iconCalendar";
            iconCalendar.Size = new Size(22, 22);
            iconCalendar.TabIndex = 0;
            iconCalendar.TabStop = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblPageTitle.Location = new Point(74, 24);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(166, 34);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Event Calendar";
            // 
            // dividerNav
            // 
            dividerNav.BackColor = Color.FromArgb(236, 230, 222);
            dividerNav.Location = new Point(254, 16);
            dividerNav.Name = "dividerNav";
            dividerNav.Size = new Size(1, 48);
            dividerNav.TabIndex = 2;
            // 
            // btnPrevMonth
            // 
            btnPrevMonth.BackColor = Color.White;
            btnPrevMonth.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnPrevMonth.FlatStyle = FlatStyle.Flat;
            btnPrevMonth.ForeColor = Color.FromArgb(52, 52, 58);
            btnPrevMonth.IconChar = IconChar.ChevronLeft;
            btnPrevMonth.IconColor = Color.FromArgb(52, 52, 58);
            btnPrevMonth.IconFont = IconFont.Auto;
            btnPrevMonth.IconSize = 16;
            btnPrevMonth.Location = new Point(270, 24);
            btnPrevMonth.Name = "btnPrevMonth";
            btnPrevMonth.Size = new Size(36, 32);
            btnPrevMonth.TabIndex = 3;
            btnPrevMonth.UseVisualStyleBackColor = false;
            btnPrevMonth.Click += btnPrevMonth_Click;
            // 
            // lblMonthYear
            // 
            lblMonthYear.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblMonthYear.ForeColor = Color.FromArgb(20, 20, 20);
            lblMonthYear.Location = new Point(312, 24);
            lblMonthYear.Name = "lblMonthYear";
            lblMonthYear.Size = new Size(169, 32);
            lblMonthYear.TabIndex = 4;
            lblMonthYear.Text = "January 2025";
            lblMonthYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextMonth
            // 
            btnNextMonth.BackColor = Color.White;
            btnNextMonth.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnNextMonth.FlatStyle = FlatStyle.Flat;
            btnNextMonth.ForeColor = Color.FromArgb(52, 52, 58);
            btnNextMonth.IconChar = IconChar.ChevronRight;
            btnNextMonth.IconColor = Color.FromArgb(52, 52, 58);
            btnNextMonth.IconFont = IconFont.Auto;
            btnNextMonth.IconSize = 16;
            btnNextMonth.Location = new Point(487, 23);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(36, 32);
            btnNextMonth.TabIndex = 5;
            btnNextMonth.UseVisualStyleBackColor = false;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // btnToday
            // 
            btnToday.BackColor = Color.FromArgb(58, 99, 232);
            btnToday.FlatAppearance.BorderSize = 0;
            btnToday.FlatStyle = FlatStyle.Flat;
            btnToday.Font = new Font("Poppins", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToday.ForeColor = Color.White;
            btnToday.IconChar = IconChar.CircleDot;
            btnToday.IconColor = Color.White;
            btnToday.IconFont = IconFont.Auto;
            btnToday.IconSize = 14;
            btnToday.ImageAlign = ContentAlignment.MiddleLeft;
            btnToday.Location = new Point(541, 23);
            btnToday.Name = "btnToday";
            btnToday.Padding = new Padding(8, 0, 0, 0);
            btnToday.Size = new Size(86, 32);
            btnToday.TabIndex = 6;
            btnToday.Text = "Today";
            btnToday.TextAlign = ContentAlignment.MiddleLeft;
            btnToday.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnToday.UseVisualStyleBackColor = false;
            btnToday.Click += btnToday_Click;
            // 
            // btnViewMonth
            // 
            btnViewMonth.BackColor = Color.FromArgb(58, 99, 232);
            btnViewMonth.FlatAppearance.BorderSize = 0;
            btnViewMonth.FlatStyle = FlatStyle.Flat;
            btnViewMonth.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewMonth.ForeColor = Color.White;
            btnViewMonth.IconChar = IconChar.TableCells;
            btnViewMonth.IconColor = Color.White;
            btnViewMonth.IconFont = IconFont.Auto;
            btnViewMonth.IconSize = 14;
            btnViewMonth.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewMonth.Location = new Point(647, 23);
            btnViewMonth.Name = "btnViewMonth";
            btnViewMonth.Padding = new Padding(6, 0, 0, 0);
            btnViewMonth.Size = new Size(80, 32);
            btnViewMonth.TabIndex = 7;
            btnViewMonth.Tag = "month";
            btnViewMonth.Text = "Month";
            btnViewMonth.TextAlign = ContentAlignment.MiddleLeft;
            btnViewMonth.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewMonth.UseVisualStyleBackColor = false;
            btnViewMonth.Click += btnViewToggle_Click;
            // 
            // btnViewWeek
            // 
            btnViewWeek.BackColor = Color.White;
            btnViewWeek.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnViewWeek.FlatStyle = FlatStyle.Flat;
            btnViewWeek.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewWeek.ForeColor = Color.FromArgb(122, 122, 128);
            btnViewWeek.IconChar = IconChar.CalendarWeek;
            btnViewWeek.IconColor = Color.FromArgb(122, 122, 128);
            btnViewWeek.IconFont = IconFont.Auto;
            btnViewWeek.IconSize = 14;
            btnViewWeek.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewWeek.Location = new Point(733, 23);
            btnViewWeek.Name = "btnViewWeek";
            btnViewWeek.Padding = new Padding(6, 0, 0, 0);
            btnViewWeek.Size = new Size(76, 32);
            btnViewWeek.TabIndex = 8;
            btnViewWeek.Tag = "week";
            btnViewWeek.Text = "Week";
            btnViewWeek.TextAlign = ContentAlignment.MiddleLeft;
            btnViewWeek.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewWeek.UseVisualStyleBackColor = false;
            btnViewWeek.Click += btnViewToggle_Click;
            // 
            // btnViewList
            // 
            btnViewList.BackColor = Color.White;
            btnViewList.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnViewList.FlatStyle = FlatStyle.Flat;
            btnViewList.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewList.ForeColor = Color.FromArgb(122, 122, 128);
            btnViewList.IconChar = IconChar.ListSquares;
            btnViewList.IconColor = Color.FromArgb(122, 122, 128);
            btnViewList.IconFont = IconFont.Auto;
            btnViewList.IconSize = 14;
            btnViewList.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewList.Location = new Point(815, 23);
            btnViewList.Name = "btnViewList";
            btnViewList.Padding = new Padding(6, 0, 0, 0);
            btnViewList.Size = new Size(56, 32);
            btnViewList.TabIndex = 9;
            btnViewList.Tag = "list";
            btnViewList.Text = "List";
            btnViewList.TextAlign = ContentAlignment.MiddleLeft;
            btnViewList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewList.UseVisualStyleBackColor = false;
            btnViewList.Click += btnViewToggle_Click;
            // 
            // cardLegend
            // 
            cardLegend.BackColor = Color.White;
            cardLegend.Controls.Add(pnlLegendActivity);
            cardLegend.Controls.Add(lblLegendActivity);
            cardLegend.Controls.Add(pnlLegendAttendance);
            cardLegend.Controls.Add(lblLegendAttendance);
            cardLegend.Controls.Add(pnlLegendMembership);
            cardLegend.Controls.Add(lblLegendMembership);
            cardLegend.Controls.Add(pnlLegendPenalty);
            cardLegend.Controls.Add(lblLegendPenalty);
            cardLegend.Controls.Add(pnlLegendClearance);
            cardLegend.Controls.Add(lblLegendClearance);
            cardLegend.Controls.Add(pnlLegendCheckpoint);
            cardLegend.Controls.Add(lblLegendCheckpoint);
            cardLegend.Location = new Point(30, 126);
            cardLegend.Name = "cardLegend";
            cardLegend.Size = new Size(878, 44);
            cardLegend.TabIndex = 1;
            // 
            // pnlLegendActivity
            // 
            pnlLegendActivity.BackColor = Color.FromArgb(58, 99, 232);
            pnlLegendActivity.Location = new Point(24, 16);
            pnlLegendActivity.Name = "pnlLegendActivity";
            pnlLegendActivity.Size = new Size(12, 12);
            pnlLegendActivity.TabIndex = 0;
            // 
            // lblLegendActivity
            // 
            lblLegendActivity.AutoSize = true;
            lblLegendActivity.Font = new Font("Poppins", 8F);
            lblLegendActivity.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendActivity.Location = new Point(40, 10);
            lblLegendActivity.Name = "lblLegendActivity";
            lblLegendActivity.Size = new Size(62, 25);
            lblLegendActivity.TabIndex = 1;
            lblLegendActivity.Text = "Activity";
            // 
            // pnlLegendAttendance
            // 
            pnlLegendAttendance.BackColor = Color.FromArgb(16, 163, 92);
            pnlLegendAttendance.Location = new Point(130, 16);
            pnlLegendAttendance.Name = "pnlLegendAttendance";
            pnlLegendAttendance.Size = new Size(12, 12);
            pnlLegendAttendance.TabIndex = 2;
            // 
            // lblLegendAttendance
            // 
            lblLegendAttendance.AutoSize = true;
            lblLegendAttendance.Font = new Font("Poppins", 8F);
            lblLegendAttendance.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendAttendance.Location = new Point(146, 10);
            lblLegendAttendance.Name = "lblLegendAttendance";
            lblLegendAttendance.Size = new Size(94, 25);
            lblLegendAttendance.TabIndex = 3;
            lblLegendAttendance.Text = "Attendance";
            // 
            // pnlLegendMembership
            // 
            pnlLegendMembership.BackColor = Color.FromArgb(130, 60, 220);
            pnlLegendMembership.Location = new Point(258, 16);
            pnlLegendMembership.Name = "pnlLegendMembership";
            pnlLegendMembership.Size = new Size(12, 12);
            pnlLegendMembership.TabIndex = 4;
            // 
            // lblLegendMembership
            // 
            lblLegendMembership.AutoSize = true;
            lblLegendMembership.Font = new Font("Poppins", 8F);
            lblLegendMembership.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendMembership.Location = new Point(274, 10);
            lblLegendMembership.Name = "lblLegendMembership";
            lblLegendMembership.Size = new Size(98, 25);
            lblLegendMembership.TabIndex = 5;
            lblLegendMembership.Text = "Membership";
            // 
            // pnlLegendPenalty
            // 
            pnlLegendPenalty.BackColor = Color.FromArgb(220, 60, 60);
            pnlLegendPenalty.Location = new Point(392, 16);
            pnlLegendPenalty.Name = "pnlLegendPenalty";
            pnlLegendPenalty.Size = new Size(12, 12);
            pnlLegendPenalty.TabIndex = 6;
            // 
            // lblLegendPenalty
            // 
            lblLegendPenalty.AutoSize = true;
            lblLegendPenalty.Font = new Font("Poppins", 8F);
            lblLegendPenalty.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendPenalty.Location = new Point(408, 10);
            lblLegendPenalty.Name = "lblLegendPenalty";
            lblLegendPenalty.Size = new Size(63, 25);
            lblLegendPenalty.TabIndex = 7;
            lblLegendPenalty.Text = "Penalty";
            // 
            // pnlLegendClearance
            // 
            pnlLegendClearance.BackColor = Color.FromArgb(234, 140, 30);
            pnlLegendClearance.Location = new Point(496, 16);
            pnlLegendClearance.Name = "pnlLegendClearance";
            pnlLegendClearance.Size = new Size(12, 12);
            pnlLegendClearance.TabIndex = 8;
            // 
            // lblLegendClearance
            // 
            lblLegendClearance.AutoSize = true;
            lblLegendClearance.Font = new Font("Poppins", 8F);
            lblLegendClearance.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendClearance.Location = new Point(512, 10);
            lblLegendClearance.Name = "lblLegendClearance";
            lblLegendClearance.Size = new Size(85, 25);
            lblLegendClearance.TabIndex = 9;
            lblLegendClearance.Text = "Clearance";
            // 
            // pnlLegendCheckpoint
            // 
            pnlLegendCheckpoint.BackColor = Color.FromArgb(0, 172, 193);
            pnlLegendCheckpoint.Location = new Point(614, 16);
            pnlLegendCheckpoint.Name = "pnlLegendCheckpoint";
            pnlLegendCheckpoint.Size = new Size(12, 12);
            pnlLegendCheckpoint.TabIndex = 10;
            // 
            // lblLegendCheckpoint
            // 
            lblLegendCheckpoint.AutoSize = true;
            lblLegendCheckpoint.Font = new Font("Poppins", 8F);
            lblLegendCheckpoint.ForeColor = Color.FromArgb(52, 52, 58);
            lblLegendCheckpoint.Location = new Point(630, 10);
            lblLegendCheckpoint.Name = "lblLegendCheckpoint";
            lblLegendCheckpoint.Size = new Size(92, 25);
            lblLegendCheckpoint.TabIndex = 11;
            lblLegendCheckpoint.Text = "Checkpoint";
            // 
            // cardCalendarGrid
            // 
            cardCalendarGrid.BackColor = Color.White;
            cardCalendarGrid.Controls.Add(pnlDayHeaders);
            cardCalendarGrid.Controls.Add(dividerDayHeader);
            cardCalendarGrid.Controls.Add(pnlCalendarCells);
            cardCalendarGrid.Location = new Point(30, 186);
            cardCalendarGrid.Name = "cardCalendarGrid";
            cardCalendarGrid.Padding = new Padding(20, 16, 20, 20);
            cardCalendarGrid.Size = new Size(878, 700);
            cardCalendarGrid.TabIndex = 2;
            // 
            // pnlDayHeaders
            // 
            pnlDayHeaders.BackColor = Color.Transparent;
            pnlDayHeaders.Controls.Add(lblDaySun);
            pnlDayHeaders.Controls.Add(lblDayMon);
            pnlDayHeaders.Controls.Add(lblDayTue);
            pnlDayHeaders.Controls.Add(lblDayWed);
            pnlDayHeaders.Controls.Add(lblDayThu);
            pnlDayHeaders.Controls.Add(lblDayFri);
            pnlDayHeaders.Controls.Add(lblDaySat);
            pnlDayHeaders.Location = new Point(20, 16);
            pnlDayHeaders.Name = "pnlDayHeaders";
            pnlDayHeaders.Size = new Size(838, 32);
            pnlDayHeaders.TabIndex = 0;
            // 
            // lblDaySun
            // 
            lblDaySun.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDaySun.ForeColor = Color.FromArgb(122, 122, 128);
            lblDaySun.Location = new Point(0, 0);
            lblDaySun.Name = "lblDaySun";
            lblDaySun.Size = new Size(118, 32);
            lblDaySun.TabIndex = 0;
            lblDaySun.Text = "SUN";
            lblDaySun.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDayMon
            // 
            lblDayMon.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDayMon.ForeColor = Color.FromArgb(122, 122, 128);
            lblDayMon.Location = new Point(120, 0);
            lblDayMon.Name = "lblDayMon";
            lblDayMon.Size = new Size(118, 32);
            lblDayMon.TabIndex = 1;
            lblDayMon.Text = "MON";
            lblDayMon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDayTue
            // 
            lblDayTue.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDayTue.ForeColor = Color.FromArgb(122, 122, 128);
            lblDayTue.Location = new Point(240, 0);
            lblDayTue.Name = "lblDayTue";
            lblDayTue.Size = new Size(118, 32);
            lblDayTue.TabIndex = 2;
            lblDayTue.Text = "TUE";
            lblDayTue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDayWed
            // 
            lblDayWed.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDayWed.ForeColor = Color.FromArgb(122, 122, 128);
            lblDayWed.Location = new Point(360, 0);
            lblDayWed.Name = "lblDayWed";
            lblDayWed.Size = new Size(118, 32);
            lblDayWed.TabIndex = 3;
            lblDayWed.Text = "WED";
            lblDayWed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDayThu
            // 
            lblDayThu.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDayThu.ForeColor = Color.FromArgb(122, 122, 128);
            lblDayThu.Location = new Point(480, 0);
            lblDayThu.Name = "lblDayThu";
            lblDayThu.Size = new Size(118, 32);
            lblDayThu.TabIndex = 4;
            lblDayThu.Text = "THU";
            lblDayThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDayFri
            // 
            lblDayFri.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDayFri.ForeColor = Color.FromArgb(122, 122, 128);
            lblDayFri.Location = new Point(600, 0);
            lblDayFri.Name = "lblDayFri";
            lblDayFri.Size = new Size(118, 32);
            lblDayFri.TabIndex = 5;
            lblDayFri.Text = "FRI";
            lblDayFri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDaySat
            // 
            lblDaySat.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblDaySat.ForeColor = Color.FromArgb(122, 122, 128);
            lblDaySat.Location = new Point(718, 0);
            lblDaySat.Name = "lblDaySat";
            lblDaySat.Size = new Size(118, 32);
            lblDaySat.TabIndex = 6;
            lblDaySat.Text = "SAT";
            lblDaySat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividerDayHeader
            // 
            dividerDayHeader.BackColor = Color.FromArgb(236, 230, 222);
            dividerDayHeader.Location = new Point(20, 52);
            dividerDayHeader.Name = "dividerDayHeader";
            dividerDayHeader.Size = new Size(838, 1);
            dividerDayHeader.TabIndex = 1;
            // 
            // pnlCalendarCells
            // 
            pnlCalendarCells.BackColor = Color.Transparent;
            pnlCalendarCells.Location = new Point(20, 58);
            pnlCalendarCells.Name = "pnlCalendarCells";
            pnlCalendarCells.Size = new Size(838, 622);
            pnlCalendarCells.TabIndex = 2;
            // 
            // cardUpcoming
            // 
            cardUpcoming.BackColor = Color.White;
            cardUpcoming.Controls.Add(pnlUpcomingIconBox);
            cardUpcoming.Controls.Add(lblUpcomingTitle);
            cardUpcoming.Controls.Add(dividerUpcoming);
            cardUpcoming.Controls.Add(pnlUpcomingList);
            cardUpcoming.Controls.Add(lblNoUpcoming);
            cardUpcoming.Location = new Point(30, 902);
            cardUpcoming.Name = "cardUpcoming";
            cardUpcoming.Padding = new Padding(28, 24, 28, 28);
            cardUpcoming.Size = new Size(878, 390);
            cardUpcoming.TabIndex = 3;
            // 
            // pnlUpcomingIconBox
            // 
            pnlUpcomingIconBox.BackColor = Color.FromArgb(255, 243, 230);
            pnlUpcomingIconBox.Controls.Add(iconUpcoming);
            pnlUpcomingIconBox.Location = new Point(28, 24);
            pnlUpcomingIconBox.Name = "pnlUpcomingIconBox";
            pnlUpcomingIconBox.Size = new Size(44, 44);
            pnlUpcomingIconBox.TabIndex = 0;
            // 
            // iconUpcoming
            // 
            iconUpcoming.BackColor = Color.Transparent;
            iconUpcoming.ForeColor = Color.FromArgb(234, 140, 30);
            iconUpcoming.IconChar = IconChar.BellConcierge;
            iconUpcoming.IconColor = Color.FromArgb(234, 140, 30);
            iconUpcoming.IconFont = IconFont.Auto;
            iconUpcoming.IconSize = 22;
            iconUpcoming.Location = new Point(11, 11);
            iconUpcoming.Name = "iconUpcoming";
            iconUpcoming.Size = new Size(22, 22);
            iconUpcoming.TabIndex = 0;
            iconUpcoming.TabStop = false;
            // 
            // lblUpcomingTitle
            // 
            lblUpcomingTitle.AutoSize = true;
            lblUpcomingTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblUpcomingTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpcomingTitle.Location = new Point(82, 30);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new Size(186, 34);
            lblUpcomingTitle.TabIndex = 1;
            lblUpcomingTitle.Text = "Upcoming Events";
            // 
            // dividerUpcoming
            // 
            dividerUpcoming.BackColor = Color.FromArgb(236, 230, 222);
            dividerUpcoming.Location = new Point(28, 78);
            dividerUpcoming.Name = "dividerUpcoming";
            dividerUpcoming.Size = new Size(822, 1);
            dividerUpcoming.TabIndex = 2;
            // 
            // pnlUpcomingList
            // 
            pnlUpcomingList.AutoScroll = true;
            pnlUpcomingList.BackColor = Color.Transparent;
            pnlUpcomingList.Controls.Add(pnlUpItem1);
            pnlUpcomingList.Controls.Add(pnlUpItem2);
            pnlUpcomingList.Controls.Add(pnlUpItem3);
            pnlUpcomingList.Controls.Add(pnlUpItem4);
            pnlUpcomingList.Controls.Add(pnlUpItem5);
            pnlUpcomingList.Location = new Point(28, 90);
            pnlUpcomingList.Name = "pnlUpcomingList";
            pnlUpcomingList.Size = new Size(822, 270);
            pnlUpcomingList.TabIndex = 3;
            // 
            // pnlUpItem1
            // 
            pnlUpItem1.BackColor = Color.FromArgb(250, 250, 252);
            pnlUpItem1.Controls.Add(pnlUpItem1Accent);
            pnlUpItem1.Controls.Add(lblUpItem1Date);
            pnlUpItem1.Controls.Add(lblUpItem1Title);
            pnlUpItem1.Controls.Add(lblUpItem1Badge);
            pnlUpItem1.Cursor = Cursors.Hand;
            pnlUpItem1.Location = new Point(0, 0);
            pnlUpItem1.Name = "pnlUpItem1";
            pnlUpItem1.Size = new Size(806, 44);
            pnlUpItem1.TabIndex = 0;
            pnlUpItem1.Click += UpcomingItem_Click;
            // 
            // pnlUpItem1Accent
            // 
            pnlUpItem1Accent.BackColor = Color.FromArgb(58, 99, 232);
            pnlUpItem1Accent.Location = new Point(0, 0);
            pnlUpItem1Accent.Name = "pnlUpItem1Accent";
            pnlUpItem1Accent.Size = new Size(4, 44);
            pnlUpItem1Accent.TabIndex = 0;
            // 
            // lblUpItem1Date
            // 
            lblUpItem1Date.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblUpItem1Date.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpItem1Date.Location = new Point(16, 0);
            lblUpItem1Date.Name = "lblUpItem1Date";
            lblUpItem1Date.Size = new Size(128, 44);
            lblUpItem1Date.TabIndex = 1;
            lblUpItem1Date.Text = "Jan 15, 2025";
            lblUpItem1Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem1Title
            // 
            lblUpItem1Title.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblUpItem1Title.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpItem1Title.Location = new Point(152, 0);
            lblUpItem1Title.Name = "lblUpItem1Title";
            lblUpItem1Title.Size = new Size(440, 44);
            lblUpItem1Title.TabIndex = 2;
            lblUpItem1Title.Text = "General Assembly";
            lblUpItem1Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem1Badge
            // 
            lblUpItem1Badge.BackColor = Color.FromArgb(233, 239, 255);
            lblUpItem1Badge.Font = new Font("Poppins", 7.5F, FontStyle.Bold);
            lblUpItem1Badge.ForeColor = Color.FromArgb(58, 99, 232);
            lblUpItem1Badge.Location = new Point(606, 10);
            lblUpItem1Badge.Name = "lblUpItem1Badge";
            lblUpItem1Badge.Padding = new Padding(6, 0, 6, 0);
            lblUpItem1Badge.Size = new Size(88, 24);
            lblUpItem1Badge.TabIndex = 3;
            lblUpItem1Badge.Text = "Activity";
            lblUpItem1Badge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUpItem2
            // 
            pnlUpItem2.BackColor = Color.FromArgb(250, 250, 252);
            pnlUpItem2.Controls.Add(pnlUpItem2Accent);
            pnlUpItem2.Controls.Add(lblUpItem2Date);
            pnlUpItem2.Controls.Add(lblUpItem2Title);
            pnlUpItem2.Controls.Add(lblUpItem2Badge);
            pnlUpItem2.Cursor = Cursors.Hand;
            pnlUpItem2.Location = new Point(0, 52);
            pnlUpItem2.Name = "pnlUpItem2";
            pnlUpItem2.Size = new Size(806, 44);
            pnlUpItem2.TabIndex = 1;
            pnlUpItem2.Click += UpcomingItem_Click;
            // 
            // pnlUpItem2Accent
            // 
            pnlUpItem2Accent.BackColor = Color.FromArgb(16, 163, 92);
            pnlUpItem2Accent.Location = new Point(0, 0);
            pnlUpItem2Accent.Name = "pnlUpItem2Accent";
            pnlUpItem2Accent.Size = new Size(4, 44);
            pnlUpItem2Accent.TabIndex = 0;
            // 
            // lblUpItem2Date
            // 
            lblUpItem2Date.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblUpItem2Date.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpItem2Date.Location = new Point(16, 0);
            lblUpItem2Date.Name = "lblUpItem2Date";
            lblUpItem2Date.Size = new Size(128, 44);
            lblUpItem2Date.TabIndex = 1;
            lblUpItem2Date.Text = "Jan 18, 2025";
            lblUpItem2Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem2Title
            // 
            lblUpItem2Title.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblUpItem2Title.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpItem2Title.Location = new Point(152, 0);
            lblUpItem2Title.Name = "lblUpItem2Title";
            lblUpItem2Title.Size = new Size(440, 44);
            lblUpItem2Title.TabIndex = 2;
            lblUpItem2Title.Text = "Attendance Check — Meeting";
            lblUpItem2Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem2Badge
            // 
            lblUpItem2Badge.BackColor = Color.FromArgb(220, 248, 235);
            lblUpItem2Badge.Font = new Font("Poppins", 7.5F, FontStyle.Bold);
            lblUpItem2Badge.ForeColor = Color.FromArgb(16, 163, 92);
            lblUpItem2Badge.Location = new Point(606, 10);
            lblUpItem2Badge.Name = "lblUpItem2Badge";
            lblUpItem2Badge.Padding = new Padding(6, 0, 6, 0);
            lblUpItem2Badge.Size = new Size(88, 24);
            lblUpItem2Badge.TabIndex = 3;
            lblUpItem2Badge.Text = "Attendance";
            lblUpItem2Badge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUpItem3
            // 
            pnlUpItem3.BackColor = Color.FromArgb(250, 250, 252);
            pnlUpItem3.Controls.Add(pnlUpItem3Accent);
            pnlUpItem3.Controls.Add(lblUpItem3Date);
            pnlUpItem3.Controls.Add(lblUpItem3Title);
            pnlUpItem3.Controls.Add(lblUpItem3Badge);
            pnlUpItem3.Cursor = Cursors.Hand;
            pnlUpItem3.Location = new Point(0, 104);
            pnlUpItem3.Name = "pnlUpItem3";
            pnlUpItem3.Size = new Size(806, 44);
            pnlUpItem3.TabIndex = 2;
            pnlUpItem3.Click += UpcomingItem_Click;
            // 
            // pnlUpItem3Accent
            // 
            pnlUpItem3Accent.BackColor = Color.FromArgb(130, 60, 220);
            pnlUpItem3Accent.Location = new Point(0, 0);
            pnlUpItem3Accent.Name = "pnlUpItem3Accent";
            pnlUpItem3Accent.Size = new Size(4, 44);
            pnlUpItem3Accent.TabIndex = 0;
            // 
            // lblUpItem3Date
            // 
            lblUpItem3Date.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblUpItem3Date.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpItem3Date.Location = new Point(16, 0);
            lblUpItem3Date.Name = "lblUpItem3Date";
            lblUpItem3Date.Size = new Size(128, 44);
            lblUpItem3Date.TabIndex = 1;
            lblUpItem3Date.Text = "Jan 20, 2025";
            lblUpItem3Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem3Title
            // 
            lblUpItem3Title.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblUpItem3Title.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpItem3Title.Location = new Point(152, 0);
            lblUpItem3Title.Name = "lblUpItem3Title";
            lblUpItem3Title.Size = new Size(440, 44);
            lblUpItem3Title.TabIndex = 2;
            lblUpItem3Title.Text = "Membership Fee Deadline";
            lblUpItem3Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem3Badge
            // 
            lblUpItem3Badge.BackColor = Color.FromArgb(237, 225, 255);
            lblUpItem3Badge.Font = new Font("Poppins", 7.5F, FontStyle.Bold);
            lblUpItem3Badge.ForeColor = Color.FromArgb(130, 60, 220);
            lblUpItem3Badge.Location = new Point(606, 10);
            lblUpItem3Badge.Name = "lblUpItem3Badge";
            lblUpItem3Badge.Padding = new Padding(6, 0, 6, 0);
            lblUpItem3Badge.Size = new Size(88, 24);
            lblUpItem3Badge.TabIndex = 3;
            lblUpItem3Badge.Text = "Membership";
            lblUpItem3Badge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUpItem4
            // 
            pnlUpItem4.BackColor = Color.FromArgb(250, 250, 252);
            pnlUpItem4.Controls.Add(pnlUpItem4Accent);
            pnlUpItem4.Controls.Add(lblUpItem4Date);
            pnlUpItem4.Controls.Add(lblUpItem4Title);
            pnlUpItem4.Controls.Add(lblUpItem4Badge);
            pnlUpItem4.Cursor = Cursors.Hand;
            pnlUpItem4.Location = new Point(0, 156);
            pnlUpItem4.Name = "pnlUpItem4";
            pnlUpItem4.Size = new Size(806, 44);
            pnlUpItem4.TabIndex = 3;
            pnlUpItem4.Click += UpcomingItem_Click;
            // 
            // pnlUpItem4Accent
            // 
            pnlUpItem4Accent.BackColor = Color.FromArgb(220, 60, 60);
            pnlUpItem4Accent.Location = new Point(0, 0);
            pnlUpItem4Accent.Name = "pnlUpItem4Accent";
            pnlUpItem4Accent.Size = new Size(4, 44);
            pnlUpItem4Accent.TabIndex = 0;
            // 
            // lblUpItem4Date
            // 
            lblUpItem4Date.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblUpItem4Date.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpItem4Date.Location = new Point(16, 0);
            lblUpItem4Date.Name = "lblUpItem4Date";
            lblUpItem4Date.Size = new Size(128, 44);
            lblUpItem4Date.TabIndex = 1;
            lblUpItem4Date.Text = "Jan 22, 2025";
            lblUpItem4Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem4Title
            // 
            lblUpItem4Title.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblUpItem4Title.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpItem4Title.Location = new Point(152, 0);
            lblUpItem4Title.Name = "lblUpItem4Title";
            lblUpItem4Title.Size = new Size(440, 44);
            lblUpItem4Title.TabIndex = 2;
            lblUpItem4Title.Text = "Penalty Payment Due";
            lblUpItem4Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem4Badge
            // 
            lblUpItem4Badge.BackColor = Color.FromArgb(255, 225, 225);
            lblUpItem4Badge.Font = new Font("Poppins", 7.5F, FontStyle.Bold);
            lblUpItem4Badge.ForeColor = Color.FromArgb(220, 60, 60);
            lblUpItem4Badge.Location = new Point(606, 10);
            lblUpItem4Badge.Name = "lblUpItem4Badge";
            lblUpItem4Badge.Padding = new Padding(6, 0, 6, 0);
            lblUpItem4Badge.Size = new Size(88, 24);
            lblUpItem4Badge.TabIndex = 3;
            lblUpItem4Badge.Text = "Penalty";
            lblUpItem4Badge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUpItem5
            // 
            pnlUpItem5.BackColor = Color.FromArgb(250, 250, 252);
            pnlUpItem5.Controls.Add(pnlUpItem5Accent);
            pnlUpItem5.Controls.Add(lblUpItem5Date);
            pnlUpItem5.Controls.Add(lblUpItem5Title);
            pnlUpItem5.Controls.Add(lblUpItem5Badge);
            pnlUpItem5.Cursor = Cursors.Hand;
            pnlUpItem5.Location = new Point(0, 208);
            pnlUpItem5.Name = "pnlUpItem5";
            pnlUpItem5.Size = new Size(806, 44);
            pnlUpItem5.TabIndex = 4;
            pnlUpItem5.Click += UpcomingItem_Click;
            // 
            // pnlUpItem5Accent
            // 
            pnlUpItem5Accent.BackColor = Color.FromArgb(0, 172, 193);
            pnlUpItem5Accent.Location = new Point(0, 0);
            pnlUpItem5Accent.Name = "pnlUpItem5Accent";
            pnlUpItem5Accent.Size = new Size(4, 44);
            pnlUpItem5Accent.TabIndex = 0;
            // 
            // lblUpItem5Date
            // 
            lblUpItem5Date.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblUpItem5Date.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpItem5Date.Location = new Point(16, 0);
            lblUpItem5Date.Name = "lblUpItem5Date";
            lblUpItem5Date.Size = new Size(128, 44);
            lblUpItem5Date.TabIndex = 1;
            lblUpItem5Date.Text = "Jan 25, 2025";
            lblUpItem5Date.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem5Title
            // 
            lblUpItem5Title.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblUpItem5Title.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpItem5Title.Location = new Point(152, 0);
            lblUpItem5Title.Name = "lblUpItem5Title";
            lblUpItem5Title.Size = new Size(440, 44);
            lblUpItem5Title.TabIndex = 2;
            lblUpItem5Title.Text = "Checkpoint Submission";
            lblUpItem5Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUpItem5Badge
            // 
            lblUpItem5Badge.BackColor = Color.FromArgb(218, 244, 247);
            lblUpItem5Badge.Font = new Font("Poppins", 7.5F, FontStyle.Bold);
            lblUpItem5Badge.ForeColor = Color.FromArgb(0, 172, 193);
            lblUpItem5Badge.Location = new Point(606, 10);
            lblUpItem5Badge.Name = "lblUpItem5Badge";
            lblUpItem5Badge.Padding = new Padding(6, 0, 6, 0);
            lblUpItem5Badge.Size = new Size(88, 24);
            lblUpItem5Badge.TabIndex = 3;
            lblUpItem5Badge.Text = "Checkpoint";
            lblUpItem5Badge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNoUpcoming
            // 
            lblNoUpcoming.AutoSize = true;
            lblNoUpcoming.Font = new Font("Poppins", 9F);
            lblNoUpcoming.ForeColor = Color.FromArgb(170, 165, 158);
            lblNoUpcoming.Location = new Point(330, 190);
            lblNoUpcoming.Name = "lblNoUpcoming";
            lblNoUpcoming.Size = new Size(220, 26);
            lblNoUpcoming.TabIndex = 4;
            lblNoUpcoming.Text = "No upcoming events found.";
            lblNoUpcoming.Visible = false;
            // 
            // cardEventDetail
            // 
            cardEventDetail.BackColor = Color.White;
            cardEventDetail.Controls.Add(pnlEventDetailIconBox);
            cardEventDetail.Controls.Add(lblEventDetailTitle);
            cardEventDetail.Controls.Add(btnCloseEventDetail);
            cardEventDetail.Controls.Add(dividerEventDetail);
            cardEventDetail.Controls.Add(pnlEventDetailAccentBar);
            cardEventDetail.Controls.Add(lblEdTypeBadge);
            cardEventDetail.Controls.Add(lblEdEventNameLbl);
            cardEventDetail.Controls.Add(lblEdEventName);
            cardEventDetail.Controls.Add(lblEdDateLbl);
            cardEventDetail.Controls.Add(lblEdDate);
            cardEventDetail.Controls.Add(lblEdTimeLbl);
            cardEventDetail.Controls.Add(lblEdTime);
            cardEventDetail.Controls.Add(lblEdModuleLbl);
            cardEventDetail.Controls.Add(lblEdModule);
            cardEventDetail.Controls.Add(lblEdStatusLbl);
            cardEventDetail.Controls.Add(lblEdStatus);
            cardEventDetail.Controls.Add(lblEdLocationLbl);
            cardEventDetail.Controls.Add(lblEdLocation);
            cardEventDetail.Controls.Add(lblEdDescLbl);
            cardEventDetail.Controls.Add(txtEdDesc);
            cardEventDetail.Controls.Add(btnEdViewRecord);
            cardEventDetail.Location = new Point(30, 1308);
            cardEventDetail.Name = "cardEventDetail";
            cardEventDetail.Padding = new Padding(28, 24, 28, 28);
            cardEventDetail.Size = new Size(878, 474);
            cardEventDetail.TabIndex = 4;
            cardEventDetail.Visible = false;
            // 
            // pnlEventDetailIconBox
            // 
            pnlEventDetailIconBox.BackColor = Color.FromArgb(233, 239, 255);
            pnlEventDetailIconBox.Controls.Add(iconEventDetail);
            pnlEventDetailIconBox.Location = new Point(28, 24);
            pnlEventDetailIconBox.Name = "pnlEventDetailIconBox";
            pnlEventDetailIconBox.Size = new Size(44, 44);
            pnlEventDetailIconBox.TabIndex = 0;
            // 
            // iconEventDetail
            // 
            iconEventDetail.BackColor = Color.Transparent;
            iconEventDetail.ForeColor = Color.FromArgb(58, 99, 232);
            iconEventDetail.IconChar = IconChar.CircleInfo;
            iconEventDetail.IconColor = Color.FromArgb(58, 99, 232);
            iconEventDetail.IconFont = IconFont.Auto;
            iconEventDetail.IconSize = 22;
            iconEventDetail.Location = new Point(11, 11);
            iconEventDetail.Name = "iconEventDetail";
            iconEventDetail.Size = new Size(22, 22);
            iconEventDetail.TabIndex = 0;
            iconEventDetail.TabStop = false;
            // 
            // lblEventDetailTitle
            // 
            lblEventDetailTitle.AutoSize = true;
            lblEventDetailTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblEventDetailTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblEventDetailTitle.Location = new Point(82, 30);
            lblEventDetailTitle.Name = "lblEventDetailTitle";
            lblEventDetailTitle.Size = new Size(144, 34);
            lblEventDetailTitle.TabIndex = 1;
            lblEventDetailTitle.Text = "Event Details";
            // 
            // btnCloseEventDetail
            // 
            btnCloseEventDetail.BackColor = Color.White;
            btnCloseEventDetail.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnCloseEventDetail.FlatStyle = FlatStyle.Flat;
            btnCloseEventDetail.Font = new Font("Poppins", 7.8F, FontStyle.Bold);
            btnCloseEventDetail.ForeColor = Color.FromArgb(122, 122, 128);
            btnCloseEventDetail.IconChar = IconChar.Close;
            btnCloseEventDetail.IconColor = Color.FromArgb(122, 122, 128);
            btnCloseEventDetail.IconFont = IconFont.Auto;
            btnCloseEventDetail.IconSize = 14;
            btnCloseEventDetail.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseEventDetail.Location = new Point(722, 30);
            btnCloseEventDetail.Name = "btnCloseEventDetail";
            btnCloseEventDetail.Padding = new Padding(8, 0, 0, 0);
            btnCloseEventDetail.Size = new Size(128, 34);
            btnCloseEventDetail.TabIndex = 2;
            btnCloseEventDetail.Text = "Close Panel";
            btnCloseEventDetail.TextAlign = ContentAlignment.MiddleLeft;
            btnCloseEventDetail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseEventDetail.UseVisualStyleBackColor = false;
            btnCloseEventDetail.Click += btnCloseEventDetail_Click;
            // 
            // dividerEventDetail
            // 
            dividerEventDetail.BackColor = Color.FromArgb(236, 230, 222);
            dividerEventDetail.Location = new Point(28, 78);
            dividerEventDetail.Name = "dividerEventDetail";
            dividerEventDetail.Size = new Size(822, 1);
            dividerEventDetail.TabIndex = 3;
            // 
            // pnlEventDetailAccentBar
            // 
            pnlEventDetailAccentBar.BackColor = Color.FromArgb(58, 99, 232);
            pnlEventDetailAccentBar.Location = new Point(28, 90);
            pnlEventDetailAccentBar.Name = "pnlEventDetailAccentBar";
            pnlEventDetailAccentBar.Size = new Size(4, 356);
            pnlEventDetailAccentBar.TabIndex = 4;
            // 
            // lblEdTypeBadge
            // 
            lblEdTypeBadge.BackColor = Color.FromArgb(233, 239, 255);
            lblEdTypeBadge.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblEdTypeBadge.ForeColor = Color.FromArgb(58, 99, 232);
            lblEdTypeBadge.Location = new Point(44, 90);
            lblEdTypeBadge.Name = "lblEdTypeBadge";
            lblEdTypeBadge.Padding = new Padding(6, 0, 6, 0);
            lblEdTypeBadge.Size = new Size(90, 24);
            lblEdTypeBadge.TabIndex = 5;
            lblEdTypeBadge.Text = "Activity";
            lblEdTypeBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEdEventNameLbl
            // 
            lblEdEventNameLbl.AutoSize = true;
            lblEdEventNameLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdEventNameLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdEventNameLbl.Location = new Point(44, 122);
            lblEdEventNameLbl.Name = "lblEdEventNameLbl";
            lblEdEventNameLbl.Size = new Size(103, 26);
            lblEdEventNameLbl.TabIndex = 6;
            lblEdEventNameLbl.Text = "Event Name";
            // 
            // lblEdEventName
            // 
            lblEdEventName.BackColor = Color.FromArgb(250, 250, 252);
            lblEdEventName.BorderStyle = BorderStyle.FixedSingle;
            lblEdEventName.Font = new Font("Poppins", 9.5F, FontStyle.Bold);
            lblEdEventName.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdEventName.Location = new Point(44, 148);
            lblEdEventName.Name = "lblEdEventName";
            lblEdEventName.Padding = new Padding(8, 0, 0, 0);
            lblEdEventName.Size = new Size(806, 32);
            lblEdEventName.TabIndex = 7;
            lblEdEventName.Text = "—";
            lblEdEventName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdDateLbl
            // 
            lblEdDateLbl.AutoSize = true;
            lblEdDateLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdDateLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdDateLbl.Location = new Point(44, 196);
            lblEdDateLbl.Name = "lblEdDateLbl";
            lblEdDateLbl.Size = new Size(48, 26);
            lblEdDateLbl.TabIndex = 8;
            lblEdDateLbl.Text = "Date";
            // 
            // lblEdDate
            // 
            lblEdDate.BackColor = Color.FromArgb(250, 250, 252);
            lblEdDate.BorderStyle = BorderStyle.FixedSingle;
            lblEdDate.Font = new Font("Poppins", 9.5F);
            lblEdDate.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdDate.Location = new Point(44, 220);
            lblEdDate.Name = "lblEdDate";
            lblEdDate.Padding = new Padding(8, 0, 0, 0);
            lblEdDate.Size = new Size(180, 32);
            lblEdDate.TabIndex = 9;
            lblEdDate.Text = "—";
            lblEdDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdTimeLbl
            // 
            lblEdTimeLbl.AutoSize = true;
            lblEdTimeLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdTimeLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdTimeLbl.Location = new Point(240, 196);
            lblEdTimeLbl.Name = "lblEdTimeLbl";
            lblEdTimeLbl.Size = new Size(50, 26);
            lblEdTimeLbl.TabIndex = 10;
            lblEdTimeLbl.Text = "Time";
            // 
            // lblEdTime
            // 
            lblEdTime.BackColor = Color.FromArgb(250, 250, 252);
            lblEdTime.BorderStyle = BorderStyle.FixedSingle;
            lblEdTime.Font = new Font("Poppins", 9.5F);
            lblEdTime.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdTime.Location = new Point(240, 220);
            lblEdTime.Name = "lblEdTime";
            lblEdTime.Padding = new Padding(8, 0, 0, 0);
            lblEdTime.Size = new Size(148, 32);
            lblEdTime.TabIndex = 11;
            lblEdTime.Text = "—";
            lblEdTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdModuleLbl
            // 
            lblEdModuleLbl.AutoSize = true;
            lblEdModuleLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdModuleLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdModuleLbl.Location = new Point(404, 196);
            lblEdModuleLbl.Name = "lblEdModuleLbl";
            lblEdModuleLbl.Size = new Size(69, 26);
            lblEdModuleLbl.TabIndex = 12;
            lblEdModuleLbl.Text = "Module";
            // 
            // lblEdModule
            // 
            lblEdModule.BackColor = Color.FromArgb(250, 250, 252);
            lblEdModule.BorderStyle = BorderStyle.FixedSingle;
            lblEdModule.Font = new Font("Poppins", 9.5F);
            lblEdModule.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdModule.Location = new Point(404, 220);
            lblEdModule.Name = "lblEdModule";
            lblEdModule.Padding = new Padding(8, 0, 0, 0);
            lblEdModule.Size = new Size(148, 32);
            lblEdModule.TabIndex = 13;
            lblEdModule.Text = "—";
            lblEdModule.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdStatusLbl
            // 
            lblEdStatusLbl.AutoSize = true;
            lblEdStatusLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdStatusLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdStatusLbl.Location = new Point(568, 196);
            lblEdStatusLbl.Name = "lblEdStatusLbl";
            lblEdStatusLbl.Size = new Size(61, 26);
            lblEdStatusLbl.TabIndex = 14;
            lblEdStatusLbl.Text = "Status";
            // 
            // lblEdStatus
            // 
            lblEdStatus.BackColor = Color.FromArgb(250, 250, 252);
            lblEdStatus.BorderStyle = BorderStyle.FixedSingle;
            lblEdStatus.Font = new Font("Poppins", 9.5F);
            lblEdStatus.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdStatus.Location = new Point(568, 220);
            lblEdStatus.Name = "lblEdStatus";
            lblEdStatus.Padding = new Padding(8, 0, 0, 0);
            lblEdStatus.Size = new Size(148, 32);
            lblEdStatus.TabIndex = 15;
            lblEdStatus.Text = "—";
            lblEdStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdLocationLbl
            // 
            lblEdLocationLbl.AutoSize = true;
            lblEdLocationLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdLocationLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdLocationLbl.Location = new Point(44, 268);
            lblEdLocationLbl.Name = "lblEdLocationLbl";
            lblEdLocationLbl.Size = new Size(140, 26);
            lblEdLocationLbl.TabIndex = 16;
            lblEdLocationLbl.Text = "Location / Venue";
            // 
            // lblEdLocation
            // 
            lblEdLocation.BackColor = Color.FromArgb(250, 250, 252);
            lblEdLocation.BorderStyle = BorderStyle.FixedSingle;
            lblEdLocation.Font = new Font("Poppins", 9.5F);
            lblEdLocation.ForeColor = Color.FromArgb(20, 20, 20);
            lblEdLocation.Location = new Point(44, 292);
            lblEdLocation.Name = "lblEdLocation";
            lblEdLocation.Padding = new Padding(8, 0, 0, 0);
            lblEdLocation.Size = new Size(806, 32);
            lblEdLocation.TabIndex = 17;
            lblEdLocation.Text = "—";
            lblEdLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEdDescLbl
            // 
            lblEdDescLbl.AutoSize = true;
            lblEdDescLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblEdDescLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblEdDescLbl.Location = new Point(44, 340);
            lblEdDescLbl.Name = "lblEdDescLbl";
            lblEdDescLbl.Size = new Size(156, 26);
            lblEdDescLbl.TabIndex = 18;
            lblEdDescLbl.Text = "Description / Notes";
            // 
            // txtEdDesc
            // 
            txtEdDesc.BackColor = Color.FromArgb(250, 250, 252);
            txtEdDesc.BorderStyle = BorderStyle.FixedSingle;
            txtEdDesc.Font = new Font("Poppins", 9F);
            txtEdDesc.ForeColor = Color.FromArgb(52, 52, 58);
            txtEdDesc.Location = new Point(44, 366);
            txtEdDesc.Multiline = true;
            txtEdDesc.Name = "txtEdDesc";
            txtEdDesc.ReadOnly = true;
            txtEdDesc.ScrollBars = ScrollBars.Vertical;
            txtEdDesc.Size = new Size(672, 80);
            txtEdDesc.TabIndex = 19;
            // 
            // btnEdViewRecord
            // 
            btnEdViewRecord.BackColor = Color.FromArgb(58, 99, 232);
            btnEdViewRecord.FlatAppearance.BorderSize = 0;
            btnEdViewRecord.FlatStyle = FlatStyle.Flat;
            btnEdViewRecord.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdViewRecord.ForeColor = Color.White;
            btnEdViewRecord.IconChar = IconChar.ArrowUpRightFromSquare;
            btnEdViewRecord.IconColor = Color.White;
            btnEdViewRecord.IconFont = IconFont.Auto;
            btnEdViewRecord.IconSize = 14;
            btnEdViewRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdViewRecord.Location = new Point(728, 390);
            btnEdViewRecord.Name = "btnEdViewRecord";
            btnEdViewRecord.Padding = new Padding(8, 0, 0, 0);
            btnEdViewRecord.Size = new Size(122, 34);
            btnEdViewRecord.TabIndex = 20;
            btnEdViewRecord.Text = "Open Record";
            btnEdViewRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnEdViewRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdViewRecord.UseVisualStyleBackColor = false;
            btnEdViewRecord.Click += btnEdViewRecord_Click;
            // 
            // CalendarView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "CalendarView";
            Size = new Size(955, 615);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            cardNavBar.ResumeLayout(false);
            cardNavBar.PerformLayout();
            pnlCalIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCalendar).EndInit();
            cardLegend.ResumeLayout(false);
            cardLegend.PerformLayout();
            cardCalendarGrid.ResumeLayout(false);
            pnlDayHeaders.ResumeLayout(false);
            cardUpcoming.ResumeLayout(false);
            cardUpcoming.PerformLayout();
            pnlUpcomingIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconUpcoming).EndInit();
            pnlUpcomingList.ResumeLayout(false);
            pnlUpItem1.ResumeLayout(false);
            pnlUpItem2.ResumeLayout(false);
            pnlUpItem3.ResumeLayout(false);
            pnlUpItem4.ResumeLayout(false);
            pnlUpItem5.ResumeLayout(false);
            cardEventDetail.ResumeLayout(false);
            cardEventDetail.PerformLayout();
            pnlEventDetailIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconEventDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel outerScrollPanel;
        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Panel cardNavBar;
        private System.Windows.Forms.Panel pnlCalIconBox;
        private FontAwesome.Sharp.IconPictureBox iconCalendar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblMonthYear;
        private FontAwesome.Sharp.IconButton btnPrevMonth;
        private FontAwesome.Sharp.IconButton btnNextMonth;
        private FontAwesome.Sharp.IconButton btnToday;
        private System.Windows.Forms.Panel dividerNav;
        private FontAwesome.Sharp.IconButton btnViewMonth;
        private FontAwesome.Sharp.IconButton btnViewWeek;
        private FontAwesome.Sharp.IconButton btnViewList;
        private System.Windows.Forms.Panel cardLegend;
        private System.Windows.Forms.Panel pnlLegendActivity;
        private System.Windows.Forms.Label lblLegendActivity;
        private System.Windows.Forms.Panel pnlLegendAttendance;
        private System.Windows.Forms.Label lblLegendAttendance;
        private System.Windows.Forms.Panel pnlLegendMembership;
        private System.Windows.Forms.Label lblLegendMembership;
        private System.Windows.Forms.Panel pnlLegendPenalty;
        private System.Windows.Forms.Label lblLegendPenalty;
        private System.Windows.Forms.Panel pnlLegendClearance;
        private System.Windows.Forms.Label lblLegendClearance;
        private System.Windows.Forms.Panel pnlLegendCheckpoint;
        private System.Windows.Forms.Label lblLegendCheckpoint;
        private System.Windows.Forms.Panel cardCalendarGrid;
        private System.Windows.Forms.Panel pnlDayHeaders;
        private System.Windows.Forms.Label lblDaySun;
        private System.Windows.Forms.Label lblDayMon;
        private System.Windows.Forms.Label lblDayTue;
        private System.Windows.Forms.Label lblDayWed;
        private System.Windows.Forms.Label lblDayThu;
        private System.Windows.Forms.Label lblDayFri;
        private System.Windows.Forms.Label lblDaySat;
        private System.Windows.Forms.Panel dividerDayHeader;
        private System.Windows.Forms.Panel pnlCalendarCells;
        private System.Windows.Forms.Panel cardUpcoming;
        private System.Windows.Forms.Panel pnlUpcomingIconBox;
        private FontAwesome.Sharp.IconPictureBox iconUpcoming;
        private System.Windows.Forms.Label lblUpcomingTitle;
        private System.Windows.Forms.Panel dividerUpcoming;
        private System.Windows.Forms.Panel pnlUpcomingList;
        private System.Windows.Forms.Label lblNoUpcoming;
        private System.Windows.Forms.Panel pnlUpItem1;
        private System.Windows.Forms.Panel pnlUpItem1Accent;
        private System.Windows.Forms.Label lblUpItem1Date;
        private System.Windows.Forms.Label lblUpItem1Title;
        private System.Windows.Forms.Label lblUpItem1Badge;
        private System.Windows.Forms.Panel pnlUpItem2;
        private System.Windows.Forms.Panel pnlUpItem2Accent;
        private System.Windows.Forms.Label lblUpItem2Date;
        private System.Windows.Forms.Label lblUpItem2Title;
        private System.Windows.Forms.Label lblUpItem2Badge;
        private System.Windows.Forms.Panel pnlUpItem3;
        private System.Windows.Forms.Panel pnlUpItem3Accent;
        private System.Windows.Forms.Label lblUpItem3Date;
        private System.Windows.Forms.Label lblUpItem3Title;
        private System.Windows.Forms.Label lblUpItem3Badge;
        private System.Windows.Forms.Panel pnlUpItem4;
        private System.Windows.Forms.Panel pnlUpItem4Accent;
        private System.Windows.Forms.Label lblUpItem4Date;
        private System.Windows.Forms.Label lblUpItem4Title;
        private System.Windows.Forms.Label lblUpItem4Badge;
        private System.Windows.Forms.Panel pnlUpItem5;
        private System.Windows.Forms.Panel pnlUpItem5Accent;
        private System.Windows.Forms.Label lblUpItem5Date;
        private System.Windows.Forms.Label lblUpItem5Title;
        private System.Windows.Forms.Label lblUpItem5Badge;
        private System.Windows.Forms.Panel cardEventDetail;
        private System.Windows.Forms.Panel pnlEventDetailIconBox;
        private FontAwesome.Sharp.IconPictureBox iconEventDetail;
        private System.Windows.Forms.Label lblEventDetailTitle;
        private FontAwesome.Sharp.IconButton btnCloseEventDetail;
        private System.Windows.Forms.Panel dividerEventDetail;
        private System.Windows.Forms.Panel pnlEventDetailAccentBar;
        private System.Windows.Forms.Label lblEdTypeBadge;
        private System.Windows.Forms.Label lblEdEventNameLbl;
        private System.Windows.Forms.Label lblEdEventName;
        private System.Windows.Forms.Label lblEdDateLbl;
        private System.Windows.Forms.Label lblEdDate;
        private System.Windows.Forms.Label lblEdTimeLbl;
        private System.Windows.Forms.Label lblEdTime;
        private System.Windows.Forms.Label lblEdModuleLbl;
        private System.Windows.Forms.Label lblEdModule;
        private System.Windows.Forms.Label lblEdStatusLbl;
        private System.Windows.Forms.Label lblEdStatus;
        private System.Windows.Forms.Label lblEdLocationLbl;
        private System.Windows.Forms.Label lblEdLocation;
        private System.Windows.Forms.Label lblEdDescLbl;
        private System.Windows.Forms.TextBox txtEdDesc;
        private FontAwesome.Sharp.IconButton btnEdViewRecord;
    }
}
