using System;
using System.Globalization;
using System.Windows.Forms;
using GoldenEye_XBLA_Editor.Controls;
using GoldenEye_XBLA_Editor.Forms;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class MP_Converter_Old : Form
    {
        public CultureInfo resourceCulture;

        public MP_Converter_Old()
        {
            //Make Form Non-Sizeable
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            try
            {
                InitializeComponent();

                //Cleanup if needed
                Class_MP_Converter.Cleanup();

                //Tooltips
                toolTip1.SetToolTip(pictureBox1, "Text to give your Xex a Unique ID for System Link Games.\n\nThis will help prevent crashing when playing via System Link");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                try
                {
                    //Class_MP_Converter.MP_Maps();
                    comboBox2.Enabled = true;
                }
                catch (Exception Ex)
                {
                    Class_SP_Converter.Cleanup();
                    MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex > -1)
            {
                try
                {
                    //Class_MP_Converter.MP_Slot();
                }
                catch (Exception Ex)
                {
                    Class_SP_Converter.Cleanup();
                    MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                //Class_MP_Converter.Open_Xex();
            }
            catch (Exception Ex)
            {
                Class_SP_Converter.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                //Class_MP_Converter.Open_Setup();

                var fileContent = string.Empty;
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Set Files (*.set)|*.set";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        textBox5.Text = filePath;

                        FileInfo fileInfo = new FileInfo(filePath);
                        if (fileInfo.IsReadOnly)
                        {
                            Message_Box form = new Message_Box();
                            form.label1.Text = "Set file is Read Only!";
                            form.ShowDialog();
                            textBox5.Text = "";
                        }
                        else
                        {
                            if (textBox4.Text != "" && textBox5.Text != "")
                            {
                                btnConvert.Enabled = true;

                                textBox5.SelectionStart = textBox5.Text.Length;
                                textBox5.ScrollToCaret();
                                textBox5.Refresh();
                            }
                        }
                    }
                }

            }
            catch (Exception Ex)
            {
                Class_SP_Converter.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                //Class_MP_Converter.Convert_Map();
            }
            catch (Exception Ex)
            {
                Class_MP_Converter.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}