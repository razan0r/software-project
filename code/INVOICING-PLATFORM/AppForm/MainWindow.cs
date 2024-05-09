using ReadDataFromExcel;
using ImageOperations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppForm
{

    public partial class MainWindow : Form
    {

        ExcelReader excelReader = new ExcelReader();
        ImageReader image = new ImageReader();
        public MainWindow()
        {
            InitializeComponent();
            this.FormClosing += Form_Closing;
            txtUpload.PlaceholderText = "  the excel file";
            txtID.PlaceholderText = "  The Member ID ";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wanna print for this Member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Assume excelReader is already defined and can retrieve a member by ID.
                MemberDto memberDto = excelReader.GetMemberFromId(txtID.Text);

                    // Assume ImageReader is set up to handle member data.
                    ImageReader imageReader = new ImageReader();
                    imageReader.SetTextAndPhotoData(memberDto);

                    // Increment the serial number.
                    Parameters.serialNum++;

                    // Update the serial number in t he file.
                    UpdateSerialNumberInFile(Parameters.serialNum);

                    // Show a message indicating the process is done.
                    MessageBox.Show("The process is done", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
             
            }
        }

        private void UpdateSerialNumberInFile(int newSerialNum)
        {
            try
            {
                // Write the new serial number to the file, overwriting the existing content.
                File.WriteAllText(Parameters.serialPath, newSerialNum.ToString());

                // Optionally, you can add code here to handle any actions after successfully updating the file.
            }
            catch (Exception ex)
            {
                // Log or handle exceptions here as needed.
                MessageBox.Show($"Failed to update serial number in file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            // string cs = Parameters.WriteToLog("btnBrowse_Click, " + Parameters.excelFilePath);
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtUpload.Text = fileDialog.FileName;

                    //   string cs1 = Parameters.WriteToLog("btnBrowse_Click, " + Parameters.excelFilePath);
                    Parameters.excelFilePath = fileDialog.FileName;
                    excelReader.ReadData(); // You might want to re-read data here if needed.
                }
            }
            catch (Exception ex)
            {
                //cs = Parameters.WriteToLog("btnBrowse_Click, Exception " + ex.Message.ToString());
            }
            finally
            {

            }
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Initialize an empty string to accumulate member details.
            string paidMembers = "";

            // Get the selected option from cmbServices.
            string selectedOption = cmbServices.SelectedItem.ToString();

            // Hide certain controls initially.
            label1.Visible = false;
            txtID.Visible = false;
            btnPrint.Visible = false;

            // Clear the textBox2 text to prepare for new content based on the selected option.
            textBox2.Text = "";
            // Show the controls as necessary.
            label1.Visible = true;
            txtID.Visible = true;
            btnPrint.Visible = true;
            textBox2.Visible = true;

            // Set the selected city in Parameters based on the selected item.
            Parameters.city = selectedOption;

            excelReader.Members.Clear();
            // Assuming excelReader.ReadData() refreshes the Members list based on the selected option.
            excelReader.ReadData();

            // Iterate through each member in the updated Members collection.
            foreach (var member in excelReader.Members)
            {
                // Append the member's Id and Name to the paidMembers string, each followed by a newline.
                paidMembers += $"Id: {member.Id}, Name: {member.Name}\r\n"; // Use "\r\n" for Windows or "\n" for Unix-like systems.
            }

            // Update textBox2.Text with the new members' details.
            textBox2.Text = paidMembers;
        }

        private void txtUpload_TextChanged(object sender, EventArgs e)
        {
            cmbServices.Visible = true;
            label3.Visible = true;
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit(); // Close the application when the form is closed by clicking the X button.
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUpload_Click(object sender, EventArgs e)
        {

        }
    }
}