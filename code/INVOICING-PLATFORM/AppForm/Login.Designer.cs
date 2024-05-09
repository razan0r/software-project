namespace AppForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            btnShow = new Button();
            btnHide = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.FromArgb(24, 42, 80);
            txtUser.Location = new Point(149, 270);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(235, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPass
            // 
            txtPass.ForeColor = Color.FromArgb(24, 42, 80);
            txtPass.Location = new Point(149, 343);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(235, 27);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(24, 42, 80);
            button1.Location = new Point(188, 419);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.Image = (Image)resources.GetObject("btnShow.Image");
            btnShow.Location = new Point(352, 345);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(32, 23);
            btnShow.TabIndex = 5;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Image = (Image)resources.GetObject("btnHide.Image");
            btnHide.Location = new Point(352, 345);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(32, 23);
            btnHide.TabIndex = 6;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BackgroundImage = Properties.Resources.user_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(112, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = Properties.Resources.pass_icon;
            pictureBox2.Location = new Point(112, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.icon1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(188, 99);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 42, 80);
            label1.Location = new Point(188, 35);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 10;
            label1.Text = "Log In ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(24, 42, 80);
            label2.Location = new Point(109, 216);
            label2.Name = "label2";
            label2.Size = new Size(282, 21);
            label2.TabIndex = 11;
            label2.Text = "Welcom In Finance Receipt Printer";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(517, 529);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnShow);
            Controls.Add(button1);
            Controls.Add(txtUser);
            Controls.Add(btnHide);
            Controls.Add(txtPass);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            RightToLeftLayout = true;
            Text = "Entrance";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private TextBox txtPass;
        private Button button1;
        private Button btnShow;
        private Button btnHide;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}