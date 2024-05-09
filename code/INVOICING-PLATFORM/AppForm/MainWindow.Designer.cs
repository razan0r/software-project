namespace AppForm
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            txtID = new TextBox();
            label1 = new Label();
            btnPrint = new Button();
            openFileDialog1 = new OpenFileDialog();
            brnBrowse = new Button();
            txtUpload = new TextBox();
            cmbServices = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.ForeColor = Color.FromArgb(24, 42, 80);
            txtID.Location = new Point(706, 130);
            txtID.Name = "txtID";
            txtID.Size = new Size(252, 27);
            txtID.TabIndex = 3;
            txtID.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 42, 80);
            label1.Location = new Point(706, 103);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 4;
            label1.Text = "Please enter the Member ID here:";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.Window;
            btnPrint.BackgroundImage = Properties.Resources.print1;
            btnPrint.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrint.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.WhiteSmoke;
            btnPrint.Location = new Point(977, 124);
            btnPrint.Name = "btnPrint";
            btnPrint.RightToLeft = RightToLeft.Yes;
            btnPrint.Size = new Size(42, 33);
            btnPrint.TabIndex = 5;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Visible = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // brnBrowse
            // 
            brnBrowse.BackColor = SystemColors.Window;
            brnBrowse.BackgroundImage = Properties.Resources.uplode_icon;
            brnBrowse.BackgroundImageLayout = ImageLayout.Zoom;
            brnBrowse.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point);
            brnBrowse.ForeColor = SystemColors.Window;
            brnBrowse.Location = new Point(305, 128);
            brnBrowse.Name = "brnBrowse";
            brnBrowse.Size = new Size(42, 33);
            brnBrowse.TabIndex = 7;
            brnBrowse.UseVisualStyleBackColor = false;
            brnBrowse.Click += btnBrowse_Click;
            // 
            // txtUpload
            // 
            txtUpload.ForeColor = Color.FromArgb(24, 42, 80);
            txtUpload.Location = new Point(56, 130);
            txtUpload.Name = "txtUpload";
            txtUpload.Size = new Size(243, 27);
            txtUpload.TabIndex = 8;
            txtUpload.TextChanged += txtUpload_TextChanged;
            // 
            // cmbServices
            // 
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.FormattingEnabled = true;
            cmbServices.Items.AddRange(new object[] { "الاردن", "فلسطين", "المغرب العربي", "سوريا", "مصر", "تركيا " });
            cmbServices.Location = new Point(405, 131);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(238, 28);
            cmbServices.TabIndex = 10;
            cmbServices.Visible = false;
            cmbServices.SelectedIndexChanged += cmbServices_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(24, 42, 80);
            label3.Location = new Point(405, 102);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 11;
            label3.Text = "Please choose the city:";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(24, 42, 80);
            textBox2.Location = new Point(56, 223);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 344);
            textBox2.TabIndex = 12;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(24, 42, 80);
            label2.Location = new Point(394, 9);
            label2.Name = "label2";
            label2.Size = new Size(274, 41);
            label2.TabIndex = 13;
            label2.Text = "payment receipt";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(24, 42, 80);
            label4.Location = new Point(56, 102);
            label4.Name = "label4";
            label4.Size = new Size(229, 21);
            label4.TabIndex = 15;
            label4.Text = "Please upload the excel file:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1104, 921);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbServices);
            Controls.Add(txtUpload);
            Controls.Add(brnBrowse);
            Controls.Add(btnPrint);
            Controls.Add(txtID);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Main";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtID;
        private Label label1;
        private Button btnPrint;
        private OpenFileDialog openFileDialog1;
        private Button brnBrowse;
        private TextBox txtUpload;
        private ComboBox cmbServices;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
    }
}