using FontAwesome.Sharp;

namespace BYTeLog.Views
{
    partial class PaymentsView
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            outerScrollPanel = new Panel();
            innerContentPanel = new Panel();
            cardSummary = new Panel();
            pnlStatCollected = new Panel();
            lblStatCollectedUnit = new Label();
            pnlStatCollectedIcon = new Panel();
            iconStatCollected = new IconPictureBox();
            lblStatCollectedNum = new Label();
            lblStatCollectedCaption = new Label();
            pnlStatPaid = new Panel();
            lblStatPaidUnit = new Label();
            pnlStatPaidIcon = new Panel();
            iconStatPaid = new IconPictureBox();
            lblStatPaidNum = new Label();
            lblStatPaidCaption = new Label();
            pnlStatUnpaid = new Panel();
            lblStatUnpaidUnit = new Label();
            pnlStatUnpaidIcon = new Panel();
            iconStatUnpaid = new IconPictureBox();
            lblStatUnpaidNum = new Label();
            lblStatUnpaidCaption = new Label();
            pnlStatPartial = new Panel();
            lblStatPartialUnit = new Label();
            pnlStatPartialIcon = new Panel();
            iconStatPartial = new IconPictureBox();
            lblStatPartialNum = new Label();
            lblStatPartialCaption = new Label();
            cardMemPayments = new Panel();
            pnlMemPayIconBox = new Panel();
            iconMemPay = new IconPictureBox();
            lblMemPayTitle = new Label();
            dividerMemPay = new Panel();
            pnlMemPayToolbar = new Panel();
            pnlMemPaySearch = new Panel();
            iconMemPaySearch = new IconPictureBox();
            txtMemPaySearch = new TextBox();
            cmbMemPayStatus = new ComboBox();
            cmbMemPayPeriod = new ComboBox();
            btnRecordMemPayment = new IconButton();
            btnMemPayRemind = new IconButton();
            btnMemPayExport = new IconButton();
            dgvMemPayments = new DataGridView();
            colMemPayId = new DataGridViewTextBoxColumn();
            colMemPayStudentNo = new DataGridViewTextBoxColumn();
            colMemPayName = new DataGridViewTextBoxColumn();
            colMemPayAmountDue = new DataGridViewTextBoxColumn();
            colMemPayAmountPaid = new DataGridViewTextBoxColumn();
            colMemPayBalance = new DataGridViewTextBoxColumn();
            colMemPayDate = new DataGridViewTextBoxColumn();
            colMemPayMethod = new DataGridViewTextBoxColumn();
            colMemPayCollectedBy = new DataGridViewTextBoxColumn();
            colMemPayReceiptNo = new DataGridViewTextBoxColumn();
            colMemPayStatus = new DataGridViewTextBoxColumn();
            colMemPayActions = new DataGridViewButtonColumn();
            pnlMemPayPagination = new Panel();
            lblMemPayPageInfo = new Label();
            btnMemPayPrev = new IconButton();
            btnMemPayNext = new IconButton();
            cardMemPolicy = new Panel();
            pnlMemPolIconBox = new Panel();
            iconMemPol = new IconPictureBox();
            lblMemPolTitle = new Label();
            btnGoToMemSettings = new IconButton();
            dividerMemPol = new Panel();
            pnlMemPolTile = new Panel();
            lblMemPolTileApplied = new Label();
            pnlMemPolTileAccent = new Panel();
            iconMemPolTile = new IconPictureBox();
            lblMemPolTileName = new Label();
            lblMemPolTileType = new Label();
            lblMemPolTileAmount = new Label();
            dividerMemPolFooter = new Panel();
            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            cardSummary.SuspendLayout();
            pnlStatCollected.SuspendLayout();
            pnlStatCollectedIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatCollected).BeginInit();
            pnlStatPaid.SuspendLayout();
            pnlStatPaidIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatPaid).BeginInit();
            pnlStatUnpaid.SuspendLayout();
            pnlStatUnpaidIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatUnpaid).BeginInit();
            pnlStatPartial.SuspendLayout();
            pnlStatPartialIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatPartial).BeginInit();
            cardMemPayments.SuspendLayout();
            pnlMemPayIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPay).BeginInit();
            pnlMemPayToolbar.SuspendLayout();
            pnlMemPaySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPaySearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemPayments).BeginInit();
            pnlMemPayPagination.SuspendLayout();
            cardMemPolicy.SuspendLayout();
            pnlMemPolIconBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPol).BeginInit();
            pnlMemPolTile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPolTile).BeginInit();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 1060);
            outerScrollPanel.BackColor = Color.FromArgb(244, 239, 231);
            outerScrollPanel.Controls.Add(innerContentPanel);
            outerScrollPanel.Dock = DockStyle.Fill;
            outerScrollPanel.Location = new Point(0, 0);
            outerScrollPanel.Name = "outerScrollPanel";
            outerScrollPanel.Size = new Size(955, 500);
            outerScrollPanel.TabIndex = 0;
            // 
            // innerContentPanel
            // 
            innerContentPanel.BackColor = Color.FromArgb(244, 239, 231);
            innerContentPanel.Controls.Add(cardSummary);
            innerContentPanel.Controls.Add(cardMemPayments);
            innerContentPanel.Controls.Add(cardMemPolicy);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Padding = new Padding(30);
            innerContentPanel.Size = new Size(934, 1057);
            innerContentPanel.TabIndex = 0;
            // 
            // cardSummary
            // 
            cardSummary.BackColor = Color.White;
            cardSummary.Controls.Add(pnlStatCollected);
            cardSummary.Controls.Add(pnlStatPaid);
            cardSummary.Controls.Add(pnlStatUnpaid);
            cardSummary.Controls.Add(pnlStatPartial);
            cardSummary.Location = new Point(30, 30);
            cardSummary.Name = "cardSummary";
            cardSummary.Padding = new Padding(24);
            cardSummary.Size = new Size(874, 148);
            cardSummary.TabIndex = 0;
            // 
            // pnlStatCollected
            // 
            pnlStatCollected.BackColor = Color.White;
            pnlStatCollected.Controls.Add(lblStatCollectedUnit);
            pnlStatCollected.Controls.Add(pnlStatCollectedIcon);
            pnlStatCollected.Controls.Add(lblStatCollectedNum);
            pnlStatCollected.Controls.Add(lblStatCollectedCaption);
            pnlStatCollected.Location = new Point(24, 24);
            pnlStatCollected.Name = "pnlStatCollected";
            pnlStatCollected.Size = new Size(206, 100);
            pnlStatCollected.TabIndex = 0;
            // 
            // lblStatCollectedUnit
            // 
            lblStatCollectedUnit.AutoSize = true;
            lblStatCollectedUnit.Font = new Font("Poppins", 8F);
            lblStatCollectedUnit.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatCollectedUnit.Location = new Point(56, 42);
            lblStatCollectedUnit.Name = "lblStatCollectedUnit";
            lblStatCollectedUnit.Size = new Size(77, 25);
            lblStatCollectedUnit.TabIndex = 2;
            lblStatCollectedUnit.Text = "collected";
            // 
            // pnlStatCollectedIcon
            // 
            pnlStatCollectedIcon.BackColor = Color.FromArgb(233, 239, 255);
            pnlStatCollectedIcon.Controls.Add(iconStatCollected);
            pnlStatCollectedIcon.Location = new Point(0, 0);
            pnlStatCollectedIcon.Name = "pnlStatCollectedIcon";
            pnlStatCollectedIcon.Size = new Size(44, 44);
            pnlStatCollectedIcon.TabIndex = 0;
            // 
            // iconStatCollected
            // 
            iconStatCollected.BackColor = Color.Transparent;
            iconStatCollected.ForeColor = Color.FromArgb(58, 99, 232);
            iconStatCollected.IconChar = IconChar.Wallet;
            iconStatCollected.IconColor = Color.FromArgb(58, 99, 232);
            iconStatCollected.IconFont = IconFont.Auto;
            iconStatCollected.IconSize = 22;
            iconStatCollected.Location = new Point(11, 11);
            iconStatCollected.Name = "iconStatCollected";
            iconStatCollected.Size = new Size(22, 22);
            iconStatCollected.TabIndex = 0;
            iconStatCollected.TabStop = false;
            // 
            // lblStatCollectedNum
            // 
            lblStatCollectedNum.AutoSize = true;
            lblStatCollectedNum.Font = new Font("Poppins", 20F, FontStyle.Bold);
            lblStatCollectedNum.ForeColor = Color.FromArgb(20, 20, 20);
            lblStatCollectedNum.Location = new Point(54, 0);
            lblStatCollectedNum.Name = "lblStatCollectedNum";
            lblStatCollectedNum.Size = new Size(76, 60);
            lblStatCollectedNum.TabIndex = 1;
            lblStatCollectedNum.Text = "₱0";
            // 
            // lblStatCollectedCaption
            // 
            lblStatCollectedCaption.AutoSize = true;
            lblStatCollectedCaption.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblStatCollectedCaption.ForeColor = Color.FromArgb(52, 52, 58);
            lblStatCollectedCaption.Location = new Point(0, 60);
            lblStatCollectedCaption.Name = "lblStatCollectedCaption";
            lblStatCollectedCaption.Size = new Size(126, 26);
            lblStatCollectedCaption.TabIndex = 3;
            lblStatCollectedCaption.Text = "Total Collected";
            // 
            // pnlStatPaid
            // 
            pnlStatPaid.BackColor = Color.White;
            pnlStatPaid.Controls.Add(lblStatPaidUnit);
            pnlStatPaid.Controls.Add(pnlStatPaidIcon);
            pnlStatPaid.Controls.Add(lblStatPaidNum);
            pnlStatPaid.Controls.Add(lblStatPaidCaption);
            pnlStatPaid.Location = new Point(246, 24);
            pnlStatPaid.Name = "pnlStatPaid";
            pnlStatPaid.Size = new Size(206, 100);
            pnlStatPaid.TabIndex = 1;
            // 
            // lblStatPaidUnit
            // 
            lblStatPaidUnit.AutoSize = true;
            lblStatPaidUnit.Font = new Font("Poppins", 8F);
            lblStatPaidUnit.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatPaidUnit.Location = new Point(56, 42);
            lblStatPaidUnit.Name = "lblStatPaidUnit";
            lblStatPaidUnit.Size = new Size(79, 25);
            lblStatPaidUnit.TabIndex = 2;
            lblStatPaidUnit.Text = "members";
            // 
            // pnlStatPaidIcon
            // 
            pnlStatPaidIcon.BackColor = Color.FromArgb(220, 252, 231);
            pnlStatPaidIcon.Controls.Add(iconStatPaid);
            pnlStatPaidIcon.Location = new Point(0, 0);
            pnlStatPaidIcon.Name = "pnlStatPaidIcon";
            pnlStatPaidIcon.Size = new Size(44, 44);
            pnlStatPaidIcon.TabIndex = 0;
            // 
            // iconStatPaid
            // 
            iconStatPaid.BackColor = Color.Transparent;
            iconStatPaid.ForeColor = Color.FromArgb(22, 163, 74);
            iconStatPaid.IconChar = IconChar.CheckCircle;
            iconStatPaid.IconColor = Color.FromArgb(22, 163, 74);
            iconStatPaid.IconFont = IconFont.Auto;
            iconStatPaid.IconSize = 22;
            iconStatPaid.Location = new Point(11, 11);
            iconStatPaid.Name = "iconStatPaid";
            iconStatPaid.Size = new Size(22, 22);
            iconStatPaid.TabIndex = 0;
            iconStatPaid.TabStop = false;
            // 
            // lblStatPaidNum
            // 
            lblStatPaidNum.AutoSize = true;
            lblStatPaidNum.Font = new Font("Poppins", 20F, FontStyle.Bold);
            lblStatPaidNum.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatPaidNum.Location = new Point(54, 0);
            lblStatPaidNum.Name = "lblStatPaidNum";
            lblStatPaidNum.Size = new Size(47, 60);
            lblStatPaidNum.TabIndex = 1;
            lblStatPaidNum.Text = "0";
            // 
            // lblStatPaidCaption
            // 
            lblStatPaidCaption.AutoSize = true;
            lblStatPaidCaption.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblStatPaidCaption.ForeColor = Color.FromArgb(52, 52, 58);
            lblStatPaidCaption.Location = new Point(0, 60);
            lblStatPaidCaption.Name = "lblStatPaidCaption";
            lblStatPaidCaption.Size = new Size(83, 26);
            lblStatPaidCaption.TabIndex = 3;
            lblStatPaidCaption.Text = "Fully Paid";
            // 
            // pnlStatUnpaid
            // 
            pnlStatUnpaid.BackColor = Color.White;
            pnlStatUnpaid.Controls.Add(lblStatUnpaidUnit);
            pnlStatUnpaid.Controls.Add(pnlStatUnpaidIcon);
            pnlStatUnpaid.Controls.Add(lblStatUnpaidNum);
            pnlStatUnpaid.Controls.Add(lblStatUnpaidCaption);
            pnlStatUnpaid.Location = new Point(468, 24);
            pnlStatUnpaid.Name = "pnlStatUnpaid";
            pnlStatUnpaid.Size = new Size(206, 100);
            pnlStatUnpaid.TabIndex = 2;
            // 
            // lblStatUnpaidUnit
            // 
            lblStatUnpaidUnit.AutoSize = true;
            lblStatUnpaidUnit.Font = new Font("Poppins", 8F);
            lblStatUnpaidUnit.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatUnpaidUnit.Location = new Point(56, 42);
            lblStatUnpaidUnit.Name = "lblStatUnpaidUnit";
            lblStatUnpaidUnit.Size = new Size(79, 25);
            lblStatUnpaidUnit.TabIndex = 2;
            lblStatUnpaidUnit.Text = "members";
            // 
            // pnlStatUnpaidIcon
            // 
            pnlStatUnpaidIcon.BackColor = Color.FromArgb(255, 243, 230);
            pnlStatUnpaidIcon.Controls.Add(iconStatUnpaid);
            pnlStatUnpaidIcon.Location = new Point(0, 0);
            pnlStatUnpaidIcon.Name = "pnlStatUnpaidIcon";
            pnlStatUnpaidIcon.Size = new Size(44, 44);
            pnlStatUnpaidIcon.TabIndex = 0;
            // 
            // iconStatUnpaid
            // 
            iconStatUnpaid.BackColor = Color.Transparent;
            iconStatUnpaid.ForeColor = Color.FromArgb(217, 119, 6);
            iconStatUnpaid.IconChar = IconChar.Hourglass2;
            iconStatUnpaid.IconColor = Color.FromArgb(217, 119, 6);
            iconStatUnpaid.IconFont = IconFont.Auto;
            iconStatUnpaid.IconSize = 22;
            iconStatUnpaid.Location = new Point(11, 11);
            iconStatUnpaid.Name = "iconStatUnpaid";
            iconStatUnpaid.Size = new Size(22, 22);
            iconStatUnpaid.TabIndex = 0;
            iconStatUnpaid.TabStop = false;
            // 
            // lblStatUnpaidNum
            // 
            lblStatUnpaidNum.AutoSize = true;
            lblStatUnpaidNum.Font = new Font("Poppins", 20F, FontStyle.Bold);
            lblStatUnpaidNum.ForeColor = Color.FromArgb(217, 119, 6);
            lblStatUnpaidNum.Location = new Point(54, 0);
            lblStatUnpaidNum.Name = "lblStatUnpaidNum";
            lblStatUnpaidNum.Size = new Size(47, 60);
            lblStatUnpaidNum.TabIndex = 1;
            lblStatUnpaidNum.Text = "0";
            // 
            // lblStatUnpaidCaption
            // 
            lblStatUnpaidCaption.AutoSize = true;
            lblStatUnpaidCaption.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblStatUnpaidCaption.ForeColor = Color.FromArgb(52, 52, 58);
            lblStatUnpaidCaption.Location = new Point(0, 60);
            lblStatUnpaidCaption.Name = "lblStatUnpaidCaption";
            lblStatUnpaidCaption.Size = new Size(145, 26);
            lblStatUnpaidCaption.TabIndex = 3;
            lblStatUnpaidCaption.Text = "Unpaid / Overdue";
            // 
            // pnlStatPartial
            // 
            pnlStatPartial.BackColor = Color.White;
            pnlStatPartial.Controls.Add(lblStatPartialUnit);
            pnlStatPartial.Controls.Add(pnlStatPartialIcon);
            pnlStatPartial.Controls.Add(lblStatPartialNum);
            pnlStatPartial.Controls.Add(lblStatPartialCaption);
            pnlStatPartial.Location = new Point(690, 24);
            pnlStatPartial.Name = "pnlStatPartial";
            pnlStatPartial.Size = new Size(160, 100);
            pnlStatPartial.TabIndex = 3;
            // 
            // lblStatPartialUnit
            // 
            lblStatPartialUnit.AutoSize = true;
            lblStatPartialUnit.Font = new Font("Poppins", 8F);
            lblStatPartialUnit.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatPartialUnit.Location = new Point(56, 42);
            lblStatPartialUnit.Name = "lblStatPartialUnit";
            lblStatPartialUnit.Size = new Size(79, 25);
            lblStatPartialUnit.TabIndex = 2;
            lblStatPartialUnit.Text = "members";
            // 
            // pnlStatPartialIcon
            // 
            pnlStatPartialIcon.BackColor = Color.FromArgb(244, 244, 245);
            pnlStatPartialIcon.Controls.Add(iconStatPartial);
            pnlStatPartialIcon.Location = new Point(0, 0);
            pnlStatPartialIcon.Name = "pnlStatPartialIcon";
            pnlStatPartialIcon.Size = new Size(44, 44);
            pnlStatPartialIcon.TabIndex = 0;
            // 
            // iconStatPartial
            // 
            iconStatPartial.BackColor = Color.Transparent;
            iconStatPartial.ForeColor = Color.FromArgb(107, 114, 128);
            iconStatPartial.IconChar = IconChar.CircleHalfStroke;
            iconStatPartial.IconColor = Color.FromArgb(107, 114, 128);
            iconStatPartial.IconFont = IconFont.Auto;
            iconStatPartial.IconSize = 22;
            iconStatPartial.Location = new Point(11, 11);
            iconStatPartial.Name = "iconStatPartial";
            iconStatPartial.Size = new Size(22, 22);
            iconStatPartial.TabIndex = 0;
            iconStatPartial.TabStop = false;
            // 
            // lblStatPartialNum
            // 
            lblStatPartialNum.AutoSize = true;
            lblStatPartialNum.Font = new Font("Poppins", 20F, FontStyle.Bold);
            lblStatPartialNum.ForeColor = Color.FromArgb(107, 114, 128);
            lblStatPartialNum.Location = new Point(54, 0);
            lblStatPartialNum.Name = "lblStatPartialNum";
            lblStatPartialNum.Size = new Size(47, 60);
            lblStatPartialNum.TabIndex = 1;
            lblStatPartialNum.Text = "0";
            // 
            // lblStatPartialCaption
            // 
            lblStatPartialCaption.AutoSize = true;
            lblStatPartialCaption.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            lblStatPartialCaption.ForeColor = Color.FromArgb(52, 52, 58);
            lblStatPartialCaption.Location = new Point(0, 60);
            lblStatPartialCaption.Name = "lblStatPartialCaption";
            lblStatPartialCaption.Size = new Size(61, 26);
            lblStatPartialCaption.TabIndex = 3;
            lblStatPartialCaption.Text = "Partial";
            // 
            // cardMemPayments
            // 
            cardMemPayments.BackColor = Color.White;
            cardMemPayments.Controls.Add(pnlMemPayIconBox);
            cardMemPayments.Controls.Add(lblMemPayTitle);
            cardMemPayments.Controls.Add(dividerMemPay);
            cardMemPayments.Controls.Add(pnlMemPayToolbar);
            cardMemPayments.Controls.Add(dgvMemPayments);
            cardMemPayments.Controls.Add(pnlMemPayPagination);
            cardMemPayments.Location = new Point(30, 200);
            cardMemPayments.Name = "cardMemPayments";
            cardMemPayments.Padding = new Padding(28, 24, 28, 24);
            cardMemPayments.Size = new Size(874, 430);
            cardMemPayments.TabIndex = 1;
            // 
            // pnlMemPayIconBox
            // 
            pnlMemPayIconBox.BackColor = Color.FromArgb(230, 255, 242);
            pnlMemPayIconBox.Controls.Add(iconMemPay);
            pnlMemPayIconBox.Location = new Point(28, 24);
            pnlMemPayIconBox.Name = "pnlMemPayIconBox";
            pnlMemPayIconBox.Size = new Size(44, 44);
            pnlMemPayIconBox.TabIndex = 0;
            // 
            // iconMemPay
            // 
            iconMemPay.BackColor = Color.Transparent;
            iconMemPay.ForeColor = Color.FromArgb(16, 163, 92);
            iconMemPay.IconChar = IconChar.CreditCard;
            iconMemPay.IconColor = Color.FromArgb(16, 163, 92);
            iconMemPay.IconFont = IconFont.Auto;
            iconMemPay.IconSize = 22;
            iconMemPay.Location = new Point(11, 11);
            iconMemPay.Name = "iconMemPay";
            iconMemPay.Size = new Size(22, 22);
            iconMemPay.TabIndex = 0;
            iconMemPay.TabStop = false;
            // 
            // lblMemPayTitle
            // 
            lblMemPayTitle.AutoSize = true;
            lblMemPayTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblMemPayTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblMemPayTitle.Location = new Point(82, 29);
            lblMemPayTitle.Name = "lblMemPayTitle";
            lblMemPayTitle.Size = new Size(245, 34);
            lblMemPayTitle.TabIndex = 1;
            lblMemPayTitle.Text = "Membership Payments";
            // 
            // dividerMemPay
            // 
            dividerMemPay.BackColor = Color.FromArgb(236, 230, 222);
            dividerMemPay.Location = new Point(28, 78);
            dividerMemPay.Name = "dividerMemPay";
            dividerMemPay.Size = new Size(818, 1);
            dividerMemPay.TabIndex = 2;
            // 
            // pnlMemPayToolbar
            // 
            pnlMemPayToolbar.BackColor = Color.White;
            pnlMemPayToolbar.Controls.Add(pnlMemPaySearch);
            pnlMemPayToolbar.Controls.Add(cmbMemPayStatus);
            pnlMemPayToolbar.Controls.Add(cmbMemPayPeriod);
            pnlMemPayToolbar.Controls.Add(btnRecordMemPayment);
            pnlMemPayToolbar.Controls.Add(btnMemPayRemind);
            pnlMemPayToolbar.Controls.Add(btnMemPayExport);
            pnlMemPayToolbar.Location = new Point(28, 90);
            pnlMemPayToolbar.Name = "pnlMemPayToolbar";
            pnlMemPayToolbar.Size = new Size(818, 40);
            pnlMemPayToolbar.TabIndex = 3;
            // 
            // pnlMemPaySearch
            // 
            pnlMemPaySearch.BackColor = Color.FromArgb(250, 250, 252);
            pnlMemPaySearch.BorderStyle = BorderStyle.FixedSingle;
            pnlMemPaySearch.Controls.Add(iconMemPaySearch);
            pnlMemPaySearch.Controls.Add(txtMemPaySearch);
            pnlMemPaySearch.Location = new Point(0, 4);
            pnlMemPaySearch.Name = "pnlMemPaySearch";
            pnlMemPaySearch.Size = new Size(220, 32);
            pnlMemPaySearch.TabIndex = 0;
            // 
            // iconMemPaySearch
            // 
            iconMemPaySearch.BackColor = Color.Transparent;
            iconMemPaySearch.ForeColor = Color.FromArgb(161, 161, 170);
            iconMemPaySearch.IconChar = IconChar.Search;
            iconMemPaySearch.IconColor = Color.FromArgb(161, 161, 170);
            iconMemPaySearch.IconFont = IconFont.Auto;
            iconMemPaySearch.IconSize = 14;
            iconMemPaySearch.Location = new Point(6, 7);
            iconMemPaySearch.Name = "iconMemPaySearch";
            iconMemPaySearch.Size = new Size(14, 14);
            iconMemPaySearch.TabIndex = 0;
            iconMemPaySearch.TabStop = false;
            // 
            // txtMemPaySearch
            // 
            txtMemPaySearch.BackColor = Color.FromArgb(250, 250, 252);
            txtMemPaySearch.BorderStyle = BorderStyle.None;
            txtMemPaySearch.Font = new Font("Poppins", 9F);
            txtMemPaySearch.ForeColor = Color.FromArgb(52, 52, 58);
            txtMemPaySearch.Location = new Point(26, 5);
            txtMemPaySearch.Name = "txtMemPaySearch";
            txtMemPaySearch.PlaceholderText = "Search student or receipt…";
            txtMemPaySearch.Size = new Size(188, 23);
            txtMemPaySearch.TabIndex = 0;
            txtMemPaySearch.TextChanged += txtMemPaySearch_TextChanged;
            // 
            // cmbMemPayStatus
            // 
            cmbMemPayStatus.BackColor = Color.FromArgb(250, 250, 252);
            cmbMemPayStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMemPayStatus.FlatStyle = FlatStyle.Flat;
            cmbMemPayStatus.Font = new Font("Poppins", 9F);
            cmbMemPayStatus.ForeColor = Color.FromArgb(52, 52, 58);
            cmbMemPayStatus.Items.AddRange(new object[] { "All Statuses", "Paid", "Unpaid", "Partial", "Overdue" });
            cmbMemPayStatus.Location = new Point(228, 4);
            cmbMemPayStatus.Name = "cmbMemPayStatus";
            cmbMemPayStatus.Size = new Size(130, 34);
            cmbMemPayStatus.TabIndex = 1;
            cmbMemPayStatus.SelectedIndexChanged += cmbMemPayStatus_SelectedIndexChanged;
            // 
            // cmbMemPayPeriod
            // 
            cmbMemPayPeriod.BackColor = Color.FromArgb(250, 250, 252);
            cmbMemPayPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMemPayPeriod.FlatStyle = FlatStyle.Flat;
            cmbMemPayPeriod.Font = new Font("Poppins", 9F);
            cmbMemPayPeriod.ForeColor = Color.FromArgb(52, 52, 58);
            cmbMemPayPeriod.Items.AddRange(new object[] { "All Time", "This Week", "This Month", "This Semester" });
            cmbMemPayPeriod.Location = new Point(366, 4);
            cmbMemPayPeriod.Name = "cmbMemPayPeriod";
            cmbMemPayPeriod.Size = new Size(150, 34);
            cmbMemPayPeriod.TabIndex = 2;
            cmbMemPayPeriod.SelectedIndexChanged += cmbMemPayPeriod_SelectedIndexChanged;
            // 
            // btnRecordMemPayment
            // 
            btnRecordMemPayment.BackColor = Color.FromArgb(58, 99, 232);
            btnRecordMemPayment.FlatAppearance.BorderSize = 0;
            btnRecordMemPayment.FlatStyle = FlatStyle.Flat;
            btnRecordMemPayment.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecordMemPayment.ForeColor = Color.White;
            btnRecordMemPayment.IconChar = IconChar.Add;
            btnRecordMemPayment.IconColor = Color.White;
            btnRecordMemPayment.IconFont = IconFont.Auto;
            btnRecordMemPayment.IconSize = 16;
            btnRecordMemPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecordMemPayment.Location = new Point(524, 4);
            btnRecordMemPayment.Name = "btnRecordMemPayment";
            btnRecordMemPayment.Padding = new Padding(8, 0, 0, 0);
            btnRecordMemPayment.Size = new Size(142, 32);
            btnRecordMemPayment.TabIndex = 3;
            btnRecordMemPayment.Text = "Record Payment";
            btnRecordMemPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnRecordMemPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecordMemPayment.UseVisualStyleBackColor = false;
            btnRecordMemPayment.Click += btnRecordMemPayment_Click;
            // 
            // btnMemPayRemind
            // 
            btnMemPayRemind.BackColor = Color.White;
            btnMemPayRemind.FlatAppearance.BorderColor = Color.FromArgb(217, 119, 6);
            btnMemPayRemind.FlatStyle = FlatStyle.Flat;
            btnMemPayRemind.Font = new Font("Poppins", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMemPayRemind.ForeColor = Color.FromArgb(217, 119, 6);
            btnMemPayRemind.IconChar = IconChar.Bell;
            btnMemPayRemind.IconColor = Color.FromArgb(217, 119, 6);
            btnMemPayRemind.IconFont = IconFont.Auto;
            btnMemPayRemind.IconSize = 16;
            btnMemPayRemind.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemPayRemind.Location = new Point(674, 4);
            btnMemPayRemind.Name = "btnMemPayRemind";
            btnMemPayRemind.Padding = new Padding(8, 0, 0, 0);
            btnMemPayRemind.Size = new Size(96, 32);
            btnMemPayRemind.TabIndex = 4;
            btnMemPayRemind.Text = "Remind";
            btnMemPayRemind.TextAlign = ContentAlignment.MiddleLeft;
            btnMemPayRemind.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMemPayRemind.UseVisualStyleBackColor = false;
            // 
            // btnMemPayExport
            // 
            btnMemPayExport.BackColor = Color.White;
            btnMemPayExport.FlatAppearance.BorderColor = Color.FromArgb(236, 230, 222);
            btnMemPayExport.FlatStyle = FlatStyle.Flat;
            btnMemPayExport.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnMemPayExport.ForeColor = Color.FromArgb(82, 82, 91);
            btnMemPayExport.IconChar = IconChar.FileArrowDown;
            btnMemPayExport.IconColor = Color.FromArgb(82, 82, 91);
            btnMemPayExport.IconFont = IconFont.Auto;
            btnMemPayExport.IconSize = 16;
            btnMemPayExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnMemPayExport.Location = new Point(778, 4);
            btnMemPayExport.Name = "btnMemPayExport";
            btnMemPayExport.Padding = new Padding(8, 0, 0, 0);
            btnMemPayExport.Size = new Size(40, 32);
            btnMemPayExport.TabIndex = 5;
            btnMemPayExport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMemPayExport.UseVisualStyleBackColor = false;
            btnMemPayExport.Click += btnMemPayExport_Click;
            // 
            // dgvMemPayments
            // 
            dgvMemPayments.AllowUserToAddRows = false;
            dgvMemPayments.AllowUserToDeleteRows = false;
            dgvMemPayments.BackgroundColor = Color.White;
            dgvMemPayments.BorderStyle = BorderStyle.None;
            dgvMemPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle7.Font = new Font("Poppins", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(122, 122, 128);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(244, 239, 231);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvMemPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvMemPayments.ColumnHeadersHeight = 36;
            dgvMemPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMemPayments.Columns.AddRange(new DataGridViewColumn[] { colMemPayId, colMemPayStudentNo, colMemPayName, colMemPayAmountDue, colMemPayAmountPaid, colMemPayBalance, colMemPayDate, colMemPayMethod, colMemPayCollectedBy, colMemPayReceiptNo, colMemPayStatus, colMemPayActions });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(52, 52, 58);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvMemPayments.DefaultCellStyle = dataGridViewCellStyle9;
            dgvMemPayments.EnableHeadersVisualStyles = false;
            dgvMemPayments.GridColor = Color.FromArgb(236, 230, 222);
            dgvMemPayments.Location = new Point(28, 140);
            dgvMemPayments.Name = "dgvMemPayments";
            dgvMemPayments.ReadOnly = true;
            dgvMemPayments.RowHeadersVisible = false;
            dgvMemPayments.RowHeadersWidth = 51;
            dgvMemPayments.RowTemplate.Height = 36;
            dgvMemPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemPayments.Size = new Size(818, 242);
            dgvMemPayments.TabIndex = 4;
            dgvMemPayments.CellContentClick += dgvMemPayments_CellContentClick;
            // 
            // colMemPayId
            // 
            colMemPayId.HeaderText = "Pay ID";
            colMemPayId.MinimumWidth = 6;
            colMemPayId.Name = "colMemPayId";
            colMemPayId.ReadOnly = true;
            colMemPayId.Width = 60;
            // 
            // colMemPayStudentNo
            // 
            colMemPayStudentNo.HeaderText = "Student No.";
            colMemPayStudentNo.MinimumWidth = 6;
            colMemPayStudentNo.Name = "colMemPayStudentNo";
            colMemPayStudentNo.ReadOnly = true;
            colMemPayStudentNo.Width = 95;
            // 
            // colMemPayName
            // 
            colMemPayName.HeaderText = "Name";
            colMemPayName.MinimumWidth = 6;
            colMemPayName.Name = "colMemPayName";
            colMemPayName.ReadOnly = true;
            colMemPayName.Width = 130;
            // 
            // colMemPayAmountDue
            // 
            colMemPayAmountDue.HeaderText = "Amount Due (₱)";
            colMemPayAmountDue.MinimumWidth = 6;
            colMemPayAmountDue.Name = "colMemPayAmountDue";
            colMemPayAmountDue.ReadOnly = true;
            colMemPayAmountDue.Width = 120;
            // 
            // colMemPayAmountPaid
            // 
            colMemPayAmountPaid.HeaderText = "Paid (₱)";
            colMemPayAmountPaid.MinimumWidth = 6;
            colMemPayAmountPaid.Name = "colMemPayAmountPaid";
            colMemPayAmountPaid.ReadOnly = true;
            colMemPayAmountPaid.Width = 75;
            // 
            // colMemPayBalance
            // 
            colMemPayBalance.HeaderText = "Balance (₱)";
            colMemPayBalance.MinimumWidth = 6;
            colMemPayBalance.Name = "colMemPayBalance";
            colMemPayBalance.ReadOnly = true;
            colMemPayBalance.Width = 85;
            // 
            // colMemPayDate
            // 
            colMemPayDate.HeaderText = "Payment Date";
            colMemPayDate.MinimumWidth = 6;
            colMemPayDate.Name = "colMemPayDate";
            colMemPayDate.ReadOnly = true;
            colMemPayDate.Width = 115;
            // 
            // colMemPayMethod
            // 
            colMemPayMethod.HeaderText = "Method";
            colMemPayMethod.MinimumWidth = 6;
            colMemPayMethod.Name = "colMemPayMethod";
            colMemPayMethod.ReadOnly = true;
            colMemPayMethod.Width = 80;
            // 
            // colMemPayCollectedBy
            // 
            colMemPayCollectedBy.HeaderText = "Collected By";
            colMemPayCollectedBy.MinimumWidth = 6;
            colMemPayCollectedBy.Name = "colMemPayCollectedBy";
            colMemPayCollectedBy.ReadOnly = true;
            colMemPayCollectedBy.Width = 110;
            // 
            // colMemPayReceiptNo
            // 
            colMemPayReceiptNo.HeaderText = "Receipt No.";
            colMemPayReceiptNo.MinimumWidth = 6;
            colMemPayReceiptNo.Name = "colMemPayReceiptNo";
            colMemPayReceiptNo.ReadOnly = true;
            colMemPayReceiptNo.Width = 95;
            // 
            // colMemPayStatus
            // 
            colMemPayStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMemPayStatus.HeaderText = "Status";
            colMemPayStatus.MinimumWidth = 6;
            colMemPayStatus.Name = "colMemPayStatus";
            colMemPayStatus.ReadOnly = true;
            // 
            // colMemPayActions
            // 
            colMemPayActions.DefaultCellStyle = dataGridViewCellStyle8;
            colMemPayActions.FlatStyle = FlatStyle.Flat;
            colMemPayActions.HeaderText = "";
            colMemPayActions.MinimumWidth = 6;
            colMemPayActions.Name = "colMemPayActions";
            colMemPayActions.ReadOnly = true;
            colMemPayActions.Text = "···";
            colMemPayActions.UseColumnTextForButtonValue = true;
            colMemPayActions.Width = 40;
            // 
            // pnlMemPayPagination
            // 
            pnlMemPayPagination.BackColor = Color.White;
            pnlMemPayPagination.Controls.Add(lblMemPayPageInfo);
            pnlMemPayPagination.Controls.Add(btnMemPayPrev);
            pnlMemPayPagination.Controls.Add(btnMemPayNext);
            pnlMemPayPagination.Location = new Point(28, 390);
            pnlMemPayPagination.Name = "pnlMemPayPagination";
            pnlMemPayPagination.Size = new Size(818, 38);
            pnlMemPayPagination.TabIndex = 5;
            // 
            // lblMemPayPageInfo
            // 
            lblMemPayPageInfo.AutoSize = true;
            lblMemPayPageInfo.Font = new Font("Poppins", 8.5F);
            lblMemPayPageInfo.ForeColor = Color.FromArgb(122, 122, 128);
            lblMemPayPageInfo.Location = new Point(0, 10);
            lblMemPayPageInfo.Name = "lblMemPayPageInfo";
            lblMemPayPageInfo.Size = new Size(225, 26);
            lblMemPayPageInfo.TabIndex = 0;
            lblMemPayPageInfo.Text = "Showing 1–20 of 0 payments";
            // 
            // btnMemPayPrev
            // 
            btnMemPayPrev.BackColor = Color.White;
            btnMemPayPrev.FlatAppearance.BorderColor = Color.FromArgb(236, 230, 222);
            btnMemPayPrev.FlatStyle = FlatStyle.Flat;
            btnMemPayPrev.IconChar = IconChar.ChevronLeft;
            btnMemPayPrev.IconColor = Color.FromArgb(82, 82, 91);
            btnMemPayPrev.IconFont = IconFont.Auto;
            btnMemPayPrev.IconSize = 14;
            btnMemPayPrev.Location = new Point(740, 3);
            btnMemPayPrev.Name = "btnMemPayPrev";
            btnMemPayPrev.Size = new Size(34, 32);
            btnMemPayPrev.TabIndex = 1;
            btnMemPayPrev.UseVisualStyleBackColor = false;
            btnMemPayPrev.Click += btnMemPayPrev_Click;
            // 
            // btnMemPayNext
            // 
            btnMemPayNext.BackColor = Color.White;
            btnMemPayNext.FlatAppearance.BorderColor = Color.FromArgb(236, 230, 222);
            btnMemPayNext.FlatStyle = FlatStyle.Flat;
            btnMemPayNext.IconChar = IconChar.ChevronRight;
            btnMemPayNext.IconColor = Color.FromArgb(82, 82, 91);
            btnMemPayNext.IconFont = IconFont.Auto;
            btnMemPayNext.IconSize = 14;
            btnMemPayNext.Location = new Point(782, 3);
            btnMemPayNext.Name = "btnMemPayNext";
            btnMemPayNext.Size = new Size(34, 32);
            btnMemPayNext.TabIndex = 2;
            btnMemPayNext.UseVisualStyleBackColor = false;
            btnMemPayNext.Click += btnMemPayNext_Click;
            // 
            // cardMemPolicy
            // 
            cardMemPolicy.BackColor = Color.White;
            cardMemPolicy.Controls.Add(pnlMemPolIconBox);
            cardMemPolicy.Controls.Add(lblMemPolTitle);
            cardMemPolicy.Controls.Add(btnGoToMemSettings);
            cardMemPolicy.Controls.Add(dividerMemPol);
            cardMemPolicy.Controls.Add(pnlMemPolTile);
            cardMemPolicy.Controls.Add(dividerMemPolFooter);
            cardMemPolicy.Location = new Point(30, 652);
            cardMemPolicy.Name = "cardMemPolicy";
            cardMemPolicy.Padding = new Padding(28, 24, 28, 24);
            cardMemPolicy.Size = new Size(874, 375);
            cardMemPolicy.TabIndex = 2;
            // 
            // pnlMemPolIconBox
            // 
            pnlMemPolIconBox.BackColor = Color.FromArgb(230, 255, 242);
            pnlMemPolIconBox.Controls.Add(iconMemPol);
            pnlMemPolIconBox.Location = new Point(28, 24);
            pnlMemPolIconBox.Name = "pnlMemPolIconBox";
            pnlMemPolIconBox.Size = new Size(44, 44);
            pnlMemPolIconBox.TabIndex = 0;
            // 
            // iconMemPol
            // 
            iconMemPol.BackColor = Color.Transparent;
            iconMemPol.ForeColor = Color.FromArgb(16, 163, 92);
            iconMemPol.IconChar = IconChar.DriversLicense;
            iconMemPol.IconColor = Color.FromArgb(16, 163, 92);
            iconMemPol.IconFont = IconFont.Auto;
            iconMemPol.IconSize = 22;
            iconMemPol.Location = new Point(11, 11);
            iconMemPol.Name = "iconMemPol";
            iconMemPol.Size = new Size(22, 22);
            iconMemPol.TabIndex = 0;
            iconMemPol.TabStop = false;
            // 
            // lblMemPolTitle
            // 
            lblMemPolTitle.AutoSize = true;
            lblMemPolTitle.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblMemPolTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblMemPolTitle.Location = new Point(82, 29);
            lblMemPolTitle.Name = "lblMemPolTitle";
            lblMemPolTitle.Size = new Size(241, 34);
            lblMemPolTitle.TabIndex = 1;
            lblMemPolTitle.Text = "Membership Fee Policy";
            // 
            // btnGoToMemSettings
            // 
            btnGoToMemSettings.BackColor = Color.White;
            btnGoToMemSettings.FlatAppearance.BorderColor = Color.FromArgb(58, 99, 232);
            btnGoToMemSettings.FlatStyle = FlatStyle.Flat;
            btnGoToMemSettings.Font = new Font("Poppins", 7.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToMemSettings.ForeColor = Color.FromArgb(58, 99, 232);
            btnGoToMemSettings.IconChar = IconChar.ArrowUpRightFromSquare;
            btnGoToMemSettings.IconColor = Color.FromArgb(58, 99, 232);
            btnGoToMemSettings.IconFont = IconFont.Auto;
            btnGoToMemSettings.IconSize = 14;
            btnGoToMemSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoToMemSettings.Location = new Point(672, 28);
            btnGoToMemSettings.Name = "btnGoToMemSettings";
            btnGoToMemSettings.Padding = new Padding(8, 0, 0, 0);
            btnGoToMemSettings.Size = new Size(174, 34);
            btnGoToMemSettings.TabIndex = 2;
            btnGoToMemSettings.Text = "Manage in Settings";
            btnGoToMemSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnGoToMemSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGoToMemSettings.UseVisualStyleBackColor = false;
            btnGoToMemSettings.Click += btnGoToMemSettings_Click;
            // 
            // dividerMemPol
            // 
            dividerMemPol.BackColor = Color.FromArgb(236, 230, 222);
            dividerMemPol.Location = new Point(28, 78);
            dividerMemPol.Name = "dividerMemPol";
            dividerMemPol.Size = new Size(818, 1);
            dividerMemPol.TabIndex = 3;
            // 
            // pnlMemPolTile
            // 
            pnlMemPolTile.BackColor = Color.FromArgb(250, 250, 252);
            pnlMemPolTile.Controls.Add(lblMemPolTileApplied);
            pnlMemPolTile.Controls.Add(pnlMemPolTileAccent);
            pnlMemPolTile.Controls.Add(iconMemPolTile);
            pnlMemPolTile.Controls.Add(lblMemPolTileName);
            pnlMemPolTile.Controls.Add(lblMemPolTileType);
            pnlMemPolTile.Controls.Add(lblMemPolTileAmount);
            pnlMemPolTile.Location = new Point(28, 116);
            pnlMemPolTile.Name = "pnlMemPolTile";
            pnlMemPolTile.Size = new Size(818, 150);
            pnlMemPolTile.TabIndex = 4;
            // 
            // lblMemPolTileApplied
            // 
            lblMemPolTileApplied.AutoSize = true;
            lblMemPolTileApplied.Font = new Font("Poppins", 8.5F);
            lblMemPolTileApplied.ForeColor = Color.FromArgb(161, 161, 170);
            lblMemPolTileApplied.Location = new Point(584, 121);
            lblMemPolTileApplied.Name = "lblMemPolTileApplied";
            lblMemPolTileApplied.Size = new Size(231, 26);
            lblMemPolTileApplied.TabIndex = 5;
            lblMemPolTileApplied.Text = "Applied 0 times this semester";
            // 
            // pnlMemPolTileAccent
            // 
            pnlMemPolTileAccent.BackColor = Color.FromArgb(16, 163, 92);
            pnlMemPolTileAccent.Location = new Point(0, 0);
            pnlMemPolTileAccent.Name = "pnlMemPolTileAccent";
            pnlMemPolTileAccent.Size = new Size(4, 150);
            pnlMemPolTileAccent.TabIndex = 0;
            // 
            // iconMemPolTile
            // 
            iconMemPolTile.BackColor = Color.FromArgb(230, 255, 242);
            iconMemPolTile.ForeColor = Color.FromArgb(16, 163, 92);
            iconMemPolTile.IconChar = IconChar.DriversLicense;
            iconMemPolTile.IconColor = Color.FromArgb(16, 163, 92);
            iconMemPolTile.IconFont = IconFont.Auto;
            iconMemPolTile.IconSize = 44;
            iconMemPolTile.Location = new Point(20, 53);
            iconMemPolTile.Name = "iconMemPolTile";
            iconMemPolTile.Size = new Size(44, 44);
            iconMemPolTile.TabIndex = 1;
            iconMemPolTile.TabStop = false;
            // 
            // lblMemPolTileName
            // 
            lblMemPolTileName.AutoSize = true;
            lblMemPolTileName.Font = new Font("Poppins", 10F, FontStyle.Bold);
            lblMemPolTileName.ForeColor = Color.FromArgb(20, 20, 20);
            lblMemPolTileName.Location = new Point(78, 40);
            lblMemPolTileName.Name = "lblMemPolTileName";
            lblMemPolTileName.Size = new Size(156, 30);
            lblMemPolTileName.TabIndex = 2;
            lblMemPolTileName.Text = "Membership Fee";
            // 
            // lblMemPolTileType
            // 
            lblMemPolTileType.AutoSize = true;
            lblMemPolTileType.Font = new Font("Poppins", 8.5F);
            lblMemPolTileType.ForeColor = Color.FromArgb(122, 122, 128);
            lblMemPolTileType.Location = new Point(78, 68);
            lblMemPolTileType.Name = "lblMemPolTileType";
            lblMemPolTileType.Size = new Size(412, 26);
            lblMemPolTileType.TabIndex = 3;
            lblMemPolTileType.Text = "Type: Financial  ·  Per semester  ·  Grace period: 7 days";
            // 
            // lblMemPolTileAmount
            // 
            lblMemPolTileAmount.AutoSize = true;
            lblMemPolTileAmount.Font = new Font("Poppins", 18F, FontStyle.Bold);
            lblMemPolTileAmount.ForeColor = Color.FromArgb(16, 163, 92);
            lblMemPolTileAmount.Location = new Point(78, 90);
            lblMemPolTileAmount.Name = "lblMemPolTileAmount";
            lblMemPolTileAmount.Size = new Size(152, 53);
            lblMemPolTileAmount.TabIndex = 4;
            lblMemPolTileAmount.Text = "₱250.00";
            // 
            // dividerMemPolFooter
            // 
            dividerMemPolFooter.BackColor = Color.FromArgb(236, 230, 222);
            dividerMemPolFooter.Location = new Point(28, 340);
            dividerMemPolFooter.Name = "dividerMemPolFooter";
            dividerMemPolFooter.Size = new Size(818, 1);
            dividerMemPolFooter.TabIndex = 5;
            // 
            // PaymentsView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "PaymentsView";
            Size = new Size(955, 500);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            cardSummary.ResumeLayout(false);
            pnlStatCollected.ResumeLayout(false);
            pnlStatCollected.PerformLayout();
            pnlStatCollectedIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatCollected).EndInit();
            pnlStatPaid.ResumeLayout(false);
            pnlStatPaid.PerformLayout();
            pnlStatPaidIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatPaid).EndInit();
            pnlStatUnpaid.ResumeLayout(false);
            pnlStatUnpaid.PerformLayout();
            pnlStatUnpaidIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatUnpaid).EndInit();
            pnlStatPartial.ResumeLayout(false);
            pnlStatPartial.PerformLayout();
            pnlStatPartialIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconStatPartial).EndInit();
            cardMemPayments.ResumeLayout(false);
            cardMemPayments.PerformLayout();
            pnlMemPayIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMemPay).EndInit();
            pnlMemPayToolbar.ResumeLayout(false);
            pnlMemPaySearch.ResumeLayout(false);
            pnlMemPaySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPaySearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMemPayments).EndInit();
            pnlMemPayPagination.ResumeLayout(false);
            pnlMemPayPagination.PerformLayout();
            cardMemPolicy.ResumeLayout(false);
            cardMemPolicy.PerformLayout();
            pnlMemPolIconBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMemPol).EndInit();
            pnlMemPolTile.ResumeLayout(false);
            pnlMemPolTile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMemPolTile).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private System.Windows.Forms.Panel outerScrollPanel;
        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Panel cardSummary;
        private System.Windows.Forms.Panel pnlStatCollected;
        private System.Windows.Forms.Panel pnlStatCollectedIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatCollected;
        private System.Windows.Forms.Label lblStatCollectedNum;
        private System.Windows.Forms.Label lblStatCollectedUnit;
        private System.Windows.Forms.Label lblStatCollectedCaption;
        private System.Windows.Forms.Panel pnlStatPaid;
        private System.Windows.Forms.Panel pnlStatPaidIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatPaid;
        private System.Windows.Forms.Label lblStatPaidNum;
        private System.Windows.Forms.Label lblStatPaidUnit;
        private System.Windows.Forms.Label lblStatPaidCaption;
        private System.Windows.Forms.Panel pnlStatUnpaid;
        private System.Windows.Forms.Panel pnlStatUnpaidIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatUnpaid;
        private System.Windows.Forms.Label lblStatUnpaidNum;
        private System.Windows.Forms.Label lblStatUnpaidUnit;
        private System.Windows.Forms.Label lblStatUnpaidCaption;
        private System.Windows.Forms.Panel pnlStatPartial;
        private System.Windows.Forms.Panel pnlStatPartialIcon;
        private FontAwesome.Sharp.IconPictureBox iconStatPartial;
        private System.Windows.Forms.Label lblStatPartialNum;
        private System.Windows.Forms.Label lblStatPartialUnit;
        private System.Windows.Forms.Label lblStatPartialCaption;
        private System.Windows.Forms.Panel cardMemPayments;
        private System.Windows.Forms.Panel pnlMemPayIconBox;
        private FontAwesome.Sharp.IconPictureBox iconMemPay;
        private System.Windows.Forms.Label lblMemPayTitle;
        private System.Windows.Forms.Panel dividerMemPay;
        private System.Windows.Forms.Panel pnlMemPayToolbar;
        private System.Windows.Forms.Panel pnlMemPaySearch;
        private FontAwesome.Sharp.IconPictureBox iconMemPaySearch;
        private System.Windows.Forms.TextBox txtMemPaySearch;
        private System.Windows.Forms.ComboBox cmbMemPayStatus;
        private System.Windows.Forms.ComboBox cmbMemPayPeriod;
        private FontAwesome.Sharp.IconButton btnRecordMemPayment;
        private FontAwesome.Sharp.IconButton btnMemPayRemind;
        private FontAwesome.Sharp.IconButton btnMemPayExport;
        private System.Windows.Forms.DataGridView dgvMemPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayAmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayAmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayCollectedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemPayStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colMemPayActions;
        private System.Windows.Forms.Panel pnlMemPayPagination;
        private System.Windows.Forms.Label lblMemPayPageInfo;
        private FontAwesome.Sharp.IconButton btnMemPayPrev;
        private FontAwesome.Sharp.IconButton btnMemPayNext;
        private System.Windows.Forms.Panel cardMemPolicy;
        private System.Windows.Forms.Panel pnlMemPolIconBox;
        private FontAwesome.Sharp.IconPictureBox iconMemPol;
        private System.Windows.Forms.Label lblMemPolTitle;
        private FontAwesome.Sharp.IconButton btnGoToMemSettings;
        private System.Windows.Forms.Panel dividerMemPol;
        private System.Windows.Forms.Panel pnlMemPolTile;
        private System.Windows.Forms.Panel pnlMemPolTileAccent;
        private FontAwesome.Sharp.IconPictureBox iconMemPolTile;
        private System.Windows.Forms.Label lblMemPolTileName;
        private System.Windows.Forms.Label lblMemPolTileType;
        private System.Windows.Forms.Label lblMemPolTileAmount;
        private System.Windows.Forms.Label lblMemPolTileApplied;
        private System.Windows.Forms.Panel dividerMemPolFooter;
    }
}
