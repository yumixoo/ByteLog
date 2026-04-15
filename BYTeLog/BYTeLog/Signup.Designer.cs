namespace BYTeLogSL
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            signup_geeting_subtext2 = new Label();
            signup_geeting_subtext = new Label();
            bytelog = new ReaLTaiizor.Controls.FoxBigLabel();
            signup_greeting_text = new ReaLTaiizor.Controls.BigLabel();
            byte_logo = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel2 = new ReaLTaiizor.Controls.Panel();
            confirm_password = new ReaLTaiizor.Controls.BigTextBox();
            create_password = new ReaLTaiizor.Controls.BigTextBox();
            student_id = new ReaLTaiizor.Controls.BigTextBox();
            middle_name_textbox = new ReaLTaiizor.Controls.BigTextBox();
            last_name_textbox = new ReaLTaiizor.Controls.BigTextBox();
            sign_up_text = new ReaLTaiizor.Controls.FoxBigLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            login_button = new ReaLTaiizor.Controls.Button();
            select_role_textbox = new ReaLTaiizor.Controls.BigTextBox();
            sign_up_subtext = new Label();
            first_name_textbox = new ReaLTaiizor.Controls.BigTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)byte_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 36, 130);
            panel1.Controls.Add(signup_geeting_subtext2);
            panel1.Controls.Add(signup_geeting_subtext);
            panel1.Controls.Add(bytelog);
            panel1.Controls.Add(signup_greeting_text);
            panel1.Controls.Add(byte_logo);
            panel1.Location = new Point(110, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 600);
            panel1.TabIndex = 3;
            // 
            // signup_geeting_subtext2
            // 
            signup_geeting_subtext2.AutoSize = true;
            signup_geeting_subtext2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_geeting_subtext2.ForeColor = Color.White;
            signup_geeting_subtext2.Location = new Point(71, 520);
            signup_geeting_subtext2.Name = "signup_geeting_subtext2";
            signup_geeting_subtext2.Size = new Size(201, 28);
            signup_geeting_subtext2.TabIndex = 6;
            signup_geeting_subtext2.Text = "show you transparency.";
            signup_geeting_subtext2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signup_geeting_subtext
            // 
            signup_geeting_subtext.AutoSize = true;
            signup_geeting_subtext.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_geeting_subtext.ForeColor = Color.White;
            signup_geeting_subtext.Location = new Point(52, 495);
            signup_geeting_subtext.Name = "signup_geeting_subtext";
            signup_geeting_subtext.Size = new Size(235, 28);
            signup_geeting_subtext.TabIndex = 5;
            signup_geeting_subtext.Text = " Enter your details and let us";
            signup_geeting_subtext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bytelog
            // 
            bytelog.BackColor = Color.Transparent;
            bytelog.Font = new Font("Poppins", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bytelog.ForeColor = Color.White;
            bytelog.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Top;
            bytelog.LineColor = Color.Transparent;
            bytelog.Location = new Point(90, 41);
            bytelog.Name = "bytelog";
            bytelog.Size = new Size(182, 56);
            bytelog.TabIndex = 4;
            bytelog.Text = "BYTeLog";
            // 
            // signup_greeting_text
            // 
            signup_greeting_text.AutoSize = true;
            signup_greeting_text.BackColor = Color.Transparent;
            signup_greeting_text.Font = new Font("Poppins SemiBold", 24.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signup_greeting_text.ForeColor = Color.White;
            signup_greeting_text.Location = new Point(105, 427);
            signup_greeting_text.Name = "signup_greeting_text";
            signup_greeting_text.Size = new Size(142, 58);
            signup_greeting_text.TabIndex = 1;
            signup_greeting_text.Text = "Join Us";
            signup_greeting_text.Click += greeting1_Click;
            // 
            // byte_logo
            // 
            byte_logo.Image = (Image)resources.GetObject("byte_logo.Image");
            byte_logo.Location = new Point(32, 122);
            byte_logo.Margin = new Padding(0);
            byte_logo.Name = "byte_logo";
            byte_logo.Size = new Size(300, 289);
            byte_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            byte_logo.TabIndex = 0;
            byte_logo.TabStop = false;
            byte_logo.Click += byte_logo_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(110, 37);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1052, 603);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(first_name_textbox);
            panel2.Controls.Add(confirm_password);
            panel2.Controls.Add(create_password);
            panel2.Controls.Add(student_id);
            panel2.Controls.Add(middle_name_textbox);
            panel2.Controls.Add(last_name_textbox);
            panel2.Controls.Add(sign_up_text);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(login_button);
            panel2.Controls.Add(select_role_textbox);
            panel2.Controls.Add(sign_up_subtext);
            panel2.EdgeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(2, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(693, 600);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 2;
            panel2.Text = "panel2";
            // 
            // confirm_password
            // 
            confirm_password.BackColor = Color.Transparent;
            confirm_password.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm_password.ForeColor = Color.DimGray;
            confirm_password.Image = null;
            confirm_password.Location = new Point(84, 424);
            confirm_password.MaxLength = 32767;
            confirm_password.Multiline = false;
            confirm_password.Name = "confirm_password";
            confirm_password.ReadOnly = false;
            confirm_password.Size = new Size(533, 47);
            confirm_password.TabIndex = 17;
            confirm_password.Text = "Confirm Password";
            confirm_password.TextAlignment = HorizontalAlignment.Left;
            confirm_password.UseSystemPasswordChar = false;
            // 
            // create_password
            // 
            create_password.BackColor = Color.Transparent;
            create_password.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create_password.ForeColor = Color.DimGray;
            create_password.Image = null;
            create_password.Location = new Point(84, 360);
            create_password.MaxLength = 32767;
            create_password.Multiline = false;
            create_password.Name = "create_password";
            create_password.ReadOnly = false;
            create_password.Size = new Size(533, 47);
            create_password.TabIndex = 16;
            create_password.Text = "Create Password";
            create_password.TextAlignment = HorizontalAlignment.Left;
            create_password.UseSystemPasswordChar = false;
            // 
            // student_id
            // 
            student_id.BackColor = Color.Transparent;
            student_id.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_id.ForeColor = Color.DimGray;
            student_id.Image = null;
            student_id.Location = new Point(84, 297);
            student_id.MaxLength = 32767;
            student_id.Multiline = false;
            student_id.Name = "student_id";
            student_id.ReadOnly = false;
            student_id.Size = new Size(533, 47);
            student_id.TabIndex = 15;
            student_id.Text = "School ID/ Student ID";
            student_id.TextAlignment = HorizontalAlignment.Left;
            student_id.UseSystemPasswordChar = false;
            // 
            // middle_name_textbox
            // 
            middle_name_textbox.BackColor = Color.Transparent;
            middle_name_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middle_name_textbox.ForeColor = Color.DimGray;
            middle_name_textbox.Image = null;
            middle_name_textbox.Location = new Point(84, 231);
            middle_name_textbox.MaxLength = 32767;
            middle_name_textbox.Multiline = false;
            middle_name_textbox.Name = "middle_name_textbox";
            middle_name_textbox.ReadOnly = false;
            middle_name_textbox.Size = new Size(533, 47);
            middle_name_textbox.TabIndex = 14;
            middle_name_textbox.Text = "Middle Name (Optional)";
            middle_name_textbox.TextAlignment = HorizontalAlignment.Left;
            middle_name_textbox.UseSystemPasswordChar = false;
            // 
            // last_name_textbox
            // 
            last_name_textbox.BackColor = Color.Transparent;
            last_name_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            last_name_textbox.ForeColor = Color.DimGray;
            last_name_textbox.Image = null;
            last_name_textbox.Location = new Point(359, 167);
            last_name_textbox.MaxLength = 32767;
            last_name_textbox.Multiline = false;
            last_name_textbox.Name = "last_name_textbox";
            last_name_textbox.ReadOnly = false;
            last_name_textbox.Size = new Size(258, 47);
            last_name_textbox.TabIndex = 13;
            last_name_textbox.Text = "Last Name";
            last_name_textbox.TextAlignment = HorizontalAlignment.Left;
            last_name_textbox.UseSystemPasswordChar = false;
            // 
            // sign_up_text
            // 
            sign_up_text.BackColor = Color.Transparent;
            sign_up_text.Font = new Font("Poppins SemiBold", 25F, FontStyle.Bold);
            sign_up_text.ForeColor = Color.Black;
            sign_up_text.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Top;
            sign_up_text.LineColor = Color.Transparent;
            sign_up_text.Location = new Point(241, 16);
            sign_up_text.Name = "sign_up_text";
            sign_up_text.Size = new Size(228, 44);
            sign_up_text.TabIndex = 7;
            sign_up_text.Text = "Let's sign up!";
            sign_up_text.Click += foxBigLabel1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(1, 36, 130);
            linkLabel1.Location = new Point(386, 554);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 26);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 554);
            label1.Name = "label1";
            label1.Size = new Size(194, 26);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account?";
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
            login_button.Location = new Point(84, 501);
            login_button.Name = "login_button";
            login_button.PressedBorderColor = Color.FromArgb(1, 36, 130);
            login_button.PressedColor = Color.White;
            login_button.Size = new Size(533, 43);
            login_button.TabIndex = 10;
            login_button.Text = "Create Account";
            login_button.TextAlignment = StringAlignment.Center;
            // 
            // select_role_textbox
            // 
            select_role_textbox.BackColor = Color.Transparent;
            select_role_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            select_role_textbox.ForeColor = Color.DimGray;
            select_role_textbox.Image = null;
            select_role_textbox.Location = new Point(84, 103);
            select_role_textbox.MaxLength = 32767;
            select_role_textbox.Multiline = false;
            select_role_textbox.Name = "select_role_textbox";
            select_role_textbox.ReadOnly = false;
            select_role_textbox.Size = new Size(533, 47);
            select_role_textbox.TabIndex = 6;
            select_role_textbox.Text = "Select Role";
            select_role_textbox.TextAlignment = HorizontalAlignment.Left;
            select_role_textbox.UseSystemPasswordChar = false;
            // 
            // sign_up_subtext
            // 
            sign_up_subtext.AutoSize = true;
            sign_up_subtext.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sign_up_subtext.Location = new Point(239, 63);
            sign_up_subtext.Name = "sign_up_subtext";
            sign_up_subtext.Size = new Size(231, 28);
            sign_up_subtext.TabIndex = 1;
            sign_up_subtext.Text = "Fill in the information below.";
            sign_up_subtext.Click += login_text_Click;
            // 
            // first_name_textbox
            // 
            first_name_textbox.BackColor = Color.Transparent;
            first_name_textbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            first_name_textbox.ForeColor = Color.DimGray;
            first_name_textbox.Image = null;
            first_name_textbox.Location = new Point(84, 167);
            first_name_textbox.MaxLength = 32767;
            first_name_textbox.Multiline = false;
            first_name_textbox.Name = "first_name_textbox";
            first_name_textbox.ReadOnly = false;
            first_name_textbox.Size = new Size(258, 47);
            first_name_textbox.TabIndex = 18;
            first_name_textbox.Text = "First Name";
            first_name_textbox.TextAlignment = HorizontalAlignment.Left;
            first_name_textbox.UseSystemPasswordChar = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ButtonHighlight;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(576, 110);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 19;
            iconPictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Name = "Signup";
            Text = "Form2";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)byte_logo).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.FoxBigLabel bytelog;
        private ReaLTaiizor.Controls.BigLabel signup_greeting_text;
        private PictureBox byte_logo;
        private SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.Panel panel2;
        private LinkLabel linkLabel1;
        private Label label1;
        private ReaLTaiizor.Controls.Button login_button;
        private LinkLabel forgot_password_link;
        private ReaLTaiizor.Controls.BigTextBox password_textbox;
        private ReaLTaiizor.Controls.BigTextBox select_role_textbox;
        private Label sign_up_subtext;
        private Label signup_geeting_subtext;
        private Label signup_geeting_subtext2;
        private ReaLTaiizor.Controls.FoxBigLabel sign_up_text;
        private ReaLTaiizor.Controls.BigTextBox confirm_password;
        private ReaLTaiizor.Controls.BigTextBox create_password;
        private ReaLTaiizor.Controls.BigTextBox student_id;
        private ReaLTaiizor.Controls.BigTextBox middle_name_textbox;
        private ReaLTaiizor.Controls.BigTextBox last_name_textbox;
        private ReaLTaiizor.Controls.BigTextBox first_name_textbox;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}