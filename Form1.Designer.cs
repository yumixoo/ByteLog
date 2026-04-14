namespace Dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            blue_panel_header = new Panel();
            white_panel_header = new Panel();
            pictureBox1 = new PictureBox();
            gray_panel_header = new Panel();
            stud_pic_header = new PictureBox();
            stud_name_header = new TextBox();
            stud_id_header = new TextBox();
            byte_logo = new PictureBox();
            bytelog_subheader = new TextBox();
            bytelog_header = new TextBox();
            splitContainer1 = new SplitContainer();
            blue_panel_sidebar = new Panel();
            white_panel_sidebar = new Panel();
            payment_icon = new PictureBox();
            payment = new Button();
            dashboard_icon = new PictureBox();
            gray_panel_sidebar = new Panel();
            stud_pic_sidebar = new PictureBox();
            stud_name_sidebar = new TextBox();
            stud_id_sidebar = new TextBox();
            dashboard = new Button();
            blue_panel_header.SuspendLayout();
            white_panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gray_panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_header).BeginInit();
            ((System.ComponentModel.ISupportInitialize)byte_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            blue_panel_sidebar.SuspendLayout();
            white_panel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)payment_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboard_icon).BeginInit();
            gray_panel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_sidebar).BeginInit();
            SuspendLayout();
            // 
            // blue_panel_header
            // 
            blue_panel_header.BackColor = Color.FromArgb(1, 36, 130);
            blue_panel_header.Controls.Add(white_panel_header);
            blue_panel_header.Location = new Point(-1, 0);
            blue_panel_header.Name = "blue_panel_header";
            blue_panel_header.Padding = new Padding(1);
            blue_panel_header.Size = new Size(1260, 75);
            blue_panel_header.TabIndex = 0;
            // 
            // white_panel_header
            // 
            white_panel_header.BackColor = Color.White;
            white_panel_header.Controls.Add(pictureBox1);
            white_panel_header.Controls.Add(gray_panel_header);
            white_panel_header.Controls.Add(byte_logo);
            white_panel_header.Controls.Add(bytelog_subheader);
            white_panel_header.Controls.Add(bytelog_header);
            white_panel_header.Location = new Point(0, 0);
            white_panel_header.Name = "white_panel_header";
            white_panel_header.Padding = new Padding(1);
            white_panel_header.Size = new Size(1260, 70);
            white_panel_header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1018, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // gray_panel_header
            // 
            gray_panel_header.BackColor = Color.LightGray;
            gray_panel_header.Controls.Add(stud_pic_header);
            gray_panel_header.Controls.Add(stud_name_header);
            gray_panel_header.Controls.Add(stud_id_header);
            gray_panel_header.Location = new Point(1071, 10);
            gray_panel_header.Name = "gray_panel_header";
            gray_panel_header.Size = new Size(180, 50);
            gray_panel_header.TabIndex = 3;
            // 
            // stud_pic_header
            // 
            stud_pic_header.Image = (Image)resources.GetObject("stud_pic_header.Image");
            stud_pic_header.Location = new Point(11, 10);
            stud_pic_header.Name = "stud_pic_header";
            stud_pic_header.Size = new Size(30, 30);
            stud_pic_header.SizeMode = PictureBoxSizeMode.Zoom;
            stud_pic_header.TabIndex = 0;
            stud_pic_header.TabStop = false;
            // 
            // stud_name_header
            // 
            stud_name_header.BackColor = Color.LightGray;
            stud_name_header.BorderStyle = BorderStyle.None;
            stud_name_header.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold);
            stud_name_header.ForeColor = Color.FromArgb(1, 36, 130);
            stud_name_header.Location = new Point(47, 7);
            stud_name_header.Name = "stud_name_header";
            stud_name_header.Size = new Size(140, 22);
            stud_name_header.TabIndex = 0;
            stud_name_header.Text = "NAME";
            stud_name_header.TextChanged += textBox6_TextChanged;
            // 
            // stud_id_header
            // 
            stud_id_header.BackColor = Color.LightGray;
            stud_id_header.BorderStyle = BorderStyle.None;
            stud_id_header.Font = new Font("Poppins Light", 5F, FontStyle.Italic);
            stud_id_header.ForeColor = Color.Black;
            stud_id_header.Location = new Point(48, 26);
            stud_id_header.Name = "stud_id_header";
            stud_id_header.Size = new Size(135, 14);
            stud_id_header.TabIndex = 1;
            stud_id_header.Text = "STUDENT_ID";
            // 
            // byte_logo
            // 
            byte_logo.BackgroundImage = Properties.Resources._462188993_504834578979683_7612540065311618134_n;
            byte_logo.ErrorImage = (Image)resources.GetObject("byte_logo.ErrorImage");
            byte_logo.Image = Properties.Resources._462188993_504834578979683_7612540065311618134_n;
            byte_logo.InitialImage = (Image)resources.GetObject("byte_logo.InitialImage");
            byte_logo.Location = new Point(10, 10);
            byte_logo.Name = "byte_logo";
            byte_logo.Size = new Size(50, 50);
            byte_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            byte_logo.TabIndex = 0;
            byte_logo.TabStop = false;
            // 
            // bytelog_subheader
            // 
            bytelog_subheader.BackColor = Color.White;
            bytelog_subheader.BorderStyle = BorderStyle.None;
            bytelog_subheader.Font = new Font("Poppins Light", 7.753846F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bytelog_subheader.ForeColor = Color.FromArgb(1, 36, 130);
            bytelog_subheader.Location = new Point(65, 38);
            bytelog_subheader.Name = "bytelog_subheader";
            bytelog_subheader.Size = new Size(321, 21);
            bytelog_subheader.TabIndex = 2;
            bytelog_subheader.Text = "BYTe Membership and Fee Tracker";
            bytelog_subheader.TextChanged += textBox2_TextChanged;
            // 
            // bytelog_header
            // 
            bytelog_header.BorderStyle = BorderStyle.None;
            bytelog_header.Font = new Font("Poppins ExtraBold", 12F, FontStyle.Bold);
            bytelog_header.ForeColor = Color.FromArgb(1, 36, 130);
            bytelog_header.Location = new Point(64, 8);
            bytelog_header.Name = "bytelog_header";
            bytelog_header.Size = new Size(135, 33);
            bytelog_header.TabIndex = 1;
            bytelog_header.Text = "BYTeLog";
            bytelog_header.TextChanged += textBox1_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 76);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(blue_panel_sidebar);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LightGray;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1258, 598);
            splitContainer1.SplitterDistance = 272;
            splitContainer1.TabIndex = 1;
            // 
            // blue_panel_sidebar
            // 
            blue_panel_sidebar.BackColor = Color.FromArgb(1, 36, 130);
            blue_panel_sidebar.Controls.Add(white_panel_sidebar);
            blue_panel_sidebar.Location = new Point(-1, 0);
            blue_panel_sidebar.Name = "blue_panel_sidebar";
            blue_panel_sidebar.Size = new Size(275, 595);
            blue_panel_sidebar.TabIndex = 5;
            // 
            // white_panel_sidebar
            // 
            white_panel_sidebar.BackColor = Color.White;
            white_panel_sidebar.BackgroundImageLayout = ImageLayout.Stretch;
            white_panel_sidebar.Controls.Add(payment_icon);
            white_panel_sidebar.Controls.Add(payment);
            white_panel_sidebar.Controls.Add(dashboard_icon);
            white_panel_sidebar.Controls.Add(gray_panel_sidebar);
            white_panel_sidebar.Controls.Add(dashboard);
            white_panel_sidebar.Location = new Point(-2, 0);
            white_panel_sidebar.Name = "white_panel_sidebar";
            white_panel_sidebar.Size = new Size(270, 595);
            white_panel_sidebar.TabIndex = 6;
            // 
            // payment_icon
            // 
            payment_icon.Image = (Image)resources.GetObject("payment_icon.Image");
            payment_icon.Location = new Point(240, 170);
            payment_icon.Name = "payment_icon";
            payment_icon.Size = new Size(20, 20);
            payment_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            payment_icon.TabIndex = 4;
            payment_icon.TabStop = false;
            // 
            // payment
            // 
            payment.BackgroundImageLayout = ImageLayout.None;
            payment.FlatStyle = FlatStyle.Flat;
            payment.Font = new Font("Poppins", 9F);
            payment.ForeColor = Color.FromArgb(1, 36, 130);
            payment.Location = new Point(1, 162);
            payment.Name = "payment";
            payment.Size = new Size(270, 40);
            payment.TabIndex = 2;
            payment.Text = "Payment";
            payment.TextAlign = ContentAlignment.MiddleLeft;
            payment.UseVisualStyleBackColor = true;
            // 
            // dashboard_icon
            // 
            dashboard_icon.Image = Properties.Resources.dashboard_layout_removebg_preview;
            dashboard_icon.Location = new Point(240, 134);
            dashboard_icon.Name = "dashboard_icon";
            dashboard_icon.Size = new Size(20, 20);
            dashboard_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            dashboard_icon.TabIndex = 3;
            dashboard_icon.TabStop = false;
            // 
            // gray_panel_sidebar
            // 
            gray_panel_sidebar.BackColor = Color.LightGray;
            gray_panel_sidebar.Controls.Add(stud_pic_sidebar);
            gray_panel_sidebar.Controls.Add(stud_name_sidebar);
            gray_panel_sidebar.Controls.Add(stud_id_sidebar);
            gray_panel_sidebar.Location = new Point(21, 20);
            gray_panel_sidebar.Name = "gray_panel_sidebar";
            gray_panel_sidebar.Size = new Size(230, 80);
            gray_panel_sidebar.TabIndex = 0;
            // 
            // stud_pic_sidebar
            // 
            stud_pic_sidebar.Image = (Image)resources.GetObject("stud_pic_sidebar.Image");
            stud_pic_sidebar.Location = new Point(14, 14);
            stud_pic_sidebar.Name = "stud_pic_sidebar";
            stud_pic_sidebar.Size = new Size(50, 50);
            stud_pic_sidebar.SizeMode = PictureBoxSizeMode.Zoom;
            stud_pic_sidebar.TabIndex = 0;
            stud_pic_sidebar.TabStop = false;
            // 
            // stud_name_sidebar
            // 
            stud_name_sidebar.BackColor = Color.LightGray;
            stud_name_sidebar.BorderStyle = BorderStyle.None;
            stud_name_sidebar.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            stud_name_sidebar.ForeColor = Color.FromArgb(1, 36, 130);
            stud_name_sidebar.Location = new Point(72, 14);
            stud_name_sidebar.Name = "stud_name_sidebar";
            stud_name_sidebar.Size = new Size(140, 28);
            stud_name_sidebar.TabIndex = 0;
            stud_name_sidebar.Text = "NAME";
            // 
            // stud_id_sidebar
            // 
            stud_id_sidebar.BackColor = Color.LightGray;
            stud_id_sidebar.BorderStyle = BorderStyle.None;
            stud_id_sidebar.Font = new Font("Poppins Light", 7F, FontStyle.Italic);
            stud_id_sidebar.ForeColor = Color.Black;
            stud_id_sidebar.Location = new Point(72, 39);
            stud_id_sidebar.Name = "stud_id_sidebar";
            stud_id_sidebar.Size = new Size(135, 19);
            stud_id_sidebar.TabIndex = 1;
            stud_id_sidebar.Text = "STUDENT_ID";
            // 
            // dashboard
            // 
            dashboard.BackgroundImageLayout = ImageLayout.None;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Poppins", 9F);
            dashboard.ForeColor = Color.FromArgb(1, 36, 130);
            dashboard.Location = new Point(1, 124);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(270, 40);
            dashboard.TabIndex = 1;
            dashboard.Text = "Dashboard";
            dashboard.TextAlign = ContentAlignment.MiddleLeft;
            dashboard.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 671);
            Controls.Add(blue_panel_header);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            blue_panel_header.ResumeLayout(false);
            white_panel_header.ResumeLayout(false);
            white_panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gray_panel_header.ResumeLayout(false);
            gray_panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_header).EndInit();
            ((System.ComponentModel.ISupportInitialize)byte_logo).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            blue_panel_sidebar.ResumeLayout(false);
            white_panel_sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)payment_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboard_icon).EndInit();
            gray_panel_sidebar.ResumeLayout(false);
            gray_panel_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_sidebar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel blue_panel_header;
        private Panel white_panel_header;
        private PictureBox byte_logo;
        private TextBox bytelog_header;
        private TextBox bytelog_subheader;
        private SplitContainer splitContainer1;
        private TextBox stud_name_sidebar;
        private TextBox stud_id_sidebar;
        private Button dashboard;
        private PictureBox dashboard_icon;
        private PictureBox payment_icon;
        private Panel blue_panel_sidebar;
        private Panel white_panel_sidebar;
        private Panel gray_panel_sidebar;
        private PictureBox stud_pic_sidebar;
        private Panel gray_panel_header;
        private PictureBox stud_pic_header;
        private TextBox stud_name_header;
        private TextBox stud_id_header;
        private Button payment;
        private PictureBox pictureBox1;
    }
}
