using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Helpers;

namespace GoldenEye_XBLA_Editor
{
    public partial class Form_WS_Editor : Form
    {
        public CultureInfo resourceCulture;

        public Form_WS_Editor()
        {
            InitializeComponent();

            General.Cleanup();

            //Make Sure Hex Characters are only Entered
            TextID_Slappers.KeyPress += TextID_KeyPress;
            TextID_Automatics.KeyPress += TextID_KeyPress;
            TextID_GG.KeyPress += TextID_KeyPress;
            TextID_GL.KeyPress += TextID_KeyPress;
            TextID_Grenades.KeyPress += TextID_KeyPress;
            TextID_HK.KeyPress += TextID_KeyPress;
            TextID_Lasers.KeyPress += TextID_KeyPress;
            TextID_Pistols.KeyPress += TextID_KeyPress;
            TextID_PM.KeyPress += TextID_KeyPress;
            TextID_PW.KeyPress += TextID_KeyPress;
            TextID_RM.KeyPress += TextID_KeyPress;
            TextID_Rockets.KeyPress += TextID_KeyPress;
            TextID_Snipers.KeyPress += TextID_KeyPress;
            TextID_TK.KeyPress += TextID_KeyPress;
            TextID_TM.KeyPress += TextID_KeyPress;
            toolTip1.SetToolTip(pictureBox1, "Text to give your Xex a Unique ID for System Link Games.\n\nThis will help prevent crashing when playing via System Link");
        }

        private void btnXex_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Weapon_Sets.Open_Xex();
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
                Class_Weapon_Sets.Edit_Xex();
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

        private void resetAllWeaponSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Weapon_Sets.Reset_Weapons();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetSlappersOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Slappers");
        }

        private void resetPistolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Pistols");
        }

        private void resetThrowingKnivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Throwing Knives");
        }

        private void resetAutomaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Automatics");
        }

        private void powerWeaponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Power Weapons");
        }

        private void resetSniperRifelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Snipers");
        }

        private void resetGrenadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Grenades");
        }

        private void resetRemoteMinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Remote Mines");
        }

        private void resetGrenadeLaunchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Grenade Launchers");
        }

        private void resetTimedMinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Timed Mines");
        }

        private void resetProximityMinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Proximity Mines");
        }

        private void resetRocketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Rockets");
        }

        private void resetLasersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Lasers");
        }

        private void resetGoldenGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Golden Gun");
        }

        private void resetHuntingKnivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class_Weapon_Sets.Reset("Hunting Knives");
        }

        private void exportWeaponSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Weapon_Sets.Export_Weapons();

                MessageBox.Show("Weapon Sets Exported Successfully!", "Export Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void importWeaponSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Class_Weapon_Sets.Import_Weapons();

                MessageBox.Show("Weapon Sets Imported Successfully!", "Export Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}