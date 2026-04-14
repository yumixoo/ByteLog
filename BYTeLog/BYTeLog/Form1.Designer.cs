namespace BYTeLog
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
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox3 = new PictureBox();
            dashboard = new Button();
            pictureBox4 = new PictureBox();
            payment = new Button();
            pictureBox5 = new PictureBox();
            panel5 = new Panel();
            textBox6 = new TextBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 36, 130);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 85);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 80);
            panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(84, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 20);
            textBox2.TabIndex = 2;
            textBox2.Text = "BYTe Membership  and Fee Tracker";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(84, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 20);
            textBox1.TabIndex = 1;
            textBox1.Text = "BYTeLog";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._462188993_504834578979683_7612540065311618134_n;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(4, 88);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(1, 36, 130);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.ForeColor = Color.Transparent;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1002, 621);
            splitContainer1.SplitterDistance = 232;
            splitContainer1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(payment);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(dashboard);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 632);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(7, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 80);
            panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bg__1_;
            pictureBox2.Location = new Point(7, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(79, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 20);
            textBox3.TabIndex = 3;
            textBox3.Text = "Agustin, Raymond";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(79, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 20);
            textBox4.TabIndex = 4;
            textBox4.Text = "2402071";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dashboard_layout_removebg_preview;
            pictureBox3.Location = new Point(173, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // dashboard
            // 
            dashboard.ForeColor = Color.Black;
            dashboard.Location = new Point(8, 113);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(209, 56);
            dashboard.TabIndex = 1;
            dashboard.Text = "Dashboard\r\n";
            dashboard.TextAlign = ContentAlignment.MiddleLeft;
            dashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(171, 186);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // payment
            // 
            payment.ForeColor = Color.Black;
            payment.Location = new Point(6, 175);
            payment.Name = "payment";
            payment.Size = new Size(209, 56);
            payment.TabIndex = 3;
            payment.Text = "Payment";
            payment.TextAlign = ContentAlignment.MiddleLeft;
            payment.UseVisualStyleBackColor = true;
            payment.Click += this.button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(754, 19);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 35);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(pictureBox6);
            panel5.Location = new Point(819, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(164, 53);
            panel5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LightGray;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(62, 14);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(80, 20);
            textBox6.TabIndex = 3;
            textBox6.Text = "Agustin";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.bg__1_;
            pictureBox6.Location = new Point(7, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(49, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private SplitContainer splitContainer1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private PictureBox pictureBox4;
        private Button payment;
        private PictureBox pictureBox3;
        private Button dashboard;
        private PictureBox pictureBox5;
        private Panel panel5;
        private TextBox textBox6;
        private PictureBox pictureBox6;
    }
}
