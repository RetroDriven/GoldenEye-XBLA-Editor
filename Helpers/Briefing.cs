using GoldenEye_XBLA_Editor;
using GoldenEye_XBLA_Editor.Controls;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Helpers
{
    public class Class_Briefing
    {
        public static CultureInfo resourceCulture;

        public static void Import()
        {
            Briefing control = new Briefing();
            //Briefing_old form1 = (Briefing_old)Application.OpenForms["Briefing"];

            if (control.Map.SelectedIndex == -1)
            {
                General.Message("Please Select Map");
            }
            else if (String.IsNullOrEmpty(control.XexFile.Text))
            {
                General.Message("Please Select Xex File");
            }
            else if (String.IsNullOrEmpty(control.BrfFile.Text))
            {
                General.Message("Please Select Brf File");
            }
            else
            {
                Cleanup();

                //Create Temp Directory
                Directory.CreateDirectory(@"C:\RetroDriven_Temp");

                //Get Offset
                String Map_Selected = control.Map.SelectedItem.ToString();
                String Temp_Offset = Class_Briefing.GetOffset(Map_Selected);

                //Convert Offset Text
                int Offset = Convert.ToInt32(Temp_Offset, 16);
                //Console.WriteLine(Offset);

                Backup_Xex(control.XexFile.Text);

                //Write the Xex
                using (BinaryWriter writer = new BinaryWriter(File.Open(control.XexFile.Text, FileMode.Open, FileAccess.ReadWrite)))
                {
                    byte[] BrfData = File.ReadAllBytes(control.BrfFile.Text);
                    writer.Seek(Offset, SeekOrigin.Begin);
                    writer.Write(BrfData);
                }

                //Get Xextool
                String Xextool = Get_File("xextool", "exe");

                //Sign Xex File
                Sign_Xex(Xextool, control.XexFile.Text);

                //Cleanup
                Cleanup();

                //All Done!
                General.Message("Briefing Import Complete!");
            }
        }
        public static string DecToHex(long decValue)
        {
            return string.Format("{0:x}", decValue);
        }
        public static void Edit_Xex()
        {
            Briefing control = new Briefing();
            //Briefing_old form1 = (Briefing_old)Application.OpenForms["Briefing"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Brf Files (*.brf)|*.brf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    control.BrfFile.Text = filePath;
                    control.BrfFile.SelectionStart = control.BrfFile.Text.Length;
                    control.BrfFile.ScrollToCaret();
                    control.BrfFile.Refresh();

                    FileInfo fileInfo = new FileInfo(control.BrfFile.Text);
                    if (fileInfo.IsReadOnly)
                    {
                        General.Message("Brf file is Read Only!");
                        control.BrfFile.Text = "";
                    }
                    if (control.Map.SelectedIndex != -1 && control.XexFile.Text != "" && control.BrfFile.Text != "")
                    {
                        control.btnImport.Enabled = true;
                    }

                    //Get Size of Briefing File
                    long Length = new FileInfo(control.BrfFile.Text).Length;
                    string BrfSize = DecToHex(Length);
                    //Console.WriteLine(BrfSize);

                    if (BrfSize != "30")
                    {
                        General.Message("Briefing File must be a Length of 30(Hex)!");
                        control.BrfFile.Text = "";
                        control.btnImport.Enabled = false;
                    }
                }
            }

        }
        public static void Open_Xex()
        {
            Briefing control = new Briefing();
            //Briefing_old form1 = (Briefing_old)Application.OpenForms["Briefing"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Xex Files (*.xex)|*.xex";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    control.XexFile.Text = filePath;
                    control.XexFile.SelectionStart = control.XexFile.Text.Length;
                    control.XexFile.ScrollToCaret();
                    control.XexFile.Refresh();

                    FileInfo fileInfo = new FileInfo(control.XexFile.Text);
                    if (fileInfo.IsReadOnly)
                    {
                        General.Message("Xex file is Read Only!");
                        control.XexFile.Text = "";
                    }
                    if (control.Map.SelectedIndex != -1 && control.XexFile.Text != "" && control.BrfFile.Text != "")
                    {
                        control.btnImport.Enabled = true;
                    }
                }
            }

        }

        public static string GetOffset(string Map)
        {
            if (Map == "Archives")
            {
                return "71DF60";
            }
            if (Map == "Control")
            {
                return "71DF90";
            }
            if (Map == "Facility")
            {
                return "71DFC0";
            }
            if (Map == "Aztec")
            {
                return "71DFF0";
            }
            if (Map == "Cradle")
            {
                return "71E020";
            }
            if (Map == "Egyptian")
            {
                return "71E050";
            }
            if (Map == "Dam")
            {
                return "71E080";
            }
            if (Map == "Depot")
            {
                return "71E0B0";
            }
            if (Map == "Frigate")
            {
                return "71E0E0";
            }
            if (Map == "Jungle")
            {
                return "71E110";
            }
            if (Map == "Cuba(End Credits)")
            {
                return "71E140";
            }
            if (Map == "Runway")
            {
                return "71E170";
            }
            if (Map == "Bunker 1")
            {
                return "71E1A0";
            }
            if (Map == "Bunker 2")
            {
                return "71E1D0";
            }
            if (Map == "Surface 1")
            {
                return "71E200";
            }
            if (Map == "Surface 2")
            {
                return "71E230";
            }
            if (Map == "Silo")
            {
                return "71E260";
            }
            if (Map == "Statue")
            {
                return "71E290";
            }
            if (Map == "Train")
            {
                return "71E2C0";
            }
            if (Map == "Streets")
            {
                return "71E2F0";
            }
            if (Map == "Caverns")
            {
                return "71E320";
            }
            else
            {
                return "";
            }
        }

        public static void Sign_Xex(string XexToolExe, string XexFile)
        {
            var startInfo = new ProcessStartInfo(XexToolExe, $"-md \"{@XexFile}\"");
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            var SignXex = Process.Start(startInfo);
            SignXex.WaitForExit();

        }
        public static string Get_File(string File_Name, string Extension)
        {
            //Briefing control = new Briefing();
            //Briefing_old form1 = (Briefing_old)Application.OpenForms["Briefing"];

            string File_Path = @"C:\RetroDriven_Temp\";
            string File = File_Path + File_Name + "." + Extension;
            object ob = Resource1.ResourceManager.GetObject(File_Name, resourceCulture);
            byte[] myResBytes = (byte[])ob;
            using (FileStream fsDst = new FileStream(File, FileMode.CreateNew))
            {
                byte[] bytes = myResBytes;
                fsDst.Write(bytes, 0, bytes.Length);
                fsDst.Close();
                fsDst.Dispose();
                return File;
            }
        }

        public static void Backup_Xex(string XexFile)
        {
            string CurrentFolder = Path.GetDirectoryName(@XexFile);
            string BackupFolder = @CurrentFolder + "\\Xex_Backups";
            Directory.CreateDirectory(BackupFolder);

            string sourceFile = @XexFile;
            string strFileName = Path.GetFileNameWithoutExtension(@sourceFile);
            string destinationFile = @BackupFolder + "\\" + string.Format(strFileName + "-{0:MM-dd-yyyy_hh-mm-ss}.xex", DateTime.Now);

            File.Copy(@sourceFile, @destinationFile);
        }

        public static void Cleanup()
        {
            if (File.Exists(@"C:\RetroDriven_Temp\SetupConverter.exe"))
            {
                File.Delete(@"C:\RetroDriven_Temp\SetupConverter.exe");
            }
            if (File.Exists(@"C:\RetroDriven_Temp\xextool.exe"))
            {
                File.Delete(@"C:\RetroDriven_Temp\xextool.exe");
            }
            if (Directory.Exists(@"C:\RetroDriven_Temp"))
            {
                Directory.Delete(@"C:\RetroDriven_Temp", true);
            }
        }
    }
}