using FontAwesome.Sharp;

namespace BYTeLog.Views
{
    partial class ReportsView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            outerScrollPanel = new System.Windows.Forms.Panel();
            innerContentPanel = new System.Windows.Forms.Panel();
            cardStats = new System.Windows.Forms.Panel();
            statCardMembers = new System.Windows.Forms.Panel();
            lblStatMembersLabel = new Label();
            pnlStatMembersIcon = new System.Windows.Forms.Panel();
            iconStatMembers = new IconPictureBox();
            lblStatMembersCount = new Label();
            statCardActive = new System.Windows.Forms.Panel();
            lblStatActiveLabel = new Label();
            pnlStatActiveIcon = new System.Windows.Forms.Panel();
            iconStatActive = new IconPictureBox();
            lblStatActiveCount = new Label();
            statCardFees = new System.Windows.Forms.Panel();
            lblStatFeesLabel = new Label();
            pnlStatFeesIcon = new System.Windows.Forms.Panel();
            iconStatFees = new IconPictureBox();
            lblStatFeesCount = new Label();
            statCardPenalties = new System.Windows.Forms.Panel();
            lblStatPenaltiesLabel = new Label();
            pnlStatPenaltiesIcon = new System.Windows.Forms.Panel();
            iconStatPenalties = new IconPictureBox();
            lblStatPenaltiesCount = new Label();
            cardFilter = new System.Windows.Forms.Panel();
            pnlFilterIconBox = new System.Windows.Forms.Panel();
            iconFilter = new IconPictureBox();
            lblFilterTitle = new Label();
            dividerFilter = new System.Windows.Forms.Panel();
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            lblDateFrom = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateTo = new DateTimePicker();
            lblSchoolYear = new Label();
            cmbSchoolYear = new ComboBox();
            lblSemester = new Label();
            cmbSemester = new ComboBox();
            btnGenerateReport = new IconButton();
            btnResetFilter = new IconButton();
            btnExportCsv = new IconButton();
            btnExportPdf = new IconButton();
            cardMembership = new System.Windows.Forms.Panel();
            pnlMemIconBox = new System.Windows.Forms.Panel();
            iconMem = new IconPictureBox();
            lblMemTitle = new Label();
            dividerMem = new System.Windows.Forms.Panel();
            lblMemResultCount = new Label();
            dgvMembership = new DataGridView();
            colMemId = new DataGridViewTextBoxColumn();
            colMemStudentName = new DataGridViewTextBoxColumn();
            colMemStudentNo = new DataGridViewTextBoxColumn();
            colMemType = new DataGridViewTextBoxColumn();
            colMemStatus = new DataGridViewTextBoxColumn();
            colMemStartDate = new DataGridViewTextBoxColumn();
            colMemEndDate = new DataGridViewTextBoxColumn();
            colMemFeePaid = new DataGridViewTextBoxColumn();
            cardFees = new System.Windows.Forms.Panel();
            pnlFeeIconBox = new System.Windows.Forms.Panel();
            iconFee = new IconPictureBox();
            lblFeeTitle = new Label();
            dividerFee = new System.Windows.Forms.Panel();
            pnlFeeSummaryBar = new System.Windows.Forms.Panel();
            pnlFeeSumCollected = new System.Windows.Forms.Panel();
            iconFeeSumCollected = new IconPictureBox();
            lblFeeSumCollectedLbl = new Label();
            lblFeeSumCollectedAmt = new Label();
            pnlFeeSumPending = new System.Windows.Forms.Panel();
            iconFeeSumPending = new IconPictureBox();
            lblFeeSumPendingLbl = new Label();
            lblFeeSumPendingAmt = new Label();
            pnlFeeSumOverdue = new System.Windows.Forms.Panel();
            iconFeeSumOverdue = new IconPictureBox();
            lblFeeSumOverdueLbl = new Label();
            lblFeeSumOverdueAmt = new Label();
            lblFeeResultCount = new Label();
            dgvFees = new DataGridView();
            colFeeId = new DataGridViewTextBoxColumn();
            colFeeStudentName = new DataGridViewTextBoxColumn();
            colFeeStudentNo = new DataGridViewTextBoxColumn();
            colFeePolicyName = new DataGridViewTextBoxColumn();
            colFeeAmount = new DataGridViewTextBoxColumn();
            colFeeAmountPaid = new DataGridViewTextBoxColumn();
            colFeeBalance = new DataGridViewTextBoxColumn();
            colFeeStatus = new DataGridViewTextBoxColumn();
            colFeePaymentDate = new DataGridViewTextBoxColumn();
            colFeeOR = new DataGridViewTextBoxColumn();
            cardPenalties = new System.Windows.Forms.Panel();
            pnlPenIconBox = new System.Windows.Forms.Panel();
            iconPen = new IconPictureBox();
            lblPenTitle = new Label();
            dividerPen = new System.Windows.Forms.Panel();
            pnlPenSummaryBar = new System.Windows.Forms.Panel();
            pnlPenSumTotal = new System.Windows.Forms.Panel();
            iconPenSumTotal = new IconPictureBox();
            lblPenSumTotalLbl = new Label();
            lblPenSumTotalAmt = new Label();
            pnlPenSumPaid = new System.Windows.Forms.Panel();
            iconPenSumPaid = new IconPictureBox();
            lblPenSumPaidLbl = new Label();
            lblPenSumPaidAmt = new Label();
            pnlPenSumUnpaid = new System.Windows.Forms.Panel();
            iconPenSumUnpaid = new IconPictureBox();
            lblPenSumUnpaidLbl = new Label();
            lblPenSumUnpaidAmt = new Label();
            lblPenResultCount = new Label();
            dgvPenalties = new DataGridView();
            colPenId = new DataGridViewTextBoxColumn();
            colPenStudentName = new DataGridViewTextBoxColumn();
            colPenStudentNo = new DataGridViewTextBoxColumn();
            colPenPolicyName = new DataGridViewTextBoxColumn();
            colPenReason = new DataGridViewTextBoxColumn();
            colPenAmount = new DataGridViewTextBoxColumn();
            colPenAmountPaid = new DataGridViewTextBoxColumn();
            colPenStatus = new DataGridViewTextBoxColumn();
            colPenDateIssued = new DataGridViewTextBoxColumn();
            cardAttendance = new System.Windows.Forms.Panel();
            pnlAttIconBox = new System.Windows.Forms.Panel();
            iconAtt = new IconPictureBox();
            lblAttTitle = new Label();
            dividerAtt = new System.Windows.Forms.Panel();
            pnlAttSummaryBar = new System.Windows.Forms.Panel();
            pnlAttSumPresent = new System.Windows.Forms.Panel();
            iconAttSumPresent = new IconPictureBox();
            lblAttSumPresentLbl = new Label();
            lblAttSumPresentCount = new Label();
            pnlAttSumAbsent = new System.Windows.Forms.Panel();
            iconAttSumAbsent = new IconPictureBox();
            lblAttSumAbsentLbl = new Label();
            lblAttSumAbsentCount = new Label();
            pnlAttSumRate = new System.Windows.Forms.Panel();
            iconAttSumRate = new IconPictureBox();
            lblAttSumRateLbl = new Label();
            lblAttSumRateCount = new Label();
            lblAttResultCount = new Label();
            dgvAttendance = new DataGridView();
            colAttId = new DataGridViewTextBoxColumn();
            colAttStudentName = new DataGridViewTextBoxColumn();
            colAttStudentNo = new DataGridViewTextBoxColumn();
            colAttActivity = new DataGridViewTextBoxColumn();
            colAttCheckpoint = new DataGridViewTextBoxColumn();
            colAttStatus = new DataGridViewTextBoxColumn();
            colAttTimeIn = new DataGridViewTextBoxColumn();
            colAttTimeOut = new DataGridViewTextBoxColumn();
            colAttPenaltyIncurred = new DataGridViewTextBoxColumn();
            cardClearance = new System.Windows.Forms.Panel();
            pnlClrIconBox = new System.Windows.Forms.Panel();
            iconClr = new IconPictureBox();
            lblClrTitle = new Label();
            dividerClr = new System.Windows.Forms.Panel();
            pnlClrSummaryBar = new System.Windows.Forms.Panel();
            pnlClrSumCleared = new System.Windows.Forms.Panel();
            iconClrSumCleared = new IconPictureBox();
            lblClrSumClearedLbl = new Label();
            lblClrSumClearedCount = new Label();
            pnlClrSumPending = new System.Windows.Forms.Panel();
            iconClrSumPending = new IconPictureBox();
            lblClrSumPendingLbl = new Label();
            lblClrSumPendingCount = new Label();
            pnlClrSumDenied = new System.Windows.Forms.Panel();
            iconClrSumDenied = new IconPictureBox();
            lblClrSumDeniedLbl = new Label();
            lblClrSumDeniedCount = new Label();
            lblClrResultCount = new Label();
            dgvClearance = new DataGridView();
            colClrId = new DataGridViewTextBoxColumn();
            colClrStudentName = new DataGridViewTextBoxColumn();
            colClrStudentNo = new DataGridViewTextBoxColumn();
            colClrCourse = new DataGridViewTextBoxColumn();
            colClrStatus = new DataGridViewTextBoxColumn();
            colClrMemObligation = new DataGridViewTextBoxColumn();
            colClrPenObligation = new DataGridViewTextBoxColumn();
            colClrRequestedDate = new DataGridViewTextBoxColumn();
            colClrIssuedDate = new DataGridViewTextBoxColumn();
            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            cardStats.SuspendLayout();
            statCardMembers.SuspendLayout();
            pnlStatMembersIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatMembers).BeginInit();
            statCardActive.SuspendLayout();
            pnlStatActiveIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatActive).BeginInit();
            statCardFees.SuspendLayout();
            pnlStatFeesIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatFees).BeginInit();
            statCardPenalties.SuspendLayout();
            pnlStatPenaltiesIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatPenalties).BeginInit();
            cardFilter.SuspendLayout();
            pnlFilterIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFilter).BeginInit();
            cardMembership.SuspendLayout();
            pnlMemIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembership).BeginInit();
            cardFees.SuspendLayout();
            pnlFeeIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFee).BeginInit();
            pnlFeeSummaryBar.SuspendLayout();
            pnlFeeSumCollected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumCollected).BeginInit();
            pnlFeeSumPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumPending).BeginInit();
            pnlFeeSumOverdue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumOverdue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFees).BeginInit();
            cardPenalties.SuspendLayout();
            pnlPenIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPen).BeginInit();
            pnlPenSummaryBar.SuspendLayout();
            pnlPenSumTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumTotal).BeginInit();
            pnlPenSumPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumPaid).BeginInit();
            pnlPenSumUnpaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumUnpaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenalties).BeginInit();
            cardAttendance.SuspendLayout();
            pnlAttIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAtt).BeginInit();
            pnlAttSummaryBar.SuspendLayout();
            pnlAttSumPresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumPresent).BeginInit();
            pnlAttSumAbsent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumAbsent).BeginInit();
            pnlAttSumRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            cardClearance.SuspendLayout();
            pnlClrIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClr).BeginInit();
            pnlClrSummaryBar.SuspendLayout();
            pnlClrSumCleared.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumCleared).BeginInit();
            pnlClrSumPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumPending).BeginInit();
            pnlClrSumDenied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumDenied).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClearance).BeginInit();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 3200);
            outerScrollPanel.BackColor = Color.FromArgb(244, 239, 231);
            outerScrollPanel.Controls.Add(innerContentPanel);
            outerScrollPanel.Dock = DockStyle.Fill;
            outerScrollPanel.Location = new Point(0, 0);
            outerScrollPanel.Name = "outerScrollPanel";
            outerScrollPanel.Size = new Size(955, 3200);
            outerScrollPanel.TabIndex = 0;
            // 
            // innerContentPanel
            // 
            innerContentPanel.BackColor = Color.FromArgb(244, 239, 231);
            innerContentPanel.Controls.Add(cardStats);
            innerContentPanel.Controls.Add(cardFilter);
            innerContentPanel.Controls.Add(cardMembership);
            innerContentPanel.Controls.Add(cardFees);
            innerContentPanel.Controls.Add(cardPenalties);
            innerContentPanel.Controls.Add(cardAttendance);
            innerContentPanel.Controls.Add(cardClearance);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Padding = new Padding(30);
            innerContentPanel.Size = new Size(934, 3200);
            innerContentPanel.TabIndex = 0;
            // 
            // cardStats
            // 
            cardStats.BackColor = Color.Transparent;
            cardStats.Controls.Add(statCardMembers);
            cardStats.Controls.Add(statCardActive);
            cardStats.Controls.Add(statCardFees);
            cardStats.Controls.Add(statCardPenalties);
            cardStats.Location = new Point(30, 30);
            cardStats.Name = "cardStats";
            cardStats.Size = new Size(878, 88);
            cardStats.TabIndex = 0;
            // 
            // statCardMembers
            // 
            statCardMembers.BackColor = Color.White;
            statCardMembers.Controls.Add(lblStatMembersLabel);
            statCardMembers.Controls.Add(pnlStatMembersIcon);
            statCardMembers.Controls.Add(lblStatMembersCount);
            statCardMembers.Location = new Point(0, 0);
            statCardMembers.Name = "statCardMembers";
            statCardMembers.Size = new Size(208, 88);
            statCardMembers.TabIndex = 0;
            // 
            // lblStatMembersLabel
            // 
            lblStatMembersLabel.AutoSize = true;
            lblStatMembersLabel.Font = new Font("Poppins", 8F);
            lblStatMembersLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatMembersLabel.Location = new Point(71, 50);
            lblStatMembersLabel.Name = "lblStatMembersLabel";
            lblStatMembersLabel.Size = new Size(111, 25);
            lblStatMembersLabel.TabIndex = 2;
            lblStatMembersLabel.Text = "Total Students";
            // 
            // pnlStatMembersIcon
            // 
            pnlStatMembersIcon.BackColor = Color.FromArgb(233, 239, 255);
            pnlStatMembersIcon.Controls.Add(iconStatMembers);
            pnlStatMembersIcon.Location = new Point(18, 22);
            pnlStatMembersIcon.Name = "pnlStatMembersIcon";
            pnlStatMembersIcon.Size = new Size(44, 44);
            pnlStatMembersIcon.TabIndex = 0;
            // 
            // iconStatMembers
            // 
            iconStatMembers.BackColor = Color.Transparent;
            iconStatMembers.ForeColor = Color.FromArgb(58, 99, 232);
            iconStatMembers.IconChar = IconChar.UserFriends;
            iconStatMembers.IconColor = Color.FromArgb(58, 99, 232);
            iconStatMembers.IconFont = IconFont.Auto;
            iconStatMembers.IconSize = 22;
            iconStatMembers.Location = new Point(11, 11);
            iconStatMembers.Name = "iconStatMembers";
            iconStatMembers.Size = new Size(22, 22);
            iconStatMembers.TabIndex = 0;
            iconStatMembers.TabStop = false;
            // 
            // lblStatMembersCount
            // 
            lblStatMembersCount.AutoSize = true;
            lblStatMembersCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatMembersCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatMembersCount.Location = new Point(70, 14);
            lblStatMembersCount.Name = "lblStatMembersCount";
            lblStatMembersCount.Size = new Size(35, 44);
            lblStatMembersCount.TabIndex = 1;
            lblStatMembersCount.Text = "0";
            // 
            // statCardActive
            // 
            statCardActive.BackColor = Color.White;
            statCardActive.Controls.Add(lblStatActiveLabel);
            statCardActive.Controls.Add(pnlStatActiveIcon);
            statCardActive.Controls.Add(lblStatActiveCount);
            statCardActive.Location = new Point(224, 0);
            statCardActive.Name = "statCardActive";
            statCardActive.Size = new Size(208, 88);
            statCardActive.TabIndex = 1;
            // 
            // lblStatActiveLabel
            // 
            lblStatActiveLabel.AutoSize = true;
            lblStatActiveLabel.Font = new Font("Poppins", 8F);
            lblStatActiveLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatActiveLabel.Location = new Point(71, 50);
            lblStatActiveLabel.Name = "lblStatActiveLabel";
            lblStatActiveLabel.Size = new Size(124, 25);
            lblStatActiveLabel.TabIndex = 2;
            lblStatActiveLabel.Text = "Active Members";
            // 
            // pnlStatActiveIcon
            // 
            pnlStatActiveIcon.BackColor = Color.FromArgb(230, 255, 242);
            pnlStatActiveIcon.Controls.Add(iconStatActive);
            pnlStatActiveIcon.Location = new Point(18, 22);
            pnlStatActiveIcon.Name = "pnlStatActiveIcon";
            pnlStatActiveIcon.Size = new Size(44, 44);
            pnlStatActiveIcon.TabIndex = 0;
            // 
            // iconStatActive
            // 
            iconStatActive.BackColor = Color.Transparent;
            iconStatActive.ForeColor = Color.FromArgb(16, 163, 92);
            iconStatActive.IconChar = IconChar.DriversLicense;
            iconStatActive.IconColor = Color.FromArgb(16, 163, 92);
            iconStatActive.IconFont = IconFont.Auto;
            iconStatActive.IconSize = 22;
            iconStatActive.Location = new Point(11, 11);
            iconStatActive.Name = "iconStatActive";
            iconStatActive.Size = new Size(22, 22);
            iconStatActive.TabIndex = 0;
            iconStatActive.TabStop = false;
            // 
            // lblStatActiveCount
            // 
            lblStatActiveCount.AutoSize = true;
            lblStatActiveCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatActiveCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatActiveCount.Location = new Point(70, 14);
            lblStatActiveCount.Name = "lblStatActiveCount";
            lblStatActiveCount.Size = new Size(35, 44);
            lblStatActiveCount.TabIndex = 1;
            lblStatActiveCount.Text = "0";
            // 
            // statCardFees
            // 
            statCardFees.BackColor = Color.White;
            statCardFees.Controls.Add(lblStatFeesLabel);
            statCardFees.Controls.Add(pnlStatFeesIcon);
            statCardFees.Controls.Add(lblStatFeesCount);
            statCardFees.Location = new Point(448, 0);
            statCardFees.Name = "statCardFees";
            statCardFees.Size = new Size(208, 88);
            statCardFees.TabIndex = 2;
            // 
            // lblStatFeesLabel
            // 
            lblStatFeesLabel.AutoSize = true;
            lblStatFeesLabel.Font = new Font("Poppins", 8F);
            lblStatFeesLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatFeesLabel.Location = new Point(71, 50);
            lblStatFeesLabel.Name = "lblStatFeesLabel";
            lblStatFeesLabel.Size = new Size(115, 25);
            lblStatFeesLabel.TabIndex = 2;
            lblStatFeesLabel.Text = "Fees Collected";
            // 
            // pnlStatFeesIcon
            // 
            pnlStatFeesIcon.BackColor = Color.FromArgb(243, 255, 230);
            pnlStatFeesIcon.Controls.Add(iconStatFees);
            pnlStatFeesIcon.Location = new Point(18, 22);
            pnlStatFeesIcon.Name = "pnlStatFeesIcon";
            pnlStatFeesIcon.Size = new Size(44, 44);
            pnlStatFeesIcon.TabIndex = 0;
            // 
            // iconStatFees
            // 
            iconStatFees.BackColor = Color.Transparent;
            iconStatFees.ForeColor = Color.FromArgb(80, 160, 30);
            iconStatFees.IconChar = IconChar.MoneyBillWave;
            iconStatFees.IconColor = Color.FromArgb(80, 160, 30);
            iconStatFees.IconFont = IconFont.Auto;
            iconStatFees.IconSize = 22;
            iconStatFees.Location = new Point(11, 11);
            iconStatFees.Name = "iconStatFees";
            iconStatFees.Size = new Size(22, 22);
            iconStatFees.TabIndex = 0;
            iconStatFees.TabStop = false;
            // 
            // lblStatFeesCount
            // 
            lblStatFeesCount.AutoSize = true;
            lblStatFeesCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatFeesCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatFeesCount.Location = new Point(70, 14);
            lblStatFeesCount.Name = "lblStatFeesCount";
            lblStatFeesCount.Size = new Size(56, 44);
            lblStatFeesCount.TabIndex = 1;
            lblStatFeesCount.Text = "₱0";
            // 
            // statCardPenalties
            // 
            statCardPenalties.BackColor = Color.White;
            statCardPenalties.Controls.Add(lblStatPenaltiesLabel);
            statCardPenalties.Controls.Add(pnlStatPenaltiesIcon);
            statCardPenalties.Controls.Add(lblStatPenaltiesCount);
            statCardPenalties.Location = new Point(670, 0);
            statCardPenalties.Name = "statCardPenalties";
            statCardPenalties.Size = new Size(208, 88);
            statCardPenalties.TabIndex = 3;
            // 
            // lblStatPenaltiesLabel
            // 
            lblStatPenaltiesLabel.AutoSize = true;
            lblStatPenaltiesLabel.Font = new Font("Poppins", 8F);
            lblStatPenaltiesLabel.ForeColor = Color.FromArgb(122, 122, 128);
            lblStatPenaltiesLabel.Location = new Point(71, 50);
            lblStatPenaltiesLabel.Name = "lblStatPenaltiesLabel";
            lblStatPenaltiesLabel.Size = new Size(126, 25);
            lblStatPenaltiesLabel.TabIndex = 2;
            lblStatPenaltiesLabel.Text = "Unpaid Penalties";
            // 
            // pnlStatPenaltiesIcon
            // 
            pnlStatPenaltiesIcon.BackColor = Color.FromArgb(255, 237, 237);
            pnlStatPenaltiesIcon.Controls.Add(iconStatPenalties);
            pnlStatPenaltiesIcon.Location = new Point(18, 22);
            pnlStatPenaltiesIcon.Name = "pnlStatPenaltiesIcon";
            pnlStatPenaltiesIcon.Size = new Size(44, 44);
            pnlStatPenaltiesIcon.TabIndex = 0;
            // 
            // iconStatPenalties
            // 
            iconStatPenalties.BackColor = Color.Transparent;
            iconStatPenalties.ForeColor = Color.FromArgb(220, 60, 60);
            iconStatPenalties.IconChar = IconChar.Warning;
            iconStatPenalties.IconColor = Color.FromArgb(220, 60, 60);
            iconStatPenalties.IconFont = IconFont.Auto;
            iconStatPenalties.IconSize = 22;
            iconStatPenalties.Location = new Point(11, 11);
            iconStatPenalties.Name = "iconStatPenalties";
            iconStatPenalties.Size = new Size(22, 22);
            iconStatPenalties.TabIndex = 0;
            iconStatPenalties.TabStop = false;
            // 
            // lblStatPenaltiesCount
            // 
            lblStatPenaltiesCount.AutoSize = true;
            lblStatPenaltiesCount.Font = new Font("Poppins", 15F, FontStyle.Bold);
            lblStatPenaltiesCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatPenaltiesCount.Location = new Point(70, 14);
            lblStatPenaltiesCount.Name = "lblStatPenaltiesCount";
            lblStatPenaltiesCount.Size = new Size(35, 44);
            lblStatPenaltiesCount.TabIndex = 1;
            lblStatPenaltiesCount.Text = "0";
            // 
            // cardFilter
            // 
            cardFilter.BackColor = Color.White;
            cardFilter.Controls.Add(pnlFilterIconBox);
            cardFilter.Controls.Add(lblFilterTitle);
            cardFilter.Controls.Add(dividerFilter);
            cardFilter.Controls.Add(lblReportType);
            cardFilter.Controls.Add(cmbReportType);
            cardFilter.Controls.Add(lblDateFrom);
            cardFilter.Controls.Add(dtpDateFrom);
            cardFilter.Controls.Add(lblDateTo);
            cardFilter.Controls.Add(dtpDateTo);
            cardFilter.Controls.Add(lblSchoolYear);
            cardFilter.Controls.Add(cmbSchoolYear);
            cardFilter.Controls.Add(lblSemester);
            cardFilter.Controls.Add(cmbSemester);
            cardFilter.Controls.Add(btnGenerateReport);
            cardFilter.Controls.Add(btnResetFilter);
            cardFilter.Controls.Add(btnExportCsv);
            cardFilter.Controls.Add(btnExportPdf);
            cardFilter.Location = new Point(30, 148);
            cardFilter.Name = "cardFilter";
            cardFilter.Padding = new Padding(28, 24, 28, 28);
            cardFilter.Size = new Size(878, 230);
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
            iconFilter.IconChar = IconChar.BarChart;
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
            lblFilterTitle.Size = new Size(201, 34);
            lblFilterTitle.TabIndex = 1;
            lblFilterTitle.Text = "Report Parameters";
            // 
            // dividerFilter
            // 
            dividerFilter.BackColor = Color.FromArgb(236, 230, 222);
            dividerFilter.Location = new Point(28, 78);
            dividerFilter.Name = "dividerFilter";
            dividerFilter.Size = new Size(822, 1);
            dividerFilter.TabIndex = 2;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblReportType.ForeColor = Color.FromArgb(52, 52, 58);
            lblReportType.Location = new Point(31, 90);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(103, 26);
            lblReportType.TabIndex = 3;
            lblReportType.Text = "Report Type";
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.FromArgb(250, 250, 252);
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FlatStyle = FlatStyle.Flat;
            cmbReportType.Font = new Font("Poppins", 9.5F);
            cmbReportType.ForeColor = Color.FromArgb(20, 20, 20);
            cmbReportType.Items.AddRange(new object[] { "(All Reports)", "Membership Summary", "Fee Collection", "Penalty Summary", "Attendance Summary", "Clearance Summary" });
            cmbReportType.Location = new Point(28, 116);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(269, 36);
            cmbReportType.TabIndex = 4;
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDateFrom.ForeColor = Color.FromArgb(52, 52, 58);
            lblDateFrom.Location = new Point(31, 168);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(91, 26);
            lblDateFrom.TabIndex = 9;
            lblDateFrom.Text = "Date From";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Font = new Font("Poppins", 9.5F);
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(28, 192);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(176, 31);
            dtpDateFrom.TabIndex = 10;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblDateTo.ForeColor = Color.FromArgb(52, 52, 58);
            lblDateTo.Location = new Point(221, 168);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(70, 26);
            lblDateTo.TabIndex = 11;
            lblDateTo.Text = "Date To";
            // 
            // dtpDateTo
            // 
            dtpDateTo.Font = new Font("Poppins", 9.5F);
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(218, 192);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(176, 31);
            dtpDateTo.TabIndex = 12;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblSchoolYear.ForeColor = Color.FromArgb(52, 52, 58);
            lblSchoolYear.Location = new Point(342, 90);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(102, 26);
            lblSchoolYear.TabIndex = 5;
            lblSchoolYear.Text = "School Year";
            // 
            // cmbSchoolYear
            // 
            cmbSchoolYear.BackColor = Color.FromArgb(250, 250, 252);
            cmbSchoolYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSchoolYear.FlatStyle = FlatStyle.Flat;
            cmbSchoolYear.Font = new Font("Poppins", 9.5F);
            cmbSchoolYear.ForeColor = Color.FromArgb(20, 20, 20);
            cmbSchoolYear.Items.AddRange(new object[] { "(All Years)", "2021-2022", "2022-2023", "2023-2024", "2024-2025", "2025-2026" });
            cmbSchoolYear.Location = new Point(342, 116);
            cmbSchoolYear.Name = "cmbSchoolYear";
            cmbSchoolYear.Size = new Size(243, 36);
            cmbSchoolYear.TabIndex = 6;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblSemester.ForeColor = Color.FromArgb(52, 52, 58);
            lblSemester.Location = new Point(629, 90);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(84, 26);
            lblSemester.TabIndex = 7;
            lblSemester.Text = "Semester";
            // 
            // cmbSemester
            // 
            cmbSemester.BackColor = Color.FromArgb(250, 250, 252);
            cmbSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemester.FlatStyle = FlatStyle.Flat;
            cmbSemester.Font = new Font("Poppins", 9.5F);
            cmbSemester.ForeColor = Color.FromArgb(20, 20, 20);
            cmbSemester.Items.AddRange(new object[] { "(All Semesters)", "1st Semester", "2nd Semester", "Summer" });
            cmbSemester.Location = new Point(629, 116);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(221, 36);
            cmbSemester.TabIndex = 8;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(58, 99, 232);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.IconChar = IconChar.Play;
            btnGenerateReport.IconColor = Color.White;
            btnGenerateReport.IconFont = IconFont.Auto;
            btnGenerateReport.IconSize = 16;
            btnGenerateReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerateReport.Location = new Point(414, 186);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Padding = new Padding(10, 0, 0, 0);
            btnGenerateReport.Size = new Size(160, 36);
            btnGenerateReport.TabIndex = 13;
            btnGenerateReport.Text = "Generate";
            btnGenerateReport.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerateReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerateReport.UseVisualStyleBackColor = false;
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
            btnResetFilter.Location = new Point(584, 186);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Padding = new Padding(10, 0, 0, 0);
            btnResetFilter.Size = new Size(104, 36);
            btnResetFilter.TabIndex = 14;
            btnResetFilter.Text = "Reset";
            btnResetFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnResetFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetFilter.UseVisualStyleBackColor = false;
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
            btnExportCsv.Location = new Point(698, 186);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Padding = new Padding(8, 0, 0, 0);
            btnExportCsv.Size = new Size(72, 36);
            btnExportCsv.TabIndex = 15;
            btnExportCsv.Text = "CSV";
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
            btnExportPdf.Location = new Point(778, 186);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Padding = new Padding(8, 0, 0, 0);
            btnExportPdf.Size = new Size(72, 36);
            btnExportPdf.TabIndex = 16;
            btnExportPdf.Text = "PDF";
            btnExportPdf.TextAlign = ContentAlignment.MiddleLeft;
            btnExportPdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // cardMembership
            // 
            cardMembership.BackColor = Color.White;
            cardMembership.Controls.Add(pnlMemIconBox);
            cardMembership.Controls.Add(lblMemTitle);
            cardMembership.Controls.Add(dividerMem);
            cardMembership.Controls.Add(lblMemResultCount);
            cardMembership.Controls.Add(dgvMembership);
            cardMembership.Location = new Point(30, 408);
            cardMembership.Name = "cardMembership";
            cardMembership.Padding = new Padding(28, 24, 28, 28);
            cardMembership.Size = new Size(878, 520);
            cardMembership.TabIndex = 2;
            // 
            // pnlMemIconBox
            // 
            pnlMemIconBox.BackColor = Color.FromArgb(233, 239, 255);
            pnlMemIconBox.Controls.Add(iconMem);
            pnlMemIconBox.Location = new Point(28, 24);
            pnlMemIconBox.Name = "pnlMemIconBox";
            pnlMemIconBox.Size = new Size(44, 44);
            pnlMemIconBox.TabIndex = 0;
            // 
            // iconMem
            // 
            iconMem.BackColor = Color.Transparent;
            iconMem.ForeColor = Color.FromArgb(58, 99, 232);
            iconMem.IconChar = IconChar.DriversLicense;
            iconMem.IconColor = Color.FromArgb(58, 99, 232);
            iconMem.IconFont = IconFont.Auto;
            iconMem.IconSize = 22;
            iconMem.Location = new Point(11, 11);
            iconMem.Name = "iconMem";
            iconMem.Size = new Size(22, 22);
            iconMem.TabIndex = 0;
            iconMem.TabStop = false;
            // 
            // lblMemTitle
            // 
            lblMemTitle.AutoSize = true;
            lblMemTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblMemTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblMemTitle.Location = new Point(82, 30);
            lblMemTitle.Name = "lblMemTitle";
            lblMemTitle.Size = new Size(242, 34);
            lblMemTitle.TabIndex = 1;
            lblMemTitle.Text = "Membership Summary";
            // 
            // dividerMem
            // 
            dividerMem.BackColor = Color.FromArgb(236, 230, 222);
            dividerMem.Location = new Point(28, 78);
            dividerMem.Name = "dividerMem";
            dividerMem.Size = new Size(822, 1);
            dividerMem.TabIndex = 2;
            // 
            // lblMemResultCount
            // 
            lblMemResultCount.AutoSize = true;
            lblMemResultCount.Font = new Font("Poppins", 8.5F);
            lblMemResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblMemResultCount.Location = new Point(31, 90);
            lblMemResultCount.Name = "lblMemResultCount";
            lblMemResultCount.Size = new Size(152, 26);
            lblMemResultCount.TabIndex = 3;
            lblMemResultCount.Text = "Showing 0 records";
            // 
            // dgvMembership
            // 
            dgvMembership.AllowUserToAddRows = false;
            dgvMembership.AllowUserToDeleteRows = false;
            dgvMembership.AllowUserToResizeRows = false;
            dgvMembership.BackgroundColor = Color.White;
            dgvMembership.BorderStyle = BorderStyle.None;
            dgvMembership.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(122, 122, 128);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembership.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembership.ColumnHeadersHeight = 38;
            dgvMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMembership.Columns.AddRange(new DataGridViewColumn[] { colMemId, colMemStudentName, colMemStudentNo, colMemType, colMemStatus, colMemStartDate, colMemEndDate, colMemFeePaid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(52, 52, 58);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMembership.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMembership.EnableHeadersVisualStyles = false;
            dgvMembership.GridColor = Color.FromArgb(236, 230, 222);
            dgvMembership.Location = new Point(28, 120);
            dgvMembership.Name = "dgvMembership";
            dgvMembership.ReadOnly = true;
            dgvMembership.RowHeadersVisible = false;
            dgvMembership.RowHeadersWidth = 51;
            dgvMembership.RowTemplate.Height = 38;
            dgvMembership.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembership.Size = new Size(822, 368);
            dgvMembership.TabIndex = 4;
            // 
            // colMemId
            // 
            colMemId.HeaderText = "#";
            colMemId.MinimumWidth = 6;
            colMemId.Name = "colMemId";
            colMemId.ReadOnly = true;
            colMemId.Resizable = DataGridViewTriState.False;
            colMemId.Width = 46;
            // 
            // colMemStudentName
            // 
            colMemStudentName.HeaderText = "Student Name";
            colMemStudentName.MinimumWidth = 6;
            colMemStudentName.Name = "colMemStudentName";
            colMemStudentName.ReadOnly = true;
            colMemStudentName.Width = 180;
            // 
            // colMemStudentNo
            // 
            colMemStudentNo.HeaderText = "Student No.";
            colMemStudentNo.MinimumWidth = 6;
            colMemStudentNo.Name = "colMemStudentNo";
            colMemStudentNo.ReadOnly = true;
            colMemStudentNo.Width = 110;
            // 
            // colMemType
            // 
            colMemType.HeaderText = "Type";
            colMemType.MinimumWidth = 6;
            colMemType.Name = "colMemType";
            colMemType.ReadOnly = true;
            colMemType.Width = 125;
            // 
            // colMemStatus
            // 
            colMemStatus.HeaderText = "Status";
            colMemStatus.MinimumWidth = 6;
            colMemStatus.Name = "colMemStatus";
            colMemStatus.ReadOnly = true;
            colMemStatus.Width = 125;
            // 
            // colMemStartDate
            // 
            colMemStartDate.HeaderText = "Start Date";
            colMemStartDate.MinimumWidth = 6;
            colMemStartDate.Name = "colMemStartDate";
            colMemStartDate.ReadOnly = true;
            colMemStartDate.Width = 125;
            // 
            // colMemEndDate
            // 
            colMemEndDate.HeaderText = "End Date";
            colMemEndDate.MinimumWidth = 6;
            colMemEndDate.Name = "colMemEndDate";
            colMemEndDate.ReadOnly = true;
            colMemEndDate.Width = 125;
            // 
            // colMemFeePaid
            // 
            colMemFeePaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMemFeePaid.HeaderText = "Fee Paid";
            colMemFeePaid.MinimumWidth = 6;
            colMemFeePaid.Name = "colMemFeePaid";
            colMemFeePaid.ReadOnly = true;
            // 
            // cardFees
            // 
            cardFees.BackColor = Color.White;
            cardFees.Controls.Add(pnlFeeIconBox);
            cardFees.Controls.Add(lblFeeTitle);
            cardFees.Controls.Add(dividerFee);
            cardFees.Controls.Add(pnlFeeSummaryBar);
            cardFees.Controls.Add(lblFeeResultCount);
            cardFees.Controls.Add(dgvFees);
            cardFees.Location = new Point(30, 958);
            cardFees.Name = "cardFees";
            cardFees.Padding = new Padding(28, 24, 28, 28);
            cardFees.Size = new Size(878, 580);
            cardFees.TabIndex = 3;
            // 
            // pnlFeeIconBox
            // 
            pnlFeeIconBox.BackColor = Color.FromArgb(243, 255, 230);
            pnlFeeIconBox.Controls.Add(iconFee);
            pnlFeeIconBox.Location = new Point(28, 24);
            pnlFeeIconBox.Name = "pnlFeeIconBox";
            pnlFeeIconBox.Size = new Size(44, 44);
            pnlFeeIconBox.TabIndex = 0;
            // 
            // iconFee
            // 
            iconFee.BackColor = Color.Transparent;
            iconFee.ForeColor = Color.FromArgb(80, 160, 30);
            iconFee.IconChar = IconChar.MoneyBillWave;
            iconFee.IconColor = Color.FromArgb(80, 160, 30);
            iconFee.IconFont = IconFont.Auto;
            iconFee.IconSize = 22;
            iconFee.Location = new Point(11, 11);
            iconFee.Name = "iconFee";
            iconFee.Size = new Size(22, 22);
            iconFee.TabIndex = 0;
            iconFee.TabStop = false;
            // 
            // lblFeeTitle
            // 
            lblFeeTitle.AutoSize = true;
            lblFeeTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblFeeTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblFeeTitle.Location = new Point(82, 30);
            lblFeeTitle.Name = "lblFeeTitle";
            lblFeeTitle.Size = new Size(222, 34);
            lblFeeTitle.TabIndex = 1;
            lblFeeTitle.Text = "Fee Collection Report";
            // 
            // dividerFee
            // 
            dividerFee.BackColor = Color.FromArgb(236, 230, 222);
            dividerFee.Location = new Point(28, 78);
            dividerFee.Name = "dividerFee";
            dividerFee.Size = new Size(822, 1);
            dividerFee.TabIndex = 2;
            // 
            // pnlFeeSummaryBar
            // 
            pnlFeeSummaryBar.BackColor = Color.Transparent;
            pnlFeeSummaryBar.Controls.Add(pnlFeeSumCollected);
            pnlFeeSummaryBar.Controls.Add(pnlFeeSumPending);
            pnlFeeSummaryBar.Controls.Add(pnlFeeSumOverdue);
            pnlFeeSummaryBar.Location = new Point(28, 90);
            pnlFeeSummaryBar.Name = "pnlFeeSummaryBar";
            pnlFeeSummaryBar.Size = new Size(822, 72);
            pnlFeeSummaryBar.TabIndex = 3;
            // 
            // pnlFeeSumCollected
            // 
            pnlFeeSumCollected.BackColor = Color.FromArgb(230, 255, 242);
            pnlFeeSumCollected.Controls.Add(iconFeeSumCollected);
            pnlFeeSumCollected.Controls.Add(lblFeeSumCollectedLbl);
            pnlFeeSumCollected.Controls.Add(lblFeeSumCollectedAmt);
            pnlFeeSumCollected.Location = new Point(0, 0);
            pnlFeeSumCollected.Name = "pnlFeeSumCollected";
            pnlFeeSumCollected.Size = new Size(260, 72);
            pnlFeeSumCollected.TabIndex = 0;
            // 
            // iconFeeSumCollected
            // 
            iconFeeSumCollected.BackColor = Color.Transparent;
            iconFeeSumCollected.ForeColor = Color.FromArgb(16, 163, 92);
            iconFeeSumCollected.IconChar = IconChar.CheckCircle;
            iconFeeSumCollected.IconColor = Color.FromArgb(16, 163, 92);
            iconFeeSumCollected.IconFont = IconFont.Auto;
            iconFeeSumCollected.IconSize = 24;
            iconFeeSumCollected.Location = new Point(14, 24);
            iconFeeSumCollected.Name = "iconFeeSumCollected";
            iconFeeSumCollected.Size = new Size(24, 24);
            iconFeeSumCollected.TabIndex = 0;
            iconFeeSumCollected.TabStop = false;
            // 
            // lblFeeSumCollectedLbl
            // 
            lblFeeSumCollectedLbl.AutoSize = true;
            lblFeeSumCollectedLbl.Font = new Font("Poppins", 8F);
            lblFeeSumCollectedLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblFeeSumCollectedLbl.Location = new Point(48, 44);
            lblFeeSumCollectedLbl.Name = "lblFeeSumCollectedLbl";
            lblFeeSumCollectedLbl.Size = new Size(117, 25);
            lblFeeSumCollectedLbl.TabIndex = 2;
            lblFeeSumCollectedLbl.Text = "Total Collected";
            // 
            // lblFeeSumCollectedAmt
            // 
            lblFeeSumCollectedAmt.AutoSize = true;
            lblFeeSumCollectedAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblFeeSumCollectedAmt.ForeColor = Color.FromArgb(16, 163, 92);
            lblFeeSumCollectedAmt.Location = new Point(48, 12);
            lblFeeSumCollectedAmt.Name = "lblFeeSumCollectedAmt";
            lblFeeSumCollectedAmt.Size = new Size(84, 39);
            lblFeeSumCollectedAmt.TabIndex = 1;
            lblFeeSumCollectedAmt.Text = "₱0.00";
            // 
            // pnlFeeSumPending
            // 
            pnlFeeSumPending.BackColor = Color.FromArgb(255, 248, 225);
            pnlFeeSumPending.Controls.Add(iconFeeSumPending);
            pnlFeeSumPending.Controls.Add(lblFeeSumPendingLbl);
            pnlFeeSumPending.Controls.Add(lblFeeSumPendingAmt);
            pnlFeeSumPending.Location = new Point(280, 0);
            pnlFeeSumPending.Name = "pnlFeeSumPending";
            pnlFeeSumPending.Size = new Size(260, 72);
            pnlFeeSumPending.TabIndex = 1;
            // 
            // iconFeeSumPending
            // 
            iconFeeSumPending.BackColor = Color.Transparent;
            iconFeeSumPending.ForeColor = Color.FromArgb(200, 140, 0);
            iconFeeSumPending.IconChar = IconChar.Hourglass2;
            iconFeeSumPending.IconColor = Color.FromArgb(200, 140, 0);
            iconFeeSumPending.IconFont = IconFont.Auto;
            iconFeeSumPending.IconSize = 24;
            iconFeeSumPending.Location = new Point(14, 24);
            iconFeeSumPending.Name = "iconFeeSumPending";
            iconFeeSumPending.Size = new Size(24, 24);
            iconFeeSumPending.TabIndex = 0;
            iconFeeSumPending.TabStop = false;
            // 
            // lblFeeSumPendingLbl
            // 
            lblFeeSumPendingLbl.AutoSize = true;
            lblFeeSumPendingLbl.Font = new Font("Poppins", 8F);
            lblFeeSumPendingLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblFeeSumPendingLbl.Location = new Point(48, 44);
            lblFeeSumPendingLbl.Name = "lblFeeSumPendingLbl";
            lblFeeSumPendingLbl.Size = new Size(129, 25);
            lblFeeSumPendingLbl.TabIndex = 2;
            lblFeeSumPendingLbl.Text = "Pending Balance";
            // 
            // lblFeeSumPendingAmt
            // 
            lblFeeSumPendingAmt.AutoSize = true;
            lblFeeSumPendingAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblFeeSumPendingAmt.ForeColor = Color.FromArgb(200, 140, 0);
            lblFeeSumPendingAmt.Location = new Point(48, 12);
            lblFeeSumPendingAmt.Name = "lblFeeSumPendingAmt";
            lblFeeSumPendingAmt.Size = new Size(84, 39);
            lblFeeSumPendingAmt.TabIndex = 1;
            lblFeeSumPendingAmt.Text = "₱0.00";
            // 
            // pnlFeeSumOverdue
            // 
            pnlFeeSumOverdue.BackColor = Color.FromArgb(255, 237, 237);
            pnlFeeSumOverdue.Controls.Add(iconFeeSumOverdue);
            pnlFeeSumOverdue.Controls.Add(lblFeeSumOverdueLbl);
            pnlFeeSumOverdue.Controls.Add(lblFeeSumOverdueAmt);
            pnlFeeSumOverdue.Location = new Point(560, 0);
            pnlFeeSumOverdue.Name = "pnlFeeSumOverdue";
            pnlFeeSumOverdue.Size = new Size(260, 72);
            pnlFeeSumOverdue.TabIndex = 2;
            // 
            // iconFeeSumOverdue
            // 
            iconFeeSumOverdue.BackColor = Color.Transparent;
            iconFeeSumOverdue.ForeColor = Color.FromArgb(220, 60, 60);
            iconFeeSumOverdue.IconChar = IconChar.CircleExclamation;
            iconFeeSumOverdue.IconColor = Color.FromArgb(220, 60, 60);
            iconFeeSumOverdue.IconFont = IconFont.Auto;
            iconFeeSumOverdue.IconSize = 24;
            iconFeeSumOverdue.Location = new Point(14, 24);
            iconFeeSumOverdue.Name = "iconFeeSumOverdue";
            iconFeeSumOverdue.Size = new Size(24, 24);
            iconFeeSumOverdue.TabIndex = 0;
            iconFeeSumOverdue.TabStop = false;
            // 
            // lblFeeSumOverdueLbl
            // 
            lblFeeSumOverdueLbl.AutoSize = true;
            lblFeeSumOverdueLbl.Font = new Font("Poppins", 8F);
            lblFeeSumOverdueLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblFeeSumOverdueLbl.Location = new Point(48, 44);
            lblFeeSumOverdueLbl.Name = "lblFeeSumOverdueLbl";
            lblFeeSumOverdueLbl.Size = new Size(135, 25);
            lblFeeSumOverdueLbl.TabIndex = 2;
            lblFeeSumOverdueLbl.Text = "Overdue / Unpaid";
            // 
            // lblFeeSumOverdueAmt
            // 
            lblFeeSumOverdueAmt.AutoSize = true;
            lblFeeSumOverdueAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblFeeSumOverdueAmt.ForeColor = Color.FromArgb(220, 60, 60);
            lblFeeSumOverdueAmt.Location = new Point(48, 12);
            lblFeeSumOverdueAmt.Name = "lblFeeSumOverdueAmt";
            lblFeeSumOverdueAmt.Size = new Size(84, 39);
            lblFeeSumOverdueAmt.TabIndex = 1;
            lblFeeSumOverdueAmt.Text = "₱0.00";
            // 
            // lblFeeResultCount
            // 
            lblFeeResultCount.AutoSize = true;
            lblFeeResultCount.Font = new Font("Poppins", 8.5F);
            lblFeeResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblFeeResultCount.Location = new Point(31, 174);
            lblFeeResultCount.Name = "lblFeeResultCount";
            lblFeeResultCount.Size = new Size(152, 26);
            lblFeeResultCount.TabIndex = 4;
            lblFeeResultCount.Text = "Showing 0 records";
            // 
            // dgvFees
            // 
            dgvFees.AllowUserToAddRows = false;
            dgvFees.AllowUserToDeleteRows = false;
            dgvFees.AllowUserToResizeRows = false;
            dgvFees.BackgroundColor = Color.White;
            dgvFees.BorderStyle = BorderStyle.None;
            dgvFees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFees.ColumnHeadersHeight = 38;
            dgvFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvFees.Columns.AddRange(new DataGridViewColumn[] { colFeeId, colFeeStudentName, colFeeStudentNo, colFeePolicyName, colFeeAmount, colFeeAmountPaid, colFeeBalance, colFeeStatus, colFeePaymentDate, colFeeOR });
            dgvFees.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFees.EnableHeadersVisualStyles = false;
            dgvFees.GridColor = Color.FromArgb(236, 230, 222);
            dgvFees.Location = new Point(28, 200);
            dgvFees.Name = "dgvFees";
            dgvFees.ReadOnly = true;
            dgvFees.RowHeadersVisible = false;
            dgvFees.RowHeadersWidth = 51;
            dgvFees.RowTemplate.Height = 38;
            dgvFees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFees.Size = new Size(822, 352);
            dgvFees.TabIndex = 5;
            // 
            // colFeeId
            // 
            colFeeId.HeaderText = "#";
            colFeeId.MinimumWidth = 6;
            colFeeId.Name = "colFeeId";
            colFeeId.ReadOnly = true;
            colFeeId.Resizable = DataGridViewTriState.False;
            colFeeId.Width = 46;
            // 
            // colFeeStudentName
            // 
            colFeeStudentName.HeaderText = "Student Name";
            colFeeStudentName.MinimumWidth = 6;
            colFeeStudentName.Name = "colFeeStudentName";
            colFeeStudentName.ReadOnly = true;
            colFeeStudentName.Width = 170;
            // 
            // colFeeStudentNo
            // 
            colFeeStudentNo.HeaderText = "Student No.";
            colFeeStudentNo.MinimumWidth = 6;
            colFeeStudentNo.Name = "colFeeStudentNo";
            colFeeStudentNo.ReadOnly = true;
            colFeeStudentNo.Width = 125;
            // 
            // colFeePolicyName
            // 
            colFeePolicyName.HeaderText = "Policy";
            colFeePolicyName.MinimumWidth = 6;
            colFeePolicyName.Name = "colFeePolicyName";
            colFeePolicyName.ReadOnly = true;
            colFeePolicyName.Width = 125;
            // 
            // colFeeAmount
            // 
            colFeeAmount.HeaderText = "Amount Due";
            colFeeAmount.MinimumWidth = 6;
            colFeeAmount.Name = "colFeeAmount";
            colFeeAmount.ReadOnly = true;
            colFeeAmount.Width = 96;
            // 
            // colFeeAmountPaid
            // 
            colFeeAmountPaid.HeaderText = "Paid";
            colFeeAmountPaid.MinimumWidth = 6;
            colFeeAmountPaid.Name = "colFeeAmountPaid";
            colFeeAmountPaid.ReadOnly = true;
            colFeeAmountPaid.Width = 80;
            // 
            // colFeeBalance
            // 
            colFeeBalance.HeaderText = "Balance";
            colFeeBalance.MinimumWidth = 6;
            colFeeBalance.Name = "colFeeBalance";
            colFeeBalance.ReadOnly = true;
            colFeeBalance.Width = 80;
            // 
            // colFeeStatus
            // 
            colFeeStatus.HeaderText = "Status";
            colFeeStatus.MinimumWidth = 6;
            colFeeStatus.Name = "colFeeStatus";
            colFeeStatus.ReadOnly = true;
            colFeeStatus.Width = 88;
            // 
            // colFeePaymentDate
            // 
            colFeePaymentDate.HeaderText = "Payment Date";
            colFeePaymentDate.MinimumWidth = 6;
            colFeePaymentDate.Name = "colFeePaymentDate";
            colFeePaymentDate.ReadOnly = true;
            colFeePaymentDate.Width = 110;
            // 
            // colFeeOR
            // 
            colFeeOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFeeOR.HeaderText = "OR Number";
            colFeeOR.MinimumWidth = 6;
            colFeeOR.Name = "colFeeOR";
            colFeeOR.ReadOnly = true;
            // 
            // cardPenalties
            // 
            cardPenalties.BackColor = Color.White;
            cardPenalties.Controls.Add(pnlPenIconBox);
            cardPenalties.Controls.Add(lblPenTitle);
            cardPenalties.Controls.Add(dividerPen);
            cardPenalties.Controls.Add(pnlPenSummaryBar);
            cardPenalties.Controls.Add(lblPenResultCount);
            cardPenalties.Controls.Add(dgvPenalties);
            cardPenalties.Location = new Point(30, 1568);
            cardPenalties.Name = "cardPenalties";
            cardPenalties.Padding = new Padding(28, 24, 28, 28);
            cardPenalties.Size = new Size(878, 540);
            cardPenalties.TabIndex = 4;
            // 
            // pnlPenIconBox
            // 
            pnlPenIconBox.BackColor = Color.FromArgb(255, 237, 237);
            pnlPenIconBox.Controls.Add(iconPen);
            pnlPenIconBox.Location = new Point(28, 24);
            pnlPenIconBox.Name = "pnlPenIconBox";
            pnlPenIconBox.Size = new Size(44, 44);
            pnlPenIconBox.TabIndex = 0;
            // 
            // iconPen
            // 
            iconPen.BackColor = Color.Transparent;
            iconPen.ForeColor = Color.FromArgb(220, 60, 60);
            iconPen.IconChar = IconChar.Warning;
            iconPen.IconColor = Color.FromArgb(220, 60, 60);
            iconPen.IconFont = IconFont.Auto;
            iconPen.IconSize = 22;
            iconPen.Location = new Point(11, 11);
            iconPen.Name = "iconPen";
            iconPen.Size = new Size(22, 22);
            iconPen.TabIndex = 0;
            iconPen.TabStop = false;
            // 
            // lblPenTitle
            // 
            lblPenTitle.AutoSize = true;
            lblPenTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblPenTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblPenTitle.Location = new Point(82, 30);
            lblPenTitle.Name = "lblPenTitle";
            lblPenTitle.Size = new Size(193, 34);
            lblPenTitle.TabIndex = 1;
            lblPenTitle.Text = "Penalty Summary";
            // 
            // dividerPen
            // 
            dividerPen.BackColor = Color.FromArgb(236, 230, 222);
            dividerPen.Location = new Point(28, 78);
            dividerPen.Name = "dividerPen";
            dividerPen.Size = new Size(822, 1);
            dividerPen.TabIndex = 2;
            // 
            // pnlPenSummaryBar
            // 
            pnlPenSummaryBar.BackColor = Color.Transparent;
            pnlPenSummaryBar.Controls.Add(pnlPenSumTotal);
            pnlPenSummaryBar.Controls.Add(pnlPenSumPaid);
            pnlPenSummaryBar.Controls.Add(pnlPenSumUnpaid);
            pnlPenSummaryBar.Location = new Point(28, 90);
            pnlPenSummaryBar.Name = "pnlPenSummaryBar";
            pnlPenSummaryBar.Size = new Size(822, 72);
            pnlPenSummaryBar.TabIndex = 3;
            // 
            // pnlPenSumTotal
            // 
            pnlPenSumTotal.BackColor = Color.FromArgb(233, 239, 255);
            pnlPenSumTotal.Controls.Add(iconPenSumTotal);
            pnlPenSumTotal.Controls.Add(lblPenSumTotalLbl);
            pnlPenSumTotal.Controls.Add(lblPenSumTotalAmt);
            pnlPenSumTotal.Location = new Point(0, 0);
            pnlPenSumTotal.Name = "pnlPenSumTotal";
            pnlPenSumTotal.Size = new Size(260, 72);
            pnlPenSumTotal.TabIndex = 0;
            // 
            // iconPenSumTotal
            // 
            iconPenSumTotal.BackColor = Color.Transparent;
            iconPenSumTotal.ForeColor = Color.FromArgb(58, 99, 232);
            iconPenSumTotal.IconChar = IconChar.List12;
            iconPenSumTotal.IconColor = Color.FromArgb(58, 99, 232);
            iconPenSumTotal.IconFont = IconFont.Auto;
            iconPenSumTotal.IconSize = 24;
            iconPenSumTotal.Location = new Point(14, 24);
            iconPenSumTotal.Name = "iconPenSumTotal";
            iconPenSumTotal.Size = new Size(24, 24);
            iconPenSumTotal.TabIndex = 0;
            iconPenSumTotal.TabStop = false;
            // 
            // lblPenSumTotalLbl
            // 
            lblPenSumTotalLbl.AutoSize = true;
            lblPenSumTotalLbl.Font = new Font("Poppins", 8F);
            lblPenSumTotalLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblPenSumTotalLbl.Location = new Point(48, 44);
            lblPenSumTotalLbl.Name = "lblPenSumTotalLbl";
            lblPenSumTotalLbl.Size = new Size(160, 25);
            lblPenSumTotalLbl.TabIndex = 2;
            lblPenSumTotalLbl.Text = "Total Penalties Issued";
            // 
            // lblPenSumTotalAmt
            // 
            lblPenSumTotalAmt.AutoSize = true;
            lblPenSumTotalAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblPenSumTotalAmt.ForeColor = Color.FromArgb(58, 99, 232);
            lblPenSumTotalAmt.Location = new Point(48, 12);
            lblPenSumTotalAmt.Name = "lblPenSumTotalAmt";
            lblPenSumTotalAmt.Size = new Size(84, 39);
            lblPenSumTotalAmt.TabIndex = 1;
            lblPenSumTotalAmt.Text = "₱0.00";
            // 
            // pnlPenSumPaid
            // 
            pnlPenSumPaid.BackColor = Color.FromArgb(230, 255, 242);
            pnlPenSumPaid.Controls.Add(iconPenSumPaid);
            pnlPenSumPaid.Controls.Add(lblPenSumPaidLbl);
            pnlPenSumPaid.Controls.Add(lblPenSumPaidAmt);
            pnlPenSumPaid.Location = new Point(280, 0);
            pnlPenSumPaid.Name = "pnlPenSumPaid";
            pnlPenSumPaid.Size = new Size(260, 72);
            pnlPenSumPaid.TabIndex = 1;
            // 
            // iconPenSumPaid
            // 
            iconPenSumPaid.BackColor = Color.Transparent;
            iconPenSumPaid.ForeColor = Color.FromArgb(16, 163, 92);
            iconPenSumPaid.IconChar = IconChar.CheckDouble;
            iconPenSumPaid.IconColor = Color.FromArgb(16, 163, 92);
            iconPenSumPaid.IconFont = IconFont.Auto;
            iconPenSumPaid.IconSize = 24;
            iconPenSumPaid.Location = new Point(14, 24);
            iconPenSumPaid.Name = "iconPenSumPaid";
            iconPenSumPaid.Size = new Size(24, 24);
            iconPenSumPaid.TabIndex = 0;
            iconPenSumPaid.TabStop = false;
            // 
            // lblPenSumPaidLbl
            // 
            lblPenSumPaidLbl.AutoSize = true;
            lblPenSumPaidLbl.Font = new Font("Poppins", 8F);
            lblPenSumPaidLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblPenSumPaidLbl.Location = new Point(48, 44);
            lblPenSumPaidLbl.Name = "lblPenSumPaidLbl";
            lblPenSumPaidLbl.Size = new Size(119, 25);
            lblPenSumPaidLbl.TabIndex = 2;
            lblPenSumPaidLbl.Text = "Amount Settled";
            // 
            // lblPenSumPaidAmt
            // 
            lblPenSumPaidAmt.AutoSize = true;
            lblPenSumPaidAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblPenSumPaidAmt.ForeColor = Color.FromArgb(16, 163, 92);
            lblPenSumPaidAmt.Location = new Point(48, 12);
            lblPenSumPaidAmt.Name = "lblPenSumPaidAmt";
            lblPenSumPaidAmt.Size = new Size(84, 39);
            lblPenSumPaidAmt.TabIndex = 1;
            lblPenSumPaidAmt.Text = "₱0.00";
            // 
            // pnlPenSumUnpaid
            // 
            pnlPenSumUnpaid.BackColor = Color.FromArgb(255, 237, 237);
            pnlPenSumUnpaid.Controls.Add(iconPenSumUnpaid);
            pnlPenSumUnpaid.Controls.Add(lblPenSumUnpaidLbl);
            pnlPenSumUnpaid.Controls.Add(lblPenSumUnpaidAmt);
            pnlPenSumUnpaid.Location = new Point(560, 0);
            pnlPenSumUnpaid.Name = "pnlPenSumUnpaid";
            pnlPenSumUnpaid.Size = new Size(260, 72);
            pnlPenSumUnpaid.TabIndex = 2;
            // 
            // iconPenSumUnpaid
            // 
            iconPenSumUnpaid.BackColor = Color.Transparent;
            iconPenSumUnpaid.ForeColor = Color.FromArgb(220, 60, 60);
            iconPenSumUnpaid.IconChar = IconChar.Cancel;
            iconPenSumUnpaid.IconColor = Color.FromArgb(220, 60, 60);
            iconPenSumUnpaid.IconFont = IconFont.Auto;
            iconPenSumUnpaid.IconSize = 24;
            iconPenSumUnpaid.Location = new Point(14, 24);
            iconPenSumUnpaid.Name = "iconPenSumUnpaid";
            iconPenSumUnpaid.Size = new Size(24, 24);
            iconPenSumUnpaid.TabIndex = 0;
            iconPenSumUnpaid.TabStop = false;
            // 
            // lblPenSumUnpaidLbl
            // 
            lblPenSumUnpaidLbl.AutoSize = true;
            lblPenSumUnpaidLbl.Font = new Font("Poppins", 8F);
            lblPenSumUnpaidLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblPenSumUnpaidLbl.Location = new Point(48, 44);
            lblPenSumUnpaidLbl.Name = "lblPenSumUnpaidLbl";
            lblPenSumUnpaidLbl.Size = new Size(138, 25);
            lblPenSumUnpaidLbl.TabIndex = 2;
            lblPenSumUnpaidLbl.Text = "Remaining Unpaid";
            // 
            // lblPenSumUnpaidAmt
            // 
            lblPenSumUnpaidAmt.AutoSize = true;
            lblPenSumUnpaidAmt.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblPenSumUnpaidAmt.ForeColor = Color.FromArgb(220, 60, 60);
            lblPenSumUnpaidAmt.Location = new Point(48, 12);
            lblPenSumUnpaidAmt.Name = "lblPenSumUnpaidAmt";
            lblPenSumUnpaidAmt.Size = new Size(84, 39);
            lblPenSumUnpaidAmt.TabIndex = 1;
            lblPenSumUnpaidAmt.Text = "₱0.00";
            // 
            // lblPenResultCount
            // 
            lblPenResultCount.AutoSize = true;
            lblPenResultCount.Font = new Font("Poppins", 8.5F);
            lblPenResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblPenResultCount.Location = new Point(31, 174);
            lblPenResultCount.Name = "lblPenResultCount";
            lblPenResultCount.Size = new Size(152, 26);
            lblPenResultCount.TabIndex = 4;
            lblPenResultCount.Text = "Showing 0 records";
            // 
            // dgvPenalties
            // 
            dgvPenalties.AllowUserToAddRows = false;
            dgvPenalties.AllowUserToDeleteRows = false;
            dgvPenalties.AllowUserToResizeRows = false;
            dgvPenalties.BackgroundColor = Color.White;
            dgvPenalties.BorderStyle = BorderStyle.None;
            dgvPenalties.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPenalties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPenalties.ColumnHeadersHeight = 38;
            dgvPenalties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPenalties.Columns.AddRange(new DataGridViewColumn[] { colPenId, colPenStudentName, colPenStudentNo, colPenPolicyName, colPenReason, colPenAmount, colPenAmountPaid, colPenStatus, colPenDateIssued });
            dgvPenalties.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPenalties.EnableHeadersVisualStyles = false;
            dgvPenalties.GridColor = Color.FromArgb(236, 230, 222);
            dgvPenalties.Location = new Point(28, 200);
            dgvPenalties.Name = "dgvPenalties";
            dgvPenalties.ReadOnly = true;
            dgvPenalties.RowHeadersVisible = false;
            dgvPenalties.RowHeadersWidth = 51;
            dgvPenalties.RowTemplate.Height = 38;
            dgvPenalties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenalties.Size = new Size(822, 312);
            dgvPenalties.TabIndex = 5;
            // 
            // colPenId
            // 
            colPenId.HeaderText = "#";
            colPenId.MinimumWidth = 6;
            colPenId.Name = "colPenId";
            colPenId.ReadOnly = true;
            colPenId.Resizable = DataGridViewTriState.False;
            colPenId.Width = 46;
            // 
            // colPenStudentName
            // 
            colPenStudentName.HeaderText = "Student Name";
            colPenStudentName.MinimumWidth = 6;
            colPenStudentName.Name = "colPenStudentName";
            colPenStudentName.ReadOnly = true;
            colPenStudentName.Width = 170;
            // 
            // colPenStudentNo
            // 
            colPenStudentNo.HeaderText = "Student No.";
            colPenStudentNo.MinimumWidth = 6;
            colPenStudentNo.Name = "colPenStudentNo";
            colPenStudentNo.ReadOnly = true;
            colPenStudentNo.Width = 125;
            // 
            // colPenPolicyName
            // 
            colPenPolicyName.HeaderText = "Penalty Policy";
            colPenPolicyName.MinimumWidth = 6;
            colPenPolicyName.Name = "colPenPolicyName";
            colPenPolicyName.ReadOnly = true;
            colPenPolicyName.Width = 120;
            // 
            // colPenReason
            // 
            colPenReason.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPenReason.HeaderText = "Reason";
            colPenReason.MinimumWidth = 6;
            colPenReason.Name = "colPenReason";
            colPenReason.ReadOnly = true;
            // 
            // colPenAmount
            // 
            colPenAmount.HeaderText = "Amount";
            colPenAmount.MinimumWidth = 6;
            colPenAmount.Name = "colPenAmount";
            colPenAmount.ReadOnly = true;
            colPenAmount.Width = 84;
            // 
            // colPenAmountPaid
            // 
            colPenAmountPaid.HeaderText = "Paid";
            colPenAmountPaid.MinimumWidth = 6;
            colPenAmountPaid.Name = "colPenAmountPaid";
            colPenAmountPaid.ReadOnly = true;
            colPenAmountPaid.Width = 80;
            // 
            // colPenStatus
            // 
            colPenStatus.HeaderText = "Status";
            colPenStatus.MinimumWidth = 6;
            colPenStatus.Name = "colPenStatus";
            colPenStatus.ReadOnly = true;
            colPenStatus.Width = 88;
            // 
            // colPenDateIssued
            // 
            colPenDateIssued.HeaderText = "Date Issued";
            colPenDateIssued.MinimumWidth = 6;
            colPenDateIssued.Name = "colPenDateIssued";
            colPenDateIssued.ReadOnly = true;
            colPenDateIssued.Width = 104;
            // 
            // cardAttendance
            // 
            cardAttendance.BackColor = Color.White;
            cardAttendance.Controls.Add(pnlAttIconBox);
            cardAttendance.Controls.Add(lblAttTitle);
            cardAttendance.Controls.Add(dividerAtt);
            cardAttendance.Controls.Add(pnlAttSummaryBar);
            cardAttendance.Controls.Add(lblAttResultCount);
            cardAttendance.Controls.Add(dgvAttendance);
            cardAttendance.Location = new Point(30, 2138);
            cardAttendance.Name = "cardAttendance";
            cardAttendance.Padding = new Padding(28, 24, 28, 28);
            cardAttendance.Size = new Size(878, 540);
            cardAttendance.TabIndex = 5;
            // 
            // pnlAttIconBox
            // 
            pnlAttIconBox.BackColor = Color.FromArgb(243, 230, 255);
            pnlAttIconBox.Controls.Add(iconAtt);
            pnlAttIconBox.Location = new Point(28, 24);
            pnlAttIconBox.Name = "pnlAttIconBox";
            pnlAttIconBox.Size = new Size(44, 44);
            pnlAttIconBox.TabIndex = 0;
            // 
            // iconAtt
            // 
            iconAtt.BackColor = Color.Transparent;
            iconAtt.ForeColor = Color.FromArgb(130, 60, 220);
            iconAtt.IconChar = IconChar.ClipboardUser;
            iconAtt.IconColor = Color.FromArgb(130, 60, 220);
            iconAtt.IconFont = IconFont.Auto;
            iconAtt.IconSize = 22;
            iconAtt.Location = new Point(11, 11);
            iconAtt.Name = "iconAtt";
            iconAtt.Size = new Size(22, 22);
            iconAtt.TabIndex = 0;
            iconAtt.TabStop = false;
            // 
            // lblAttTitle
            // 
            lblAttTitle.AutoSize = true;
            lblAttTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblAttTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblAttTitle.Location = new Point(82, 30);
            lblAttTitle.Name = "lblAttTitle";
            lblAttTitle.Size = new Size(234, 34);
            lblAttTitle.TabIndex = 1;
            lblAttTitle.Text = "Attendance Summary";
            // 
            // dividerAtt
            // 
            dividerAtt.BackColor = Color.FromArgb(236, 230, 222);
            dividerAtt.Location = new Point(28, 78);
            dividerAtt.Name = "dividerAtt";
            dividerAtt.Size = new Size(822, 1);
            dividerAtt.TabIndex = 2;
            // 
            // pnlAttSummaryBar
            // 
            pnlAttSummaryBar.BackColor = Color.Transparent;
            pnlAttSummaryBar.Controls.Add(pnlAttSumPresent);
            pnlAttSummaryBar.Controls.Add(pnlAttSumAbsent);
            pnlAttSummaryBar.Controls.Add(pnlAttSumRate);
            pnlAttSummaryBar.Location = new Point(28, 90);
            pnlAttSummaryBar.Name = "pnlAttSummaryBar";
            pnlAttSummaryBar.Size = new Size(822, 72);
            pnlAttSummaryBar.TabIndex = 3;
            // 
            // pnlAttSumPresent
            // 
            pnlAttSumPresent.BackColor = Color.FromArgb(230, 255, 242);
            pnlAttSumPresent.Controls.Add(iconAttSumPresent);
            pnlAttSumPresent.Controls.Add(lblAttSumPresentLbl);
            pnlAttSumPresent.Controls.Add(lblAttSumPresentCount);
            pnlAttSumPresent.Location = new Point(0, 0);
            pnlAttSumPresent.Name = "pnlAttSumPresent";
            pnlAttSumPresent.Size = new Size(260, 72);
            pnlAttSumPresent.TabIndex = 0;
            // 
            // iconAttSumPresent
            // 
            iconAttSumPresent.BackColor = Color.Transparent;
            iconAttSumPresent.ForeColor = Color.FromArgb(16, 163, 92);
            iconAttSumPresent.IconChar = IconChar.UserCheck;
            iconAttSumPresent.IconColor = Color.FromArgb(16, 163, 92);
            iconAttSumPresent.IconFont = IconFont.Auto;
            iconAttSumPresent.IconSize = 24;
            iconAttSumPresent.Location = new Point(14, 24);
            iconAttSumPresent.Name = "iconAttSumPresent";
            iconAttSumPresent.Size = new Size(24, 24);
            iconAttSumPresent.TabIndex = 0;
            iconAttSumPresent.TabStop = false;
            // 
            // lblAttSumPresentLbl
            // 
            lblAttSumPresentLbl.AutoSize = true;
            lblAttSumPresentLbl.Font = new Font("Poppins", 8F);
            lblAttSumPresentLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblAttSumPresentLbl.Location = new Point(48, 44);
            lblAttSumPresentLbl.Name = "lblAttSumPresentLbl";
            lblAttSumPresentLbl.Size = new Size(125, 25);
            lblAttSumPresentLbl.TabIndex = 2;
            lblAttSumPresentLbl.Text = "Present Records";
            // 
            // lblAttSumPresentCount
            // 
            lblAttSumPresentCount.AutoSize = true;
            lblAttSumPresentCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblAttSumPresentCount.ForeColor = Color.FromArgb(16, 163, 92);
            lblAttSumPresentCount.Location = new Point(48, 12);
            lblAttSumPresentCount.Name = "lblAttSumPresentCount";
            lblAttSumPresentCount.Size = new Size(31, 39);
            lblAttSumPresentCount.TabIndex = 1;
            lblAttSumPresentCount.Text = "0";
            // 
            // pnlAttSumAbsent
            // 
            pnlAttSumAbsent.BackColor = Color.FromArgb(255, 237, 237);
            pnlAttSumAbsent.Controls.Add(iconAttSumAbsent);
            pnlAttSumAbsent.Controls.Add(lblAttSumAbsentLbl);
            pnlAttSumAbsent.Controls.Add(lblAttSumAbsentCount);
            pnlAttSumAbsent.Location = new Point(280, 0);
            pnlAttSumAbsent.Name = "pnlAttSumAbsent";
            pnlAttSumAbsent.Size = new Size(260, 72);
            pnlAttSumAbsent.TabIndex = 1;
            // 
            // iconAttSumAbsent
            // 
            iconAttSumAbsent.BackColor = Color.Transparent;
            iconAttSumAbsent.ForeColor = Color.FromArgb(220, 60, 60);
            iconAttSumAbsent.IconChar = IconChar.UserXmark;
            iconAttSumAbsent.IconColor = Color.FromArgb(220, 60, 60);
            iconAttSumAbsent.IconFont = IconFont.Auto;
            iconAttSumAbsent.IconSize = 24;
            iconAttSumAbsent.Location = new Point(14, 24);
            iconAttSumAbsent.Name = "iconAttSumAbsent";
            iconAttSumAbsent.Size = new Size(24, 24);
            iconAttSumAbsent.TabIndex = 0;
            iconAttSumAbsent.TabStop = false;
            // 
            // lblAttSumAbsentLbl
            // 
            lblAttSumAbsentLbl.AutoSize = true;
            lblAttSumAbsentLbl.Font = new Font("Poppins", 8F);
            lblAttSumAbsentLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblAttSumAbsentLbl.Location = new Point(48, 44);
            lblAttSumAbsentLbl.Name = "lblAttSumAbsentLbl";
            lblAttSumAbsentLbl.Size = new Size(121, 25);
            lblAttSumAbsentLbl.TabIndex = 2;
            lblAttSumAbsentLbl.Text = "Absent Records";
            // 
            // lblAttSumAbsentCount
            // 
            lblAttSumAbsentCount.AutoSize = true;
            lblAttSumAbsentCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblAttSumAbsentCount.ForeColor = Color.FromArgb(220, 60, 60);
            lblAttSumAbsentCount.Location = new Point(48, 12);
            lblAttSumAbsentCount.Name = "lblAttSumAbsentCount";
            lblAttSumAbsentCount.Size = new Size(31, 39);
            lblAttSumAbsentCount.TabIndex = 1;
            lblAttSumAbsentCount.Text = "0";
            // 
            // pnlAttSumRate
            // 
            pnlAttSumRate.BackColor = Color.FromArgb(233, 239, 255);
            pnlAttSumRate.Controls.Add(iconAttSumRate);
            pnlAttSumRate.Controls.Add(lblAttSumRateLbl);
            pnlAttSumRate.Controls.Add(lblAttSumRateCount);
            pnlAttSumRate.Location = new Point(560, 0);
            pnlAttSumRate.Name = "pnlAttSumRate";
            pnlAttSumRate.Size = new Size(260, 72);
            pnlAttSumRate.TabIndex = 2;
            // 
            // iconAttSumRate
            // 
            iconAttSumRate.BackColor = Color.Transparent;
            iconAttSumRate.ForeColor = Color.FromArgb(58, 99, 232);
            iconAttSumRate.IconChar = IconChar.ChartLine;
            iconAttSumRate.IconColor = Color.FromArgb(58, 99, 232);
            iconAttSumRate.IconFont = IconFont.Auto;
            iconAttSumRate.IconSize = 24;
            iconAttSumRate.Location = new Point(14, 24);
            iconAttSumRate.Name = "iconAttSumRate";
            iconAttSumRate.Size = new Size(24, 24);
            iconAttSumRate.TabIndex = 0;
            iconAttSumRate.TabStop = false;
            // 
            // lblAttSumRateLbl
            // 
            lblAttSumRateLbl.AutoSize = true;
            lblAttSumRateLbl.Font = new Font("Poppins", 8F);
            lblAttSumRateLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblAttSumRateLbl.Location = new Point(48, 44);
            lblAttSumRateLbl.Name = "lblAttSumRateLbl";
            lblAttSumRateLbl.Size = new Size(130, 25);
            lblAttSumRateLbl.TabIndex = 2;
            lblAttSumRateLbl.Text = "Attendance Rate";
            // 
            // lblAttSumRateCount
            // 
            lblAttSumRateCount.AutoSize = true;
            lblAttSumRateCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblAttSumRateCount.ForeColor = Color.FromArgb(58, 99, 232);
            lblAttSumRateCount.Location = new Point(48, 12);
            lblAttSumRateCount.Name = "lblAttSumRateCount";
            lblAttSumRateCount.Size = new Size(50, 39);
            lblAttSumRateCount.TabIndex = 1;
            lblAttSumRateCount.Text = "0%";
            // 
            // lblAttResultCount
            // 
            lblAttResultCount.AutoSize = true;
            lblAttResultCount.Font = new Font("Poppins", 8.5F);
            lblAttResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblAttResultCount.Location = new Point(31, 174);
            lblAttResultCount.Name = "lblAttResultCount";
            lblAttResultCount.Size = new Size(152, 26);
            lblAttResultCount.TabIndex = 4;
            lblAttResultCount.Text = "Showing 0 records";
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeight = 38;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colAttId, colAttStudentName, colAttStudentNo, colAttActivity, colAttCheckpoint, colAttStatus, colAttTimeIn, colAttTimeOut, colAttPenaltyIncurred });
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.FromArgb(236, 230, 222);
            dgvAttendance.Location = new Point(28, 200);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 38;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(822, 312);
            dgvAttendance.TabIndex = 5;
            // 
            // colAttId
            // 
            colAttId.HeaderText = "#";
            colAttId.MinimumWidth = 6;
            colAttId.Name = "colAttId";
            colAttId.ReadOnly = true;
            colAttId.Resizable = DataGridViewTriState.False;
            colAttId.Width = 46;
            // 
            // colAttStudentName
            // 
            colAttStudentName.HeaderText = "Student Name";
            colAttStudentName.MinimumWidth = 6;
            colAttStudentName.Name = "colAttStudentName";
            colAttStudentName.ReadOnly = true;
            colAttStudentName.Width = 170;
            // 
            // colAttStudentNo
            // 
            colAttStudentNo.HeaderText = "Student No.";
            colAttStudentNo.MinimumWidth = 6;
            colAttStudentNo.Name = "colAttStudentNo";
            colAttStudentNo.ReadOnly = true;
            colAttStudentNo.Width = 125;
            // 
            // colAttActivity
            // 
            colAttActivity.HeaderText = "Activity";
            colAttActivity.MinimumWidth = 6;
            colAttActivity.Name = "colAttActivity";
            colAttActivity.ReadOnly = true;
            colAttActivity.Width = 150;
            // 
            // colAttCheckpoint
            // 
            colAttCheckpoint.HeaderText = "Checkpoint";
            colAttCheckpoint.MinimumWidth = 6;
            colAttCheckpoint.Name = "colAttCheckpoint";
            colAttCheckpoint.ReadOnly = true;
            colAttCheckpoint.Width = 110;
            // 
            // colAttStatus
            // 
            colAttStatus.HeaderText = "Status";
            colAttStatus.MinimumWidth = 6;
            colAttStatus.Name = "colAttStatus";
            colAttStatus.ReadOnly = true;
            colAttStatus.Width = 88;
            // 
            // colAttTimeIn
            // 
            colAttTimeIn.HeaderText = "Time In";
            colAttTimeIn.MinimumWidth = 6;
            colAttTimeIn.Name = "colAttTimeIn";
            colAttTimeIn.ReadOnly = true;
            colAttTimeIn.Width = 80;
            // 
            // colAttTimeOut
            // 
            colAttTimeOut.HeaderText = "Time Out";
            colAttTimeOut.MinimumWidth = 6;
            colAttTimeOut.Name = "colAttTimeOut";
            colAttTimeOut.ReadOnly = true;
            colAttTimeOut.Width = 80;
            // 
            // colAttPenaltyIncurred
            // 
            colAttPenaltyIncurred.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAttPenaltyIncurred.HeaderText = "Penalty Incurred";
            colAttPenaltyIncurred.MinimumWidth = 6;
            colAttPenaltyIncurred.Name = "colAttPenaltyIncurred";
            colAttPenaltyIncurred.ReadOnly = true;
            // 
            // cardClearance
            // 
            cardClearance.BackColor = Color.White;
            cardClearance.Controls.Add(pnlClrIconBox);
            cardClearance.Controls.Add(lblClrTitle);
            cardClearance.Controls.Add(dividerClr);
            cardClearance.Controls.Add(pnlClrSummaryBar);
            cardClearance.Controls.Add(lblClrResultCount);
            cardClearance.Controls.Add(dgvClearance);
            cardClearance.Location = new Point(30, 2708);
            cardClearance.Name = "cardClearance";
            cardClearance.Padding = new Padding(28, 24, 28, 28);
            cardClearance.Size = new Size(878, 460);
            cardClearance.TabIndex = 6;
            // 
            // pnlClrIconBox
            // 
            pnlClrIconBox.BackColor = Color.FromArgb(230, 255, 242);
            pnlClrIconBox.Controls.Add(iconClr);
            pnlClrIconBox.Location = new Point(28, 24);
            pnlClrIconBox.Name = "pnlClrIconBox";
            pnlClrIconBox.Size = new Size(44, 44);
            pnlClrIconBox.TabIndex = 0;
            // 
            // iconClr
            // 
            iconClr.BackColor = Color.Transparent;
            iconClr.ForeColor = Color.FromArgb(16, 163, 92);
            iconClr.IconChar = IconChar.Certificate;
            iconClr.IconColor = Color.FromArgb(16, 163, 92);
            iconClr.IconFont = IconFont.Auto;
            iconClr.IconSize = 22;
            iconClr.Location = new Point(11, 11);
            iconClr.Name = "iconClr";
            iconClr.Size = new Size(22, 22);
            iconClr.TabIndex = 0;
            iconClr.TabStop = false;
            // 
            // lblClrTitle
            // 
            lblClrTitle.AutoSize = true;
            lblClrTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblClrTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblClrTitle.Location = new Point(82, 30);
            lblClrTitle.Name = "lblClrTitle";
            lblClrTitle.Size = new Size(219, 34);
            lblClrTitle.TabIndex = 1;
            lblClrTitle.Text = "Clearance Summary";
            // 
            // dividerClr
            // 
            dividerClr.BackColor = Color.FromArgb(236, 230, 222);
            dividerClr.Location = new Point(28, 78);
            dividerClr.Name = "dividerClr";
            dividerClr.Size = new Size(822, 1);
            dividerClr.TabIndex = 2;
            // 
            // pnlClrSummaryBar
            // 
            pnlClrSummaryBar.BackColor = Color.Transparent;
            pnlClrSummaryBar.Controls.Add(pnlClrSumCleared);
            pnlClrSummaryBar.Controls.Add(pnlClrSumPending);
            pnlClrSummaryBar.Controls.Add(pnlClrSumDenied);
            pnlClrSummaryBar.Location = new Point(28, 90);
            pnlClrSummaryBar.Name = "pnlClrSummaryBar";
            pnlClrSummaryBar.Size = new Size(822, 72);
            pnlClrSummaryBar.TabIndex = 3;
            // 
            // pnlClrSumCleared
            // 
            pnlClrSumCleared.BackColor = Color.FromArgb(230, 255, 242);
            pnlClrSumCleared.Controls.Add(iconClrSumCleared);
            pnlClrSumCleared.Controls.Add(lblClrSumClearedLbl);
            pnlClrSumCleared.Controls.Add(lblClrSumClearedCount);
            pnlClrSumCleared.Location = new Point(0, 0);
            pnlClrSumCleared.Name = "pnlClrSumCleared";
            pnlClrSumCleared.Size = new Size(260, 72);
            pnlClrSumCleared.TabIndex = 0;
            // 
            // iconClrSumCleared
            // 
            iconClrSumCleared.BackColor = Color.Transparent;
            iconClrSumCleared.ForeColor = Color.FromArgb(16, 163, 92);
            iconClrSumCleared.IconChar = IconChar.Certificate;
            iconClrSumCleared.IconColor = Color.FromArgb(16, 163, 92);
            iconClrSumCleared.IconFont = IconFont.Auto;
            iconClrSumCleared.IconSize = 24;
            iconClrSumCleared.Location = new Point(14, 24);
            iconClrSumCleared.Name = "iconClrSumCleared";
            iconClrSumCleared.Size = new Size(24, 24);
            iconClrSumCleared.TabIndex = 0;
            iconClrSumCleared.TabStop = false;
            // 
            // lblClrSumClearedLbl
            // 
            lblClrSumClearedLbl.AutoSize = true;
            lblClrSumClearedLbl.Font = new Font("Poppins", 8F);
            lblClrSumClearedLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblClrSumClearedLbl.Location = new Point(48, 44);
            lblClrSumClearedLbl.Name = "lblClrSumClearedLbl";
            lblClrSumClearedLbl.Size = new Size(132, 25);
            lblClrSumClearedLbl.TabIndex = 2;
            lblClrSumClearedLbl.Text = "Cleared Students";
            // 
            // lblClrSumClearedCount
            // 
            lblClrSumClearedCount.AutoSize = true;
            lblClrSumClearedCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblClrSumClearedCount.ForeColor = Color.FromArgb(16, 163, 92);
            lblClrSumClearedCount.Location = new Point(48, 12);
            lblClrSumClearedCount.Name = "lblClrSumClearedCount";
            lblClrSumClearedCount.Size = new Size(31, 39);
            lblClrSumClearedCount.TabIndex = 1;
            lblClrSumClearedCount.Text = "0";
            // 
            // pnlClrSumPending
            // 
            pnlClrSumPending.BackColor = Color.FromArgb(255, 248, 225);
            pnlClrSumPending.Controls.Add(iconClrSumPending);
            pnlClrSumPending.Controls.Add(lblClrSumPendingLbl);
            pnlClrSumPending.Controls.Add(lblClrSumPendingCount);
            pnlClrSumPending.Location = new Point(280, 0);
            pnlClrSumPending.Name = "pnlClrSumPending";
            pnlClrSumPending.Size = new Size(260, 72);
            pnlClrSumPending.TabIndex = 1;
            // 
            // iconClrSumPending
            // 
            iconClrSumPending.BackColor = Color.Transparent;
            iconClrSumPending.ForeColor = Color.FromArgb(200, 140, 0);
            iconClrSumPending.IconChar = IconChar.Hourglass2;
            iconClrSumPending.IconColor = Color.FromArgb(200, 140, 0);
            iconClrSumPending.IconFont = IconFont.Auto;
            iconClrSumPending.IconSize = 24;
            iconClrSumPending.Location = new Point(14, 24);
            iconClrSumPending.Name = "iconClrSumPending";
            iconClrSumPending.Size = new Size(24, 24);
            iconClrSumPending.TabIndex = 0;
            iconClrSumPending.TabStop = false;
            // 
            // lblClrSumPendingLbl
            // 
            lblClrSumPendingLbl.AutoSize = true;
            lblClrSumPendingLbl.Font = new Font("Poppins", 8F);
            lblClrSumPendingLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblClrSumPendingLbl.Location = new Point(48, 44);
            lblClrSumPendingLbl.Name = "lblClrSumPendingLbl";
            lblClrSumPendingLbl.Size = new Size(136, 25);
            lblClrSumPendingLbl.TabIndex = 2;
            lblClrSumPendingLbl.Text = "Pending Requests";
            // 
            // lblClrSumPendingCount
            // 
            lblClrSumPendingCount.AutoSize = true;
            lblClrSumPendingCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblClrSumPendingCount.ForeColor = Color.FromArgb(200, 140, 0);
            lblClrSumPendingCount.Location = new Point(48, 12);
            lblClrSumPendingCount.Name = "lblClrSumPendingCount";
            lblClrSumPendingCount.Size = new Size(31, 39);
            lblClrSumPendingCount.TabIndex = 1;
            lblClrSumPendingCount.Text = "0";
            // 
            // pnlClrSumDenied
            // 
            pnlClrSumDenied.BackColor = Color.FromArgb(255, 237, 237);
            pnlClrSumDenied.Controls.Add(iconClrSumDenied);
            pnlClrSumDenied.Controls.Add(lblClrSumDeniedLbl);
            pnlClrSumDenied.Controls.Add(lblClrSumDeniedCount);
            pnlClrSumDenied.Location = new Point(560, 0);
            pnlClrSumDenied.Name = "pnlClrSumDenied";
            pnlClrSumDenied.Size = new Size(260, 72);
            pnlClrSumDenied.TabIndex = 2;
            // 
            // iconClrSumDenied
            // 
            iconClrSumDenied.BackColor = Color.Transparent;
            iconClrSumDenied.ForeColor = Color.FromArgb(220, 60, 60);
            iconClrSumDenied.IconChar = IconChar.XmarkCircle;
            iconClrSumDenied.IconColor = Color.FromArgb(220, 60, 60);
            iconClrSumDenied.IconFont = IconFont.Auto;
            iconClrSumDenied.IconSize = 24;
            iconClrSumDenied.Location = new Point(14, 24);
            iconClrSumDenied.Name = "iconClrSumDenied";
            iconClrSumDenied.Size = new Size(24, 24);
            iconClrSumDenied.TabIndex = 0;
            iconClrSumDenied.TabStop = false;
            // 
            // lblClrSumDeniedLbl
            // 
            lblClrSumDeniedLbl.AutoSize = true;
            lblClrSumDeniedLbl.Font = new Font("Poppins", 8F);
            lblClrSumDeniedLbl.ForeColor = Color.FromArgb(52, 52, 58);
            lblClrSumDeniedLbl.Location = new Point(48, 44);
            lblClrSumDeniedLbl.Name = "lblClrSumDeniedLbl";
            lblClrSumDeniedLbl.Size = new Size(138, 25);
            lblClrSumDeniedLbl.TabIndex = 2;
            lblClrSumDeniedLbl.Text = "Denied / Rejected";
            // 
            // lblClrSumDeniedCount
            // 
            lblClrSumDeniedCount.AutoSize = true;
            lblClrSumDeniedCount.Font = new Font("Poppins", 13F, FontStyle.Bold);
            lblClrSumDeniedCount.ForeColor = Color.FromArgb(220, 60, 60);
            lblClrSumDeniedCount.Location = new Point(48, 12);
            lblClrSumDeniedCount.Name = "lblClrSumDeniedCount";
            lblClrSumDeniedCount.Size = new Size(31, 39);
            lblClrSumDeniedCount.TabIndex = 1;
            lblClrSumDeniedCount.Text = "0";
            // 
            // lblClrResultCount
            // 
            lblClrResultCount.AutoSize = true;
            lblClrResultCount.Font = new Font("Poppins", 8.5F);
            lblClrResultCount.ForeColor = Color.FromArgb(122, 122, 128);
            lblClrResultCount.Location = new Point(31, 174);
            lblClrResultCount.Name = "lblClrResultCount";
            lblClrResultCount.Size = new Size(152, 26);
            lblClrResultCount.TabIndex = 4;
            lblClrResultCount.Text = "Showing 0 records";
            // 
            // dgvClearance
            // 
            dgvClearance.AllowUserToAddRows = false;
            dgvClearance.AllowUserToDeleteRows = false;
            dgvClearance.AllowUserToResizeRows = false;
            dgvClearance.BackgroundColor = Color.White;
            dgvClearance.BorderStyle = BorderStyle.None;
            dgvClearance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClearance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClearance.ColumnHeadersHeight = 38;
            dgvClearance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClearance.Columns.AddRange(new DataGridViewColumn[] { colClrId, colClrStudentName, colClrStudentNo, colClrCourse, colClrStatus, colClrMemObligation, colClrPenObligation, colClrRequestedDate, colClrIssuedDate });
            dgvClearance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClearance.EnableHeadersVisualStyles = false;
            dgvClearance.GridColor = Color.FromArgb(236, 230, 222);
            dgvClearance.Location = new Point(28, 200);
            dgvClearance.Name = "dgvClearance";
            dgvClearance.ReadOnly = true;
            dgvClearance.RowHeadersVisible = false;
            dgvClearance.RowHeadersWidth = 51;
            dgvClearance.RowTemplate.Height = 38;
            dgvClearance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClearance.Size = new Size(822, 232);
            dgvClearance.TabIndex = 5;
            // 
            // colClrId
            // 
            colClrId.HeaderText = "#";
            colClrId.MinimumWidth = 6;
            colClrId.Name = "colClrId";
            colClrId.ReadOnly = true;
            colClrId.Resizable = DataGridViewTriState.False;
            colClrId.Width = 46;
            // 
            // colClrStudentName
            // 
            colClrStudentName.HeaderText = "Student Name";
            colClrStudentName.MinimumWidth = 6;
            colClrStudentName.Name = "colClrStudentName";
            colClrStudentName.ReadOnly = true;
            colClrStudentName.Width = 170;
            // 
            // colClrStudentNo
            // 
            colClrStudentNo.HeaderText = "Student No.";
            colClrStudentNo.MinimumWidth = 6;
            colClrStudentNo.Name = "colClrStudentNo";
            colClrStudentNo.ReadOnly = true;
            colClrStudentNo.Width = 125;
            // 
            // colClrCourse
            // 
            colClrCourse.HeaderText = "Course";
            colClrCourse.MinimumWidth = 6;
            colClrCourse.Name = "colClrCourse";
            colClrCourse.ReadOnly = true;
            colClrCourse.Width = 80;
            // 
            // colClrStatus
            // 
            colClrStatus.HeaderText = "Status";
            colClrStatus.MinimumWidth = 6;
            colClrStatus.Name = "colClrStatus";
            colClrStatus.ReadOnly = true;
            colClrStatus.Width = 88;
            // 
            // colClrMemObligation
            // 
            colClrMemObligation.HeaderText = "Mem. Obligation";
            colClrMemObligation.MinimumWidth = 6;
            colClrMemObligation.Name = "colClrMemObligation";
            colClrMemObligation.ReadOnly = true;
            colClrMemObligation.Width = 120;
            // 
            // colClrPenObligation
            // 
            colClrPenObligation.HeaderText = "Pen. Obligation";
            colClrPenObligation.MinimumWidth = 6;
            colClrPenObligation.Name = "colClrPenObligation";
            colClrPenObligation.ReadOnly = true;
            colClrPenObligation.Width = 115;
            // 
            // colClrRequestedDate
            // 
            colClrRequestedDate.HeaderText = "Requested";
            colClrRequestedDate.MinimumWidth = 6;
            colClrRequestedDate.Name = "colClrRequestedDate";
            colClrRequestedDate.ReadOnly = true;
            colClrRequestedDate.Width = 125;
            // 
            // colClrIssuedDate
            // 
            colClrIssuedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colClrIssuedDate.HeaderText = "Issued Date";
            colClrIssuedDate.MinimumWidth = 6;
            colClrIssuedDate.Name = "colClrIssuedDate";
            colClrIssuedDate.ReadOnly = true;
            // 
            // ReportsView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "ReportsView";
            Size = new Size(955, 3200);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            cardStats.ResumeLayout(false);
            statCardMembers.ResumeLayout(false);
            statCardMembers.PerformLayout();
            pnlStatMembersIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatMembers).EndInit();
            statCardActive.ResumeLayout(false);
            statCardActive.PerformLayout();
            pnlStatActiveIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatActive).EndInit();
            statCardFees.ResumeLayout(false);
            statCardFees.PerformLayout();
            pnlStatFeesIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatFees).EndInit();
            statCardPenalties.ResumeLayout(false);
            statCardPenalties.PerformLayout();
            pnlStatPenaltiesIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatPenalties).EndInit();
            cardFilter.ResumeLayout(false);
            cardFilter.PerformLayout();
            pnlFilterIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconFilter).EndInit();
            cardMembership.ResumeLayout(false);
            cardMembership.PerformLayout();
            pnlMemIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembership).EndInit();
            cardFees.ResumeLayout(false);
            cardFees.PerformLayout();
            pnlFeeIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconFee).EndInit();
            pnlFeeSummaryBar.ResumeLayout(false);
            pnlFeeSumCollected.ResumeLayout(false);
            pnlFeeSumCollected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumCollected).EndInit();
            pnlFeeSumPending.ResumeLayout(false);
            pnlFeeSumPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumPending).EndInit();
            pnlFeeSumOverdue.ResumeLayout(false);
            pnlFeeSumOverdue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconFeeSumOverdue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFees).EndInit();
            cardPenalties.ResumeLayout(false);
            cardPenalties.PerformLayout();
            pnlPenIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPen).EndInit();
            pnlPenSummaryBar.ResumeLayout(false);
            pnlPenSumTotal.ResumeLayout(false);
            pnlPenSumTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumTotal).EndInit();
            pnlPenSumPaid.ResumeLayout(false);
            pnlPenSumPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumPaid).EndInit();
            pnlPenSumUnpaid.ResumeLayout(false);
            pnlPenSumUnpaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPenSumUnpaid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenalties).EndInit();
            cardAttendance.ResumeLayout(false);
            cardAttendance.PerformLayout();
            pnlAttIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconAtt).EndInit();
            pnlAttSummaryBar.ResumeLayout(false);
            pnlAttSumPresent.ResumeLayout(false);
            pnlAttSumPresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumPresent).EndInit();
            pnlAttSumAbsent.ResumeLayout(false);
            pnlAttSumAbsent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumAbsent).EndInit();
            pnlAttSumRate.ResumeLayout(false);
            pnlAttSumRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconAttSumRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            cardClearance.ResumeLayout(false);
            cardClearance.PerformLayout();
            pnlClrIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconClr).EndInit();
            pnlClrSummaryBar.ResumeLayout(false);
            pnlClrSumCleared.ResumeLayout(false);
            pnlClrSumCleared.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumCleared).EndInit();
            pnlClrSumPending.ResumeLayout(false);
            pnlClrSumPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumPending).EndInit();
            pnlClrSumDenied.ResumeLayout(false);
            pnlClrSumDenied.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconClrSumDenied).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClearance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel outerScrollPanel;
        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Panel cardStats;
        private System.Windows.Forms.Panel statCardMembers;
        private System.Windows.Forms.Panel pnlStatMembersIcon;
        private IconPictureBox iconStatMembers;
        private System.Windows.Forms.Label lblStatMembersCount;
        private System.Windows.Forms.Label lblStatMembersLabel;
        private System.Windows.Forms.Panel statCardActive;
        private System.Windows.Forms.Panel pnlStatActiveIcon;
        private IconPictureBox iconStatActive;
        private System.Windows.Forms.Label lblStatActiveCount;
        private System.Windows.Forms.Label lblStatActiveLabel;
        private System.Windows.Forms.Panel statCardFees;
        private System.Windows.Forms.Panel pnlStatFeesIcon;
        private IconPictureBox iconStatFees;
        private System.Windows.Forms.Label lblStatFeesCount;
        private System.Windows.Forms.Label lblStatFeesLabel;
        private System.Windows.Forms.Panel statCardPenalties;
        private System.Windows.Forms.Panel pnlStatPenaltiesIcon;
        private IconPictureBox iconStatPenalties;
        private System.Windows.Forms.Label lblStatPenaltiesCount;
        private System.Windows.Forms.Label lblStatPenaltiesLabel;
        private System.Windows.Forms.Panel cardFilter;
        private System.Windows.Forms.Panel pnlFilterIconBox;
        private IconPictureBox iconFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Panel dividerFilter;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblSchoolYear;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cmbSemester;
        private IconButton btnGenerateReport;
        private IconButton btnResetFilter;
        private IconButton btnExportCsv;
        private IconButton btnExportPdf;
        private System.Windows.Forms.Panel cardMembership;
        private System.Windows.Forms.Panel pnlMemIconBox;
        private IconPictureBox iconMem;
        private System.Windows.Forms.Label lblMemTitle;
        private System.Windows.Forms.Panel dividerMem;
        private System.Windows.Forms.Label lblMemResultCount;
        private System.Windows.Forms.DataGridView dgvMembership;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemFeePaid;
        private System.Windows.Forms.Panel cardFees;
        private System.Windows.Forms.Panel pnlFeeIconBox;
        private IconPictureBox iconFee;
        private System.Windows.Forms.Label lblFeeTitle;
        private System.Windows.Forms.Panel dividerFee;
        private System.Windows.Forms.Panel pnlFeeSummaryBar;
        private System.Windows.Forms.Panel pnlFeeSumCollected;
        private IconPictureBox iconFeeSumCollected;
        private System.Windows.Forms.Label lblFeeSumCollectedLbl;
        private System.Windows.Forms.Label lblFeeSumCollectedAmt;
        private System.Windows.Forms.Panel pnlFeeSumPending;
        private IconPictureBox iconFeeSumPending;
        private System.Windows.Forms.Label lblFeeSumPendingLbl;
        private System.Windows.Forms.Label lblFeeSumPendingAmt;
        private System.Windows.Forms.Panel pnlFeeSumOverdue;
        private IconPictureBox iconFeeSumOverdue;
        private System.Windows.Forms.Label lblFeeSumOverdueLbl;
        private System.Windows.Forms.Label lblFeeSumOverdueAmt;
        private System.Windows.Forms.Label lblFeeResultCount;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePolicyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeOR;
        private System.Windows.Forms.Panel cardPenalties;
        private System.Windows.Forms.Panel pnlPenIconBox;
        private IconPictureBox iconPen;
        private System.Windows.Forms.Label lblPenTitle;
        private System.Windows.Forms.Panel dividerPen;
        private System.Windows.Forms.Panel pnlPenSummaryBar;
        private System.Windows.Forms.Panel pnlPenSumTotal;
        private IconPictureBox iconPenSumTotal;
        private System.Windows.Forms.Label lblPenSumTotalLbl;
        private System.Windows.Forms.Label lblPenSumTotalAmt;
        private System.Windows.Forms.Panel pnlPenSumPaid;
        private IconPictureBox iconPenSumPaid;
        private System.Windows.Forms.Label lblPenSumPaidLbl;
        private System.Windows.Forms.Label lblPenSumPaidAmt;
        private System.Windows.Forms.Panel pnlPenSumUnpaid;
        private IconPictureBox iconPenSumUnpaid;
        private System.Windows.Forms.Label lblPenSumUnpaidLbl;
        private System.Windows.Forms.Label lblPenSumUnpaidAmt;
        private System.Windows.Forms.Label lblPenResultCount;
        private System.Windows.Forms.DataGridView dgvPenalties;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenPolicyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPenDateIssued;
        private System.Windows.Forms.Panel cardAttendance;
        private System.Windows.Forms.Panel pnlAttIconBox;
        private IconPictureBox iconAtt;
        private System.Windows.Forms.Label lblAttTitle;
        private System.Windows.Forms.Panel dividerAtt;
        private System.Windows.Forms.Panel pnlAttSummaryBar;
        private System.Windows.Forms.Panel pnlAttSumPresent;
        private IconPictureBox iconAttSumPresent;
        private System.Windows.Forms.Label lblAttSumPresentLbl;
        private System.Windows.Forms.Label lblAttSumPresentCount;
        private System.Windows.Forms.Panel pnlAttSumAbsent;
        private IconPictureBox iconAttSumAbsent;
        private System.Windows.Forms.Label lblAttSumAbsentLbl;
        private System.Windows.Forms.Label lblAttSumAbsentCount;
        private System.Windows.Forms.Panel pnlAttSumRate;
        private IconPictureBox iconAttSumRate;
        private System.Windows.Forms.Label lblAttSumRateLbl;
        private System.Windows.Forms.Label lblAttSumRateCount;
        private System.Windows.Forms.Label lblAttResultCount;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttCheckpoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttPenaltyIncurred;
        private System.Windows.Forms.Panel cardClearance;
        private System.Windows.Forms.Panel pnlClrIconBox;
        private IconPictureBox iconClr;
        private System.Windows.Forms.Label lblClrTitle;
        private System.Windows.Forms.Panel dividerClr;
        private System.Windows.Forms.Panel pnlClrSummaryBar;
        private System.Windows.Forms.Panel pnlClrSumCleared;
        private IconPictureBox iconClrSumCleared;
        private System.Windows.Forms.Label lblClrSumClearedLbl;
        private System.Windows.Forms.Label lblClrSumClearedCount;
        private System.Windows.Forms.Panel pnlClrSumPending;
        private IconPictureBox iconClrSumPending;
        private System.Windows.Forms.Label lblClrSumPendingLbl;
        private System.Windows.Forms.Label lblClrSumPendingCount;
        private System.Windows.Forms.Panel pnlClrSumDenied;
        private IconPictureBox iconClrSumDenied;
        private System.Windows.Forms.Label lblClrSumDeniedLbl;
        private System.Windows.Forms.Label lblClrSumDeniedCount;
        private System.Windows.Forms.Label lblClrResultCount;
        private System.Windows.Forms.DataGridView dgvClearance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrMemObligation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrPenObligation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrRequestedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClrIssuedDate;
    }
}
