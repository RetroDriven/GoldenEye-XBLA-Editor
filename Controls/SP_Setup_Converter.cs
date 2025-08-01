using Helpers;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class SP_Setup_Converter : UserControl
    {
        public SP_Setup_Converter()
        {
            InitializeComponent();
            Class_SP_Converter.Cleanup();
        }

        private void SP_Map_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SP_Map.SelectedIndex > -1)
            {
                try
                {
                    Class_SP_Converter.SP_Maps(SP_Map.SelectedItem.ToString());
                }
                catch (Exception Ex)
                {
                    Class_SP_Converter.Cleanup();
                    General.Message(Ex.Message.ToString());
                }
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Class_SP_Converter.Convert_Map(textBox4.Text, textBox5.Text);
            }
            catch (Exception Ex)
            {
                Class_SP_Converter.Cleanup();
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
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
    }
}
