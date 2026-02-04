using System.Globalization;

namespace GoldenEye_XBLA_Editor.Forms.Main
{
    public partial class Main : Form
    {
        public CultureInfo resourceCulture;

        public Main()
        {
            InitializeComponent();
            MP_Converter.Checked = true;
        }

        private void MP_Converter_Click(object sender, System.EventArgs e)
        {
            Hide_Controls();
            mP_Setup_Converter1.Visible = true;
        }
        private void Hide_Controls()
        {
            mP_Setup_Converter1.Visible = false;
            sP_Setup_Converter1.Visible = false;
            briefing1.Visible = false;
            xex_Signer1.Visible = false;
            mP_Music1.Visible = false;
            mP_Weapon_Set1.Visible = false;
        }

        private void SP_Converter_Click(object sender, EventArgs e)
        {
            Hide_Controls();
            sP_Setup_Converter1.Visible = true;
        }

        private void Briefing_Click(object sender, EventArgs e)
        {
            Hide_Controls();
            briefing1.Visible = true;
        }

        private void XexSign_Click(object sender, EventArgs e)
        {
            Hide_Controls();
            xex_Signer1.Visible = true;
        }

        private void MP_Music_Click(object sender, EventArgs e)
        {
            Hide_Controls();
            mP_Music1.Visible = true;
        }

        private void MP_Weapons_Click(object sender, EventArgs e)
        {
            Hide_Controls();
            mP_Weapon_Set1.Visible = true;
        }
    }
}
