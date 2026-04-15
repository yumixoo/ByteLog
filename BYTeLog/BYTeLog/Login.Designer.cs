namespace BYTeLogSL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            byte_logo = new PictureBox();
            panel1 = new Panel();
            bytelog = new ReaLTaiizor.Controls.FoxBigLabel();
            greeting2 = new ReaLTaiizor.Controls.FoxLabel();
            greeting1 = new ReaLTaiizor.Controls.BigLabel();
            splitContainer1 = new SplitContainer();
            panel2 = new ReaLTaiizor.Controls.Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            login_button = new ReaLTaiizor.Controls.Button();
            forgot_password_link = new LinkLabel();
            password_textbox = new ReaLTaiizor.Controls.BigTextBox();
            id_textbox = new ReaLTaiizor.Controls.BigTextBox();
            login = new ReaLTaiizor.Controls.FoxBigLabel();
            login_text = new Label();
            ((System.ComponentModel.ISupportInitialize)byte_logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // byte_logo
            // 
            byte_logo.Image = (Image)resources.GetObject("byte_logo.Image");
            byte_logo.Location = new Point(39, 90);
            byte_logo.Margin = new Padding(0);
            byte_logo.Name = "byte_logo";
            byte_logo.Size = new Size(300, 289);
            byte_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            byte_logo.TabIndex = 0;
            byte_logo.TabStop = false;
            byte_logo.Click += byte_logo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 36, 130);
            panel1.Controls.Add(bytelog);
            panel1.Controls.Add(greeting2);
            panel1.Controls.Add(greeting1);
            panel1.Controls.Add(byte_logo);
            panel1.Location = new Point(72, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 523);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // bytelog
            // 
            bytelog.BackColor = Color.Transparent;
            bytelog.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bytelog.ForeColor = Color.White;
            bytelog.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Top;
            bytelog.LineColor = Color.Transparent;
            bytelog.Location = new Point(93, 21);
            bytelog.Name = "bytelog";
            bytelog.Size = new Size(182, 56);
            bytelog.TabIndex = 4;
            bytelog.Text = "BYTeLog";
            // 
            // greeting2
            // 
            greeting2.BackColor = Color.Transparent;
            greeting2.Font = new Font("Poppins Medium", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            greeting2.ForeColor = Color.White;
            greeting2.Location = new Point(98, 443);
            greeting2.Name = "greeting2";
            greeting2.Size = new Size(177, 29);
            greeting2.TabIndex = 3;
            greeting2.Text = "Hope your doing fine! ";
            // 
            // greeting1
            // 
            greeting1.AutoSize = true;
            greeting1.BackColor = Color.Transparent;
            greeting1.Font = new Font("Poppins SemiBold", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            greeting1.ForeColor = Color.White;
            greeting1.Location = new Point(47, 393);
            greeting1.Name = "greeting1";
            greeting1.Size = new Size(285, 58);
            greeting1.TabIndex = 1;
            greeting1.Text = "Welcome Back!";
            greeting1.Click += greeting1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(71, 78);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1121, 523);
            splitContainer1.SplitterDistance = 373;
            splitContainer1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(login_button);
            panel2.Controls.Add(forgot_password_link);
            panel2.Controls.Add(password_textbox);
            panel2.Controls.Add(id_textbox);
            panel2.Controls.Add(login);
            panel2.Controls.Add(login_text);
            panel2.EdgeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(742, 523);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 2;
            panel2.Text = "panel2";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(1, 36, 130);
            linkLabel1.Location = new Point(425, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 26);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 414);
            label1.Name = "label1";
            label1.Size = new Size(194, 26);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // login_button
            // 
            login_button.BackColor = Color.Transparent;
            login_button.BorderColor = Color.FromArgb(32, 34, 37);
            login_button.EnteredBorderColor = Color.White;
            login_button.EnteredColor = Color.White;
            login_button.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.Image = null;
            login_button.ImageAlign = ContentAlignment.MiddleLeft;
            login_button.InactiveColor = Color.FromArgb(1, 36, 130);
            login_button.Location = new Point(98, 356);
            login_button.Name = "login_button";
            login_button.PressedBorderColor = Color.FromArgb(1, 36, 130);
            login_button.PressedColor = Color.White;
            login_button.Size = new Size(562, 43);
            login_button.TabIndex = 10;
            login_button.Text = "Login";
            login_button.TextAlignment = StringAlignment.Center;
            // 
            // forgot_password_link
            // 
            forgot_password_link.AutoSize = true;
            forgot_password_link.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgot_password_link.LinkBehavior = LinkBehavior.NeverUnderline;
            forgot_password_link.LinkColor = Color.FromArgb(1, 36, 130);
            forgot_password_link.Location = new Point(560, 301);
            forgot_password_link.Name = "forgot_password_link";
            forgot_password_link.Size = new Size(116, 22);
            forgot_password_link.TabIndex = 8;
            forgot_password_link.TabStop = true;
            forgot_password_link.Text = "Forgot Password?";
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.Transparent;
            password_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textbox.ForeColor = Color.DimGray;
            password_textbox.Image = null;
            password_textbox.Location = new Point(98, 246);
            password_textbox.MaxLength = 32767;
            password_textbox.Multiline = false;
            password_textbox.Name = "password_textbox";
            password_textbox.ReadOnly = false;
            password_textbox.Size = new Size(562, 43);
            password_textbox.TabIndex = 7;
            password_textbox.Text = "Password";
            password_textbox.TextAlignment = HorizontalAlignment.Left;
            password_textbox.UseSystemPasswordChar = false;
            // 
            // id_textbox
            // 
            id_textbox.BackColor = Color.Transparent;
            id_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id_textbox.ForeColor = Color.DimGray;
            id_textbox.Image = null;
            id_textbox.Location = new Point(98, 181);
            id_textbox.MaxLength = 32767;
            id_textbox.Multiline = false;
            id_textbox.Name = "id_textbox";
            id_textbox.ReadOnly = false;
            id_textbox.Size = new Size(562, 43);
            id_textbox.TabIndex = 6;
            id_textbox.Text = "School ID/ Student ID";
            id_textbox.TextAlignment = HorizontalAlignment.Left;
            id_textbox.UseSystemPasswordChar = false;
            // 
            // login
            // 
            login.BackColor = Color.Transparent;
            login.Font = new Font("Poppins SemiBold", 25F, FontStyle.Bold);
            login.ForeColor = Color.FromArgb(1, 36, 130);
            login.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Top;
            login.LineColor = Color.White;
            login.Location = new Point(327, 50);
            login.Name = "login";
            login.Size = new Size(101, 56);
            login.TabIndex = 5;
            login.Text = "Login";
            login.Click += login_Click;
            // 
            // login_text
            // 
            login_text.AutoSize = true;
            login_text.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_text.Location = new Point(194, 109);
            login_text.Name = "login_text";
            login_text.Size = new Size(401, 28);
            login_text.TabIndex = 1;
            login_text.Text = "Enter your credentials to access your dashboard.";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Name = "Login";
            Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)byte_logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox byte_logo;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel greeting1;
        private ReaLTaiizor.Controls.FoxLabel greeting2;
        private ReaLTaiizor.Controls.FoxBigLabel bytelog;
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.Panel panel2;
        private Label login_text;
        private ReaLTaiizor.Controls.BigTextBox password_textbox;
        private ReaLTaiizor.Controls.BigTextBox id_textbox;
        private ReaLTaiizor.Controls.FoxBigLabel login;
        private LinkLabel forgot_password_link;
        private ReaLTaiizor.Controls.Button login_button;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}
