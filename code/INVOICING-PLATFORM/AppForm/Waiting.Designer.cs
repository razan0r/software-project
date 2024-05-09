namespace AppForm
{
    partial class Waiting
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiting));
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(24, 42, 80);
            label1.Location = new Point(376, 261);
            label1.Name = "label1";
            label1.Size = new Size(250, 52);
            label1.TabIndex = 0;
            label1.Text = "Kun Club...";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Maiandra GD", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(24, 42, 80);
            label2.Location = new Point(390, 361);
            label2.Name = "label2";
            label2.Size = new Size(236, 27);
            label2.TabIndex = 1;
            label2.Text = "Be Club- نادي كن الطلابي";
            // 
            // Waiting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1011, 606);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Waiting";
            Text = "Waiting";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}