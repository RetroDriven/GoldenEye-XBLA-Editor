using GoldenEye_XBLA_Editor.Forms;
using Helpers;
using System.Globalization;
using System.Text;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class MP_Setup_Converter : UserControl
    {
        public CultureInfo resourceCulture;
        public MP_Setup_Converter()
        {
            InitializeComponent();
            Class_MP_Converter.Cleanup();

        }

        private void MP_Map_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MP_Map.SelectedIndex > -1)
            {
                try
                {
                    Class_MP_Converter.MP_Maps(MP_Map.SelectedItem.ToString());
                    MP_Slot.Enabled = true;
                }
                catch (Exception Ex)
                {
                    Class_MP_Converter.Cleanup();
                    General.Message(Ex.Message.ToString());
                }
            }
        }

        private void MP_Slot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MP_Slot.SelectedIndex > -1)
            {
                try
                {
                    Class_MP_Converter.MP_Slot(MP_Slot.SelectedItem.ToString());
                }
                catch (Exception Ex)
                {
                    Class_MP_Converter.Cleanup();
                    General.Message(Ex.Message.ToString());

                }
            }
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
                            txtUnique.Enabled = true;

                            byte[] data = new byte[22];

                            using (FileStream fs = new FileStream(textBox4.Text, FileMode.Open))
                            {
                                fs.Position = 7452;
                                fs.Read(data, 0, 22);
                                String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));

                                var bytes = new byte[UniqueName.Length / 2];
                                for (var i = 0; i < bytes.Length; i++)
                                {
                                    bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                    txtUnique.Text = Encoding.UTF8.GetString(bytes);
                                }
                            }
                            if (textBox4.Text != "" && textBox5.Text != "")
                            {
                                btnConvert.Enabled = true;
                            }
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

                        textBox5.SelectionStart = textBox5.Text.Length;
                        textBox5.ScrollToCaret();
                        textBox5.Refresh();

                        FileInfo fileInfo = new FileInfo(filePath);
                        if (fileInfo.IsReadOnly)
                        {
                            General.Message("Set file is Read Only!");
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
                Class_MP_Converter.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Class_MP_Converter.Convert_Map(textBox4.Text, textBox5.Text, txtUnique.Text,Backup);

            }
            catch (Exception Ex)
            {
                Class_MP_Converter.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnique_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
