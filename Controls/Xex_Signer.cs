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
    public partial class Xex_Signer : UserControl
    {
        public static CultureInfo resourceCulture;

        public Xex_Signer()
        {
            InitializeComponent();

            //Create Temp Directory
            if (Directory.Exists(@"C:\RetroDriven_Temp"))
            {
                Directory.Delete(@"C:\RetroDriven_Temp", true);
            }
            Directory.CreateDirectory(@"C:\RetroDriven_Temp");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                //Class_MP_Converter.Open_Xex();

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

                        textBox4.Text = filePath;
                        textBox4.SelectionStart = textBox4.Text.Length;
                        textBox4.ScrollToCaret();
                        textBox4.Refresh();

                        FileInfo fileInfo = new FileInfo(filePath);
                        if (fileInfo.IsReadOnly)
                        {
                            General.Message("Xex file is Read Only!");
                            textBox4.Text = "";
                        }
                        else
                        {

                            //if (textBox4.Text != "")
                            //{
                            //    btnSign.Enabled = true;
                            //}


                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Class_MP_Converter.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                //Get Xextool
                String Xextool = Class_MP_Converter.Get_File("xextool", "exe");

                //Sign Xex File
                Class_MP_Converter.Sign_Xex(Xextool, textBox4.Text);
                Class_MP_Converter.Cleanup();
                btnSign.Enabled = false;
                General.Message("Xex File Signed!");
                btnSign.Enabled = true;

            }
            catch (Exception Ex)
            {
                Class_MP_Converter.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                btnSign.Enabled = true;
            }
            else
            {
                btnSign.Enabled = false;
            }
        }
    }
}
