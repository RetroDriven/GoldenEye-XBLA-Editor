using System;
using System.Globalization;
using System.Windows.Forms;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class SP_Converter : Form
    {
        public CultureInfo resourceCulture;

        public SP_Converter()
        {
            //Make Form Non-Sizeable
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            try
            {
                InitializeComponent();

                //Cleanup if needed
                Class_SP_Converter.Cleanup();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                //Class_SP_Converter.Open_Xex();
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
                //Class_SP_Converter.Open_Setup();
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
                //Class_SP_Converter.Convert_Map();
            }
            catch (Exception Ex)
            {
                Class_SP_Converter.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex > -1)
            {
                try
                {
                    //Class_SP_Converter.SP_Maps();
                }
                catch (Exception Ex)
                {
                    Class_SP_Converter.Cleanup();
                    MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}