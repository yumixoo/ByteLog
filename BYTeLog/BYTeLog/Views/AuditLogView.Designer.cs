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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            outerScrollPanel = new Panel();
            innerContentPanel = new Panel();
            toolbarCard = new Panel();
            searchIconPanel = new Panel();
            iconSearch = new IconPictureBox();
            txtSearch = new TextBox();
            toolbarDivider = new Panel();
            cmbFilterTable = new ComboBox();
            cmbFilterAction = new ComboBox();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnApplyFilter = new IconButton();
            btnClearFilter = new IconButton();
            btnExport = new IconButton();
            lblDateSeparator = new Label();
            summaryStrip = new Panel();
            cardTotal = new Panel();
            iconTotal = new IconPictureBox();
            lblTotalCaption = new Label();
            lblTotalCount = new Label();
            cardInsert = new Panel();
            iconInsert = new IconPictureBox();
            lblInsertCaption = new Label();
            lblInsertCount = new Label();
            cardUpdate = new Panel();
            iconUpdate = new IconPictureBox();
            lblUpdateCount = new Label();
            lblUpdateCaption = new Label();
            cardDelete = new Panel();
            iconDelete = new IconPictureBox();
            lblDeleteCount = new Label();
            lblDeleteCaption = new Label();
            tableCard = new Panel();
            tableCardHeader = new Panel();
            lblTableTitle = new Label();
            tableCardDivider = new Panel();
            dgvAuditLog = new DataGridView();
            colLogID = new DataGridViewTextBoxColumn();
            colTimestamp = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            colTableAffected = new DataGridViewTextBoxColumn();
            colRecordID = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            paginationPanel = new Panel();
            lblPaginationInfo = new Label();
            btnPrevPage = new IconButton();
            lblPageNumber = new Label();
            btnNextPage = new IconButton();
            paginationTopLine = new Panel();
            lblSearchHint = new Label();
            lblFilterByTable = new Label();

            outerScrollPanel.SuspendLayout();
            innerContentPanel.SuspendLayout();
            toolbarCard.SuspendLayout();
            searchIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).BeginInit();
            summaryStrip.SuspendLayout();
            cardTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotal).BeginInit();
            cardInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconInsert).BeginInit();
            cardUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUpdate).BeginInit();
            cardDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconDelete).BeginInit();
            tableCard.SuspendLayout();
            tableCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).BeginInit();
            paginationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // outerScrollPanel
            // 
            outerScrollPanel.AutoScroll = true;
            outerScrollPanel.AutoScrollMinSize = new Size(0, 680);
            outerScrollPanel.BackColor = Color.FromArgb(244, 239, 231);
            outerScrollPanel.Controls.Add(innerContentPanel);
            outerScrollPanel.Dock = DockStyle.Fill;
            outerScrollPanel.Location = new Point(0, 0);
            outerScrollPanel.Name = "outerScrollPanel";
            outerScrollPanel.Size = new Size(955, 790);
            outerScrollPanel.TabIndex = 0;
            // 
            // innerContentPanel
            // 
            innerContentPanel.BackColor = Color.FromArgb(244, 239, 231);
            innerContentPanel.Controls.Add(toolbarCard);
            innerContentPanel.Controls.Add(summaryStrip);
            innerContentPanel.Controls.Add(tableCard);
            innerContentPanel.Location = new Point(0, 0);
            innerContentPanel.Name = "innerContentPanel";
            innerContentPanel.Size = new Size(934, 760);
            innerContentPanel.TabIndex = 0;
            // 
            // toolbarCard
            // 
            toolbarCard.BackColor = Color.White;
            toolbarCard.Controls.Add(searchIconPanel);
            toolbarCard.Controls.Add(toolbarDivider);
            toolbarCard.Controls.Add(cmbFilterTable);
            toolbarCard.Controls.Add(cmbFilterAction);
            toolbarCard.Controls.Add(dtpFrom);
            toolbarCard.Controls.Add(dtpTo);
            toolbarCard.Controls.Add(btnApplyFilter);
            toolbarCard.Controls.Add(btnClearFilter);
            toolbarCard.Controls.Add(btnExport);
            toolbarCard.Controls.Add(lblDateSeparator);
            toolbarCard.Location = new Point(20, 20);
            toolbarCard.Name = "toolbarCard";
            toolbarCard.Size = new Size(915, 108);
            toolbarCard.TabIndex = 0;
            toolbarCard.Paint += ToolbarCard_Paint;
            // 
            // searchIconPanel
            // 
            searchIconPanel.BackColor = Color.FromArgb(248, 248, 250);
            searchIconPanel.BorderStyle = BorderStyle.FixedSingle;
            searchIconPanel.Controls.Add(iconSearch);
            searchIconPanel.Controls.Add(txtSearch);
            searchIconPanel.Location = new Point(20, 16);
            searchIconPanel.Name = "searchIconPanel";
            searchIconPanel.Size = new Size(300, 36);
            searchIconPanel.TabIndex = 0;
            // 
            // iconSearch
            // 
            iconSearch.BackColor = Color.Transparent;
            iconSearch.ForeColor = Color.FromArgb(161, 161, 170);
            iconSearch.IconChar = IconChar.Search;
            iconSearch.IconColor = Color.FromArgb(161, 161, 170);
            iconSearch.IconFont = IconFont.Auto;
            iconSearch.IconSize = 18;
            iconSearch.Location = new Point(8, 8);
            iconSearch.Name = "iconSearch";
            iconSearch.Size = new Size(20, 18);
            iconSearch.TabIndex = 0;
            iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(248, 248, 250);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Poppins", 9F);
            txtSearch.ForeColor = Color.FromArgb(82, 82, 91);
            txtSearch.Location = new Point(34, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search logs…";
            txtSearch.Size = new Size(258, 23);
            txtSearch.TabIndex = 1;
            // 
            // toolbarDivider
            // 
            toolbarDivider.BackColor = Color.FromArgb(236, 230, 222);
            toolbarDivider.Location = new Point(20, 62);
            toolbarDivider.Name = "toolbarDivider";
            toolbarDivider.Size = new Size(875, 1);
            toolbarDivider.TabIndex = 9;
            // 
            // cmbFilterTable
            // 
            cmbFilterTable.BackColor = Color.FromArgb(248, 248, 250);
            cmbFilterTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterTable.FlatStyle = FlatStyle.Flat;
            cmbFilterTable.Font = new Font("Poppins", 9F);
            cmbFilterTable.ForeColor = Color.FromArgb(82, 82, 91);
            cmbFilterTable.Items.AddRange(new object[] { "All Tables", "STUDENT", "MEMBERSHIP", "MEM_PAYMENT", "MEM_POLICY", "ACTIVITY", "ATTENDANCE", "CHECKPOINT", "PENALTY", "PEN_PAYMENT", "PEN_POLICY", "CLEARANCE", "ARCHIVE", "OFFICER", "COMMITTEE", "USER", "ROLE", "PERMISSION", "ROLE_PERMISSION", "LOG" });
            cmbFilterTable.Location = new Point(20, 72);
            cmbFilterTable.Name = "cmbFilterTable";
            cmbFilterTable.Size = new Size(160, 34);
            cmbFilterTable.TabIndex = 2;
            // 
            // cmbFilterAction
            // 
            cmbFilterAction.BackColor = Color.FromArgb(248, 248, 250);
            cmbFilterAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterAction.FlatStyle = FlatStyle.Flat;
            cmbFilterAction.Font = new Font("Poppins", 9F);
            cmbFilterAction.ForeColor = Color.FromArgb(82, 82, 91);
            cmbFilterAction.Items.AddRange(new object[] { "All Actions", "INSERT", "UPDATE", "DELETE", "LOGIN", "LOGOUT" });
            cmbFilterAction.Location = new Point(192, 72);
            cmbFilterAction.Name = "cmbFilterAction";
            cmbFilterAction.Size = new Size(130, 34);
            cmbFilterAction.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarFont = new Font("Poppins", 9F);
            dtpFrom.Font = new Font("Poppins", 9F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(334, 72);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(120, 30);
            dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            dtpTo.CalendarFont = new Font("Poppins", 9F);
            dtpTo.Font = new Font("Poppins", 9F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(480, 72);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(120, 30);
            dtpTo.TabIndex = 5;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(58, 99, 232);
            btnApplyFilter.FlatAppearance.BorderSize = 0;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.IconChar = IconChar.Filter;
            btnApplyFilter.IconColor = Color.White;
            btnApplyFilter.IconFont = IconFont.Auto;
            btnApplyFilter.IconSize = 14;
            btnApplyFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplyFilter.Location = new Point(614, 69);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Padding = new Padding(6, 0, 0, 0);
            btnApplyFilter.Size = new Size(100, 32);
            btnApplyFilter.TabIndex = 6;
            btnApplyFilter.Text = "Filter";
            btnApplyFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnApplyFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(248, 248, 250);
            btnClearFilter.FlatAppearance.BorderColor = Color.FromArgb(214, 211, 206);
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("Poppins", 9F);
            btnClearFilter.ForeColor = Color.FromArgb(82, 82, 91);
            btnClearFilter.IconChar = IconChar.Close;
            btnClearFilter.IconColor = Color.FromArgb(161, 161, 170);
            btnClearFilter.IconFont = IconFont.Auto;
            btnClearFilter.IconSize = 14;
            btnClearFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearFilter.Location = new Point(722, 69);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Padding = new Padding(6, 0, 0, 0);
            btnClearFilter.Size = new Size(90, 32);
            btnClearFilter.TabIndex = 7;
            btnClearFilter.Text = "Clear";
            btnClearFilter.TextAlign = ContentAlignment.MiddleLeft;
            btnClearFilter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(248, 248, 250);
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(214, 211, 206);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Poppins", 9F);
            btnExport.ForeColor = Color.FromArgb(82, 82, 91);
            btnExport.IconChar = IconChar.None;
            btnExport.IconColor = Color.FromArgb(161, 161, 170);
            btnExport.IconFont = IconFont.Auto;
            btnExport.IconSize = 14;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(820, 69);
            btnExport.Name = "btnExport";
            btnExport.Padding = new Padding(6, 0, 0, 0);
            btnExport.Size = new Size(75, 32);
            btnExport.TabIndex = 8;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblDateSeparator
            // 
            lblDateSeparator.AutoSize = true;
            lblDateSeparator.Font = new Font("Poppins", 9F);
            lblDateSeparator.ForeColor = Color.FromArgb(161, 161, 170);
            lblDateSeparator.Location = new Point(456, 74);
            lblDateSeparator.Name = "lblDateSeparator";
            lblDateSeparator.Size = new Size(22, 26);
            lblDateSeparator.TabIndex = 10;
            lblDateSeparator.Text = "–";
            // 
            // summaryStrip
            // 
            summaryStrip.BackColor = Color.Transparent;
            summaryStrip.Controls.Add(cardTotal);
            summaryStrip.Controls.Add(cardInsert);
            summaryStrip.Controls.Add(cardUpdate);
            summaryStrip.Controls.Add(cardDelete);
            summaryStrip.Location = new Point(20, 142);
            summaryStrip.Name = "summaryStrip";
            summaryStrip.Size = new Size(915, 90);
            summaryStrip.TabIndex = 1;
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(iconTotal);
            cardTotal.Controls.Add(lblTotalCaption);
            cardTotal.Controls.Add(lblTotalCount);
            cardTotal.Location = new Point(0, 0);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(219, 90);
            cardTotal.TabIndex = 0;
            cardTotal.Paint += StatCard_Paint;
            // 
            // iconTotal
            // 
            iconTotal.BackColor = Color.FromArgb(233, 239, 255);
            iconTotal.ForeColor = Color.FromArgb(58, 99, 232);
            iconTotal.IconChar = IconChar.ClipboardList;
            iconTotal.IconColor = Color.FromArgb(58, 99, 232);
            iconTotal.IconFont = IconFont.Auto;
            iconTotal.IconSize = 46;
            iconTotal.Location = new Point(16, 18);
            iconTotal.Name = "iconTotal";
            iconTotal.Size = new Size(46, 46);
            iconTotal.TabIndex = 0;
            iconTotal.TabStop = false;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Poppins", 8F);
            lblTotalCaption.ForeColor = Color.FromArgb(122, 122, 128);
            lblTotalCaption.Location = new Point(72, 50);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(81, 25);
            lblTotalCaption.TabIndex = 2;
            lblTotalCaption.Text = "Total Logs";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Poppins", 16F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblTotalCount.Location = new Point(72, 14);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(38, 48);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "0";
            // 
            // cardInsert
            // 
            cardInsert.BackColor = Color.White;
            cardInsert.Controls.Add(iconInsert);
            cardInsert.Controls.Add(lblInsertCaption);
            cardInsert.Controls.Add(lblInsertCount);
            cardInsert.Location = new Point(219, 0);
            cardInsert.Name = "cardInsert";
            cardInsert.Size = new Size(219, 90);
            cardInsert.TabIndex = 1;
            cardInsert.Paint += StatCard_Paint;
            // 
            // iconInsert
            // 
            iconInsert.BackColor = Color.FromArgb(220, 252, 231);
            iconInsert.ForeColor = Color.FromArgb(34, 197, 94);
            iconInsert.IconChar = IconChar.CirclePlus;
            iconInsert.IconColor = Color.FromArgb(34, 197, 94);
            iconInsert.IconFont = IconFont.Auto;
            iconInsert.IconSize = 46;
            iconInsert.Location = new Point(16, 18);
            iconInsert.Name = "iconInsert";
            iconInsert.Size = new Size(46, 46);
            iconInsert.TabIndex = 0;
            iconInsert.TabStop = false;
            // 
            // lblInsertCaption
            // 
            lblInsertCaption.AutoSize = true;
            lblInsertCaption.Font = new Font("Poppins", 8F);
            lblInsertCaption.ForeColor = Color.FromArgb(122, 122, 128);
            lblInsertCaption.Location = new Point(72, 50);
            lblInsertCaption.Name = "lblInsertCaption";
            lblInsertCaption.Size = new Size(57, 25);
            lblInsertCaption.TabIndex = 2;
            lblInsertCaption.Text = "Inserts";
            // 
            // lblInsertCount
            // 
            lblInsertCount.AutoSize = true;
            lblInsertCount.Font = new Font("Poppins", 16F, FontStyle.Bold);
            lblInsertCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblInsertCount.Location = new Point(72, 14);
            lblInsertCount.Name = "lblInsertCount";
            lblInsertCount.Size = new Size(38, 48);
            lblInsertCount.TabIndex = 1;
            lblInsertCount.Text = "0";
            // 
            // cardUpdate
            // 
            cardUpdate.BackColor = Color.White;
            cardUpdate.Controls.Add(iconUpdate);
            cardUpdate.Controls.Add(lblUpdateCount);
            cardUpdate.Controls.Add(lblUpdateCaption);
            cardUpdate.Location = new Point(219, 0);
            cardUpdate.Name = "cardUpdate";
            cardUpdate.Size = new Size(219, 90);
            cardUpdate.TabIndex = 2;
            cardUpdate.Paint += StatCard_Paint;
            // 
            // iconUpdate
            // 
            iconUpdate.BackColor = Color.FromArgb(254, 249, 195);
            iconUpdate.ForeColor = Color.FromArgb(234, 179, 8);
            iconUpdate.IconChar = IconChar.Edit;
            iconUpdate.IconColor = Color.FromArgb(234, 179, 8);
            iconUpdate.IconFont = IconFont.Auto;
            iconUpdate.IconSize = 46;
            iconUpdate.Location = new Point(16, 18);
            iconUpdate.Name = "iconUpdate";
            iconUpdate.Size = new Size(46, 46);
            iconUpdate.TabIndex = 0;
            iconUpdate.TabStop = false;
            // 
            // lblUpdateCount
            // 
            lblUpdateCount.AutoSize = true;
            lblUpdateCount.Font = new Font("Poppins", 16F, FontStyle.Bold);
            lblUpdateCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblUpdateCount.Location = new Point(72, 14);
            lblUpdateCount.Name = "lblUpdateCount";
            lblUpdateCount.Size = new Size(38, 48);
            lblUpdateCount.TabIndex = 1;
            lblUpdateCount.Text = "0";
            // 
            // lblUpdateCaption
            // 
            lblUpdateCaption.AutoSize = true;
            lblUpdateCaption.Font = new Font("Poppins", 8F);
            lblUpdateCaption.ForeColor = Color.FromArgb(122, 122, 128);
            lblUpdateCaption.Location = new Point(72, 50);
            lblUpdateCaption.Name = "lblUpdateCaption";
            lblUpdateCaption.Size = new Size(69, 25);
            lblUpdateCaption.TabIndex = 2;
            lblUpdateCaption.Text = "Updates";
            // 
            // cardDelete
            // 
            cardDelete.BackColor = Color.White;
            cardDelete.Controls.Add(iconDelete);
            cardDelete.Controls.Add(lblDeleteCount);
            cardDelete.Controls.Add(lblDeleteCaption);
            cardDelete.Location = new Point(219, 0);
            cardDelete.Name = "cardDelete";
            cardDelete.Size = new Size(219, 90);
            cardDelete.TabIndex = 3;
            cardDelete.Paint += StatCard_Paint;
            // 
            // iconDelete
            // 
            iconDelete.BackColor = Color.FromArgb(254, 226, 226);
            iconDelete.ForeColor = Color.FromArgb(239, 68, 68);
            iconDelete.IconChar = IconChar.Trash;
            iconDelete.IconColor = Color.FromArgb(239, 68, 68);
            iconDelete.IconFont = IconFont.Auto;
            iconDelete.IconSize = 46;
            iconDelete.Location = new Point(16, 18);
            iconDelete.Name = "iconDelete";
            iconDelete.Size = new Size(46, 46);
            iconDelete.TabIndex = 0;
            iconDelete.TabStop = false;
            // 
            // lblDeleteCount
            // 
            lblDeleteCount.AutoSize = true;
            lblDeleteCount.Font = new Font("Poppins", 16F, FontStyle.Bold);
            lblDeleteCount.ForeColor = Color.FromArgb(20, 20, 20);
            lblDeleteCount.Location = new Point(72, 14);
            lblDeleteCount.Name = "lblDeleteCount";
            lblDeleteCount.Size = new Size(38, 48);
            lblDeleteCount.TabIndex = 1;
            lblDeleteCount.Text = "0";
            // 
            // lblDeleteCaption
            // 
            lblDeleteCaption.AutoSize = true;
            lblDeleteCaption.Font = new Font("Poppins", 8F);
            lblDeleteCaption.ForeColor = Color.FromArgb(122, 122, 128);
            lblDeleteCaption.Location = new Point(72, 50);
            lblDeleteCaption.Name = "lblDeleteCaption";
            lblDeleteCaption.Size = new Size(64, 25);
            lblDeleteCaption.TabIndex = 2;
            lblDeleteCaption.Text = "Deletes";
            // 
            // tableCard
            // 
            tableCard.BackColor = Color.White;
            tableCard.Controls.Add(tableCardHeader);
            tableCard.Controls.Add(tableCardDivider);
            tableCard.Controls.Add(dgvAuditLog);
            tableCard.Controls.Add(paginationPanel);
            tableCard.Location = new Point(20, 246);
            tableCard.Name = "tableCard";
            tableCard.Size = new Size(915, 494);
            tableCard.TabIndex = 2;
            tableCard.Paint += ToolbarCard_Paint;
            // 
            // tableCardHeader
            // 
            tableCardHeader.BackColor = Color.White;
            tableCardHeader.Controls.Add(lblTableTitle);
            tableCardHeader.Location = new Point(0, 0);
            tableCardHeader.Name = "tableCardHeader";
            tableCardHeader.Size = new Size(915, 52);
            tableCardHeader.TabIndex = 0;
            // 
            // lblTableTitle
            // 
            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Poppins", 10F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(20, 20, 20);
            lblTableTitle.Location = new Point(20, 14);
            lblTableTitle.Name = "lblTableTitle";
            lblTableTitle.Size = new Size(117, 30);
            lblTableTitle.TabIndex = 0;
            lblTableTitle.Text = "Activity Log";
            // 
            // tableCardDivider
            // 
            tableCardDivider.BackColor = Color.FromArgb(236, 230, 222);
            tableCardDivider.Location = new Point(0, 52);
            tableCardDivider.Name = "tableCardDivider";
            tableCardDivider.Size = new Size(915, 1);
            tableCardDivider.TabIndex = 1;
            // 
            // dgvAuditLog
            // 
            dgvAuditLog.AllowUserToAddRows = false;
            dgvAuditLog.AllowUserToDeleteRows = false;
            dgvAuditLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 249, 247);
            dgvAuditLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLog.BackgroundColor = Color.White;
            dgvAuditLog.BorderStyle = BorderStyle.None;
            dgvAuditLog.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAuditLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 248, 250);
            dataGridViewCellStyle2.Font = new Font("Poppins", 8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(122, 122, 128);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dgvAuditLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAuditLog.ColumnHeadersHeight = 38;
            dgvAuditLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAuditLog.Columns.AddRange(new DataGridViewColumn[] { colLogID, colTimestamp, colUser, colAction, colTableAffected, colRecordID, colDescription });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins", 8.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(233, 239, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(58, 99, 232);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAuditLog.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAuditLog.EnableHeadersVisualStyles = false;
            dgvAuditLog.GridColor = Color.FromArgb(236, 230, 222);
            dgvAuditLog.Location = new Point(0, 53);
            dgvAuditLog.MultiSelect = false;
            dgvAuditLog.Name = "dgvAuditLog";
            dgvAuditLog.ReadOnly = true;
            dgvAuditLog.RowHeadersVisible = false;
            dgvAuditLog.RowHeadersWidth = 51;
            dgvAuditLog.RowTemplate.Height = 40;
            dgvAuditLog.ScrollBars = ScrollBars.Vertical;
            dgvAuditLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLog.Size = new Size(915, 388);
            dgvAuditLog.TabIndex = 2;
            // 
            // colLogID
            // 
            colLogID.DataPropertyName = "LogID";
            colLogID.FillWeight = 6F;
            colLogID.HeaderText = "LOG ID";
            colLogID.MinimumWidth = 55;
            colLogID.Name = "colLogID";
            colLogID.ReadOnly = true;
            // 
            // colTimestamp
            // 
            colTimestamp.DataPropertyName = "LogTimestamp";
            colTimestamp.FillWeight = 14F;
            colTimestamp.HeaderText = "DATE & TIME";
            colTimestamp.MinimumWidth = 130;
            colTimestamp.Name = "colTimestamp";
            colTimestamp.ReadOnly = true;
            // 
            // colUser
            // 
            colUser.DataPropertyName = "Username";
            colUser.FillWeight = 13F;
            colUser.HeaderText = "USER";
            colUser.MinimumWidth = 110;
            colUser.Name = "colUser";
            colUser.ReadOnly = true;
            // 
            // colAction
            // 
            colAction.DataPropertyName = "Action";
            colAction.FillWeight = 9F;
            colAction.HeaderText = "ACTION";
            colAction.MinimumWidth = 75;
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            // 
            // colTableAffected
            // 
            colTableAffected.DataPropertyName = "TableAffected";
            colTableAffected.FillWeight = 12F;
            colTableAffected.HeaderText = "TABLE";
            colTableAffected.MinimumWidth = 100;
            colTableAffected.Name = "colTableAffected";
            colTableAffected.ReadOnly = true;
            // 
            // colRecordID
            // 
            colRecordID.DataPropertyName = "RecordID";
            colRecordID.FillWeight = 9F;
            colRecordID.HeaderText = "RECORD ID";
            colRecordID.MinimumWidth = 75;
            colRecordID.Name = "colRecordID";
            colRecordID.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 37F;
            colDescription.HeaderText = "DESCRIPTION";
            colDescription.MinimumWidth = 200;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // paginationPanel
            // 
            paginationPanel.BackColor = Color.White;
            paginationPanel.Controls.Add(lblPaginationInfo);
            paginationPanel.Controls.Add(btnPrevPage);
            paginationPanel.Controls.Add(lblPageNumber);
            paginationPanel.Controls.Add(btnNextPage);
            paginationPanel.Controls.Add(paginationTopLine);
            paginationPanel.Location = new Point(0, 441);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(915, 52);
            paginationPanel.TabIndex = 3;
            // 
            // lblPaginationInfo
            // 
            lblPaginationInfo.AutoSize = true;
            lblPaginationInfo.Font = new Font("Poppins", 8.5F);
            lblPaginationInfo.ForeColor = Color.FromArgb(122, 122, 128);
            lblPaginationInfo.Location = new Point(19, 14);
            lblPaginationInfo.Name = "lblPaginationInfo";
            lblPaginationInfo.Size = new Size(204, 26);
            lblPaginationInfo.TabIndex = 0;
            lblPaginationInfo.Text = "Showing 0 – 0 of 0 entries";
            // 
            // btnPrevPage
            // 
            btnPrevPage.BackColor = Color.FromArgb(248, 248, 250);
            btnPrevPage.FlatAppearance.BorderColor = Color.FromArgb(214, 211, 206);
            btnPrevPage.FlatStyle = FlatStyle.Flat;
            btnPrevPage.Font = new Font("Poppins", 9F);
            btnPrevPage.ForeColor = Color.FromArgb(82, 82, 91);
            btnPrevPage.IconChar = IconChar.ChevronLeft;
            btnPrevPage.IconColor = Color.FromArgb(82, 82, 91);
            btnPrevPage.IconFont = IconFont.Auto;
            btnPrevPage.IconSize = 12;
            btnPrevPage.Location = new Point(750, 10);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(36, 32);
            btnPrevPage.TabIndex = 1;
            btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblPageNumber.ForeColor = Color.FromArgb(58, 99, 232);
            lblPageNumber.Location = new Point(792, 13);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(18, 26);
            lblPageNumber.TabIndex = 2;
            lblPageNumber.Text = "1";
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = Color.FromArgb(248, 248, 250);
            btnNextPage.FlatAppearance.BorderColor = Color.FromArgb(214, 211, 206);
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Poppins", 9F);
            btnNextPage.ForeColor = Color.FromArgb(82, 82, 91);
            btnNextPage.IconChar = IconChar.ChevronRight;
            btnNextPage.IconColor = Color.FromArgb(82, 82, 91);
            btnNextPage.IconFont = IconFont.Auto;
            btnNextPage.IconSize = 12;
            btnNextPage.Location = new Point(816, 10);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(36, 32);
            btnNextPage.TabIndex = 3;
            btnNextPage.UseVisualStyleBackColor = false;
            // 
            // paginationTopLine
            // 
            paginationTopLine.BackColor = Color.FromArgb(236, 230, 222);
            paginationTopLine.Dock = DockStyle.Top;
            paginationTopLine.Location = new Point(0, 0);
            paginationTopLine.Name = "paginationTopLine";
            paginationTopLine.Size = new Size(915, 1);
            paginationTopLine.TabIndex = 4;
            // 
            // lblSearchHint
            // 
            lblSearchHint.AutoSize = true;
            lblSearchHint.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblSearchHint.ForeColor = Color.FromArgb(82, 82, 91);
            lblSearchHint.Location = new Point(20, 0);
            lblSearchHint.Name = "lblSearchHint";
            lblSearchHint.Size = new Size(54, 14);
            lblSearchHint.TabIndex = 11;
            lblSearchHint.Text = "Search";
            // 
            // lblFilterByTable
            // 
            lblFilterByTable.AutoSize = true;
            lblFilterByTable.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblFilterByTable.ForeColor = Color.FromArgb(82, 82, 91);
            lblFilterByTable.Location = new Point(20, 56);
            lblFilterByTable.Name = "lblFilterByTable";
            lblFilterByTable.Size = new Size(100, 23);
            lblFilterByTable.TabIndex = 12;
            lblFilterByTable.Text = "Table";
            // 
            // AuditLogView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(244, 239, 231);
            Controls.Add(outerScrollPanel);
            Name = "AuditLogView";
            Size = new Size(955, 790);
            outerScrollPanel.ResumeLayout(false);
            innerContentPanel.ResumeLayout(false);
            toolbarCard.ResumeLayout(false);
            toolbarCard.PerformLayout();
            searchIconPanel.ResumeLayout(false);
            searchIconPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconSearch).EndInit();
            summaryStrip.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotal).EndInit();
            cardInsert.ResumeLayout(false);
            cardInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconInsert).EndInit();
            cardUpdate.ResumeLayout(false);
            cardUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUpdate).EndInit();
            cardDelete.ResumeLayout(false);
            cardDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconDelete).EndInit();
            tableCard.ResumeLayout(false);
            tableCardHeader.ResumeLayout(false);
            tableCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLog).EndInit();
            paginationPanel.ResumeLayout(false);
            paginationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel outerScrollPanel;
        private System.Windows.Forms.Panel innerContentPanel;
        private System.Windows.Forms.Panel toolbarCard;
        private System.Windows.Forms.Panel searchIconPanel;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel toolbarDivider;
        private System.Windows.Forms.ComboBox cmbFilterTable;
        private System.Windows.Forms.ComboBox cmbFilterAction;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblDateSeparator;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private FontAwesome.Sharp.IconButton btnApplyFilter;
        private FontAwesome.Sharp.IconButton btnClearFilter;
        private FontAwesome.Sharp.IconButton btnExport;
        private System.Windows.Forms.Panel summaryStrip;
        private System.Windows.Forms.Panel cardTotal;
        private FontAwesome.Sharp.IconPictureBox iconTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Panel cardInsert;
        private FontAwesome.Sharp.IconPictureBox iconInsert;
        private System.Windows.Forms.Label lblInsertCount;
        private System.Windows.Forms.Label lblInsertCaption;
        private System.Windows.Forms.Panel cardUpdate;
        private FontAwesome.Sharp.IconPictureBox iconUpdate;
        private System.Windows.Forms.Label lblUpdateCount;
        private System.Windows.Forms.Label lblUpdateCaption;
        private System.Windows.Forms.Panel cardDelete;
        private FontAwesome.Sharp.IconPictureBox iconDelete;
        private System.Windows.Forms.Label lblDeleteCount;
        private System.Windows.Forms.Label lblDeleteCaption;
        private System.Windows.Forms.Panel tableCard;
        private System.Windows.Forms.Panel tableCardHeader;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Panel tableCardDivider;
        private System.Windows.Forms.DataGridView dgvAuditLog;
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Label lblPaginationInfo;
        private FontAwesome.Sharp.IconButton btnPrevPage;
        private System.Windows.Forms.Label lblPageNumber;
        private FontAwesome.Sharp.IconButton btnNextPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableAffected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private Panel paginationTopLine;
        private Label lblSearchHint;
        private Label lblFilterByTable;
    }
}
