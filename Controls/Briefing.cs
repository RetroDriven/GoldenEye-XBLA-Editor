using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class Briefing : UserControl

    {
        public static CultureInfo resourceCulture;

        public Briefing()
        {
            InitializeComponent();
            Class_Briefing.Cleanup();
        }
        private void Map_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Map.SelectedIndex != -1 && XexFile.Text != "" && BrfFile.Text != "")
            {
                btnImport.Enabled = true;
            }
        }

        private void btnXex_Click_1(object sender, EventArgs e)
        {
            try
            {
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

                        XexFile.Text = filePath;
                        XexFile.SelectionStart = XexFile.Text.Length;
                        XexFile.ScrollToCaret();
                        XexFile.Refresh();

                        FileInfo fileInfo = new FileInfo(XexFile.Text);
                        if (fileInfo.IsReadOnly)
                        {
                            General.Message("Xex file is Read Only!");
                            XexFile.Text = "";
                        }
                        if (Map.SelectedIndex != -1 && XexFile.Text != "" && BrfFile.Text != "")
                        {
                            btnImport.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnBrf_Click_1(object sender, EventArgs e)
        {
            try
            {
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

                        BrfFile.Text = filePath;
                        BrfFile.SelectionStart = BrfFile.Text.Length;
                        BrfFile.ScrollToCaret();
                        BrfFile.Refresh();

                        FileInfo fileInfo = new FileInfo(BrfFile.Text);
                        if (fileInfo.IsReadOnly)
                        {
                            General.Message("Brf file is Read Only!");
                            BrfFile.Text = "";
                        }
                        if (Map.SelectedIndex != -1 && XexFile.Text != "" && BrfFile.Text != "")
                        {
                            btnImport.Enabled = true;
                        }

                        //Get Size of Briefing File
                        long Length = new FileInfo(BrfFile.Text).Length;
                        string BrfSize = Class_Briefing.DecToHex(Length);
                        //Console.WriteLine(BrfSize);

                        if (BrfSize != "30")
                        {
                            General.Message("Briefing File must be a Length of 30(Hex)!");
                            BrfFile.Text = "";
                            btnImport.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Map.SelectedIndex == -1)
                {
                    General.Message("Please Select Map");
                }
                else if (String.IsNullOrEmpty(XexFile.Text))
                {
                    General.Message("Please Select Xex File");
                }
                else if (String.IsNullOrEmpty(BrfFile.Text))
                {
                    General.Message("Please Select Brf File");
                }
                else
                {
                    Class_Briefing.Cleanup();

                    //Create Temp Directory
                    if(!Directory.Exists(@"C:\RetroDriven_Temp"))
                    {
                        Directory.CreateDirectory(@"C:\RetroDriven_Temp");
                    }

                    //Get Offset
                    String Map_Selected = Map.SelectedItem.ToString();
                    String Temp_Offset = Class_Briefing.GetOffset(Map_Selected);

                    //Convert Offset Text
                    int Offset = Convert.ToInt32(Temp_Offset, 16);
                    //Console.WriteLine(Offset);

                    Class_Briefing.Backup_Xex(XexFile.Text);

                    //Write the Xex
                    using (BinaryWriter writer = new BinaryWriter(File.Open(XexFile.Text, FileMode.Open, FileAccess.ReadWrite)))
                    {
                        byte[] BrfData = File.ReadAllBytes(BrfFile.Text);
                        writer.Seek(Offset, SeekOrigin.Begin);
                        writer.Write(BrfData);
                    }

                    //Get Xextool
                    String Xextool = Class_Briefing.Get_File("xextool", "exe");

                    //Sign Xex File
                    Class_Briefing.Sign_Xex(Xextool, XexFile.Text);

                    //Cleanup
                    Class_Briefing.Cleanup();

                    //All Done!
                    General.Message("Briefing Import Complete!");
                }
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }
    }
}
