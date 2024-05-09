using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += Form_Closing;
            txtPass.PasswordChar = '*';
            txtUser.PlaceholderText = "  Username";
            txtPass.PlaceholderText = "  Password";
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "admin" && txtPass.Text == "2024")
            {
                new MainWindow().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter the write the correct info");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Close the application when the form is closed by clicking the X button.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
