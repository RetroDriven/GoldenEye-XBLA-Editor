using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class BinFileInjector : Form
    {
        public CultureInfo resourceCulture;

        public BinFileInjector()
        {
            InitializeComponent();

            General.Cleanup();

            //Hex and Backspace Only
            textBox4.KeyPress += TextID_KeyPress;

            //Tooltips
            toolTip1.SetToolTip(pictureBox1, "Include your Offset at the end of the filename following an Underscore it will auto populate below for you. \n\nEx: C:\\Fixes_417728.bin");
            toolTip2.SetToolTip(pictureBox2, "Text to give your Xex a Unique ID for System Link Games.\n\nThis will help prevent crashing when playing via System Link");
            toolTip3.SetToolTip(pictureBox3, "Offset location where your Bin Data file will be injected within your Xex file.");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Injector.Open_Xex();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Injector.Inject_Xex();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Injector.Open_Bin();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        public const string HexLetters = "0123456789abcdefABCDEF\b"; // \b is the BackSpace character
        private void TextID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }
    }
}

