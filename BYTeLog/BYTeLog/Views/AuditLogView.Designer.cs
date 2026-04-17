using FontAwesome.Sharp;

namespace BYTeLog.Views
{
    partial class AuditLogView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            outerScrollPanel = new Panel();
            innerContentPanel = new Panel();
            cardStats = new Panel();
            statCardTotal = new Panel();
            lblStatTotalLabel = new Label();
            pnlStatTotalIcon = new Panel();
            iconStatTotal = new IconPictureBox();
            lblStatTotalCount = new Label();
            statCardToday = new Panel();
            lblStatTodayLabel = new Label();
            pnlStatTodayIcon = new Panel();
            iconStatToday = new IconPictureBox();
            lblStatTodayCount = new Label();
            statCardUsers = new Panel();
            lblStatUsersLabel = new Label();
            pnlStatUsersIcon = new Panel();
            iconStatUsers = new IconPictureBox();
            lblStatUsersCount = new Label();
            statCardWarnings = new Panel();
            lblStatWarningsLabel = new Label();
            pnlStatWarningsIcon = new Panel();
            iconStatWarnings = new IconPictureBox();
            lblStatWarningsCount = new Label();
            cardFilter = new Panel();
            btnResetFilter = new IconButton();
            btnApplyFilter = new IconButton();
            pnlFilterIconBox = new Panel();
            iconFilter = new IconPictureBox();
            lblFilterTitle = new Label();
            dividerFilter = new Panel();
            pnlSearchBox = new Panel();
            iconSearch = new IconPictureBox();
            txtSearch = new TextBox();
            lblDateFrom = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateTo = new DateTimePicker();
            lblModule = new Label();
            cmbModule = new ComboBox();
            lblActionType = new Label();
            cmbActionType = new ComboBox();
            lblFilterUser = new Label();
            cmbFilterUser = new ComboBox();
            cardLogTable = new Panel();
            pnlLogIconBox = new Panel();
            iconLog = new IconPictureBox();
            lblLogTitle = new Label();
            dividerLog = new Panel();
            lblResultCount = new Label();
            btnExportCsv = new IconButton();
            btnExportPdf = new IconButton();
            dgvAuditLog = new DataGridView();
            colLogId = new DataGridViewTextBoxColumn();
            colTimestamp = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colActionType = new DataGridViewTextBoxColumn();
            colModule = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            cardDetail = new Panel();
            pnlDetailIconBox = new Panel();
            iconDetail = new IconPictureBox();
            lblDetailTitle = new Label();
            btnCloseDetail = new IconButton();
            dividerDetail = new Panel();
            lblDetailTimestampLbl = new Label();
            lblDetailTimestamp = new Label();
            lblDetailUserLbl = new Label();
            lblDetailUser = new Label();
            lblDetailActionLbl = new Label();
            lblDetailAction = new Label();
            lblDetailModuleLbl = new Label();
            lblDetailModule = new Label();
            lblDetailStatusLbl = new Label();
            lblDetailStatus = new Label();
            lblDetailDescLbl = new Label();
            txtDetailDesc = new TextBox();
            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            cardStats.SuspendLayout();
            statCardTotal.SuspendLayout();
            pnlStatTotalIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatTotal).BeginInit();
            statCardToday.SuspendLayout();
            pnlStatTodayIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatToday).BeginInit();
            statCardUsers.SuspendLayout();
            pnlStatUsersIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatUsers).BeginInit();
            statCardWarnings.SuspendLayout();
            pnlStatWarningsIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatWarnings).BeginInit();
            cardFilter.SuspendLayout();
            pnlFilterIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFilter).BeginInit();
            pnlSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).BeginInit();
            cardLogTable.SuspendLayout();
            pnlLogIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).BeginInit();
            cardDetail.SuspendLayout();
            pnlDetailIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDetail).BeginInit();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 1480);
            outerScrollPanel.BackColor = Color.FromArgb(244, 239, 231);
            outerScrollPanel.Controls.Add(innerContentPanel);
            outerScrollPanel.Dock = DockStyle.Fill;
            outerScrollPanel.Location = new Point(0, 0);
            outerScrollPanel.Name = "outerScrollPanel";
            outerScrollPanel.Size = new Size(955, 770);
            outerScrollPanel.TabIndex = 0;
            // 
            // innerContentPanel
            // 
            innerContentPanel.BackColor = Color.FromArgb(244, 239, 231);
            innerContentPanel.Controls.Add(cardStats);
            innerContentPanel.Controls.Add(cardFilter);
            innerContentPanel.Controls.Add(cardLogTable);
            innerContentPanel.Controls.Add(cardDetail);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Padding = new Padding(30);
            innerContentPanel.Size = new Size(934, 1480);
            innerContentPanel.TabIndex = 0;
            // 
            // cardStats
            // 
            cardStats.BackColor = Color.Transparent;
            cardStats.Controls.Add(statCardTotal);
            cardStats.Controls.Add(statCardToday);
            cardStats.Controls.Add(statCardUsers);
            cardStats.Controls.Add(statCardWarnings);
            cardStats.Location = new Point(30, 30);
            cardStats.Name = "cardStats";
            cardStats.Size = new Size(878, 88);
            cardStats.TabIndex = 0;
            // 
            // statCardTotal
            // 
            statCardTotal.BackColor = Color.White;
            statCardTotal.Controls.Add(lblStatTotalLabel);
            statCardTotal.Controls.Add(pnlStatTotalIcon);
            statCardTotal.Controls.Add(lblStatTotalCount);
            statCardTotal.Location = new Point(0, 0);
            statCardTotal.Name = "statCardTotal";
            statCardTotal.Size = new Size(208, 88);
            statCardTotal.TabIndex = 0;
            // 
            // lblStatTotalLabel
            // 
            lblStatTotalLabel.AutoSize = true;
            lblStatTotalLabel.Font = new Font("Poppins", 8F);
            lblStatTotalLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatTotalLabel.Location = new Point(71, 50);
            lblStatTotalLabel.Name = "lblStatTotalLabel";
            lblStatTotalLabel.Size = new Size(81, 25);
            lblStatTotalLabel.TabIndex = 2;
            lblStatTotalLabel.Text = "Total Logs";
            // 
            // pnlStatTotalIcon
            // 
            pnlStatTotalIcon.BackColor = Color.FromArgb(233, 239, 255);
            pnlStatTotalIcon.Controls.Add(iconStatTotal);
            pnlStatTotalIcon.Location = new Point(18, 22);
            pnlStatTotalIcon.Name = "pnlStatTotalIcon";
            pnlStatTotalIcon.Size = new Size(44, 44);
            pnlStatTotalIcon.TabIndex = 0;
            // 
            // iconStatTotal
            // 
            iconStatTotal.BackColor = Color.Transparent;
            iconStatTotal.ForeColor = Color.FromArgb(58, 99, 232);
            iconStatTotal.IconChar = IconChar.ClipboardList;
            iconStatTotal.IconColor = Color.FromArgb(58, 99, 232);
            iconStatTotal.IconFont = IconFont.Auto;
            iconStatTotal.IconSize = 22;
            iconStatTotal.Location = new Point(11, 11);
            iconStatTotal.Name = "iconStatTotal";
            iconStatTotal.Size = new Size(22, 22);
            iconStatTotal.TabIndex = 0;
            iconStatTotal.TabStop = false;
            // 
            // lblStatTotalCount
            // 
            lblStatTotalCount.AutoSize = true;
            lblStatTotalCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatTotalCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatTotalCount.Location = new Point(70, 14);
            lblStatTotalCount.Name = "lblStatTotalCount";
            lblStatTotalCount.Size = new Size(35, 44);
            lblStatTotalCount.TabIndex = 1;
            lblStatTotalCount.Text = "0";
            // 
            // statCardToday
            // 
            statCardToday.BackColor = Color.White;
            statCardToday.Controls.Add(lblStatTodayLabel);
            statCardToday.Controls.Add(pnlStatTodayIcon);
            statCardToday.Controls.Add(lblStatTodayCount);
            statCardToday.Location = new Point(224, 0);
            statCardToday.Name = "statCardToday";
            statCardToday.Size = new Size(208, 88);
            statCardToday.TabIndex = 1;
            // 
            // lblStatTodayLabel
            // 
            lblStatTodayLabel.AutoSize = true;
            lblStatTodayLabel.Font = new Font("Poppins", 8F);
            lblStatTodayLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatTodayLabel.Location = new Point(71, 50);
            lblStatTodayLabel.Name = "lblStatTodayLabel";
            lblStatTodayLabel.Size = new Size(119, 25);
            lblStatTodayLabel.TabIndex = 2;
            lblStatTodayLabel.Text = "Today's Actions";
            // 
            // pnlStatTodayIcon
            // 
            pnlStatTodayIcon.BackColor = Color.FromArgb(230, 255, 242);
            pnlStatTodayIcon.Controls.Add(iconStatToday);
            pnlStatTodayIcon.Location = new Point(18, 22);
            pnlStatTodayIcon.Name = "pnlStatTodayIcon";
            pnlStatTodayIcon.Size = new Size(44, 44);
            pnlStatTodayIcon.TabIndex = 0;
            // 
            // iconStatToday
            // 
            iconStatToday.BackColor = Color.Transparent;
            iconStatToday.ForeColor = Color.FromArgb(16, 163, 92);
            iconStatToday.IconChar = IconChar.CalendarDay;
            iconStatToday.IconColor = Color.FromArgb(16, 163, 92);
            iconStatToday.IconFont = IconFont.Auto;
            iconStatToday.IconSize = 22;
            iconStatToday.Location = new Point(11, 11);
            iconStatToday.Name = "iconStatToday";
            iconStatToday.Size = new Size(22, 22);
            iconStatToday.TabIndex = 0;
            iconStatToday.TabStop = false;
            // 
            // lblStatTodayCount
            // 
            lblStatTodayCount.AutoSize = true;
            lblStatTodayCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatTodayCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatTodayCount.Location = new Point(70, 14);
            lblStatTodayCount.Name = "lblStatTodayCount";
            lblStatTodayCount.Size = new Size(35, 44);
            lblStatTodayCount.TabIndex = 1;
            lblStatTodayCount.Text = "0";
            // 
            // statCardUsers
            // 
            statCardUsers.BackColor = Color.White;
            statCardUsers.Controls.Add(lblStatUsersLabel);
            statCardUsers.Controls.Add(pnlStatUsersIcon);
            statCardUsers.Controls.Add(lblStatUsersCount);
            statCardUsers.Location = new Point(448, 0);
            statCardUsers.Name = "statCardUsers";
            statCardUsers.Size = new Size(208, 88);
            statCardUsers.TabIndex = 2;
            // 
            // lblStatUsersLabel
            // 
            lblStatUsersLabel.AutoSize = true;
            lblStatUsersLabel.Font = new Font("Poppins", 8F);
            lblStatUsersLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatUsersLabel.Location = new Point(71, 50);
            lblStatUsersLabel.Name = "lblStatUsersLabel";
            lblStatUsersLabel.Size = new Size(96, 25);
            lblStatUsersLabel.TabIndex = 2;
            lblStatUsersLabel.Text = "Active Users";
            // 
            // pnlStatUsersIcon
            // 
            pnlStatUsersIcon.BackColor = Color.FromArgb(243, 230, 255);
            pnlStatUsersIcon.Controls.Add(iconStatUsers);
            pnlStatUsersIcon.Location = new Point(18, 22);
            pnlStatUsersIcon.Name = "pnlStatUsersIcon";
            pnlStatUsersIcon.Size = new Size(44, 44);
            pnlStatUsersIcon.TabIndex = 0;
            // 
            // iconStatUsers
            // 
            iconStatUsers.BackColor = Color.Transparent;
            iconStatUsers.ForeColor = Color.FromArgb(130, 60, 220);
            iconStatUsers.IconChar = IconChar.UserClock;
            iconStatUsers.IconColor = Color.FromArgb(130, 60, 220);
            iconStatUsers.IconFont = IconFont.Auto;
            iconStatUsers.IconSize = 22;
            iconStatUsers.Location = new Point(11, 11);
            iconStatUsers.Name = "iconStatUsers";
            iconStatUsers.Size = new Size(22, 22);
            iconStatUsers.TabIndex = 0;
            iconStatUsers.TabStop = false;
            // 
            // lblStatUsersCount
            // 
            lblStatUsersCount.AutoSize = true;
            lblStatUsersCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatUsersCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatUsersCount.Location = new Point(70, 14);
            lblStatUsersCount.Name = "lblStatUsersCount";
            lblStatUsersCount.Size = new Size(35, 44);
            lblStatUsersCount.TabIndex = 1;
            lblStatUsersCount.Text = "0";
            // 
            // statCardWarnings
            // 
            statCardWarnings.BackColor = Color.White;
            statCardWarnings.Controls.Add(lblStatWarningsLabel);
            statCardWarnings.Controls.Add(pnlStatWarningsIcon);
            statCardWarnings.Controls.Add(lblStatWarningsCount);
            statCardWarnings.Location = new Point(670, 0);
            statCardWarnings.Name = "statCardWarnings";
            statCardWarnings.Size = new Size(208, 88);
            statCardWarnings.TabIndex = 3;
            // 
            // lblStatWarningsLabel
            // 
            lblStatWarningsLabel.AutoSize = true;
            lblStatWarningsLabel.Font = new Font("Poppins", 8F);
            lblStatWarningsLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatWarningsLabel.Location = new Point(71, 50);
            lblStatWarningsLabel.Name = "lblStatWarningsLabel";
            lblStatWarningsLabel.Size = new Size(107, 25);
            lblStatWarningsLabel.TabIndex = 2;
            lblStatWarningsLabel.Text = "Failed Actions";
            // 
            // pnlStatWarningsIcon
            // 
            pnlStatWarningsIcon.BackColor = Color.FromArgb(255, 237, 237);
            pnlStatWarningsIcon.Controls.Add(iconStatWarnings);
            pnlStatWarningsIcon.Location = new Point(18, 22);
            pnlStatWarningsIcon.Name = "pnlStatWarningsIcon";
            pnlStatWarningsIcon.Size = new Size(44, 44);
            pnlStatWarningsIcon.TabIndex = 0;
            // 
            // iconStatWarnings
            // 
            iconStatWarnings.BackColor = Color.Transparent;
            iconStatWarnings.ForeColor = Color.FromArgb(220, 60, 60);
            iconStatWarnings.IconChar = IconChar.Warning;
            iconStatWarnings.IconColor = Color.FromArgb(220, 60, 60);
            iconStatWarnings.IconFont = IconFont.Auto;
            iconStatWarnings.IconSize = 22;
            iconStatWarnings.Location = new Point(11, 11);
            iconStatWarnings.Name = "iconStatWarnings";
            iconStatWarnings.Size = new Size(22, 22);
            iconStatWarnings.TabIndex = 0;
            iconStatWarnings.TabStop = false;
            // 
            // lblStatWarningsCount
            // 
            lblStatWarningsCount.AutoSize = true;
            lblStatWarningsCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatWarningsCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatWarningsCount.Location = new Point(70, 14);
            lblStatWarningsCount.Name = "lblStatWarningsCount";
            lblStatWarningsCount.Size = new Size(35, 44);
            lblStatWarningsCount.TabIndex = 1;
            lblStatWarningsCount.Text = "0";
            // 
            // cardFilter
            // 
            cardFilter.BackColor = Color.White;
            cardFilter.Controls.Add(btnResetFilter);
            cardFilter.Controls.Add(btnApplyFilter);
            cardFilter.Controls.Add(pnlFilterIconBox);
            cardFilter.Controls.Add(lblFilterTitle);
            cardFilter.Controls.Add(dividerFilter);
            cardFilter.Controls.Add(pnlSearchBox);
            cardFilter.Controls.Add(lblDateFrom);
            cardFilter.Controls.Add(dtpDateFrom);
            cardFilter.Controls.Add(lblDateTo);
            cardFilter.Controls.Add(dtpDateTo);
            cardFilter.Controls.Add(lblModule);
            cardFilter.Controls.Add(cmbModule);
            cardFilter.Controls.Add(lblActionType);
            cardFilter.Controls.Add(cmbActionType);
            cardFilter.Controls.Add(lblFilterUser);
            cardFilter.Controls.Add(cmbFilterUser);
            cardFilter.Location = new Point(30, 140);
            cardFilter.Name = "cardFilter";
            cardFilter.Padding = new Padding(28, 24, 28, 28);
            cardFilter.Size = new Size(878, 250);
            cardFilter.TabIndex = 1;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.White;
            btnResetFilter.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnResetFilter.ForeColor = Color.FromArgb(122, 122, 128);
            btnResetFilter.IconChar = IconChar.RotateBack;
            btnResetFilter.IconColor = Color.FromArgb(122, 122, 128);
            btnResetFilter.IconFont = IconFont.Auto;
            btnResetFilter.IconSize = 16;
            btnResetFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetFilter.Location = new Point(746, 209);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Padding = new Padding(10, 0, 0, 0);
            btnResetFilter.Size = new Size(104, 36);
            btnResetFilter.TabIndex = 15;
            btnResetFilter.Text = "Reset";
            btnResetFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnResetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(58, 99, 232);
            btnApplyFilter.FlatAppearance.BorderSize = 0;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.IconChar = IconChar.Search;
            btnApplyFilter.IconColor = Color.White;
            btnApplyFilter.IconFont = IconFont.Auto;
            btnApplyFilter.IconSize = 16;
            btnApplyFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplyFilter.Location = new Point(588, 210);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Padding = new Padding(10, 0, 0, 0);
            btnApplyFilter.Size = new Size(148, 36);
            btnApplyFilter.TabIndex = 14;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnApplyFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // pnlFilterIconBox
            // 
            pnlFilterIconBox.BackColor = Color.FromArgb(233, 239, 255);
            pnlFilterIconBox.Controls.Add(iconFilter);
            pnlFilterIconBox.Location = new Point(28, 24);
            pnlFilterIconBox.Name = "pnlFilterIconBox";
            pnlFilterIconBox.Size = new Size(44, 44);
            pnlFilterIconBox.TabIndex = 0;
            // 
            // iconFilter
            // 
            iconFilter.BackColor = Color.Transparent;
            iconFilter.ForeColor = Color.FromArgb(58, 99, 232);
            iconFilter.IconChar = IconChar.Filter;
            iconFilter.IconColor = Color.FromArgb(58, 99, 232);
            iconFilter.IconFont = IconFont.Auto;
            iconFilter.IconSize = 22;
            iconFilter.Location = new Point(11, 11);
            iconFilter.Name = "iconFilter";
            iconFilter.Size = new Size(22, 22);
            iconFilter.TabIndex = 0;
            iconFilter.TabStop = false;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblFilterTitle.Location = new Point(82, 30);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(153, 34);
            lblFilterTitle.TabIndex = 1;
            lblFilterTitle.Text = "Search & Filters";
            // 
            // dividerFilter
            // 
            dividerFilter.BackColor = Color.FromArgb(236, 230, 222);
            dividerFilter.Location = new Point(28, 78);
            dividerFilter.Name = "dividerFilter";
            dividerFilter.Size = new Size(822, 1);
            dividerFilter.TabIndex = 2;
            // 
            // pnlSearchBox
            // 
            pnlSearchBox.BackColor = Color.FromArgb(250, 250, 252);
            pnlSearchBox.BorderStyle = BorderStyle.FixedSingle;
            pnlSearchBox.Controls.Add(iconSearch);
            pnlSearchBox.Controls.Add(txtSearch);
            pnlSearchBox.Location = new Point(28, 90);
            pnlSearchBox.Name = "pnlSearchBox";
            pnlSearchBox.Size = new Size(822, 34);
            pnlSearchBox.TabIndex = 3;
            // 
            // iconSearch
            // 
            iconSearch.BackColor = Color.Transparent;
            iconSearch.ForeColor = Color.FromArgb(122, 122, 128);
            iconSearch.IconChar = IconChar.Search;
            iconSearch.IconColor = Color.FromArgb(122, 122, 128);
            iconSearch.IconFont = IconFont.Auto;
            iconSearch.IconSize = 16;
            iconSearch.Location = new Point(8, 7);
            iconSearch.Name = "iconSearch";
            iconSearch.Size = new Size(16, 16);
            iconSearch.TabIndex = 0;
            iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(250, 250, 252);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Poppins", 9F);
            txtSearch.ForeColor = Color.FromArgb(52, 52, 58);
            txtSearch.Location = new Point(32, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by keyword, user, description…";
            txtSearch.Size = new Size(780, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDateFrom.ForeColor = Color.FromArgb(52, 52, 58);
            lblDateFrom.Location = new Point(31, 138);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(91, 26);
            lblDateFrom.TabIndex = 4;
            lblDateFrom.Text = "Date From";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Font = new Font("Poppins", 9.5F);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(28, 164);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(176, 31);
            dtpDateFrom.TabIndex = 5;
            dtpDateFrom.ValueChanged += dtpDateFrom_ValueChanged;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.FromArgb(52, 52, 58);
            lblDateTo.Location = new Point(218, 138);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(70, 26);
            lblDateTo.TabIndex = 6;
            lblDateTo.Text = "Date To";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Font = new Font("Poppins", 9.5F);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(214, 164);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(176, 31);
            dtpDateTo.TabIndex = 7;
            dtpDateTo.ValueChanged += dtpDateTo_ValueChanged;
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblModule.ForeColor = Color.FromArgb(52, 52, 58);
            lblModule.Location = new Point(405, 138);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(69, 26);
            lblModule.TabIndex = 8;
            lblModule.Text = "Module";
            // 
            // cmbModule
            // 
            cmbModule.BackColor = Color.FromArgb(250, 250, 252);
            cmbModule.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModule.FlatStyle = FlatStyle.Flat;
            cmbModule.Font = new Font("Poppins", 9.5F);
            cmbModule.ForeColor = Color.FromArgb(20, 20, 20);
            cmbModule.Items.AddRange(new object[] { "(All Modules)", "Student", "Membership", "Membership Payment", "Penalty", "Penalty Payment", "Attendance", "Activity", "Checkpoint", "Clearance", "Officer", "Committee", "Archive", "User & Roles", "Settings" });
            cmbModule.Location = new Point(400, 164);
            cmbModule.Name = "cmbModule";
            cmbModule.Size = new Size(200, 36);
            cmbModule.TabIndex = 9;
            cmbModule.SelectedIndexChanged += cmbModule_SelectedIndexChanged;
            // 
            // lblActionType
            // 
            lblActionType.AutoSize = true;
            lblActionType.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblActionType.ForeColor = Color.FromArgb(52, 52, 58);
            lblActionType.Location = new Point(617, 138);
            lblActionType.Name = "lblActionType";
            lblActionType.Size = new Size(102, 26);
            lblActionType.TabIndex = 10;
            lblActionType.Text = "Action Type";
            // 
            // cmbActionType
            // 
            cmbActionType.BackColor = Color.FromArgb(250, 250, 252);
            cmbActionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActionType.FlatStyle = FlatStyle.Flat;
            cmbActionType.Font = new Font("Poppins", 9.5F);
            cmbActionType.ForeColor = Color.FromArgb(20, 20, 20);
            cmbActionType.Items.AddRange(new object[] { "(All Actions)", "Created", "Updated", "Deleted", "Archived", "Restored", "Login", "Logout", "Payment Recorded", "Penalty Applied", "Clearance Issued", "Attendance Marked", "Settings Changed" });
            cmbActionType.Location = new Point(612, 164);
            cmbActionType.Name = "cmbActionType";
            cmbActionType.Size = new Size(238, 36);
            cmbActionType.TabIndex = 11;
            cmbActionType.SelectedIndexChanged += cmbActionType_SelectedIndexChanged;
            // 
            // lblFilterUser
            // 
            lblFilterUser.AutoSize = true;
            lblFilterUser.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblFilterUser.ForeColor = Color.FromArgb(52, 52, 58);
            lblFilterUser.Location = new Point(31, 200);
            lblFilterUser.Name = "lblFilterUser";
            lblFilterUser.Size = new Size(46, 26);
            lblFilterUser.TabIndex = 12;
            lblFilterUser.Text = "User";
            // 
            // cmbFilterUser
            // 
            cmbFilterUser.BackColor = Color.FromArgb(250, 250, 252);
            cmbFilterUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterUser.FlatStyle = FlatStyle.Flat;
            cmbFilterUser.Font = new Font("Poppins", 9.5F);
            cmbFilterUser.ForeColor = Color.FromArgb(20, 20, 20);
            cmbFilterUser.Items.AddRange(new object[] { "(All Users)" });
            cmbFilterUser.Location = new Point(28, 164);
            cmbFilterUser.Name = "cmbFilterUser";
            cmbFilterUser.Size = new Size(176, 36);
            cmbFilterUser.TabIndex = 13;
            cmbFilterUser.Visible = false;
            // 
            // cardLogTable
            // 
            cardLogTable.BackColor = Color.White;
            cardLogTable.Controls.Add(pnlLogIconBox);
            cardLogTable.Controls.Add(lblLogTitle);
            cardLogTable.Controls.Add(dividerLog);
            cardLogTable.Controls.Add(lblResultCount);
            cardLogTable.Controls.Add(btnExportCsv);
            cardLogTable.Controls.Add(btnExportPdf);
            cardLogTable.Controls.Add(dgvAuditLog);
            cardLogTable.Location = new Point(30, 420);
            cardLogTable.Name = "cardLogTable";
            cardLogTable.Padding = new Padding(28, 24, 28, 28);
            cardLogTable.Size = new Size(878, 620);
            cardLogTable.TabIndex = 2;
            // 
            // pnlLogIconBox
            // 
            pnlLogIconBox.BackColor = Color.FromArgb(255, 243, 230);
            pnlLogIconBox.Controls.Add(iconLog);
            pnlLogIconBox.Location = new Point(28, 24);
            pnlLogIconBox.Name = "pnlLogIconBox";
            pnlLogIconBox.Size = new Size(44, 44);
            pnlLogIconBox.TabIndex = 0;
            // 
            // iconLog
            // 
            iconLog.BackColor = Color.Transparent;
            iconLog.ForeColor = Color.FromArgb(234, 140, 30);
            iconLog.IconChar = IconChar.Scroll;
            iconLog.IconColor = Color.FromArgb(234, 140, 30);
            iconLog.IconFont = IconFont.Auto;
            iconLog.IconSize = 22;
            iconLog.Location = new Point(11, 11);
            iconLog.Name = "iconLog";
            iconLog.Size = new Size(22, 22);
            iconLog.TabIndex = 0;
            iconLog.TabStop = false;
            // 
            // lblLogTitle
            // 
            lblLogTitle.AutoSize = true;
            lblLogTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblLogTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblLogTitle.Location = new Point(82, 30);
            lblLogTitle.Name = "lblLogTitle";
            lblLogTitle.Size = new Size(179, 34);
            lblLogTitle.TabIndex = 1;
            lblLogTitle.Text = "Audit Log Entries";
            // 
            // dividerLog
            // 
            dividerLog.BackColor = Color.FromArgb(236, 230, 222);
            dividerLog.Location = new Point(28, 78);
            dividerLog.Name = "dividerLog";
            dividerLog.Size = new Size(822, 1);
            dividerLog.TabIndex = 2;
            // 
            // lblResultCount
            // 
            lblResultCount.AutoSize = true;
            lblResultCount.Font = new Font("Poppins", 8.5F);
            lblResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblResultCount.Location = new Point(31, 90);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(152, 26);
            lblResultCount.TabIndex = 3;
            lblResultCount.Text = "Showing 0 records";
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.White;
            btnExportCsv.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 92);
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCsv.ForeColor = Color.FromArgb(16, 163, 92);
            btnExportCsv.IconChar = IconChar.FileCsv;
            btnExportCsv.IconColor = Color.FromArgb(16, 163, 92);
            btnExportCsv.IconFont = IconFont.Auto;
            btnExportCsv.IconSize = 16;
            btnExportCsv.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportCsv.Location = new Point(568, 82);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Padding = new Padding(8, 0, 0, 0);
            btnExportCsv.Size = new Size(128, 34);
            btnExportCsv.TabIndex = 4;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.TextAlign = ContentAlignment.MiddleLeft;
            btnExportCsv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.White;
            btnExportPdf.FlatAppearance.BorderColor = Color.FromArgb(220, 60, 60);
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPdf.ForeColor = Color.FromArgb(220, 60, 60);
            btnExportPdf.IconChar = IconChar.FilePdf;
            btnExportPdf.IconColor = Color.FromArgb(220, 60, 60);
            btnExportPdf.IconFont = IconFont.Auto;
            btnExportPdf.IconSize = 16;
            btnExportPdf.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.Location = new Point(706, 82);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Padding = new Padding(8, 0, 0, 0);
            btnExportPdf.Size = new Size(124, 34);
            btnExportPdf.TabIndex = 5;
            btnExportPdf.Text = "Export PDF";
            btnExportPdf.TextAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // dgvAuditLog
            // 
            dgvAuditLog.AllowUserToAddRows = false;
            dgvAuditLog.AllowUserToDeleteRows = false;
            dgvAuditLog.AllowUserToResizeRows = false;
            dgvAuditLog.BackgroundColor = Color.White;
            dgvAuditLog.BorderStyle = BorderStyle.None;
            dgvAuditLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(122, 122, 128);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuditLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditLog.ColumnHeadersHeight = 38;
            dgvAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAuditLog.Columns.AddRange(new DataGridViewColumn[] { colLogId, colTimestamp, colUser, colActionType, colModule, colDescription, colStatus, colView });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(52, 52, 58);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAuditLog.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAuditLog.EnableHeadersVisualStyles = false;
            dgvAuditLog.GridColor = Color.FromArgb(236, 230, 222);
            dgvAuditLog.Location = new Point(28, 124);
            dgvAuditLog.Name = "dgvAuditLog";
            dgvAuditLog.ReadOnly = true;
            dgvAuditLog.RowHeadersVisible = false;
            dgvAuditLog.RowHeadersWidth = 51;
            dgvAuditLog.RowTemplate.Height = 38;
            dgvAuditLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLog.Size = new Size(822, 464);
            dgvAuditLog.TabIndex = 6;
            // 
            // colLogId
            // 
            colLogId.HeaderText = "#";
            colLogId.MinimumWidth = 6;
            colLogId.Name = "colLogId";
            colLogId.ReadOnly = true;
            colLogId.Resizable = DataGridViewTriState.False;
            colLogId.Width = 46;
            // 
            // colTimestamp
            // 
            colTimestamp.HeaderText = "Timestamp";
            colTimestamp.MinimumWidth = 6;
            colTimestamp.Name = "colTimestamp";
            colTimestamp.ReadOnly = true;
            colTimestamp.Width = 148;
            // 
            // colUser
            // 
            colUser.HeaderText = "User";
            colUser.MinimumWidth = 6;
            colUser.Name = "colUser";
            colUser.ReadOnly = true;
            colUser.Width = 130;
            // 
            // colActionType
            // 
            colActionType.HeaderText = "Action";
            colActionType.MinimumWidth = 6;
            colActionType.Name = "colActionType";
            colActionType.ReadOnly = true;
            colActionType.Width = 132;
            // 
            // colModule
            // 
            colModule.HeaderText = "Module";
            colModule.MinimumWidth = 6;
            colModule.Name = "colModule";
            colModule.ReadOnly = true;
            colModule.Width = 118;
            // 
            // colDescription
            // 
            colDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescription.HeaderText = "Description";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 88;
            // 
            // colView
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle2.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle2;
            colView.HeaderText = "Details";
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Text = "View";
            colView.UseColumnTextForButtonValue = true;
            colView.Width = 72;
            // 
            // cardDetail
            // 
            cardDetail.BackColor = Color.White;
            cardDetail.Controls.Add(pnlDetailIconBox);
            cardDetail.Controls.Add(lblDetailTitle);
            cardDetail.Controls.Add(btnCloseDetail);
            cardDetail.Controls.Add(dividerDetail);
            cardDetail.Controls.Add(lblDetailTimestampLbl);
            cardDetail.Controls.Add(lblDetailTimestamp);
            cardDetail.Controls.Add(lblDetailUserLbl);
            cardDetail.Controls.Add(lblDetailUser);
            cardDetail.Controls.Add(lblDetailActionLbl);
            cardDetail.Controls.Add(lblDetailAction);
            cardDetail.Controls.Add(lblDetailModuleLbl);
            cardDetail.Controls.Add(lblDetailModule);
            cardDetail.Controls.Add(lblDetailStatusLbl);
            cardDetail.Controls.Add(lblDetailStatus);
            cardDetail.Controls.Add(lblDetailDescLbl);
            cardDetail.Controls.Add(txtDetailDesc);
            cardDetail.Location = new Point(30, 1062);
            cardDetail.Name = "cardDetail";
            cardDetail.Padding = new Padding(28, 24, 28, 28);
            cardDetail.Size = new Size(878, 410);
            cardDetail.TabIndex = 3;
            cardDetail.Visible = false;
            // 
            // pnlDetailIconBox
            // 
            pnlDetailIconBox.BackColor = Color.FromArgb(233, 239, 255);
            pnlDetailIconBox.Controls.Add(iconDetail);
            pnlDetailIconBox.Location = new Point(28, 24);
            pnlDetailIconBox.Name = "pnlDetailIconBox";
            pnlDetailIconBox.Size = new Size(44, 44);
            pnlDetailIconBox.TabIndex = 0;
            // 
            // iconDetail
            // 
            iconDetail.BackColor = Color.Transparent;
            iconDetail.ForeColor = Color.FromArgb(58, 99, 232);
            iconDetail.IconChar = IconChar.CircleInfo;
            iconDetail.IconColor = Color.FromArgb(58, 99, 232);
            iconDetail.IconFont = IconFont.Auto;
            iconDetail.IconSize = 22;
            iconDetail.Location = new Point(11, 11);
            iconDetail.Name = "iconDetail";
            iconDetail.Size = new Size(22, 22);
            iconDetail.TabIndex = 0;
            iconDetail.TabStop = false;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblDetailTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailTitle.Location = new Point(82, 30);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(178, 34);
            lblDetailTitle.TabIndex = 1;
            lblDetailTitle.Text = "Log Entry Details";
            // 
            // btnCloseDetail
            // 
            btnCloseDetail.BackColor = Color.White;
            btnCloseDetail.FlatAppearance.BorderColor = Color.FromArgb(200, 195, 188);
            btnCloseDetail.FlatStyle = FlatStyle.Flat;
            btnCloseDetail.Font = new Font("Poppins", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseDetail.ForeColor = Color.FromArgb(122, 122, 128);
            btnCloseDetail.IconChar = IconChar.Close;
            btnCloseDetail.IconColor = Color.FromArgb(122, 122, 128);
            btnCloseDetail.IconFont = IconFont.Auto;
            btnCloseDetail.IconSize = 16;
            btnCloseDetail.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseDetail.Location = new Point(722, 30);
            btnCloseDetail.Name = "btnCloseDetail";
            btnCloseDetail.Padding = new Padding(8, 0, 0, 0);
            btnCloseDetail.Size = new Size(128, 34);
            btnCloseDetail.TabIndex = 2;
            btnCloseDetail.Text = "Close Panel";
            btnCloseDetail.TextAlign = ContentAlignment.MiddleLeft;
            btnCloseDetail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCloseDetail.UseVisualStyleBackColor = false;
            // 
            // dividerDetail
            // 
            dividerDetail.BackColor = Color.FromArgb(236, 230, 222);
            dividerDetail.Location = new Point(28, 78);
            dividerDetail.Name = "dividerDetail";
            dividerDetail.Size = new Size(822, 1);
            dividerDetail.TabIndex = 3;
            // 
            // lblDetailTimestampLbl
            // 
            lblDetailTimestampLbl.AutoSize = true;
            lblDetailTimestampLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailTimestampLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailTimestampLbl.Location = new Point(31, 94);
            lblDetailTimestampLbl.Name = "lblDetailTimestampLbl";
            lblDetailTimestampLbl.Size = new Size(100, 26);
            lblDetailTimestampLbl.TabIndex = 4;
            lblDetailTimestampLbl.Text = "Timestamp";
            // 
            // lblDetailTimestamp
            // 
            lblDetailTimestamp.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailTimestamp.BorderStyle = BorderStyle.FixedSingle;
            lblDetailTimestamp.Font = new Font("Poppins", 9.5F);
            lblDetailTimestamp.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailTimestamp.Location = new Point(28, 122);
            lblDetailTimestamp.Name = "lblDetailTimestamp";
            lblDetailTimestamp.Padding = new Padding(8, 0, 0, 0);
            lblDetailTimestamp.Size = new Size(260, 32);
            lblDetailTimestamp.TabIndex = 5;
            lblDetailTimestamp.Text = "—";
            lblDetailTimestamp.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailTimestamp.Click += lblDetailTimestamp_Click;
            // 
            // lblDetailUserLbl
            // 
            lblDetailUserLbl.AutoSize = true;
            lblDetailUserLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailUserLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailUserLbl.Location = new Point(305, 94);
            lblDetailUserLbl.Name = "lblDetailUserLbl";
            lblDetailUserLbl.Size = new Size(46, 26);
            lblDetailUserLbl.TabIndex = 6;
            lblDetailUserLbl.Text = "User";
            // 
            // lblDetailUser
            // 
            lblDetailUser.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailUser.BorderStyle = BorderStyle.FixedSingle;
            lblDetailUser.Font = new Font("Poppins", 9.5F);
            lblDetailUser.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailUser.Location = new Point(302, 122);
            lblDetailUser.Name = "lblDetailUser";
            lblDetailUser.Padding = new Padding(8, 0, 0, 0);
            lblDetailUser.Size = new Size(260, 32);
            lblDetailUser.TabIndex = 7;
            lblDetailUser.Text = "—";
            lblDetailUser.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailUser.Click += lblDetailUser_Click;
            // 
            // lblDetailActionLbl
            // 
            lblDetailActionLbl.AutoSize = true;
            lblDetailActionLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailActionLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailActionLbl.Location = new Point(31, 170);
            lblDetailActionLbl.Name = "lblDetailActionLbl";
            lblDetailActionLbl.Size = new Size(62, 26);
            lblDetailActionLbl.TabIndex = 8;
            lblDetailActionLbl.Text = "Action";
            // 
            // lblDetailAction
            // 
            lblDetailAction.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailAction.BorderStyle = BorderStyle.FixedSingle;
            lblDetailAction.Font = new Font("Poppins", 9.5F);
            lblDetailAction.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailAction.Location = new Point(28, 198);
            lblDetailAction.Name = "lblDetailAction";
            lblDetailAction.Padding = new Padding(8, 0, 0, 0);
            lblDetailAction.Size = new Size(260, 32);
            lblDetailAction.TabIndex = 9;
            lblDetailAction.Text = "—";
            lblDetailAction.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailAction.Click += lblDetailAction_Click;
            // 
            // lblDetailModuleLbl
            // 
            lblDetailModuleLbl.AutoSize = true;
            lblDetailModuleLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailModuleLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailModuleLbl.Location = new Point(305, 170);
            lblDetailModuleLbl.Name = "lblDetailModuleLbl";
            lblDetailModuleLbl.Size = new Size(69, 26);
            lblDetailModuleLbl.TabIndex = 10;
            lblDetailModuleLbl.Text = "Module";
            // 
            // lblDetailModule
            // 
            lblDetailModule.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailModule.BorderStyle = BorderStyle.FixedSingle;
            lblDetailModule.Font = new Font("Poppins", 9.5F);
            lblDetailModule.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailModule.Location = new Point(302, 198);
            lblDetailModule.Name = "lblDetailModule";
            lblDetailModule.Padding = new Padding(8, 0, 0, 0);
            lblDetailModule.Size = new Size(260, 32);
            lblDetailModule.TabIndex = 11;
            lblDetailModule.Text = "—";
            lblDetailModule.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailModule.Click += lblDetailModule_Click;
            // 
            // lblDetailStatusLbl
            // 
            lblDetailStatusLbl.AutoSize = true;
            lblDetailStatusLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailStatusLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailStatusLbl.Location = new Point(580, 94);
            lblDetailStatusLbl.Name = "lblDetailStatusLbl";
            lblDetailStatusLbl.Size = new Size(61, 26);
            lblDetailStatusLbl.TabIndex = 12;
            lblDetailStatusLbl.Text = "Status";
            // 
            // lblDetailStatus
            // 
            lblDetailStatus.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailStatus.BorderStyle = BorderStyle.FixedSingle;
            lblDetailStatus.Font = new Font("Poppins", 9.5F);
            lblDetailStatus.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailStatus.Location = new Point(576, 122);
            lblDetailStatus.Name = "lblDetailStatus";
            lblDetailStatus.Padding = new Padding(8, 0, 0, 0);
            lblDetailStatus.Size = new Size(274, 32);
            lblDetailStatus.TabIndex = 13;
            lblDetailStatus.Text = "—";
            lblDetailStatus.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailStatus.Click += lblDetailStatus_Click;
            // 
            // lblDetailDescLbl
            // 
            lblDetailDescLbl.AutoSize = true;
            lblDetailDescLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailDescLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailDescLbl.Location = new Point(31, 248);
            lblDetailDescLbl.Name = "lblDetailDescLbl";
            lblDetailDescLbl.Size = new Size(185, 26);
            lblDetailDescLbl.TabIndex = 14;
            lblDetailDescLbl.Text = "Full Description / Notes";
            // 
            // txtDetailDesc
            // 
            txtDetailDesc.BackColor = Color.FromArgb(250, 250, 252);
            txtDetailDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDetailDesc.Font = new Font("Poppins", 9F);
            txtDetailDesc.ForeColor = Color.FromArgb(52, 52, 58);
            txtDetailDesc.Location = new Point(28, 276);
            txtDetailDesc.Multiline = true;
            txtDetailDesc.Name = "txtDetailDesc";
            txtDetailDesc.ReadOnly = true;
            txtDetailDesc.ScrollBars = ScrollBars.Vertical;
            txtDetailDesc.Size = new Size(822, 100);
            txtDetailDesc.TabIndex = 15;
            txtDetailDesc.Text = "Bruh";
            // 
            // AuditLogView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "AuditLogView";
            Size = new Size(955, 770);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            cardStats.ResumeLayout(false);
            statCardTotal.ResumeLayout(false);
            statCardTotal.PerformLayout();
            pnlStatTotalIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatTotal).EndInit();
            statCardToday.ResumeLayout(false);
            statCardToday.PerformLayout();
            pnlStatTodayIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatToday).EndInit();
            statCardUsers.ResumeLayout(false);
            statCardUsers.PerformLayout();
            pnlStatUsersIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatUsers).EndInit();
            statCardWarnings.ResumeLayout(false);
            statCardWarnings.PerformLayout();
            pnlStatWarningsIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatWarnings).EndInit();
            cardFilter.ResumeLayout(false);
            cardFilter.PerformLayout();
            pnlFilterIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconFilter).EndInit();
            pnlSearchBox.ResumeLayout(false);
            pnlSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).EndInit();
            cardLogTable.ResumeLayout(false);
            cardLogTable.PerformLayout();
            pnlLogIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).EndInit();
            cardDetail.ResumeLayout(false);
            cardDetail.PerformLayout();
            pnlDetailIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconDetail).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel outerScrollPanel;
        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Panel cardStats;
        private System.Windows.Forms.Panel statCardTotal;
        private System.Windows.Forms.Panel pnlStatTotalIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatTotal;
        private System.Windows.Forms.Label lblStatTotalCount;
        private System.Windows.Forms.Label lblStatTotalLabel;
        private System.Windows.Forms.Panel statCardToday;
        private System.Windows.Forms.Panel pnlStatTodayIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatToday;
        private System.Windows.Forms.Label lblStatTodayCount;
        private System.Windows.Forms.Label lblStatTodayLabel;
        private System.Windows.Forms.Panel statCardUsers;
        private System.Windows.Forms.Panel pnlStatUsersIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatUsers;
        private System.Windows.Forms.Label lblStatUsersCount;
        private System.Windows.Forms.Label lblStatUsersLabel;
        private System.Windows.Forms.Panel statCardWarnings;
        private System.Windows.Forms.Panel pnlStatWarningsIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatWarnings;
        private System.Windows.Forms.Label lblStatWarningsCount;
        private System.Windows.Forms.Label lblStatWarningsLabel;
        private System.Windows.Forms.Panel cardFilter;
        private System.Windows.Forms.Panel pnlFilterIconBox;
        private FontAwesome.Sharp.IconPictureBox iconFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Panel dividerFilter;
        private System.Windows.Forms.Panel pnlSearchBox;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label lblActionType;
        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.Label lblFilterUser;
        private System.Windows.Forms.ComboBox cmbFilterUser;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private FontAwesome.Sharp.IconButton btnResetFilter;
        private System.Windows.Forms.Panel cardLogTable;
        private System.Windows.Forms.Panel pnlLogIconBox;
        private FontAwesome.Sharp.IconPictureBox iconLog;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.Panel dividerLog;
        private System.Windows.Forms.Label lblResultCount;
        private FontAwesome.Sharp.IconButton btnExportCsv;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private System.Windows.Forms.DataGridView dgvAuditLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.Panel cardDetail;
        private System.Windows.Forms.Panel pnlDetailIconBox;
        private FontAwesome.Sharp.IconPictureBox iconDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private FontAwesome.Sharp.IconButton btnCloseDetail;
        private System.Windows.Forms.Panel dividerDetail;
        private System.Windows.Forms.Label lblDetailTimestampLbl;
        private System.Windows.Forms.Label lblDetailTimestamp;
        private System.Windows.Forms.Label lblDetailUserLbl;
        private System.Windows.Forms.Label lblDetailUser;
        private System.Windows.Forms.Label lblDetailActionLbl;
        private System.Windows.Forms.Label lblDetailAction;
        private System.Windows.Forms.Label lblDetailModuleLbl;
        private System.Windows.Forms.Label lblDetailModule;
        private System.Windows.Forms.Label lblDetailStatusLbl;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailDescLbl;
        private System.Windows.Forms.TextBox txtDetailDesc;
    }
}
