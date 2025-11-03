using FolderSelect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IFZConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlImg2Ifz.SendToBack();
            pnlImg2Ifz.Visible = false;

            cmbSelectExt.SelectedIndex = 0; //select .bmp as Default extension
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "Select folder with image files.";

            if (txbFolderSource.Text.Length > 0 && Directory.Exists(txbFolderSource.Text))
            {
                fsd.InitialDirectory = txbFolderSource.Text;
            }
            else{
                fsd.InitialDirectory = @"c:\";
            }

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                Console.WriteLine(fsd.FileName);
                txbFolderSource.Text = fsd.FileName;
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            var fsd = new FolderSelectDialog();
            fsd.Title = "What to select";

            if (txbFolderDestination.Text.Length > 0 && Directory.Exists(txbFolderDestination.Text))
            {
                fsd.InitialDirectory = txbFolderDestination.Text;
            }
            else
            {
                fsd.InitialDirectory = @"c:\";
            }

            if (fsd.ShowDialog(IntPtr.Zero))
            {
                Console.WriteLine(fsd.FileName);
                txbFolderDestination.Text = fsd.FileName;
            }
        }

        private void btnImg2Ifz_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(txbFolderSource.Text))
            {
                if (Directory.Exists(txbFolderDestination.Text))
                {
                    //ok
                }
                else
                {
                    txbFolderDestination.Text = txbFolderSource.Text; // It will be the same folder.
                }
            }
            else
            {
                // No source dir -
                MessageBox.Show("Error: Source path not found! Please, check specified path.");
                return;
            }

            pnlSelectFolders.SendToBack();
            pnlSelectFolders.Visible = false;

            pnlImg2Ifz.BringToFront();
            pnlImg2Ifz.Visible = true;

            // call for counting files in the provided source folder
            CountImagesInFolder();

            txbFolderPath.Text = txbFolderSource.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSelectFolders.BringToFront();
            pnlSelectFolders.Visible = true;

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

                txbImgsCount.Text = $".bmp: {bmpFileCount} \r\n.jpg .jpeg: {jpgFileCount + jpegFileCount}\r\n.png: {pngFileCount}\r\n.ifz: {ifzFileCount}";

                // Display the count to the user
                //MessageBox.Show($"Number of .bmp files: {bmpFileCount}", "File Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ExecuteSave()
        {
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                fd.Filter = "IFZ(*.ifz)|*.ifz";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fn = fd.FileName;
                        using (FileStream fs = new FileStream(fn, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(4294967294u);
                                bw.Write(this.GetCameraConnectInfo());
                                //this.WriteImageData(this.cameraImage0, bw);
                                //this.WriteImageData(this.cameraImage1, bw);
                                //this.WriteImageData(this.cameraImage2, bw);
                                //this.WriteImageData(this.cameraImage3, bw);
                                //this.WriteImageData(this.cameraImage4, bw);
                                //this.WriteImageData(this.cameraImage5, bw);
                                //this.WriteImageData(this.cameraImage6, bw);
                                //this.WriteImageData(this.cameraImage7, bw);
                                bw.Close();
                                fs.Close();
                            }
                        }
                    }
                    catch
                    {
                        //MessageBox.Show(this.lang.GetText("saveError"));
                    }
                }
            }
        }

        public static bool MakeIFZ(string filename)
        {
            filename = filename.ToLower();
            if (filename.IndexOf(".bmp") < 1)
            {
                return false;
            }
            string fn = filename.Replace(".bmp", ".ifz");
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

        private bool WriteImageData(cameraimage camimg, BinaryWriter bw)
        {
            if (camimg.CameraEnable)
            {
                if (camimg.isMonochrome)
                {
                    bw.Write(10);
                }
                else
                {
                    bw.Write(103);
                }
                
                bw.Write(camimg.CameraWidth);
                bw.Write(camimg.CameraHeight);
                bw.Write(Math.Max(0, camimg.ImageOffsetX));
                bw.Write(Math.Max(0, camimg.ImageOffsetY));
                bw.Write(camimg.ImageWidth);
                bw.Write(camimg.ImageHeight);
                bw.Write(camimg.ImageWidth * camimg.ImageHeight + 32);

                using (Bitmap bmp = camimg.ImageData)
                {
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
            }
            return true;
        }

        /*
        private static bool WriteImageData_Original(string img_file, BinaryWriter bw)
        {
            bw.Write(10);
            using (Bitmap bmp = new Bitmap(img_file))
            {
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
        //*/


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

        /// <summary>
        /// Write one image data as IFZ file to Camera0 slot
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


        private uint GetCameraConnectInfo()
        {
            uint caminfo = 0u;
            //if (this.cameraImage7.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage6.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage5.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage4.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage3.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage2.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage1.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            //caminfo <<= 1;
            //if (this.cameraImage0.CameraEnable)
            //{
            //    caminfo += 1u;
            //}
            return caminfo;
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string path = txbFolderSource.Text;

            switch (cmbSelectExt.SelectedIndex)
            {
                case 0: // .bmp
                    {
                        string[] files = Directory.GetFiles(path, "*.bmp", SearchOption.TopDirectoryOnly);
                        foreach (string file in files)
                        {
                            MakeIFZ(file);
                        }
                        break;
                    }
                case 1: // .jpg/.jpeg
                    {
                        string[] files_jpg = Directory.GetFiles(path, "*.jpg", SearchOption.TopDirectoryOnly);
                        string[] files_jpeg = Directory.GetFiles(path, "*.jpeg", SearchOption.TopDirectoryOnly);
                        foreach (string file in files_jpg)
                        {
                            MakeIFZ(file);
                        }
                        foreach (string file in files_jpeg)
                        {
                            MakeIFZ(file);
                        }
                        break;
                    }
                case 2: // .png
                    {
                        string[] files = Directory.GetFiles(path, "*.png", SearchOption.TopDirectoryOnly);
                        foreach (string file in files)
                        {
                            MakeIFZ(file);
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please select a valid extension to convert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
