using FolderSelect;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IFZConvertor
{
    public partial class Form1 : Form
    {

        private bool _addExtensionToName = false;    //checkbox
        private bool _sameAsSource = true;           //checkbox

        public Form1()
        {
            InitializeComponent();

            SetAllControlsToDefault();
        }

        #region "UI Controls and Events"

        /// <summary>
        /// When user selects checkbox "Destination same as Source", disable destination path selection.
        /// Copy source path to destination path.
        /// </summary>
        private void CheckDestinationPathSameAsSource() { 
            
            if(chbSameAsSourceFolder.Checked)
            {
                txbFolderDestination.Enabled = false;
                btnSelectDestination.Enabled = false;
                txbFolderDestination.Text = txbFolderSource.Text;

                _sameAsSource = true;
            }
            else
            {
                txbFolderDestination.Enabled = true;
                btnSelectDestination.Enabled = true;

                _sameAsSource = false;
            }

        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            SelectSourceFolder();
            CountImagesInFolder();
        }

        /// <summary>
        /// Open FileDialog (Vista style) to select Source folder with images.
        /// We are getting only folder paths, not files.
        /// </summary>
        private void SelectSourceFolder() {

            var fsd = new FolderSelectDialog();
            fsd.Title = "Select folder with image files.";

            if (txbFolderSource.Text.Length > 0 && Directory.Exists(txbFolderSource.Text))
            {
                fsd.InitialDirectory = txbFolderSource.Text;
            }
            else
            {
                // Get the path to the user's Documents folder
                fsd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                //Console.WriteLine(fsd.FileName);
                txbFolderSource.Text = fsd.FileName;
                CheckDestinationPathSameAsSource();
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            SelectDestinationFolder();
        }

        private void SelectDestinationFolder(){

            if (chbSameAsSourceFolder.Checked)
            {
                MessageBox.Show("Destination folder is checked the same as Source folder!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFolderDestination.Text = txbFolderSource.Text;
                return;
            }

            var fsd = new FolderSelectDialog();
            fsd.Title = "What to select";

            if (txbFolderDestination.Text.Length > 0 && Directory.Exists(txbFolderDestination.Text))
            {
                fsd.InitialDirectory = txbFolderDestination.Text;
            }
            else
            {
                // Get the path to the user's Documents folder
                fsd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                //Console.WriteLine(fsd.FileName);
                txbFolderDestination.Text = fsd.FileName;
            }
        }

        private void btnImg2Ifz_Click(object sender, EventArgs e)
        {

            SelectImg2IfzMode();

        }

        private void SelectImg2IfzMode()
        {
            pnlSelectMainMode.SendToBack();
            pnlSelectMainMode.Visible = false;

            pnlImg2Ifz.BringToFront();
            pnlImg2Ifz.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSelectMainMode.BringToFront();
            pnlSelectMainMode.Visible = true;

            pnlImg2Ifz.SendToBack();
            pnlImg2Ifz.Visible = false;
        }

        private void CountImagesInFolder()
        {
            try
            {
                // Ensure the source folder path is not empty
                if (string.IsNullOrWhiteSpace(txbFolderSource.Text))
                {
                    MessageBox.Show("Please select a source folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the folder path from the text box
                string folderPath = txbFolderSource.Text;

                // Check if the folder exists
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("The selected folder does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Count .bmp files in the folder
                int bmpFileCount = Directory.GetFiles(folderPath, "*.bmp", SearchOption.TopDirectoryOnly).Length;
                // Count .jpg files in the folder
                int jpgFileCount = Directory.GetFiles(folderPath, "*.jpg", SearchOption.TopDirectoryOnly).Length;
                // Count .jpeg files in the folder
                int jpegFileCount = Directory.GetFiles(folderPath, "*.jpeg", SearchOption.TopDirectoryOnly).Length;
                // Count .png files in the folder
                int pngFileCount = Directory.GetFiles(folderPath, "*.png", SearchOption.TopDirectoryOnly).Length;
                // Count .ifz files in the folder
                int ifzFileCount = Directory.GetFiles(folderPath, "*.ifz", SearchOption.TopDirectoryOnly).Length;

                int totalFileCount = bmpFileCount + jpgFileCount + jpegFileCount + pngFileCount + ifzFileCount;

                txbImgsCount.Text = $".bmp: {bmpFileCount} \r\n" +
                    $".jpg .jpeg: {jpgFileCount + jpegFileCount}\r\n" +
                    $".png: {pngFileCount}\r\n" +
                    $".ifz: {ifzFileCount}\r\n" +
                    $"--- --- ---" + "\r\n" +
                    $"All: {totalFileCount}";

            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the process
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshImgCount_Click(object sender, EventArgs e)
        {
            CountImagesInFolder();
        }

        /// <summary>
        /// Convert images from Image type (bmp jpg png) to .IFZ format.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertImagesToIFZ();
        }

        private void ConvertImagesToIFZ() {
            string path = txbFolderSource.Text;

            if (txbFolderSource.Text.Length < 3 || !Directory.Exists(txbFolderSource.Text))
            {
                MessageBox.Show("Please select correct folder path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                switch (cmbSelectExt.SelectedIndex)
            {
                case 0: // .bmp
                    {
                        string[] files = Directory.GetFiles(path, "*.bmp", SearchOption.TopDirectoryOnly);
                        foreach (string file in files)
                        {
                            MakeIFZ(file, ".bmp", _addExtensionToName);
                        }

                        MessageBox.Show("Converted images: " + files.Count().ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case 1: // .jpg/.jpeg
                    {
                        string[] files_jpg = Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly);
                        string[] files_jpeg = Directory.GetFiles(path, "*.jpeg", SearchOption.TopDirectoryOnly);
                        foreach (string file in files_jpg)
                        {
                            MakeIFZ(file, ".jpg", _addExtensionToName);
                        }
                        foreach (string file in files_jpeg)
                        {
                            MakeIFZ(file, ".jpeg", _addExtensionToName);
                        }

                        int totalJpg = files_jpg.Count() + files_jpeg.Count();
                        MessageBox.Show("Converted images: " + totalJpg.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case 2: // .png
                    {
                        string[] files = Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly);
                        foreach (string file in files)
                        {
                            MakeIFZ(file, ".png", _addExtensionToName);
                        }

                        MessageBox.Show("Converted images: " + files.Count().ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                case 3: // ALL: bmp + jpg + png
                    {
                        string[] files_bmp = Directory.GetFiles(path, "*.bmp", SearchOption.TopDirectoryOnly);
                        string[] files_jpg = Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly);
                        string[] files_jpeg = Directory.GetFiles(path, "*.jpeg", SearchOption.TopDirectoryOnly);
                        string[] files_png = Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly);

                        foreach (string file in files_bmp)
                        {
                            MakeIFZ(file, ".bmp", _addExtensionToName);
                        }
                        foreach (string file in files_jpg)
                        {
                            MakeIFZ(file, ".jpg", _addExtensionToName);
                        }
                        foreach (string file in files_jpeg)
                        {
                            MakeIFZ(file, ".jpeg", _addExtensionToName);
                        }
                        foreach (string file in files_png)
                        {
                            MakeIFZ(file, ".png", _addExtensionToName);
                        }

                        int totalNumber = files_bmp.Count() + files_jpg.Count() + files_jpeg.Count() + files_png.Count();
                        MessageBox.Show("Converted images: " + totalNumber.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please select a valid extension to convert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }

            //Update counters for images inside the Source folder
            CountImagesInFolder();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chbSameAsSourceFolder_CheckedChanged(object sender, EventArgs e)
        {
            CheckDestinationPathSameAsSource();
        }

        private void SetAllControlsToDefault()
        {
            _sameAsSource = true;
            _addExtensionToName = false;

            txbFolderSource.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            txbFolderDestination.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            chbSameAsSourceFolder.Enabled = true;
            chbSameAsSourceFolder.Checked = true;
            CheckDestinationPathSameAsSource();

            pnlImg2Ifz.SendToBack();
            pnlImg2Ifz.Visible = false;

            pnlSelectMainMode.BringToFront();
            pnlSelectMainMode.Visible = true;

            cmbSelectExt.SelectedIndex = 0; //select .bmp as Default extension

            chbAddExtToName.Enabled = true;
            chbAddExtToName.Checked = false;    //until we select from combobox no point in checking this
        }

        private void txbFolderSource_TextChanged(object sender, EventArgs e)
        {
            if (chbSameAsSourceFolder.Checked)
            {
                txbFolderDestination.Text = txbFolderSource.Text;
            }
        }

        #endregion

        #region "Menu UI (top)"

        // --- --- --- Menu -> File

        /// <summary>
        /// Set all fields and controls and panels to default values and states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllControlsToDefault();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- --- --- Menu -> Functions
        private void tsmiSelectSourcePath_Click(object sender, EventArgs e)
        {
            SelectSourceFolder();
        }

        private void tsmiSelectDestinationPath_Click(object sender, EventArgs e)
        {
            SelectDestinationFolder();
        }

        #endregion

        /// --- --- --- --- ---
        #region "Image conversion and transformation"

        /// <summary>
        /// Change filename extension to .ifz
        /// </summary>
        /// <param name="filename">Full filename path</param>
        /// <param name="extension">Filename extension as ".bmp" or ".png" etc</param>
        private static string MakeNewFileNameIFZ(string filename, string extension)
        {
            string filenameLower = filename.ToLower();
            int lastIndex = filenameLower.LastIndexOf(extension, StringComparison.Ordinal);

            if (lastIndex < extension.Length || lastIndex >= filenameLower.Length)
            {
                MessageBox.Show("File \r\n" + filename + "\r\n is not a " + extension + " image by extension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //string fn = filename.Replace(".bmp", ".ifz");         //replace is BAD, because it could be a part of full path
            //cut out ".bmp" (extension) part from ORIGINAL filename
            //in this version of Function we don't add original extension of the file to the end of file name
            string fn = filename.Substring(0, filenameLower.Length - extension.Length); 
            fn += ".ifz";

            return fn;
        }

        /// <summary>
        /// Change filename extension to .ifz
        /// </summary>
        /// <param name="filename">Full filename path</param>
        /// <param name="extension">Filename extension as ".bmp" or ".png" etc</param>
        private static string MakeNewFileNameIFZ(string filename, string extension, bool addExtensionToFilename)
        {
            string filenameLower = filename.ToLower();
            int lastIndex = filenameLower.LastIndexOf(extension, StringComparison.Ordinal);

            if (lastIndex < extension.Length || lastIndex >= filenameLower.Length)
            {
                MessageBox.Show("File \r\n" + filename + "\r\n is not a " + extension + " image by extension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //string fn = filename.Replace(".bmp", ".ifz");         //replace is BAD, because it could be a part of full path
            //cut out ".bmp" (extension) part from ORIGINAL filename
            //in this version of Function we don't add original extension of the file to the end of file name
            string fn = filename.Substring(0, filenameLower.Length - extension.Length);
            if (addExtensionToFilename)
            {
                fn += extension;
            }
            fn += ".ifz";

            return fn;
        }


        /// <summary>
        /// Create ONE .IFZ file from ONE image file.
        /// One to One.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool MakeIFZ(string filename, string extension)
        {
            if (filename.Equals(string.Empty))
            {
                MessageBox.Show("Empty filename!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (extension.Equals(string.Empty))
            {
                MessageBox.Show("Empty extension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string fn = MakeNewFileNameIFZ(filename, extension);

            using (new SaveFileDialog())
            {
                using (FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(4294967294u);
                        bw.Write(1);
                        WriteImageData(filename, bw);
                        bw.Close();
                        fs.Close();
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Create ONE .IFZ file from ONE image file.
        /// One to One.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool MakeIFZ(string filename, string extension, bool addExtensionToFilename)
        {
            if (filename.Equals(string.Empty))
            {
                MessageBox.Show("Empty filename!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (extension.Equals(string.Empty))
            {
                MessageBox.Show("Empty extension!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string fn = MakeNewFileNameIFZ(filename, extension, addExtensionToFilename);

            using (new SaveFileDialog())
            {
                using (FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(4294967294u);
                        bw.Write(1);
                        WriteImageData(filename, bw);
                        bw.Close();
                        fs.Close();
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// This approach assumes the replacement length matches the length of the substring being replaced. 
        /// If not, you may need to adjust the Substring calls.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replace"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        static string ReplaceSubstringFromIndex(string input, string replace, int startIndex) { 
            
            string before = input.Substring(0, startIndex);
            string after = input.Substring(startIndex + replace.Length);

            return before + replace + after;
        }

        /// <summary>
        /// Write one image data Format24bppRgb as IFZ file to Camera0 slot.
        /// </summary>
        /// <param name="img_file"></param>
        /// <param name="bw"></param>
        /// <returns></returns>
        private static bool WriteImageData(string img_file, BinaryWriter bw)
        {

            using (Bitmap bmp = new Bitmap(img_file))
            {
                if (IsMonochromeOptimized(bmp))
                {
                    bw.Write(10);
                }
                else
                {
                    bw.Write(103);
                }

                bw.Write(bmp.Width);
                bw.Write(bmp.Height);
                bw.Write(0);
                bw.Write(0);
                bw.Write(bmp.Width);
                bw.Write(bmp.Height);
                bw.Write(bmp.Width * bmp.Height + 32);

                int w = bmp.Width;
                int h = bmp.Height;

                BitmapData bmp_data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                IntPtr pData = bmp_data.Scan0;

                int stride = bmp_data.Stride;
                int size = h * stride;
                int[] target = new int[]
                {
                    1,
                    2
                };

                byte[] rgbdata = new byte[size];
                Marshal.Copy(pData, rgbdata, 0, size);

                for (int y = 0; y < h; y++)
                {
                    int pXofst = y * stride;
                    if (y < 0)
                    {
                        pXofst = 0;
                    }
                    if (y == h)
                    {
                        pXofst = (h - 1) * stride;
                    }
                    if ((y + 1) % 2 == 0)
                    {
                        target[0] = 1;
                        target[1] = 2;
                    }
                    else
                    {
                        target[0] = 0;
                        target[1] = 1;
                    }
                    for (int x = 0; x < w; x++)
                    {
                        int pPix = pXofst + x * 3;
                        bw.Write(rgbdata[pPix + target[x % 2]]);
                    }
                }
                bmp.UnlockBits(bmp_data);
            }
            return true;
        }

        public static bool IsMonochromeOptimized(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            try
            {
                int stride = bmpData.Stride;
                IntPtr scan0 = bmpData.Scan0;
                int width = bmp.Width;
                int height = bmp.Height;

                unsafe
                {
                    byte* ptr = (byte*)scan0.ToPointer();
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            byte b = ptr[y * stride + x * 3];
                            byte g = ptr[y * stride + x * 3 + 1];
                            byte r = ptr[y * stride + x * 3 + 2];

                            if (r != g || g != b)
                            {
                                return false; // The image is not monochrome
                            }
                        }
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }

            return true; // All pixels are monochrome
        }

        /*
        public static void ConvertPngToBmp(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                // Ensure the source file exists
                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException("Source file not found.", sourceFilePath);
                }

                // Load the .png file
                using (Bitmap pngImage = new Bitmap(sourceFilePath))
                {
                    // Save the image as .bmp
                    pngImage.Save(destinationFilePath, System.Drawing.Imaging.ImageFormat.Bmp);
                }

                Console.WriteLine($"Successfully converted {sourceFilePath} to {destinationFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        //*/


        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionYP versionForm = new VersionYP();
            versionForm.TopMost = true;
            versionForm.ShowDialog();
        }

        private void tsmiImg2Ifz_Click(object sender, EventArgs e)
        {
            SelectImg2IfzMode();
        }

        private void cmbSelectExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // for .jpg / .jpeg and ALL extensions we check the "Add extension to filename" checkbox by default
            if (cmbSelectExt.SelectedIndex == 1 || cmbSelectExt.SelectedIndex == 3)
            {
                chbAddExtToName.Checked = true;
                _addExtensionToName = true;
            }
            else
            {
                chbAddExtToName.Checked = false;
                _addExtensionToName = false;
            }
        }

        private void chbAddExtToName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddExtToName.Checked)
            {
                _addExtensionToName = true;
            }
            else
            {
                _addExtensionToName = false;
            }
        }
    }
}
