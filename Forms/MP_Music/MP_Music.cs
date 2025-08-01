using System;
using System.Globalization;
using System.Windows.Forms;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class MPMusic : Form
    {
        public CultureInfo resourceCulture;

        public MPMusic()
        {
            InitializeComponent();
            General.Cleanup();
            toolTip1.SetToolTip(pictureBox1, "Text to give your Xex a Unique ID for System Link Games.\n\nThis will help prevent crashing when playing via System Link");
        }

        private void btnXex_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Music.Open_Xex();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Music.Edit_Xex();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetTracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Music.Reset_Tracks();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importTracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Music.Import_Tracks();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportTracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Music.Export_Tracks();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
