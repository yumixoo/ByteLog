using FontAwesome.Sharp;

namespace BYTeLog.Views
{
    partial class ArchiveView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            outerScrollPanel = new Panel();
            innerContentPanel = new Panel();
            cardStats = new Panel();
            statCardTotal = new Panel();
            lblStatTotalLabel = new Label();
            pnlStatTotalIcon = new Panel();
            iconStatTotal = new IconPictureBox();
            lblStatTotalCount = new Label();
            statCardMonth = new Panel();
            lblStatMonthLabel = new Label();
            pnlStatMonthIcon = new Panel();
            iconStatMonth = new IconPictureBox();
            lblStatMonthCount = new Label();
            statCardRestored = new Panel();
            lblStatRestoredLabel = new Label();
            pnlStatRestoredIcon = new Panel();
            iconStatRestored = new IconPictureBox();
            lblStatRestoredCount = new Label();
            statCardPending = new Panel();
            lblStatPendingLabel = new Label();
            pnlStatPendingIcon = new Panel();
            iconStatPending = new IconPictureBox();
            lblStatPendingCount = new Label();
            cardFilter = new Panel();
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
            lblArchiveType = new Label();
            cmbArchiveType = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblArchivedBy = new Label();
            cmbArchivedBy = new ComboBox();
            btnApplyFilter = new IconButton();
            btnResetFilter = new IconButton();
            cardArchiveTable = new Panel();
            pnlTableIconBox = new Panel();
            iconTable = new IconPictureBox();
            lblTableTitle = new Label();
            dividerTable = new Panel();
            lblResultCount = new Label();
            btnExportCsv = new IconButton();
            btnExportPdf = new IconButton();
            dgvArchive = new DataGridView();
            colArchiveId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colArchiveType = new DataGridViewTextBoxColumn();
            colArchivedDate = new DataGridViewTextBoxColumn();
            colArchivedBy = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colRestore = new DataGridViewButtonColumn();
            colView = new DataGridViewButtonColumn();
            cardDetail = new Panel();
            pnlDetailIconBox = new Panel();
            iconDetail = new IconPictureBox();
            lblDetailTitle = new Label();
            btnCloseDetail = new IconButton();
            dividerDetail = new Panel();
            lblDetailIdLbl = new Label();
            lblDetailId = new Label();
            lblDetailNameLbl = new Label();
            lblDetailName = new Label();
            lblDetailTypeLbl = new Label();
            lblDetailType = new Label();
            lblDetailStatusLbl = new Label();
            lblDetailStatus = new Label();
            lblDetailArchivedDateLbl = new Label();
            lblDetailArchivedDate = new Label();
            lblDetailArchivedByLbl = new Label();
            lblDetailArchivedBy = new Label();
            lblDetailReasonLbl = new Label();
            txtDetailReason = new TextBox();
            dividerDetailActions = new Panel();
            btnRestoreRecord = new IconButton();
            btnDeletePermanent = new IconButton();
            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            cardStats.SuspendLayout();
            statCardTotal.SuspendLayout();
            pnlStatTotalIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatTotal).BeginInit();
            statCardMonth.SuspendLayout();
            pnlStatMonthIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatMonth).BeginInit();
            statCardRestored.SuspendLayout();
            pnlStatRestoredIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatRestored).BeginInit();
            statCardPending.SuspendLayout();
            pnlStatPendingIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatPending).BeginInit();
            cardFilter.SuspendLayout();
            pnlFilterIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFilter).BeginInit();
            pnlSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).BeginInit();
            cardArchiveTable.SuspendLayout();
            pnlTableIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).BeginInit();
            cardDetail.SuspendLayout();
            pnlDetailIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDetail).BeginInit();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 1050);
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
            innerContentPanel.Controls.Add(cardStats);
            innerContentPanel.Controls.Add(cardFilter);
            innerContentPanel.Controls.Add(cardArchiveTable);
            innerContentPanel.Controls.Add(cardDetail);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Padding = new Padding(30);
            innerContentPanel.Size = new Size(934, 1500);
            innerContentPanel.TabIndex = 0;
            // 
            // cardStats
            // 
            cardStats.BackColor = Color.Transparent;
            cardStats.Controls.Add(statCardTotal);
            cardStats.Controls.Add(statCardMonth);
            cardStats.Controls.Add(statCardRestored);
            cardStats.Controls.Add(statCardPending);
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
            lblStatTotalLabel.Size = new Size(111, 25);
            lblStatTotalLabel.TabIndex = 2;
            lblStatTotalLabel.Text = "Total Archived";
            // 
            // pnlStatTotalIcon
            // 
            pnlStatTotalIcon.BackColor = Color.FromArgb(255, 243, 230);
            pnlStatTotalIcon.Controls.Add(iconStatTotal);
            pnlStatTotalIcon.Location = new Point(18, 22);
            pnlStatTotalIcon.Name = "pnlStatTotalIcon";
            pnlStatTotalIcon.Size = new Size(44, 44);
            pnlStatTotalIcon.TabIndex = 0;
            // 
            // iconStatTotal
            // 
            iconStatTotal.BackColor = Color.Transparent;
            iconStatTotal.ForeColor = Color.FromArgb(234, 140, 30);
            iconStatTotal.IconChar = IconChar.Archive;
            iconStatTotal.IconColor = Color.FromArgb(234, 140, 30);
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
            // statCardMonth
            // 
            statCardMonth.BackColor = Color.White;
            statCardMonth.Controls.Add(lblStatMonthLabel);
            statCardMonth.Controls.Add(pnlStatMonthIcon);
            statCardMonth.Controls.Add(lblStatMonthCount);
            statCardMonth.Location = new Point(224, 0);
            statCardMonth.Name = "statCardMonth";
            statCardMonth.Size = new Size(208, 88);
            statCardMonth.TabIndex = 1;
            // 
            // lblStatMonthLabel
            // 
            lblStatMonthLabel.AutoSize = true;
            lblStatMonthLabel.Font = new Font("Poppins", 8F);
            lblStatMonthLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatMonthLabel.Location = new Point(71, 50);
            lblStatMonthLabel.Name = "lblStatMonthLabel";
            lblStatMonthLabel.Size = new Size(152, 25);
            lblStatMonthLabel.TabIndex = 2;
            lblStatMonthLabel.Text = "Archived This Month";
            // 
            // pnlStatMonthIcon
            // 
            pnlStatMonthIcon.BackColor = Color.FromArgb(233, 239, 255);
            pnlStatMonthIcon.Controls.Add(iconStatMonth);
            pnlStatMonthIcon.Location = new Point(18, 22);
            pnlStatMonthIcon.Name = "pnlStatMonthIcon";
            pnlStatMonthIcon.Size = new Size(44, 44);
            pnlStatMonthIcon.TabIndex = 0;
            // 
            // iconStatMonth
            // 
            iconStatMonth.BackColor = Color.Transparent;
            iconStatMonth.ForeColor = Color.FromArgb(58, 99, 232);
            iconStatMonth.IconChar = IconChar.CalendarCheck;
            iconStatMonth.IconColor = Color.FromArgb(58, 99, 232);
            iconStatMonth.IconFont = IconFont.Auto;
            iconStatMonth.IconSize = 22;
            iconStatMonth.Location = new Point(11, 11);
            iconStatMonth.Name = "iconStatMonth";
            iconStatMonth.Size = new Size(22, 22);
            iconStatMonth.TabIndex = 0;
            iconStatMonth.TabStop = false;
            // 
            // lblStatMonthCount
            // 
            lblStatMonthCount.AutoSize = true;
            lblStatMonthCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatMonthCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatMonthCount.Location = new Point(70, 14);
            lblStatMonthCount.Name = "lblStatMonthCount";
            lblStatMonthCount.Size = new Size(35, 44);
            lblStatMonthCount.TabIndex = 1;
            lblStatMonthCount.Text = "0";
            // 
            // statCardRestored
            // 
            statCardRestored.BackColor = Color.White;
            statCardRestored.Controls.Add(lblStatRestoredLabel);
            statCardRestored.Controls.Add(pnlStatRestoredIcon);
            statCardRestored.Controls.Add(lblStatRestoredCount);
            statCardRestored.Location = new Point(448, 0);
            statCardRestored.Name = "statCardRestored";
            statCardRestored.Size = new Size(208, 88);
            statCardRestored.TabIndex = 2;
            // 
            // lblStatRestoredLabel
            // 
            lblStatRestoredLabel.AutoSize = true;
            lblStatRestoredLabel.Font = new Font("Poppins", 8F);
            lblStatRestoredLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatRestoredLabel.Location = new Point(71, 50);
            lblStatRestoredLabel.Name = "lblStatRestoredLabel";
            lblStatRestoredLabel.Size = new Size(135, 25);
            lblStatRestoredLabel.TabIndex = 2;
            lblStatRestoredLabel.Text = "Restored Records";
            // 
            // pnlStatRestoredIcon
            // 
            pnlStatRestoredIcon.BackColor = Color.FromArgb(230, 255, 242);
            pnlStatRestoredIcon.Controls.Add(iconStatRestored);
            pnlStatRestoredIcon.Location = new Point(18, 22);
            pnlStatRestoredIcon.Name = "pnlStatRestoredIcon";
            pnlStatRestoredIcon.Size = new Size(44, 44);
            pnlStatRestoredIcon.TabIndex = 0;
            // 
            // iconStatRestored
            // 
            iconStatRestored.BackColor = Color.Transparent;
            iconStatRestored.ForeColor = Color.FromArgb(16, 163, 92);
            iconStatRestored.IconChar = IconChar.RotateBack;
            iconStatRestored.IconColor = Color.FromArgb(16, 163, 92);
            iconStatRestored.IconFont = IconFont.Auto;
            iconStatRestored.IconSize = 22;
            iconStatRestored.Location = new Point(11, 11);
            iconStatRestored.Name = "iconStatRestored";
            iconStatRestored.Size = new Size(22, 22);
            iconStatRestored.TabIndex = 0;
            iconStatRestored.TabStop = false;
            // 
            // lblStatRestoredCount
            // 
            lblStatRestoredCount.AutoSize = true;
            lblStatRestoredCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatRestoredCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatRestoredCount.Location = new Point(70, 14);
            lblStatRestoredCount.Name = "lblStatRestoredCount";
            lblStatRestoredCount.Size = new Size(35, 44);
            lblStatRestoredCount.TabIndex = 1;
            lblStatRestoredCount.Text = "0";
            // 
            // statCardPending
            // 
            statCardPending.BackColor = Color.White;
            statCardPending.Controls.Add(lblStatPendingLabel);
            statCardPending.Controls.Add(pnlStatPendingIcon);
            statCardPending.Controls.Add(lblStatPendingCount);
            statCardPending.Location = new Point(670, 0);
            statCardPending.Name = "statCardPending";
            statCardPending.Size = new Size(208, 88);
            statCardPending.TabIndex = 3;
            // 
            // lblStatPendingLabel
            // 
            lblStatPendingLabel.AutoSize = true;
            lblStatPendingLabel.Font = new Font("Poppins", 8F);
            lblStatPendingLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatPendingLabel.Location = new Point(71, 50);
            lblStatPendingLabel.Name = "lblStatPendingLabel";
            lblStatPendingLabel.Size = new Size(121, 25);
            lblStatPendingLabel.TabIndex = 2;
            lblStatPendingLabel.Text = "Pending Review";
            // 
            // pnlStatPendingIcon
            // 
            pnlStatPendingIcon.BackColor = Color.FromArgb(255, 248, 225);
            pnlStatPendingIcon.Controls.Add(iconStatPending);
            pnlStatPendingIcon.Location = new Point(18, 22);
            pnlStatPendingIcon.Name = "pnlStatPendingIcon";
            pnlStatPendingIcon.Size = new Size(44, 44);
            pnlStatPendingIcon.TabIndex = 0;
            // 
            // iconStatPending
            // 
            iconStatPending.BackColor = Color.Transparent;
            iconStatPending.ForeColor = Color.FromArgb(214, 158, 0);
            iconStatPending.IconChar = IconChar.Hourglass2;
            iconStatPending.IconColor = Color.FromArgb(214, 158, 0);
            iconStatPending.IconFont = IconFont.Auto;
            iconStatPending.IconSize = 22;
            iconStatPending.Location = new Point(11, 11);
            iconStatPending.Name = "iconStatPending";
            iconStatPending.Size = new Size(22, 22);
            iconStatPending.TabIndex = 0;
            iconStatPending.TabStop = false;
            // 
            // lblStatPendingCount
            // 
            lblStatPendingCount.AutoSize = true;
            lblStatPendingCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatPendingCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatPendingCount.Location = new Point(70, 14);
            lblStatPendingCount.Name = "lblStatPendingCount";
            lblStatPendingCount.Size = new Size(35, 44);
            lblStatPendingCount.TabIndex = 1;
            lblStatPendingCount.Text = "0";
            // 
            // cardFilter
            // 
            cardFilter.BackColor = Color.White;
            cardFilter.Controls.Add(pnlFilterIconBox);
            cardFilter.Controls.Add(lblFilterTitle);
            cardFilter.Controls.Add(dividerFilter);
            cardFilter.Controls.Add(pnlSearchBox);
            cardFilter.Controls.Add(lblDateFrom);
            cardFilter.Controls.Add(dtpDateFrom);
            cardFilter.Controls.Add(lblDateTo);
            cardFilter.Controls.Add(dtpDateTo);
            cardFilter.Controls.Add(lblArchiveType);
            cardFilter.Controls.Add(cmbArchiveType);
            cardFilter.Controls.Add(lblStatus);
            cardFilter.Controls.Add(cmbStatus);
            cardFilter.Controls.Add(lblArchivedBy);
            cardFilter.Controls.Add(cmbArchivedBy);
            cardFilter.Controls.Add(btnApplyFilter);
            cardFilter.Controls.Add(btnResetFilter);
            cardFilter.Location = new Point(30, 140);
            cardFilter.Name = "cardFilter";
            cardFilter.Padding = new Padding(28, 24, 28, 28);
            cardFilter.Size = new Size(878, 260);
            cardFilter.TabIndex = 1;
            // 
            // pnlFilterIconBox
            // 
            pnlFilterIconBox.BackColor = Color.FromArgb(255, 243, 230);
            pnlFilterIconBox.Controls.Add(iconFilter);
            pnlFilterIconBox.Location = new Point(28, 24);
            pnlFilterIconBox.Name = "pnlFilterIconBox";
            pnlFilterIconBox.Size = new Size(44, 44);
            pnlFilterIconBox.TabIndex = 0;
            // 
            // iconFilter
            // 
            iconFilter.BackColor = Color.Transparent;
            iconFilter.ForeColor = Color.FromArgb(234, 140, 30);
            iconFilter.IconChar = IconChar.Filter;
            iconFilter.IconColor = Color.FromArgb(234, 140, 30);
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
            txtSearch.PlaceholderText = "Search by name, ID, reason, archived by…";
            txtSearch.Size = new Size(780, 23);
            txtSearch.TabIndex = 1;
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
            dtpDateFrom.Size = new Size(170, 31);
            dtpDateFrom.TabIndex = 5;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.FromArgb(52, 52, 58);
            lblDateTo.Location = new Point(212, 138);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(70, 26);
            lblDateTo.TabIndex = 6;
            lblDateTo.Text = "Date To";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Font = new Font("Poppins", 9.5F);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(208, 164);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(170, 31);
            dtpDateTo.TabIndex = 7;
            // 
            // lblArchiveType
            // 
            lblArchiveType.AutoSize = true;
            lblArchiveType.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblArchiveType.ForeColor = Color.FromArgb(52, 52, 58);
            lblArchiveType.Location = new Point(394, 138);
            lblArchiveType.Name = "lblArchiveType";
            lblArchiveType.Size = new Size(110, 26);
            lblArchiveType.TabIndex = 8;
            lblArchiveType.Text = "Archive Type";
            // 
            // cmbArchiveType
            // 
            cmbArchiveType.BackColor = Color.FromArgb(250, 250, 252);
            cmbArchiveType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArchiveType.FlatStyle = FlatStyle.Flat;
            cmbArchiveType.Font = new Font("Poppins", 9.5F);
            cmbArchiveType.ForeColor = Color.FromArgb(20, 20, 20);
            cmbArchiveType.Items.AddRange(new object[] { "(All Types)", "Student", "Membership", "Membership Payment", "Penalty", "Penalty Payment", "Attendance", "Activity", "Checkpoint", "Clearance", "Officer", "Committee" });
            cmbArchiveType.Location = new Point(390, 164);
            cmbArchiveType.Name = "cmbArchiveType";
            cmbArchiveType.Size = new Size(200, 36);
            cmbArchiveType.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(52, 52, 58);
            lblStatus.Location = new Point(606, 138);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(61, 26);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.FromArgb(250, 250, 252);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Poppins", 9.5F);
            cmbStatus.ForeColor = Color.FromArgb(20, 20, 20);
            cmbStatus.Items.AddRange(new object[] { "(All Statuses)", "Archived", "Restored", "Pending Review" });
            cmbStatus.Location = new Point(602, 164);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(248, 36);
            cmbStatus.TabIndex = 11;
            // 
            // lblArchivedBy
            // 
            lblArchivedBy.AutoSize = true;
            lblArchivedBy.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblArchivedBy.ForeColor = Color.FromArgb(52, 52, 58);
            lblArchivedBy.Location = new Point(31, 208);
            lblArchivedBy.Name = "lblArchivedBy";
            lblArchivedBy.Size = new Size(102, 26);
            lblArchivedBy.TabIndex = 12;
            lblArchivedBy.Text = "Archived By";
            // 
            // cmbArchivedBy
            // 
            cmbArchivedBy.BackColor = Color.FromArgb(250, 250, 252);
            cmbArchivedBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArchivedBy.FlatStyle = FlatStyle.Flat;
            cmbArchivedBy.Font = new Font("Poppins", 9.5F);
            cmbArchivedBy.ForeColor = Color.FromArgb(20, 20, 20);
            cmbArchivedBy.Items.AddRange(new object[] { "(All Officers)" });
            cmbArchivedBy.Location = new Point(28, 218);
            cmbArchivedBy.Name = "cmbArchivedBy";
            cmbArchivedBy.Size = new Size(200, 36);
            cmbArchivedBy.TabIndex = 13;
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
            btnApplyFilter.Location = new Point(590, 218);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Padding = new Padding(10, 0, 0, 0);
            btnApplyFilter.Size = new Size(148, 36);
            btnApplyFilter.TabIndex = 14;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnApplyFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyFilter.UseVisualStyleBackColor = false;
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
            btnResetFilter.Location = new Point(748, 218);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Padding = new Padding(10, 0, 0, 0);
            btnResetFilter.Size = new Size(104, 36);
            btnResetFilter.TabIndex = 15;
            btnResetFilter.Text = "Reset";
            btnResetFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnResetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // cardArchiveTable
            // 
            cardArchiveTable.BackColor = Color.White;
            cardArchiveTable.Controls.Add(pnlTableIconBox);
            cardArchiveTable.Controls.Add(lblTableTitle);
            cardArchiveTable.Controls.Add(dividerTable);
            cardArchiveTable.Controls.Add(lblResultCount);
            cardArchiveTable.Controls.Add(btnExportCsv);
            cardArchiveTable.Controls.Add(btnExportPdf);
            cardArchiveTable.Controls.Add(dgvArchive);
            cardArchiveTable.Location = new Point(30, 432);
            cardArchiveTable.Name = "cardArchiveTable";
            cardArchiveTable.Padding = new Padding(28, 24, 28, 28);
            cardArchiveTable.Size = new Size(878, 590);
            cardArchiveTable.TabIndex = 2;
            // 
            // pnlTableIconBox
            // 
            pnlTableIconBox.BackColor = Color.FromArgb(255, 243, 230);
            pnlTableIconBox.Controls.Add(iconTable);
            pnlTableIconBox.Location = new Point(28, 24);
            pnlTableIconBox.Name = "pnlTableIconBox";
            pnlTableIconBox.Size = new Size(44, 44);
            pnlTableIconBox.TabIndex = 0;
            // 
            // iconTable
            // 
            iconTable.BackColor = Color.Transparent;
            iconTable.ForeColor = Color.FromArgb(234, 140, 30);
            iconTable.IconChar = IconChar.Archive;
            iconTable.IconColor = Color.FromArgb(234, 140, 30);
            iconTable.IconFont = IconFont.Auto;
            iconTable.IconSize = 22;
            iconTable.Location = new Point(11, 11);
            iconTable.Name = "iconTable";
            iconTable.Size = new Size(22, 22);
            iconTable.TabIndex = 0;
            iconTable.TabStop = false;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblTableTitle.Location = new Point(82, 30);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(187, 34);
            lblTableTitle.TabIndex = 1;
            lblTableTitle.Text = "Archived Records";
            // 
            // dividerTable
            // 
            dividerTable.BackColor = Color.FromArgb(236, 230, 222);
            dividerTable.Location = new Point(28, 78);
            dividerTable.Name = "dividerTable";
            dividerTable.Size = new Size(822, 1);
            dividerTable.TabIndex = 2;
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
            btnExportCsv.Location = new Point(566, 82);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Padding = new Padding(8, 0, 0, 0);
            btnExportCsv.Size = new Size(128, 34);
            btnExportCsv.TabIndex = 4;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.TextAlign = ContentAlignment.MiddleLeft;
            btnExportCsv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportCsv.UseVisualStyleBackColor = false;
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
            btnExportPdf.Location = new Point(704, 82);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Padding = new Padding(8, 0, 0, 0);
            btnExportPdf.Size = new Size(128, 34);
            btnExportPdf.TabIndex = 5;
            btnExportPdf.Text = "Export PDF";
            btnExportPdf.TextAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // dgvArchive
            // 
            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;
            dgvArchive.AllowUserToResizeRows = false;
            dgvArchive.BackgroundColor = Color.White;
            dgvArchive.BorderStyle = BorderStyle.None;
            dgvArchive.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(122, 122, 128);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvArchive.ColumnHeadersHeight = 38;
            dgvArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvArchive.Columns.AddRange(new DataGridViewColumn[] { colArchiveId, colName, colArchiveType, colArchivedDate, colArchivedBy, colReason, colStatus, colRestore, colView });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(52, 52, 58);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 243, 230);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(234, 140, 30);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvArchive.DefaultCellStyle = dataGridViewCellStyle4;
            dgvArchive.EnableHeadersVisualStyles = false;
            dgvArchive.GridColor = Color.FromArgb(236, 230, 222);
            dgvArchive.Location = new Point(28, 124);
            dgvArchive.Name = "dgvArchive";
            dgvArchive.ReadOnly = true;
            dgvArchive.RowHeadersVisible = false;
            dgvArchive.RowHeadersWidth = 51;
            dgvArchive.RowTemplate.Height = 38;
            dgvArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.Size = new Size(822, 430);
            dgvArchive.TabIndex = 6;
            // 
            // colArchiveId
            // 
            colArchiveId.HeaderText = "#";
            colArchiveId.MinimumWidth = 6;
            colArchiveId.Name = "colArchiveId";
            colArchiveId.ReadOnly = true;
            colArchiveId.Resizable = DataGridViewTriState.False;
            colArchiveId.Width = 46;
            // 
            // colName
            // 
            colName.HeaderText = "Name / Subject";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 160;
            // 
            // colArchiveType
            // 
            colArchiveType.HeaderText = "Type";
            colArchiveType.MinimumWidth = 6;
            colArchiveType.Name = "colArchiveType";
            colArchiveType.ReadOnly = true;
            colArchiveType.Width = 120;
            // 
            // colArchivedDate
            // 
            colArchivedDate.HeaderText = "Archived Date";
            colArchivedDate.MinimumWidth = 6;
            colArchivedDate.Name = "colArchivedDate";
            colArchivedDate.ReadOnly = true;
            colArchivedDate.Width = 130;
            // 
            // colArchivedBy
            // 
            colArchivedBy.HeaderText = "Archived By";
            colArchivedBy.MinimumWidth = 6;
            colArchivedBy.Name = "colArchivedBy";
            colArchivedBy.ReadOnly = true;
            colArchivedBy.Width = 130;
            // 
            // colReason
            // 
            colReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReason.HeaderText = "Reason";
            colReason.MinimumWidth = 6;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // colRestore
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(230, 255, 242);
            dataGridViewCellStyle2.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(16, 163, 92);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(16, 163, 92);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            colRestore.DefaultCellStyle = dataGridViewCellStyle2;
            colRestore.HeaderText = "Restore";
            colRestore.MinimumWidth = 6;
            colRestore.Name = "colRestore";
            colRestore.ReadOnly = true;
            colRestore.Text = "Restore";
            colRestore.UseColumnTextForButtonValue = true;
            colRestore.Width = 76;
            // 
            // colView
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle3.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle3;
            colView.HeaderText = "Details";
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Text = "View";
            colView.UseColumnTextForButtonValue = true;
            colView.Width = 68;
            // 
            // cardDetail
            // 
            cardDetail.BackColor = Color.White;
            cardDetail.Controls.Add(pnlDetailIconBox);
            cardDetail.Controls.Add(lblDetailTitle);
            cardDetail.Controls.Add(btnCloseDetail);
            cardDetail.Controls.Add(dividerDetail);
            cardDetail.Controls.Add(lblDetailIdLbl);
            cardDetail.Controls.Add(lblDetailId);
            cardDetail.Controls.Add(lblDetailNameLbl);
            cardDetail.Controls.Add(lblDetailName);
            cardDetail.Controls.Add(lblDetailTypeLbl);
            cardDetail.Controls.Add(lblDetailType);
            cardDetail.Controls.Add(lblDetailStatusLbl);
            cardDetail.Controls.Add(lblDetailStatus);
            cardDetail.Controls.Add(lblDetailArchivedDateLbl);
            cardDetail.Controls.Add(lblDetailArchivedDate);
            cardDetail.Controls.Add(lblDetailArchivedByLbl);
            cardDetail.Controls.Add(lblDetailArchivedBy);
            cardDetail.Controls.Add(lblDetailReasonLbl);
            cardDetail.Controls.Add(txtDetailReason);
            cardDetail.Controls.Add(dividerDetailActions);
            cardDetail.Controls.Add(btnRestoreRecord);
            cardDetail.Controls.Add(btnDeletePermanent);
            cardDetail.Location = new Point(30, 1054);
            cardDetail.Name = "cardDetail";
            cardDetail.Padding = new Padding(28, 24, 28, 28);
            cardDetail.Size = new Size(878, 416);
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
            lblDetailTitle.Size = new Size(237, 34);
            lblDetailTitle.TabIndex = 1;
            lblDetailTitle.Text = "Archive Record Details";
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
            // lblDetailIdLbl
            // 
            lblDetailIdLbl.AutoSize = true;
            lblDetailIdLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailIdLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailIdLbl.Location = new Point(31, 94);
            lblDetailIdLbl.Name = "lblDetailIdLbl";
            lblDetailIdLbl.Size = new Size(88, 26);
            lblDetailIdLbl.TabIndex = 4;
            lblDetailIdLbl.Text = "Archive ID";
            // 
            // lblDetailId
            // 
            lblDetailId.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailId.BorderStyle = BorderStyle.FixedSingle;
            lblDetailId.Font = new Font("Poppins", 9.5F);
            lblDetailId.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailId.Location = new Point(28, 122);
            lblDetailId.Name = "lblDetailId";
            lblDetailId.Padding = new Padding(8, 0, 0, 0);
            lblDetailId.Size = new Size(120, 32);
            lblDetailId.TabIndex = 5;
            lblDetailId.Text = "—";
            lblDetailId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailNameLbl
            // 
            lblDetailNameLbl.AutoSize = true;
            lblDetailNameLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailNameLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailNameLbl.Location = new Point(162, 94);
            lblDetailNameLbl.Name = "lblDetailNameLbl";
            lblDetailNameLbl.Size = new Size(128, 26);
            lblDetailNameLbl.TabIndex = 6;
            lblDetailNameLbl.Text = "Name / Subject";
            // 
            // lblDetailName
            // 
            lblDetailName.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailName.BorderStyle = BorderStyle.FixedSingle;
            lblDetailName.Font = new Font("Poppins", 9.5F);
            lblDetailName.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailName.Location = new Point(158, 122);
            lblDetailName.Name = "lblDetailName";
            lblDetailName.Padding = new Padding(8, 0, 0, 0);
            lblDetailName.Size = new Size(260, 32);
            lblDetailName.TabIndex = 7;
            lblDetailName.Text = "—";
            lblDetailName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailTypeLbl
            // 
            lblDetailTypeLbl.AutoSize = true;
            lblDetailTypeLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailTypeLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailTypeLbl.Location = new Point(434, 94);
            lblDetailTypeLbl.Name = "lblDetailTypeLbl";
            lblDetailTypeLbl.Size = new Size(110, 26);
            lblDetailTypeLbl.TabIndex = 8;
            lblDetailTypeLbl.Text = "Archive Type";
            // 
            // lblDetailType
            // 
            lblDetailType.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailType.BorderStyle = BorderStyle.FixedSingle;
            lblDetailType.Font = new Font("Poppins", 9.5F);
            lblDetailType.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailType.Location = new Point(430, 122);
            lblDetailType.Name = "lblDetailType";
            lblDetailType.Padding = new Padding(8, 0, 0, 0);
            lblDetailType.Size = new Size(170, 32);
            lblDetailType.TabIndex = 9;
            lblDetailType.Text = "—";
            lblDetailType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailStatusLbl
            // 
            lblDetailStatusLbl.AutoSize = true;
            lblDetailStatusLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailStatusLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailStatusLbl.Location = new Point(616, 94);
            lblDetailStatusLbl.Name = "lblDetailStatusLbl";
            lblDetailStatusLbl.Size = new Size(61, 26);
            lblDetailStatusLbl.TabIndex = 10;
            lblDetailStatusLbl.Text = "Status";
            // 
            // lblDetailStatus
            // 
            lblDetailStatus.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailStatus.BorderStyle = BorderStyle.FixedSingle;
            lblDetailStatus.Font = new Font("Poppins", 9.5F);
            lblDetailStatus.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailStatus.Location = new Point(612, 122);
            lblDetailStatus.Name = "lblDetailStatus";
            lblDetailStatus.Padding = new Padding(8, 0, 0, 0);
            lblDetailStatus.Size = new Size(238, 32);
            lblDetailStatus.TabIndex = 11;
            lblDetailStatus.Text = "—";
            lblDetailStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailArchivedDateLbl
            // 
            lblDetailArchivedDateLbl.AutoSize = true;
            lblDetailArchivedDateLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailArchivedDateLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailArchivedDateLbl.Location = new Point(31, 170);
            lblDetailArchivedDateLbl.Name = "lblDetailArchivedDateLbl";
            lblDetailArchivedDateLbl.Size = new Size(119, 26);
            lblDetailArchivedDateLbl.TabIndex = 12;
            lblDetailArchivedDateLbl.Text = "Archived Date";
            // 
            // lblDetailArchivedDate
            // 
            lblDetailArchivedDate.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailArchivedDate.BorderStyle = BorderStyle.FixedSingle;
            lblDetailArchivedDate.Font = new Font("Poppins", 9.5F);
            lblDetailArchivedDate.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailArchivedDate.Location = new Point(28, 198);
            lblDetailArchivedDate.Name = "lblDetailArchivedDate";
            lblDetailArchivedDate.Padding = new Padding(8, 0, 0, 0);
            lblDetailArchivedDate.Size = new Size(260, 32);
            lblDetailArchivedDate.TabIndex = 13;
            lblDetailArchivedDate.Text = "—";
            lblDetailArchivedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailArchivedByLbl
            // 
            lblDetailArchivedByLbl.AutoSize = true;
            lblDetailArchivedByLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailArchivedByLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailArchivedByLbl.Location = new Point(305, 170);
            lblDetailArchivedByLbl.Name = "lblDetailArchivedByLbl";
            lblDetailArchivedByLbl.Size = new Size(102, 26);
            lblDetailArchivedByLbl.TabIndex = 14;
            lblDetailArchivedByLbl.Text = "Archived By";
            // 
            // lblDetailArchivedBy
            // 
            lblDetailArchivedBy.BackColor = Color.FromArgb(250, 250, 252);
            lblDetailArchivedBy.BorderStyle = BorderStyle.FixedSingle;
            lblDetailArchivedBy.Font = new Font("Poppins", 9.5F);
            lblDetailArchivedBy.ForeColor = Color.FromArgb(20, 20, 20);
            lblDetailArchivedBy.Location = new Point(302, 198);
            lblDetailArchivedBy.Name = "lblDetailArchivedBy";
            lblDetailArchivedBy.Padding = new Padding(8, 0, 0, 0);
            lblDetailArchivedBy.Size = new Size(548, 32);
            lblDetailArchivedBy.TabIndex = 15;
            lblDetailArchivedBy.Text = "—";
            lblDetailArchivedBy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetailReasonLbl
            // 
            lblDetailReasonLbl.AutoSize = true;
            lblDetailReasonLbl.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDetailReasonLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblDetailReasonLbl.Location = new Point(31, 248);
            lblDetailReasonLbl.Name = "lblDetailReasonLbl";
            lblDetailReasonLbl.Size = new Size(126, 26);
            lblDetailReasonLbl.TabIndex = 16;
            lblDetailReasonLbl.Text = "Reason / Notes";
            // 
            // txtDetailReason
            // 
            txtDetailReason.BackColor = Color.FromArgb(250, 250, 252);
            txtDetailReason.BorderStyle = BorderStyle.FixedSingle;
            txtDetailReason.Font = new Font("Poppins", 9F);
            txtDetailReason.ForeColor = Color.FromArgb(52, 52, 58);
            txtDetailReason.Location = new Point(28, 276);
            txtDetailReason.Multiline = true;
            txtDetailReason.Name = "txtDetailReason";
            txtDetailReason.ReadOnly = true;
            txtDetailReason.ScrollBars = ScrollBars.Vertical;
            txtDetailReason.Size = new Size(822, 70);
            txtDetailReason.TabIndex = 17;
            // 
            // dividerDetailActions
            // 
            dividerDetailActions.BackColor = Color.FromArgb(236, 230, 222);
            dividerDetailActions.Location = new Point(28, 358);
            dividerDetailActions.Name = "dividerDetailActions";
            dividerDetailActions.Size = new Size(822, 1);
            dividerDetailActions.TabIndex = 18;
            // 
            // btnRestoreRecord
            // 
            btnRestoreRecord.BackColor = Color.FromArgb(16, 163, 92);
            btnRestoreRecord.FlatAppearance.BorderSize = 0;
            btnRestoreRecord.FlatStyle = FlatStyle.Flat;
            btnRestoreRecord.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnRestoreRecord.ForeColor = Color.White;
            btnRestoreRecord.IconChar = IconChar.RotateBack;
            btnRestoreRecord.IconColor = Color.White;
            btnRestoreRecord.IconFont = IconFont.Auto;
            btnRestoreRecord.IconSize = 16;
            btnRestoreRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestoreRecord.Location = new Point(456, 368);
            btnRestoreRecord.Name = "btnRestoreRecord";
            btnRestoreRecord.Padding = new Padding(10, 0, 0, 0);
            btnRestoreRecord.Size = new Size(170, 36);
            btnRestoreRecord.TabIndex = 19;
            btnRestoreRecord.Text = "Restore Record";
            btnRestoreRecord.TextAlign = ContentAlignment.MiddleLeft;
            btnRestoreRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRestoreRecord.UseVisualStyleBackColor = false;
            // 
            // btnDeletePermanent
            // 
            btnDeletePermanent.BackColor = Color.White;
            btnDeletePermanent.FlatAppearance.BorderColor = Color.FromArgb(220, 60, 60);
            btnDeletePermanent.FlatStyle = FlatStyle.Flat;
            btnDeletePermanent.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnDeletePermanent.ForeColor = Color.FromArgb(220, 60, 60);
            btnDeletePermanent.IconChar = IconChar.TrashAlt;
            btnDeletePermanent.IconColor = Color.FromArgb(220, 60, 60);
            btnDeletePermanent.IconFont = IconFont.Auto;
            btnDeletePermanent.IconSize = 16;
            btnDeletePermanent.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeletePermanent.Location = new Point(636, 368);
            btnDeletePermanent.Name = "btnDeletePermanent";
            btnDeletePermanent.Padding = new Padding(10, 0, 0, 0);
            btnDeletePermanent.Size = new Size(214, 36);
            btnDeletePermanent.TabIndex = 20;
            btnDeletePermanent.Text = "Delete Permanently";
            btnDeletePermanent.TextAlign = ContentAlignment.MiddleLeft;
            btnDeletePermanent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeletePermanent.UseVisualStyleBackColor = false;
            // 
            // ArchiveView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "ArchiveView";
            Size = new Size(955, 615);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            cardStats.ResumeLayout(false);
            statCardTotal.ResumeLayout(false);
            statCardTotal.PerformLayout();
            pnlStatTotalIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatTotal).EndInit();
            statCardMonth.ResumeLayout(false);
            statCardMonth.PerformLayout();
            pnlStatMonthIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatMonth).EndInit();
            statCardRestored.ResumeLayout(false);
            statCardRestored.PerformLayout();
            pnlStatRestoredIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatRestored).EndInit();
            statCardPending.ResumeLayout(false);
            statCardPending.PerformLayout();
            pnlStatPendingIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatPending).EndInit();
            cardFilter.ResumeLayout(false);
            cardFilter.PerformLayout();
            pnlFilterIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconFilter).EndInit();
            pnlSearchBox.ResumeLayout(false);
            pnlSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).EndInit();
            cardArchiveTable.ResumeLayout(false);
            cardArchiveTable.PerformLayout();
            pnlTableIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArchive).EndInit();
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
        private System.Windows.Forms.Panel statCardMonth;
        private System.Windows.Forms.Panel pnlStatMonthIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatMonth;
        private System.Windows.Forms.Label lblStatMonthCount;
        private System.Windows.Forms.Label lblStatMonthLabel;
        private System.Windows.Forms.Panel statCardRestored;
        private System.Windows.Forms.Panel pnlStatRestoredIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatRestored;
        private System.Windows.Forms.Label lblStatRestoredCount;
        private System.Windows.Forms.Label lblStatRestoredLabel;
        private System.Windows.Forms.Panel statCardPending;
        private System.Windows.Forms.Panel pnlStatPendingIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatPending;
        private System.Windows.Forms.Label lblStatPendingCount;
        private System.Windows.Forms.Label lblStatPendingLabel;
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
        private System.Windows.Forms.Label lblArchiveType;
        private System.Windows.Forms.ComboBox cmbArchiveType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblArchivedBy;
        private System.Windows.Forms.ComboBox cmbArchivedBy;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private FontAwesome.Sharp.IconButton btnResetFilter;
        private System.Windows.Forms.Panel cardArchiveTable;
        private System.Windows.Forms.Panel pnlTableIconBox;
        private FontAwesome.Sharp.IconPictureBox iconTable;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Panel dividerTable;
        private System.Windows.Forms.Label lblResultCount;
        private FontAwesome.Sharp.IconButton btnExportCsv;
        private FontAwesome.Sharp.IconButton btnExportPdf;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchiveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchiveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colRestore;
        private System.Windows.Forms.DataGridViewButtonColumn colView;
        private System.Windows.Forms.Panel cardDetail;
        private System.Windows.Forms.Panel pnlDetailIconBox;
        private FontAwesome.Sharp.IconPictureBox iconDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private FontAwesome.Sharp.IconButton btnCloseDetail;
        private System.Windows.Forms.Panel dividerDetail;
        private System.Windows.Forms.Label lblDetailIdLbl;
        private System.Windows.Forms.Label lblDetailId;
        private System.Windows.Forms.Label lblDetailNameLbl;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Label lblDetailTypeLbl;
        private System.Windows.Forms.Label lblDetailType;
        private System.Windows.Forms.Label lblDetailStatusLbl;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailArchivedDateLbl;
        private System.Windows.Forms.Label lblDetailArchivedDate;
        private System.Windows.Forms.Label lblDetailArchivedByLbl;
        private System.Windows.Forms.Label lblDetailArchivedBy;
        private System.Windows.Forms.Label lblDetailReasonLbl;
        private System.Windows.Forms.TextBox txtDetailReason;
        private System.Windows.Forms.Panel dividerDetailActions;
        private FontAwesome.Sharp.IconButton btnRestoreRecord;
        private FontAwesome.Sharp.IconButton btnDeletePermanent;
    }
}
