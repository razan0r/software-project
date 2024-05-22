using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ReadDataFromExcel;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace ImageOperations
{
    public class ImageReader
    {
        const float restFONT_SIZE = 13;
        const float serialFont_SIZE = 11;

        const float ADDRESS_END_X = 387f;
        const float ADDRESS_Y = 220f;
        const float Date_END_X = 721f;
        const float Date_Y = 220f;
        const float NAME_X = 721f;
        const float NAME_Y = 275f;
        const float year_END_X = 721f;
        const float year_Y = 381f;
        const float payment_END_X = 387f;
        const float payment_Y = 275f;
        const float totalcost_END_X = 721f;
        const float totalcost_Y = 327f;
        const float serialNum_Y = 448f;
        const float serial_Num_END_X = 168f;


        float nameX;
        float adressX;
        float DateX;
        float totalcostX;
        float paymentX;
        float yearX;
        float serialNumX;

        private static string path;
        private static Image image;
        string outputDirectory;
        string pdfFolder;
        string exeFile;
        string exeDir;
        string nameFontPath;
        string IDFontPath;
        string restFontPath;
        string defImagePath;
        static Color customColor = Color.FromArgb(25, 25, 112);
        SolidBrush brush = new SolidBrush(customColor);



        public ImageReader()
        {
            exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            exeDir = Path.GetDirectoryName(exeFile);

            if (string.IsNullOrWhiteSpace(exeDir))
            {
                // Handle the case where exeDir is null or empty
                throw new InvalidOperationException("Unable to determine the application directory.");
            }

            path = Path.GetFullPath(Path.Combine(exeDir, "Template_Finance.jpg"));
            image = Bitmap.FromFile(path);

            outputDirectory = Path.GetFullPath(Path.Combine(exeDir, "IMAGES"));
            pdfFolder = Path.GetFullPath(Path.Combine(exeDir, "PDFs"));

            nameFontPath = Path.GetFullPath(Path.Combine(exeDir, "Fonts\\Madani Arabic Semi Bold.ttf"));
            IDFontPath = Path.GetFullPath(Path.Combine(exeDir, "Fonts\\Madani Arabic Regular.ttf"));
            restFontPath = Path.GetFullPath(Path.Combine(exeDir, "Fonts\\Madani Arabic Regular.ttf"));
        }

        public void SetTextAndPhotoData(MemberDto member)
        {
            ExcelReader reader = new ExcelReader();
            //string cs = Parameters.WriteToLog("SetTextAndPhotoData, " + Parameters.excelFilePath);


            string pdfFileName = Path.Combine(pdfFolder, $"{member.Name}.pdf");

            // Create a new document for each member
            using (Document document = new Document(PageSize.A4)) // Use A4 size (adjust if needed)
            {
                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfFileName, FileMode.Create));

                    // Open the document before adding content
                    document.Open();

                    // Add content here
                    CreateImage(member);
                    AddImageToPdf(member, document, writer);

                    // Close the document after adding content
                    document.Close();
                }
                catch (Exception ex)
                {
                    // Handle or log the exception here
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

            }
        }


        public void CreateImage(MemberDto memberDto)
        {
            // Construct the unique filename for the member
            string uniqueFilename = Path.Combine(outputDirectory, $"{memberDto.Name}.jpg");

            // Check if the output directory exists; if not, create it
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Check if the image file already exists; if yes, delete it
            if (File.Exists(uniqueFilename))
            {
                File.Delete(uniqueFilename);
            }

            // Clone the base image
            using (Image clonedImage = (Image)image.Clone())
            {
                using (Graphics graphics = Graphics.FromImage(clonedImage))
                {
                    Font restFont = new Font(restFontPath, restFONT_SIZE);
                    Font serialFont = new Font(restFontPath, serialFont_SIZE);

                    SizeF adressSize = graphics.MeasureString(memberDto.Address, restFont);
                    SizeF DateSize = graphics.MeasureString(memberDto.Date, restFont);
                    SizeF totalcostSize = graphics.MeasureString(memberDto.TotalCost, restFont);
                    SizeF paymentSize = graphics.MeasureString(memberDto.Payment, restFont);
                    SizeF nameSize = graphics.MeasureString(memberDto.Name, restFont);
                    SizeF yearSize = graphics.MeasureString(Parameters.year, restFont);
                    SizeF serialSize = graphics.MeasureString(Parameters.serialNum.ToString("D8"), serialFont);

                    adressX = ADDRESS_END_X - adressSize.Width;
                    DateX = Date_END_X - DateSize.Width;
                    totalcostX = totalcost_END_X - totalcostSize.Width;
                    paymentX = payment_END_X - paymentSize.Width;
                    nameX = NAME_X - nameSize.Width;
                    yearX = year_END_X - yearSize.Width;
                    serialNumX = serial_Num_END_X - serialSize.Width;

                    graphics.DrawString(memberDto.Address, restFont, brush, adressX, ADDRESS_Y);
                    graphics.DrawString(memberDto.Date, restFont, brush, DateX, Date_Y);
                    graphics.DrawString(memberDto.Name, restFont, brush, nameX, NAME_Y);
                    graphics.DrawString(memberDto.TotalCost, restFont, brush, totalcostX, totalcost_Y);
                    graphics.DrawString(memberDto.Payment, restFont, brush, paymentX, payment_Y);
                    graphics.DrawString(Parameters.year, restFont, brush, yearX, year_Y);
                    graphics.DrawString(Parameters.serialNum.ToString("D8"), serialFont, brush, serialNumX, serialNum_Y);


                }

                // Save the new image
                clonedImage.Save(uniqueFilename, ImageFormat.Jpeg);
            }
        }



        public void AddImageToPdf(MemberDto memberDto, Document document, PdfWriter writer)
        {
            // Check if the image file exists
            string uniqueFilename = Path.Combine(outputDirectory, $"{memberDto.Name}.jpg");

            if (File.Exists(uniqueFilename))
            {
                // Open the document before adding content
                document.Open();

                // Load the image
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(uniqueFilename);

                // Adjust the size of the image to fit the page
                img.ScaleToFit(document.PageSize.Width, document.PageSize.Height);

                // Add the image to the PDF document
                document.Add(img);

                // Close the document after adding content
                document.Close();
            }
            else
            {
                Console.WriteLine("Image file not found: " + uniqueFilename);
            }
        }



    }
}