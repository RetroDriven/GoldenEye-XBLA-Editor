using System;
using System.Globalization;
using System.Windows.Forms;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class Briefing_old : Form
    {
        public CultureInfo resourceCulture;

        public Briefing_old()
        {
            InitializeComponent();
            Class_Briefing.Cleanup();
        }

        private void btnXex_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Briefing.Open_Xex();
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrf_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Briefing.Edit_Xex();
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Map_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Map.SelectedIndex != -1 && XexFile.Text != "" && BrfFile.Text != "")
            {
                btnImport.Enabled = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Briefing.Import();
            }
            catch (Exception Ex)
            {
                Class_Briefing.Cleanup();
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
