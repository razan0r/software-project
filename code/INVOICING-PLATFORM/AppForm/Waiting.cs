using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Windows.Forms;

namespace AppForm
{
    partial class Waiting : Form
    {
        public Waiting()
        {
            InitializeComponent();
            this.FormClosing += Form_Closing;
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);

            const int WM_LBUTTONDOWN = 0x0201;

            if (m.Msg == WM_LBUTTONDOWN)
            {

                // Open the Login form when the Waiting form is clicked
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Close the application when the form is closed by clicking the X button.
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    

    }
}
