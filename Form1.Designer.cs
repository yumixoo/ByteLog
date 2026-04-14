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
            gray_panel_sidebar = new Panel();
            stud_pic_sidebar = new PictureBox();
            stud_name_sidebar = new TextBox();
            stud_id_sidebar = new TextBox();
            dashboard = new ReaLTaiizor.Controls.Button();
            payment = new ReaLTaiizor.Controls.Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            blue_panel_header.SuspendLayout();
            white_panel_header.SuspendLayout();
            gray_panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_header).BeginInit();
            ((System.ComponentModel.ISupportInitialize)byte_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            blue_panel_sidebar.SuspendLayout();
            white_panel_sidebar.SuspendLayout();
            gray_panel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_sidebar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
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
            white_panel_header.Controls.Add(iconPictureBox3);
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
            splitContainer1.Panel2.BackColor = Color.Gainsboro;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1258, 598);
            splitContainer1.SplitterDistance = 267;
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
            white_panel_sidebar.BackgroundImage = Properties.Resources.Untitled_design;
            white_panel_sidebar.BackgroundImageLayout = ImageLayout.Stretch;
            white_panel_sidebar.Controls.Add(iconPictureBox2);
            white_panel_sidebar.Controls.Add(iconPictureBox1);
            white_panel_sidebar.Controls.Add(payment);
            white_panel_sidebar.Controls.Add(dashboard);
            white_panel_sidebar.Controls.Add(gray_panel_sidebar);
            white_panel_sidebar.Location = new Point(-9, 0);
            white_panel_sidebar.Name = "white_panel_sidebar";
            white_panel_sidebar.Size = new Size(270, 595);
            white_panel_sidebar.TabIndex = 6;
            // 
            // gray_panel_sidebar
            // 
            gray_panel_sidebar.BackColor = Color.Gainsboro;
            gray_panel_sidebar.Controls.Add(stud_pic_sidebar);
            gray_panel_sidebar.Controls.Add(stud_name_sidebar);
            gray_panel_sidebar.Controls.Add(stud_id_sidebar);
            gray_panel_sidebar.Location = new Point(19, 13);
            gray_panel_sidebar.Name = "gray_panel_sidebar";
            gray_panel_sidebar.Size = new Size(240, 80);
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
            stud_name_sidebar.BackColor = Color.Gainsboro;
            stud_name_sidebar.BorderStyle = BorderStyle.None;
            stud_name_sidebar.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold);
            stud_name_sidebar.ForeColor = Color.FromArgb(1, 36, 130);
            stud_name_sidebar.Location = new Point(72, 15);
            stud_name_sidebar.Name = "stud_name_sidebar";
            stud_name_sidebar.Size = new Size(140, 28);
            stud_name_sidebar.TabIndex = 0;
            stud_name_sidebar.Text = "NAME";
            // 
            // stud_id_sidebar
            // 
            stud_id_sidebar.BackColor = Color.Gainsboro;
            stud_id_sidebar.BorderStyle = BorderStyle.None;
            stud_id_sidebar.Font = new Font("Poppins Light", 7F, FontStyle.Italic);
            stud_id_sidebar.ForeColor = Color.Black;
            stud_id_sidebar.Location = new Point(72, 38);
            stud_id_sidebar.Name = "stud_id_sidebar";
            stud_id_sidebar.Size = new Size(135, 19);
            stud_id_sidebar.TabIndex = 1;
            stud_id_sidebar.Text = "STUDENT_ID";
            // 
            // dashboard
            // 
            dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard.BackColor = Color.White;
            dashboard.BorderColor = Color.FromArgb(1, 36, 130);
            dashboard.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            dashboard.EnteredColor = Color.White;
            dashboard.Font = new Font("Poppins SemiBold", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.Image = null;
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.InactiveColor = Color.White;
            dashboard.Location = new Point(19, 99);
            dashboard.Name = "dashboard";
            dashboard.Padding = new Padding(1);
            dashboard.PressedBorderColor = Color.FromArgb(1, 36, 130);
            dashboard.PressedColor = Color.FromArgb(1, 36, 130);
            dashboard.Size = new Size(240, 40);
            dashboard.TabIndex = 0;
            dashboard.Text = "Dashboard";
            dashboard.TextAlignment = StringAlignment.Center;
            // 
            // payment
            // 
            payment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            payment.BackColor = Color.White;
            payment.BorderColor = Color.FromArgb(1, 36, 130);
            payment.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            payment.EnteredColor = Color.White;
            payment.Font = new Font("Poppins SemiBold", 8.861538F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment.Image = null;
            payment.ImageAlign = ContentAlignment.MiddleLeft;
            payment.InactiveColor = Color.White;
            payment.Location = new Point(19, 145);
            payment.Name = "payment";
            payment.Padding = new Padding(1);
            payment.PressedBorderColor = Color.FromArgb(1, 36, 130);
            payment.PressedColor = Color.FromArgb(1, 36, 130);
            payment.Size = new Size(240, 40);
            payment.TabIndex = 1;
            payment.Text = "Payment";
            payment.TextAlignment = StringAlignment.Center;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconPictureBox1.ForeColor = Color.FromArgb(1, 36, 130);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            iconPictureBox1.IconColor = Color.FromArgb(1, 36, 130);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(23, 104);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = Color.FromArgb(1, 36, 130);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            iconPictureBox2.IconColor = Color.FromArgb(1, 36, 130);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(24, 150);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 30);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconPictureBox3.ForeColor = Color.FromArgb(1, 36, 130);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconPictureBox3.IconColor = Color.FromArgb(1, 36, 130);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(1023, 20);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(30, 30);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox3.TabIndex = 4;
            iconPictureBox3.TabStop = false;
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
            gray_panel_header.ResumeLayout(false);
            gray_panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_header).EndInit();
            ((System.ComponentModel.ISupportInitialize)byte_logo).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            blue_panel_sidebar.ResumeLayout(false);
            white_panel_sidebar.ResumeLayout(false);
            gray_panel_sidebar.ResumeLayout(false);
            gray_panel_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stud_pic_sidebar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
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
        private Panel blue_panel_sidebar;
        private Panel white_panel_sidebar;
        private Panel gray_panel_sidebar;
        private PictureBox stud_pic_sidebar;
        private Panel gray_panel_header;
        private PictureBox stud_pic_header;
        private TextBox stud_name_header;
        private TextBox stud_id_header;
        private ReaLTaiizor.Controls.Button dashboard;
        private ReaLTaiizor.Controls.Button payment;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}
