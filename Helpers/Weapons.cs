using GoldenEye_XBLA_Editor;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Helpers
{
    public class Class_Weapons
    {
        public static void Reset(string Weapon_Set)
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            try
            {
                if (Weapon_Set == "Slappers")
                {
                    form1.W1_Slappers.SelectedItem = "Slapper";
                    form1.W2_Slappers.SelectedItem = "Slapper";
                    form1.W3_Slappers.SelectedItem = "Slapper";
                    form1.W4_Slappers.SelectedItem = "Slapper";
                    form1.W5_Slappers.SelectedItem = "Slapper";
                    form1.W6_Slappers.SelectedItem = "Slapper";
                    form1.W7_Slappers.SelectedItem = "Slapper";
                    form1.W8_Slappers.SelectedItem = "Slapper";
                }
                if (Weapon_Set == "Pistols")
                {
                    form1.W1_Pistols.SelectedItem = "DD4 Dostovei";
                    form1.W2_Pistols.SelectedItem = "DD4 Dostovei";
                    form1.W3_Pistols.SelectedItem = "DD4 Dostovei";
                    form1.W4_Pistols.SelectedItem = "PP7 Silenced";
                    form1.W5_Pistols.SelectedItem = "PP7 Silenced";
                    form1.W6_Pistols.SelectedItem = "PP7 Silenced";
                    form1.W7_Pistols.SelectedItem = "Cougar Magnum";
                    form1.W8_Pistols.SelectedItem = "Cougar Magnum";
                }
                if (Weapon_Set == "Throwing Knives")
                {
                    form1.W1_TK.SelectedItem = "Throwing Knife";
                    form1.W2_TK.SelectedItem = "Throwing Knife";
                    form1.W3_TK.SelectedItem = "Throwing Knife";
                    form1.W4_TK.SelectedItem = "Throwing Knife";
                    form1.W5_TK.SelectedItem = "Throwing Knife";
                    form1.W6_TK.SelectedItem = "Throwing Knife";
                    form1.W7_TK.SelectedItem = "Throwing Knife";
                    form1.W8_TK.SelectedItem = "Throwing Knife";
                }
                if (Weapon_Set == "Automatics")
                {
                    form1.W1_Automatics.SelectedItem = "PP7 Silenced";
                    form1.W2_Automatics.SelectedItem = "PP7 Silenced";
                    form1.W3_Automatics.SelectedItem = "DD4 Dostovei";
                    form1.W4_Automatics.SelectedItem = "DD4 Dostovei";
                    form1.W5_Automatics.SelectedItem = "Klobb";
                    form1.W6_Automatics.SelectedItem = "Klobb";
                    form1.W7_Automatics.SelectedItem = "D5K Deutsche";
                    form1.W8_Automatics.SelectedItem = "D5K Deutsche";
                }
                if (Weapon_Set == "Power Weapons")
                {
                    form1.W1_PW.SelectedItem = "DD4 Dostovei";
                    form1.W2_PW.SelectedItem = "DD4 Dostovei";
                    form1.W3_PW.SelectedItem = "Cougar Magnum";
                    form1.W4_PW.SelectedItem = "Cougar Magnum";
                    form1.W5_PW.SelectedItem = "RC-P90";
                    form1.W6_PW.SelectedItem = "RC-P90";
                    form1.W7_PW.SelectedItem = "Automatic Shotgun";
                    form1.W8_PW.SelectedItem = "Automatic Shotgun";
                }
                if (Weapon_Set == "Snipers")
                {
                    form1.W1_Sniper.SelectedItem = "DD4 Dostovei";
                    form1.W2_Sniper.SelectedItem = "DD4 Dostovei";
                    form1.W3_Sniper.SelectedItem = "Cougar Magnum";
                    form1.W4_Sniper.SelectedItem = "Cougar Magnum";
                    form1.W5_Sniper.SelectedItem = "Klobb";
                    form1.W6_Sniper.SelectedItem = "Klobb";
                    form1.W7_Sniper.SelectedItem = "Sniper Rifle";
                    form1.W8_Sniper.SelectedItem = "Sniper Rifle";
                }
                if (Weapon_Set == "Grenades")
                {
                    form1.W1_Grenade.SelectedItem = "DD4 Dostovei";
                    form1.W2_Grenade.SelectedItem = "DD4 Dostovei";
                    form1.W3_Grenade.SelectedItem = "Klobb";
                    form1.W4_Grenade.SelectedItem = "Klobb";
                    form1.W5_Grenade.SelectedItem = "KF7 Soviet";
                    form1.W6_Grenade.SelectedItem = "KF7 Soviet";
                    form1.W7_Grenade.SelectedItem = "Hand Grenade";
                    form1.W8_Grenade.SelectedItem = "Hand Grenade";
                }
                if (Weapon_Set == "Remote Mines")
                {
                    form1.W1_RM.SelectedItem = "PP7";
                    form1.W2_RM.SelectedItem = "PP7";
                    form1.W3_RM.SelectedItem = "ZMG";
                    form1.W4_RM.SelectedItem = "ZMG";
                    form1.W5_RM.SelectedItem = "AR33 Assault Rifle";
                    form1.W6_RM.SelectedItem = "AR33 Assault Rifle";
                    form1.W7_RM.SelectedItem = "Remote Mine";
                    form1.W8_RM.SelectedItem = "Remote Mine";
                }
                if (Weapon_Set == "Grenade Launchers")
                {
                    form1.W1_GL.SelectedItem = "DD4 Dostovei";
                    form1.W2_GL.SelectedItem = "DD4 Dostovei";
                    form1.W3_GL.SelectedItem = "Klobb";
                    form1.W4_GL.SelectedItem = "Klobb";
                    form1.W5_GL.SelectedItem = "KF7 Soviet";
                    form1.W6_GL.SelectedItem = "KF7 Soviet";
                    form1.W7_GL.SelectedItem = "Grenade Launcher";
                    form1.W8_GL.SelectedItem = "Grenade Launcher";
                }
                if (Weapon_Set == "Timed Mines")
                {
                    form1.W1_TM.SelectedItem = "PP7";
                    form1.W2_TM.SelectedItem = "PP7";
                    form1.W3_TM.SelectedItem = "ZMG";
                    form1.W4_TM.SelectedItem = "ZMG";
                    form1.W5_TM.SelectedItem = "AR33 Assault Rifle";
                    form1.W6_TM.SelectedItem = "AR33 Assault Rifle";
                    form1.W7_TM.SelectedItem = "Timed Mine";
                    form1.W8_TM.SelectedItem = "Timed Mine";
                }
                if (Weapon_Set == "Proximity Mines")
                {
                    form1.W1_PM.SelectedItem = "PP7";
                    form1.W2_PM.SelectedItem = "PP7";
                    form1.W3_PM.SelectedItem = "ZMG";
                    form1.W4_PM.SelectedItem = "ZMG";
                    form1.W5_PM.SelectedItem = "AR33 Assault Rifle";
                    form1.W6_PM.SelectedItem = "AR33 Assault Rifle";
                    form1.W7_PM.SelectedItem = "Proximity Mine";
                    form1.W8_PM.SelectedItem = "Proximity Mine";
                }
                if (Weapon_Set == "Rockets")
                {
                    form1.W1_Rockets.SelectedItem = "DD4 Dostovei";
                    form1.W2_Rockets.SelectedItem = "DD4 Dostovei";
                    form1.W3_Rockets.SelectedItem = "Klobb";
                    form1.W4_Rockets.SelectedItem = "Klobb";
                    form1.W5_Rockets.SelectedItem = "KF7 Soviet";
                    form1.W6_Rockets.SelectedItem = "KF7 Soviet";
                    form1.W7_Rockets.SelectedItem = "Rocket Launcher";
                    form1.W8_Rockets.SelectedItem = "Rocket Launcher";
                }
                if (Weapon_Set == "Lasers")
                {
                    form1.W1_Lasers.SelectedItem = "DD4 Dostovei";
                    form1.W2_Lasers.SelectedItem = "DD4 Dostovei";
                    form1.W3_Lasers.SelectedItem = "Klobb";
                    form1.W4_Lasers.SelectedItem = "Klobb";
                    form1.W5_Lasers.SelectedItem = "KF7 Soviet";
                    form1.W6_Lasers.SelectedItem = "KF7 Soviet";
                    form1.W7_Lasers.SelectedItem = "Moonraker";
                    form1.W8_Lasers.SelectedItem = "Moonraker";
                }
                if (Weapon_Set == "Golden Gun")
                {
                    form1.W1_GG.SelectedItem = "DD4 Dostovei";
                    form1.W2_GG.SelectedItem = "DD4 Dostovei";
                    form1.W3_GG.SelectedItem = "Klobb";
                    form1.W4_GG.SelectedItem = "Klobb";
                    form1.W5_GG.SelectedItem = "KF7 Soviet";
                    form1.W6_GG.SelectedItem = "KF7 Soviet";
                    form1.W7_GG.SelectedItem = "PP7 Silenced";
                    form1.W8_GG.SelectedItem = "Golden Gun";
                }
                if (Weapon_Set == "Hunting Knives")
                {
                    form1.W1_HK.SelectedItem = "Hunting Knife";
                    form1.W2_HK.SelectedItem = "Hunting Knife";
                    form1.W3_HK.SelectedItem = "Hand Grenade";
                    form1.W4_HK.SelectedItem = "Hand Grenade";
                    form1.W5_HK.SelectedItem = "Hunting Knife";
                    form1.W6_HK.SelectedItem = "Hunting Knife";
                    form1.W7_HK.SelectedItem = "Sniper Rifle";
                    form1.W8_HK.SelectedItem = "Sniper Rifle";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Edit_Xex()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            //Cleanup
            General.Cleanup();

            if (String.IsNullOrEmpty(form1.XexFileName.Text))
            {
                MessageBox.Show("Please Select Xex File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (String.IsNullOrEmpty(form1.TextID_Slappers.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Slappers Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Pistols.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Pistols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_TK.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Throwing Knives!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Automatics.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Automatics!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_PW.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Power Weapons!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Snipers.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Snipers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Grenades.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Grenades!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_RM.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Remote Mines!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_GL.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Grenade Launchers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_TM.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Timed Mines!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_PM.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Proximity Mines!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Rockets.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Rockets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_Lasers.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Lasers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_GG.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Golden Gun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.TextID_HK.Text))
            {
                MessageBox.Show("Please Enter Weapon Set Text ID for Hunting Knives!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.Unique_Name.Text))
            {
                MessageBox.Show("Please Enter Unique Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Write Weapons
                Write_Weapons();

                //Write Unique ID
                Write_Unique_ID();

                //Get Xextool
                Get_Xex_Tool();

                //Sign Xex File
                Sign_Xex();

                General.Cleanup();
                MessageBox.Show("Weapon Sets Updated Successfully!", "Xex File Written", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void Open_Xex()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

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

                    form1.XexFileName.Text = filePath;
                    form1.XexFileName.SelectionStart = form1.XexFileName.Text.Length;
                    form1.XexFileName.ScrollToCaret();
                    form1.XexFileName.Refresh();

                    FileInfo fileInfo = new FileInfo(form1.XexFileName.Text);
                    if (fileInfo.IsReadOnly)
                    {
                        MessageBox.Show("Xex file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form1.XexFileName.Text = "";
                    }
                    else
                    {

                        form1.toolsToolStripMenuItem.Enabled = true;
                        form1.fileToolStripMenuItem.Enabled = true;
                        form1.Unique_Name.Enabled = true;
                        form1.menuStrip1.Enabled = true;
                        form1.btnEdit.Enabled = true;

                        byte[] data = new byte[22];

                        using (FileStream fs = new FileStream(form1.XexFileName.Text, FileMode.Open))
                        {
                            fs.Position = 7452;
                            fs.Read(data, 0, 22);
                            String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));
                            //textBox2.Text = UniqueName;

                            var bytes = new byte[UniqueName.Length / 2];
                            for (var i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                form1.Unique_Name.Text = Encoding.UTF8.GetString(bytes);
                            }
                        }

                        //Get Weapons
                        Get_Weapons();

                        //Get Text IDs
                        Text_ID();
                    }
                }
            }
        }
        public static void Import_Weapons()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //string path = @"C:\";
                //openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //MessageBox.Show(path);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    var doc = XDocument.Load(filePath);
                    var groups = doc.XPathSelectElements("/Weapon_Sets/Weapon_Set");
                    foreach (var group in groups)
                    {
                        string Set_Name = group.Attribute("Name").Value;
                        string Weapon_1 = group.Element("Weapon_1").Value;
                        string Weapon_2 = group.Element("Weapon_2").Value;
                        string Weapon_3 = group.Element("Weapon_3").Value;
                        string Weapon_4 = group.Element("Weapon_4").Value;
                        string Weapon_5 = group.Element("Weapon_5").Value;
                        string Weapon_6 = group.Element("Weapon_6").Value;
                        string Weapon_7 = group.Element("Weapon_7").Value;
                        string Weapon_8 = group.Element("Weapon_8").Value;

                        //Slappers
                        if (Set_Name == "Slappers Only!")
                        {
                            form1.W1_Slappers.SelectedItem = Weapon_1;
                            form1.W2_Slappers.SelectedItem = Weapon_2;
                            form1.W3_Slappers.SelectedItem = Weapon_3;
                            form1.W4_Slappers.SelectedItem = Weapon_4;
                            form1.W5_Slappers.SelectedItem = Weapon_5;
                            form1.W6_Slappers.SelectedItem = Weapon_6;
                            form1.W7_Slappers.SelectedItem = Weapon_7;
                            form1.W8_Slappers.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Pistols")
                        {
                            form1.W1_Pistols.SelectedItem = Weapon_1;
                            form1.W2_Pistols.SelectedItem = Weapon_2;
                            form1.W3_Pistols.SelectedItem = Weapon_3;
                            form1.W4_Pistols.SelectedItem = Weapon_4;
                            form1.W5_Pistols.SelectedItem = Weapon_5;
                            form1.W6_Pistols.SelectedItem = Weapon_6;
                            form1.W7_Pistols.SelectedItem = Weapon_7;
                            form1.W8_Pistols.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Throwing Knives")
                        {
                            form1.W1_TK.SelectedItem = Weapon_1;
                            form1.W2_TK.SelectedItem = Weapon_2;
                            form1.W3_TK.SelectedItem = Weapon_3;
                            form1.W4_TK.SelectedItem = Weapon_4;
                            form1.W5_TK.SelectedItem = Weapon_5;
                            form1.W6_TK.SelectedItem = Weapon_6;
                            form1.W7_TK.SelectedItem = Weapon_7;
                            form1.W8_TK.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Automatics")
                        {
                            form1.W1_Automatics.SelectedItem = Weapon_1;
                            form1.W2_Automatics.SelectedItem = Weapon_2;
                            form1.W3_Automatics.SelectedItem = Weapon_3;
                            form1.W4_Automatics.SelectedItem = Weapon_4;
                            form1.W5_Automatics.SelectedItem = Weapon_5;
                            form1.W6_Automatics.SelectedItem = Weapon_6;
                            form1.W7_Automatics.SelectedItem = Weapon_7;
                            form1.W8_Automatics.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Power Weapons")
                        {
                            form1.W1_PW.SelectedItem = Weapon_1;
                            form1.W2_PW.SelectedItem = Weapon_2;
                            form1.W3_PW.SelectedItem = Weapon_3;
                            form1.W4_PW.SelectedItem = Weapon_4;
                            form1.W5_PW.SelectedItem = Weapon_5;
                            form1.W6_PW.SelectedItem = Weapon_6;
                            form1.W7_PW.SelectedItem = Weapon_7;
                            form1.W8_PW.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Sniper Rifles")
                        {
                            form1.W1_Sniper.SelectedItem = Weapon_1;
                            form1.W2_Sniper.SelectedItem = Weapon_2;
                            form1.W3_Sniper.SelectedItem = Weapon_3;
                            form1.W4_Sniper.SelectedItem = Weapon_4;
                            form1.W5_Sniper.SelectedItem = Weapon_5;
                            form1.W6_Sniper.SelectedItem = Weapon_6;
                            form1.W7_Sniper.SelectedItem = Weapon_7;
                            form1.W8_Sniper.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Grenades")
                        {
                            form1.W1_Grenade.SelectedItem = Weapon_1;
                            form1.W2_Grenade.SelectedItem = Weapon_2;
                            form1.W3_Grenade.SelectedItem = Weapon_3;
                            form1.W4_Grenade.SelectedItem = Weapon_4;
                            form1.W5_Grenade.SelectedItem = Weapon_5;
                            form1.W6_Grenade.SelectedItem = Weapon_6;
                            form1.W7_Grenade.SelectedItem = Weapon_7;
                            form1.W8_Grenade.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Remote Mines")
                        {
                            form1.W1_RM.SelectedItem = Weapon_1;
                            form1.W2_RM.SelectedItem = Weapon_2;
                            form1.W3_RM.SelectedItem = Weapon_3;
                            form1.W4_RM.SelectedItem = Weapon_4;
                            form1.W5_RM.SelectedItem = Weapon_5;
                            form1.W6_RM.SelectedItem = Weapon_6;
                            form1.W7_RM.SelectedItem = Weapon_7;
                            form1.W8_RM.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Grenade Launchers")
                        {
                            form1.W1_GL.SelectedItem = Weapon_1;
                            form1.W2_GL.SelectedItem = Weapon_2;
                            form1.W3_GL.SelectedItem = Weapon_3;
                            form1.W4_GL.SelectedItem = Weapon_4;
                            form1.W5_GL.SelectedItem = Weapon_5;
                            form1.W6_GL.SelectedItem = Weapon_6;
                            form1.W7_GL.SelectedItem = Weapon_7;
                            form1.W8_GL.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Timed Mines")
                        {
                            form1.W1_TM.SelectedItem = Weapon_1;
                            form1.W2_TM.SelectedItem = Weapon_2;
                            form1.W3_TM.SelectedItem = Weapon_3;
                            form1.W4_TM.SelectedItem = Weapon_4;
                            form1.W5_TM.SelectedItem = Weapon_5;
                            form1.W6_TM.SelectedItem = Weapon_6;
                            form1.W7_TM.SelectedItem = Weapon_7;
                            form1.W8_TM.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Proximity Mines")
                        {
                            form1.W1_PM.SelectedItem = Weapon_1;
                            form1.W2_PM.SelectedItem = Weapon_2;
                            form1.W3_PM.SelectedItem = Weapon_3;
                            form1.W4_PM.SelectedItem = Weapon_4;
                            form1.W5_PM.SelectedItem = Weapon_5;
                            form1.W6_PM.SelectedItem = Weapon_6;
                            form1.W7_PM.SelectedItem = Weapon_7;
                            form1.W8_PM.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Rockets")
                        {
                            form1.W1_Rockets.SelectedItem = Weapon_1;
                            form1.W2_Rockets.SelectedItem = Weapon_2;
                            form1.W3_Rockets.SelectedItem = Weapon_3;
                            form1.W4_Rockets.SelectedItem = Weapon_4;
                            form1.W5_Rockets.SelectedItem = Weapon_5;
                            form1.W6_Rockets.SelectedItem = Weapon_6;
                            form1.W7_Rockets.SelectedItem = Weapon_7;
                            form1.W8_Rockets.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Lasers")
                        {
                            form1.W1_Lasers.SelectedItem = Weapon_1;
                            form1.W2_Lasers.SelectedItem = Weapon_2;
                            form1.W3_Lasers.SelectedItem = Weapon_3;
                            form1.W4_Lasers.SelectedItem = Weapon_4;
                            form1.W5_Lasers.SelectedItem = Weapon_5;
                            form1.W6_Lasers.SelectedItem = Weapon_6;
                            form1.W7_Lasers.SelectedItem = Weapon_7;
                            form1.W8_Lasers.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Golden Gun")
                        {
                            form1.W1_GG.SelectedItem = Weapon_1;
                            form1.W2_GG.SelectedItem = Weapon_2;
                            form1.W3_GG.SelectedItem = Weapon_3;
                            form1.W4_GG.SelectedItem = Weapon_4;
                            form1.W5_GG.SelectedItem = Weapon_5;
                            form1.W6_GG.SelectedItem = Weapon_6;
                            form1.W7_GG.SelectedItem = Weapon_7;
                            form1.W8_GG.SelectedItem = Weapon_8;
                        }
                        if (Set_Name == "Hunting Knives")
                        {
                            form1.W1_HK.SelectedItem = Weapon_1;
                            form1.W2_HK.SelectedItem = Weapon_2;
                            form1.W3_HK.SelectedItem = Weapon_3;
                            form1.W4_HK.SelectedItem = Weapon_4;
                            form1.W5_HK.SelectedItem = Weapon_5;
                            form1.W6_HK.SelectedItem = Weapon_6;
                            form1.W7_HK.SelectedItem = Weapon_7;
                            form1.W8_HK.SelectedItem = Weapon_8;
                        }
                    }

                }
            }

        }
        public static void Export_Weapons()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                //string path = @"C:\";
                //openFileDialog.InitialDirectory = path;
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                //MessageBox.Show(path);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;


                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
                    {
                        Indent = true,
                        IndentChars = "\t",
                        NewLineOnAttributes = true

                    };

                    using (XmlWriter w = XmlWriter.Create(filePath, xmlWriterSettings))
                    {
                        w.WriteStartDocument();
                        w.WriteStartElement("Weapon_Sets");

                        //Slappers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Slappers Only!");
                        w.WriteElementString("Weapon_1", form1.W1_Slappers.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Slappers.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Slappers.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Slappers.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Slappers.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Slappers.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Slappers.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Slappers.Text);
                        w.WriteEndElement();

                        //Pistols
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Pistols");
                        w.WriteElementString("Weapon_1", form1.W1_Pistols.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Pistols.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Pistols.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Pistols.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Pistols.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Pistols.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Pistols.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Pistols.Text);
                        w.WriteEndElement();


                        //Throwing Knives
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Throwing Knives");
                        w.WriteElementString("Weapon_1", form1.W1_TK.Text);
                        w.WriteElementString("Weapon_2", form1.W2_TK.Text);
                        w.WriteElementString("Weapon_3", form1.W3_TK.Text);
                        w.WriteElementString("Weapon_4", form1.W4_TK.Text);
                        w.WriteElementString("Weapon_5", form1.W5_TK.Text);
                        w.WriteElementString("Weapon_6", form1.W6_TK.Text);
                        w.WriteElementString("Weapon_7", form1.W7_TK.Text);
                        w.WriteElementString("Weapon_8", form1.W8_TK.Text);
                        w.WriteEndElement();

                        //Automatics
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Automatics");
                        w.WriteElementString("Weapon_1", form1.W1_Automatics.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Automatics.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Automatics.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Automatics.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Automatics.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Automatics.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Automatics.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Automatics.Text);
                        w.WriteEndElement();

                        //Power Weapons
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Power Weapons");
                        w.WriteElementString("Weapon_1", form1.W1_PW.Text);
                        w.WriteElementString("Weapon_2", form1.W2_PW.Text);
                        w.WriteElementString("Weapon_3", form1.W3_PW.Text);
                        w.WriteElementString("Weapon_4", form1.W4_PW.Text);
                        w.WriteElementString("Weapon_5", form1.W5_PW.Text);
                        w.WriteElementString("Weapon_6", form1.W6_PW.Text);
                        w.WriteElementString("Weapon_7", form1.W7_PW.Text);
                        w.WriteElementString("Weapon_8", form1.W8_PW.Text);
                        w.WriteEndElement();

                        //Snipers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Sniper Rifles");
                        w.WriteElementString("Weapon_1", form1.W1_Sniper.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Sniper.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Sniper.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Sniper.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Sniper.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Sniper.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Sniper.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Sniper.Text);
                        w.WriteEndElement();

                        //Grenades
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Grenades");
                        w.WriteElementString("Weapon_1", form1.W1_Grenade.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Grenade.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Grenade.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Grenade.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Grenade.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Grenade.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Grenade.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Grenade.Text);
                        w.WriteEndElement();

                        //Remote Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Remote Mines");
                        w.WriteElementString("Weapon_1", form1.W1_RM.Text);
                        w.WriteElementString("Weapon_2", form1.W2_RM.Text);
                        w.WriteElementString("Weapon_3", form1.W3_RM.Text);
                        w.WriteElementString("Weapon_4", form1.W4_RM.Text);
                        w.WriteElementString("Weapon_5", form1.W5_RM.Text);
                        w.WriteElementString("Weapon_6", form1.W6_RM.Text);
                        w.WriteElementString("Weapon_7", form1.W7_RM.Text);
                        w.WriteElementString("Weapon_8", form1.W8_RM.Text);
                        w.WriteEndElement();

                        //Grenade Launchers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Grenade Launchers");
                        w.WriteElementString("Weapon_1", form1.W1_GL.Text);
                        w.WriteElementString("Weapon_2", form1.W2_GL.Text);
                        w.WriteElementString("Weapon_3", form1.W3_GL.Text);
                        w.WriteElementString("Weapon_4", form1.W4_GL.Text);
                        w.WriteElementString("Weapon_5", form1.W5_GL.Text);
                        w.WriteElementString("Weapon_6", form1.W6_GL.Text);
                        w.WriteElementString("Weapon_7", form1.W7_GL.Text);
                        w.WriteElementString("Weapon_8", form1.W8_GL.Text);
                        w.WriteEndElement();

                        //Timed Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Timed Mines");
                        w.WriteElementString("Weapon_1", form1.W1_TM.Text);
                        w.WriteElementString("Weapon_2", form1.W2_TM.Text);
                        w.WriteElementString("Weapon_3", form1.W3_TM.Text);
                        w.WriteElementString("Weapon_4", form1.W4_TM.Text);
                        w.WriteElementString("Weapon_5", form1.W5_TM.Text);
                        w.WriteElementString("Weapon_6", form1.W6_TM.Text);
                        w.WriteElementString("Weapon_7", form1.W7_TM.Text);
                        w.WriteElementString("Weapon_8", form1.W8_TM.Text);
                        w.WriteEndElement();

                        //Proximity Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Proximity Mines");
                        w.WriteElementString("Weapon_1", form1.W1_PM.Text);
                        w.WriteElementString("Weapon_2", form1.W2_PM.Text);
                        w.WriteElementString("Weapon_3", form1.W3_PM.Text);
                        w.WriteElementString("Weapon_4", form1.W4_PM.Text);
                        w.WriteElementString("Weapon_5", form1.W5_PM.Text);
                        w.WriteElementString("Weapon_6", form1.W6_PM.Text);
                        w.WriteElementString("Weapon_7", form1.W7_PM.Text);
                        w.WriteElementString("Weapon_8", form1.W8_PM.Text);
                        w.WriteEndElement();

                        //Rockets
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Rockets");
                        w.WriteElementString("Weapon_1", form1.W1_Rockets.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Rockets.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Rockets.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Rockets.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Rockets.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Rockets.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Rockets.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Rockets.Text);
                        w.WriteEndElement();

                        //Lasers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Lasers");
                        w.WriteElementString("Weapon_1", form1.W1_Lasers.Text);
                        w.WriteElementString("Weapon_2", form1.W2_Lasers.Text);
                        w.WriteElementString("Weapon_3", form1.W3_Lasers.Text);
                        w.WriteElementString("Weapon_4", form1.W4_Lasers.Text);
                        w.WriteElementString("Weapon_5", form1.W5_Lasers.Text);
                        w.WriteElementString("Weapon_6", form1.W6_Lasers.Text);
                        w.WriteElementString("Weapon_7", form1.W7_Lasers.Text);
                        w.WriteElementString("Weapon_8", form1.W8_Lasers.Text);
                        w.WriteEndElement();

                        //Golden Gun
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Golden Gun");
                        w.WriteElementString("Weapon_1", form1.W1_GG.Text);
                        w.WriteElementString("Weapon_2", form1.W2_GG.Text);
                        w.WriteElementString("Weapon_3", form1.W3_GG.Text);
                        w.WriteElementString("Weapon_4", form1.W4_GG.Text);
                        w.WriteElementString("Weapon_5", form1.W5_GG.Text);
                        w.WriteElementString("Weapon_6", form1.W6_GG.Text);
                        w.WriteElementString("Weapon_7", form1.W7_GG.Text);
                        w.WriteElementString("Weapon_8", form1.W8_GG.Text);
                        w.WriteEndElement();

                        //Hunting Knives
                        //Golden Gun
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Hunting Knives");
                        w.WriteElementString("Weapon_1", form1.W1_HK.Text);
                        w.WriteElementString("Weapon_2", form1.W2_HK.Text);
                        w.WriteElementString("Weapon_3", form1.W3_HK.Text);
                        w.WriteElementString("Weapon_4", form1.W4_HK.Text);
                        w.WriteElementString("Weapon_5", form1.W5_HK.Text);
                        w.WriteElementString("Weapon_6", form1.W6_HK.Text);
                        w.WriteElementString("Weapon_7", form1.W7_HK.Text);
                        w.WriteElementString("Weapon_8", form1.W8_HK.Text);
                        w.WriteEndElement();

                        w.WriteEndElement();
                        w.WriteEndDocument();
                        w.Flush();
                        w.Close();
                    }
                }
            }
        }
        public static void Sign_Xex()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            string Xextool = @"C:\RetroDriven_Temp\xextool.exe";
            string XexTool = $"/C {Xextool} -md \"{form1.XexFileName.Text}\"";
            System.Diagnostics.Process SignXex = new System.Diagnostics.Process();
            SignXex.StartInfo.FileName = "cmd.exe";
            SignXex.StartInfo.Arguments = XexTool;
            SignXex.Start();
            SignXex.WaitForExit();
        }
        public static void Get_Xex_Tool()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            Directory.CreateDirectory(@"C:\RetroDriven_Temp");
            string Xextool = @"C:\RetroDriven_Temp\xextool.exe";
            object ob2 =Resource1.ResourceManager.GetObject("xextool", form1.resourceCulture);
            byte[] myResBytes2 = (byte[])ob2;
            using (FileStream fsDst2 = new FileStream(Xextool, FileMode.CreateNew))
            {
                byte[] bytes2 = myResBytes2;
                fsDst2.Write(bytes2, 0, bytes2.Length);
                fsDst2.Close();
                fsDst2.Dispose();
            }
        }
        public static void Write_Unique_ID()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            using (BinaryWriter writer = new BinaryWriter(File.Open(form1.XexFileName.Text, FileMode.Open, FileAccess.ReadWrite)))
            {
                int offset2 = 7452; //position you want to start editing
                string trimmed = String.Concat(form1.Unique_Name.Text.Where(c => !Char.IsWhiteSpace(c)));
                byte[] new_data = Encoding.ASCII.GetBytes(trimmed);
                byte[] new_data2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //new data
                writer.Seek(offset2, SeekOrigin.Begin); //move your cursor to the position
                writer.Write(new_data2);
                writer.Seek(offset2, SeekOrigin.Begin);
                writer.Write(new_data);//write it
            }
        }
        public static void Text_ID()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            form1.TextID_Slappers.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Slappers", 0x417AF4);
            form1.TextID_Slappers_Offset.Enabled = true;
            form1.TextID_Slappers_Offset.Text = "417AF4";

            form1.TextID_Pistols.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Pistols", 0x417B00);
            form1.TextID_Pistols_Offset.Enabled = true;
            form1.TextID_Pistols_Offset.Text = "417B00";

            form1.TextID_TK.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Throwing Knives", 0x417B0C);
            form1.TextID_TK_Offset.Enabled = true;
            form1.TextID_TK_Offset.Text = "417B0C";

            form1.TextID_Automatics.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Automatics", 0x417B18);
            form1.TextID_Automatics_Offset.Enabled = true;
            form1.TextID_Automatics_Offset.Text = "417B18";

            form1.TextID_PW.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Power Weapons", 0x417B24);
            form1.TextID_PW_Offset.Enabled = true;
            form1.TextID_PW_Offset.Text = "417B24";

            form1.TextID_Snipers.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Snipers", 0x417B30);
            form1.TextID_Snipers_Offset.Enabled = true;
            form1.TextID_Snipers_Offset.Text = "417B30";

            form1.TextID_Grenades.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Grenades", 0x417B3C);
            form1.TextID_Grenades_Offset.Enabled = true;
            form1.TextID_Grenades_Offset.Text = "417B3C";

            form1.TextID_RM.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Remote Mines", 0x417B48);
            form1.TextID_RM_Offset.Enabled = true;
            form1.TextID_RM_Offset.Text = "417B48";

            form1.TextID_GL.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Grenade Launchers", 0x417B54);
            form1.TextID_GL_Offset.Enabled = true;
            form1.TextID_GL_Offset.Text = "417B54";

            form1.TextID_TM.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Timed Mines", 0x417B60);
            form1.TextID_TM_Offset.Enabled = true;
            form1.TextID_TM_Offset.Text = "417B60";

            form1.TextID_PM.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Proximity Mines", 0x417B6C);
            form1.TextID_PM_Offset.Enabled = true;
            form1.TextID_PM_Offset.Text = "417B6C";

            form1.TextID_Rockets.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Rockets", 0x417B78);
            form1.TextID_Rockets_Offset.Enabled = true;
            form1.TextID_Rockets_Offset.Text = "417B78";

            form1.TextID_Lasers.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Lasers", 0x417B84);
            form1.TextID_Lasers_Offset.Enabled = true;
            form1.TextID_Lasers_Offset.Text = "417B84";

            form1.TextID_GG.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Golden Gun", 0x417B90);
            form1.TextID_GG_Offset.Enabled = true;
            form1.TextID_GG_Offset.Text = "417B90";

            form1.TextID_HK.Enabled = true;
            GetTextID(form1.XexFileName.Text, "Hunting Knives", 0x417B9C);
            form1.TextID_HK_Offset.Enabled = true;
            form1.TextID_HK_Offset.Text = "417B9C";
        }
        public static void GetTextID(string Xex, string WeaponSet, int TextIDOffset)
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            BinaryReader reader = new BinaryReader(new FileStream(Xex, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = TextIDOffset; // The offset you are reading the data from
            byte[] data = reader.ReadBytes(0x2); // Read 2 bytes into an array
            string TextID = BitConverter.ToString(data);
            TextID = TextID.Replace("-", ""); //Remove "-" between the bytes

            if (WeaponSet == "Slappers")
            {
                form1.TextID_Slappers.Text = TextID;
            }
            else if (WeaponSet == "Pistols")
            {
                form1.TextID_Pistols.Text = TextID;
            }
            else if (WeaponSet == "Throwing Knives")
            {
                form1.TextID_TK.Text = TextID;
            }
            else if (WeaponSet == "Automatics")
            {
                form1.TextID_Automatics.Text = TextID;
            }
            else if (WeaponSet == "Power Weapons")
            {
                form1.TextID_PW.Text = TextID;
            }
            else if (WeaponSet == "Snipers")
            {
                form1.TextID_Snipers.Text = TextID;
            }
            else if (WeaponSet == "Grenades")
            {
                form1.TextID_Grenades.Text = TextID;
            }
            else if (WeaponSet == "Remote Mines")
            {
                form1.TextID_RM.Text = TextID;
            }
            else if (WeaponSet == "Grenade Launchers")
            {
                form1.TextID_GL.Text = TextID;
            }
            else if (WeaponSet == "Timed Mines")
            {
                form1.TextID_TM.Text = TextID;
            }
            else if (WeaponSet == "Proximity Mines")
            {
                form1.TextID_PM.Text = TextID;
            }
            else if (WeaponSet == "Rockets")
            {
                form1.TextID_Rockets.Text = TextID;
            }
            else if (WeaponSet == "Lasers")
            {
                form1.TextID_Lasers.Text = TextID;
            }
            else if (WeaponSet == "Golden Gun")
            {
                form1.TextID_GG.Text = TextID;
            }
            else if (WeaponSet == "Hunting Knives")
            {
                form1.TextID_HK.Text = TextID;
            }

            reader.Close();
        }

        public static void Reset_Weapons()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            //Slappers
            form1.W1_Slappers.SelectedItem = "Slapper";
            form1.W1_Slappers.SelectedItem = "Slapper";
            form1.W2_Slappers.SelectedItem = "Slapper";
            form1.W3_Slappers.SelectedItem = "Slapper";
            form1.W4_Slappers.SelectedItem = "Slapper";
            form1.W5_Slappers.SelectedItem = "Slapper";
            form1.W6_Slappers.SelectedItem = "Slapper";
            form1.W7_Slappers.SelectedItem = "Slapper";
            form1.W8_Slappers.SelectedItem = "Slapper";

            //Pistols
            form1.W1_Pistols.SelectedItem = "DD4 Dostovei";
            form1.W2_Pistols.SelectedItem = "DD4 Dostovei";
            form1.W3_Pistols.SelectedItem = "DD4 Dostovei";
            form1.W4_Pistols.SelectedItem = "PP7 Silenced";
            form1.W5_Pistols.SelectedItem = "PP7 Silenced";
            form1.W6_Pistols.SelectedItem = "PP7 Silenced";
            form1.W7_Pistols.SelectedItem = "Cougar Magnum";
            form1.W8_Pistols.SelectedItem = "Cougar Magnum";

            //Throwing Knives
            form1.W1_TK.SelectedItem = "Throwing Knife";
            form1.W2_TK.SelectedItem = "Throwing Knife";
            form1.W3_TK.SelectedItem = "Throwing Knife";
            form1.W4_TK.SelectedItem = "Throwing Knife";
            form1.W5_TK.SelectedItem = "Throwing Knife";
            form1.W6_TK.SelectedItem = "Throwing Knife";
            form1.W7_TK.SelectedItem = "Throwing Knife";
            form1.W8_TK.SelectedItem = "Throwing Knife";

            //Automatics
            form1.W1_Automatics.SelectedItem = "PP7 Silenced";
            form1.W2_Automatics.SelectedItem = "PP7 Silenced";
            form1.W3_Automatics.SelectedItem = "DD4 Dostovei";
            form1.W4_Automatics.SelectedItem = "DD4 Dostovei";
            form1.W5_Automatics.SelectedItem = "Klobb";
            form1.W6_Automatics.SelectedItem = "Klobb";
            form1.W7_Automatics.SelectedItem = "D5K Deutsche";
            form1.W8_Automatics.SelectedItem = "D5K Deutsche";

            //Power Weapons
            form1.W1_PW.SelectedItem = "DD4 Dostovei";
            form1.W2_PW.SelectedItem = "DD4 Dostovei";
            form1.W3_PW.SelectedItem = "Cougar Magnum";
            form1.W4_PW.SelectedItem = "Cougar Magnum";
            form1.W5_PW.SelectedItem = "RC-P90";
            form1.W6_PW.SelectedItem = "RC-P90";
            form1.W7_PW.SelectedItem = "Automatic Shotgun";
            form1.W8_PW.SelectedItem = "Automatic Shotgun";

            //Sniper Rifles
            form1.W1_Sniper.SelectedItem = "DD4 Dostovei";
            form1.W2_Sniper.SelectedItem = "DD4 Dostovei";
            form1.W3_Sniper.SelectedItem = "Cougar Magnum";
            form1.W4_Sniper.SelectedItem = "Cougar Magnum";
            form1.W5_Sniper.SelectedItem = "Klobb";
            form1.W6_Sniper.SelectedItem = "Klobb";
            form1.W7_Sniper.SelectedItem = "Sniper Rifle";
            form1.W8_Sniper.SelectedItem = "Sniper Rifle";

            //Grenades
            form1.W1_Grenade.SelectedItem = "DD4 Dostovei";
            form1.W2_Grenade.SelectedItem = "DD4 Dostovei";
            form1.W3_Grenade.SelectedItem = "Klobb";
            form1.W4_Grenade.SelectedItem = "Klobb";
            form1.W5_Grenade.SelectedItem = "KF7 Soviet";
            form1.W6_Grenade.SelectedItem = "KF7 Soviet";
            form1.W7_Grenade.SelectedItem = "Hand Grenade";
            form1.W8_Grenade.SelectedItem = "Hand Grenade";

            //Remote Mines
            form1.W1_RM.SelectedItem = "PP7";
            form1.W2_RM.SelectedItem = "PP7";
            form1.W3_RM.SelectedItem = "ZMG";
            form1.W4_RM.SelectedItem = "ZMG";
            form1.W5_RM.SelectedItem = "AR33 Assault Rifle";
            form1.W6_RM.SelectedItem = "AR33 Assault Rifle";
            form1.W7_RM.SelectedItem = "Remote Mine";
            form1.W8_RM.SelectedItem = "Remote Mine";

            //Grenade Launchers
            form1.W1_GL.SelectedItem = "DD4 Dostovei";
            form1.W2_GL.SelectedItem = "DD4 Dostovei";
            form1.W3_GL.SelectedItem = "Klobb";
            form1.W4_GL.SelectedItem = "Klobb";
            form1.W5_GL.SelectedItem = "KF7 Soviet";
            form1.W6_GL.SelectedItem = "KF7 Soviet";
            form1.W7_GL.SelectedItem = "Grenade Launcher";
            form1.W8_GL.SelectedItem = "Grenade Launcher";

            //Timed Mines
            form1.W1_TM.SelectedItem = "PP7";
            form1.W2_TM.SelectedItem = "PP7";
            form1.W3_TM.SelectedItem = "ZMG";
            form1.W4_TM.SelectedItem = "ZMG";
            form1.W5_TM.SelectedItem = "AR33 Assault Rifle";
            form1.W6_TM.SelectedItem = "AR33 Assault Rifle";
            form1.W7_TM.SelectedItem = "Timed Mine";
            form1.W8_TM.SelectedItem = "Timed Mine";

            //Proximity Mines
            form1.W1_PM.SelectedItem = "PP7";
            form1.W2_PM.SelectedItem = "PP7";
            form1.W3_PM.SelectedItem = "ZMG";
            form1.W4_PM.SelectedItem = "ZMG";
            form1.W5_PM.SelectedItem = "AR33 Assault Rifle";
            form1.W6_PM.SelectedItem = "AR33 Assault Rifle";
            form1.W7_PM.SelectedItem = "Proximity Mine";
            form1.W8_PM.SelectedItem = "Proximity Mine";

            //Rockets
            form1.W1_Rockets.SelectedItem = "DD4 Dostovei";
            form1.W2_Rockets.SelectedItem = "DD4 Dostovei";
            form1.W3_Rockets.SelectedItem = "Klobb";
            form1.W4_Rockets.SelectedItem = "Klobb";
            form1.W5_Rockets.SelectedItem = "KF7 Soviet";
            form1.W6_Rockets.SelectedItem = "KF7 Soviet";
            form1.W7_Rockets.SelectedItem = "Rocket Launcher";
            form1.W8_Rockets.SelectedItem = "Rocket Launcher";

            //Lasers
            form1.W1_Lasers.SelectedItem = "DD4 Dostovei";
            form1.W2_Lasers.SelectedItem = "DD4 Dostovei";
            form1.W3_Lasers.SelectedItem = "Klobb";
            form1.W4_Lasers.SelectedItem = "Klobb";
            form1.W5_Lasers.SelectedItem = "KF7 Soviet";
            form1.W6_Lasers.SelectedItem = "KF7 Soviet";
            form1.W7_Lasers.SelectedItem = "Moonraker";
            form1.W8_Lasers.SelectedItem = "Moonraker";

            //Golden Gun
            form1.W1_GG.SelectedItem = "DD4 Dostovei";
            form1.W2_GG.SelectedItem = "DD4 Dostovei";
            form1.W3_GG.SelectedItem = "Klobb";
            form1.W4_GG.SelectedItem = "Klobb";
            form1.W5_GG.SelectedItem = "KF7 Soviet";
            form1.W6_GG.SelectedItem = "KF7 Soviet";
            form1.W7_GG.SelectedItem = "PP7 Silenced";
            form1.W8_GG.SelectedItem = "Golden Gun";

            //Hunting Knives
            form1.W1_HK.SelectedItem = "Hunting Knife";
            form1.W2_HK.SelectedItem = "Hunting Knife";
            form1.W3_HK.SelectedItem = "Hand Grenade";
            form1.W4_HK.SelectedItem = "Hand Grenade";
            form1.W5_HK.SelectedItem = "Hunting Knife";
            form1.W6_HK.SelectedItem = "Hunting Knife";
            form1.W7_HK.SelectedItem = "Sniper Rifle";
            form1.W8_HK.SelectedItem = "Sniper Rifle";

        }
        public static void Get_Weapons()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            //Get Slappers
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417728, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417730, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417738, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417740, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417748, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417750, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417758, "_Slappers");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417760, "_Slappers");


            //Get Pistols
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417768, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417770, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417778, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417780, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417788, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417790, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417798, "_Pistols");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4177A0, "_Pistols");

            //Get Throwing Knives
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4177A8, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4177B0, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4177B8, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x4177C0, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x4177C8, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x4177D0, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x4177D8, "_TK");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4177E0, "_TK");

            //Get Automatics
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4177E8, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4177F0, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4177F8, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417800, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417808, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417810, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417818, "_Automatics");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417820, "_Automatics");

            //Get Power Weapons
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417828, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417830, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417838, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417840, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417848, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417850, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417858, "_PW");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417860, "_PW");

            //Get Snipers
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417868, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417870, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417878, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417880, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417888, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417890, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417898, "_Sniper");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4178A0, "_Sniper");

            //Get Grenades
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4178A8, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4178B0, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4178B8, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x4178C0, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x4178C8, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x4178D0, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x4178D8, "_Grenade");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4178E0, "_Grenade");

            //Get Remote Mines
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4178E8, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4178F0, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4178F8, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417900, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417908, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417910, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417918, "_RM");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417920, "_RM");

            //Get Grenade Launcher
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417928, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417930, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417938, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417940, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417948, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417950, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417958, "_GL");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417960, "_GL");

            //Get Timed Mines
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417968, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417970, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417978, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417980, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417988, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417990, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417998, "_TM");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4179A0, "_TM");

            //Get Proximity Mines
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4179A8, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4179B0, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4179B8, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x4179C0, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x4179C8, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x4179D0, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x4179D8, "_PM");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x4179E0, "_PM");

            //Get Rockets
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x4179E8, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x4179F0, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x4179F8, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417A00, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417A08, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417A10, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417A18, "_Rockets");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417A20, "_Rockets");

            //Get Lasers
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417A28, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417A30, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417A38, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417A40, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417A48, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417A50, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417A58, "_Lasers");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417A60, "_Lasers");

            //Get Golden Gun
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417A68, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417A70, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417A78, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417A80, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417A88, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417A90, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417A98, "_GG");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417AA0, "_GG");

            //Get Hunting Knives
            Get_Weapons_Populate(form1.XexFileName.Text, "1", 0x417AA8, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "2", 0x417AB0, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "3", 0x417AB8, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "4", 0x417AC0, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "5", 0x417AC8, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "6", 0x417AD0, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "7", 0x417AD8, "_HK");
            Get_Weapons_Populate(form1.XexFileName.Text, "8", 0x417AE0, "_HK");
        }
        public static void Get_Weapons_Populate(string Xex, string WeaponSlot, int WeaponOffset, string ComboName)
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

            BinaryReader reader = new BinaryReader(new FileStream(Xex, FileMode.Open, FileAccess.Read, FileShare.None));
                reader.BaseStream.Position = WeaponOffset;     // The offset you are reading the data from
                byte[] data = reader.ReadBytes(0x1); // Read 16 bytes into an array
                string WeaponID = BitConverter.ToString(data);

                for (int i = 1; i <= 8; i++)
                {

                    ComboBox cb1 = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                    if (cb1 != null)
                    {
                        cb1.Enabled = true;
                    }
                }

                if (WeaponID == "00")
                {
                    String WeaponName = "Slapper";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "02")
                {
                    String WeaponName = "Hunting Knife";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "03")
                {

                    String WeaponName = "Throwing Knife";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "04")
                {

                    String WeaponName = "PP7";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "05")
                {
                    String WeaponName = "PP7 Silenced";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "06")
                {
                    String WeaponName = "DD4 Dostovei";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "07")
                {
                    String WeaponName = "Klobb";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "08")
                {
                    String WeaponName = "KF7 Soviet";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "09")
                {
                    String WeaponName = "ZMG";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "0A")
                {
                    String WeaponName = "D5K Deutsche";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "0B")
                {
                    String WeaponName = "D5K Silenced";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }

                }

                if (WeaponID == "0C")
                {
                    String WeaponName = "Phantom";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "0D")
                {
                    String WeaponName = "AR33 Assault Rifle";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "0E")
                {
                    String WeaponName = "RC-P90";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "0F")
                {
                    String WeaponName = "Shotgun";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "10")
                {
                    String WeaponName = "Automatic Shotgun";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "11")
                {
                    String WeaponName = "Sniper Rifle";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "12")
                {
                    String WeaponName = "Cougar Magnum";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "13")
                {
                    String WeaponName = "Golden Gun";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "14")
                {
                    String WeaponName = "Silver PP7";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "15")
                {
                    String WeaponName = "Gold PP7";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "16")
                {
                    String WeaponName = "Moonraker";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "18")
                {
                    String WeaponName = "Grenade Launcher";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "19")
                {
                    String WeaponName = "Rocket Launcher";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "1A")
                {
                    String WeaponName = "Hand Grenade";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "1B")
                {
                    String WeaponName = "Timed Mine";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "1C")
                {
                    String WeaponName = "Proximity Mine";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                if (WeaponID == "1D")
                {
                    String WeaponName = "Remote Mine";

                    for (int i = 1; i <= 8; i++)
                    {
                        string number = i.ToString();
                        if (WeaponSlot == number)
                        {
                            ComboBox cb = form1.Controls.Find("W" + i + ComboName, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                cb.SelectedItem = WeaponName;
                            }
                        }
                    }
                }

                reader.Close();
        }
        public static void Write_Weapons()
        {
            Form_WS_Editor form1 = (Form_WS_Editor)Application.OpenForms["Form_WS_Editor"];

                //Slappers
                Write_TextID(form1.XexFileName.Text, 0x417AF4, form1.TextID_Slappers.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417728, form1.W1_Slappers.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417730, form1.W2_Slappers.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417738, form1.W3_Slappers.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417740, form1.W4_Slappers.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417748, form1.W5_Slappers.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417750, form1.W6_Slappers.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417758, form1.W7_Slappers.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417760, form1.W8_Slappers.Text);

                //Pistols
                Write_TextID(form1.XexFileName.Text, 0x417B00, form1.TextID_Pistols.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417768, form1.W1_Pistols.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417770, form1.W2_Pistols.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417778, form1.W3_Pistols.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417780, form1.W4_Pistols.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417788, form1.W5_Pistols.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417790, form1.W6_Pistols.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417798, form1.W7_Pistols.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4177A0, form1.W8_Pistols.Text);

                //Throwing Knives
                Write_TextID(form1.XexFileName.Text, 0x417B0C, form1.TextID_TK.Text);
                Write_W(form1.XexFileName.Text, "1", 0x4177A8, form1.W1_TK.Text);
                Write_W(form1.XexFileName.Text, "2", 0x4177B0, form1.W2_TK.Text);
                Write_W(form1.XexFileName.Text, "3", 0x4177B8, form1.W3_TK.Text);
                Write_W(form1.XexFileName.Text, "4", 0x4177C0, form1.W4_TK.Text);
                Write_W(form1.XexFileName.Text, "5", 0x4177C8, form1.W5_TK.Text);
                Write_W(form1.XexFileName.Text, "6", 0x4177D0, form1.W6_TK.Text);
                Write_W(form1.XexFileName.Text, "7", 0x4177D8, form1.W7_TK.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4177E0, form1.W8_TK.Text);

                //Automatics
                Write_TextID(form1.XexFileName.Text, 0x417B18, form1.TextID_Automatics.Text);
                Write_W(form1.XexFileName.Text, "1", 0x4177E8, form1.W1_Automatics.Text);
                Write_W(form1.XexFileName.Text, "2", 0x4177F0, form1.W2_Automatics.Text);
                Write_W(form1.XexFileName.Text, "3", 0x4177F8, form1.W3_Automatics.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417800, form1.W4_Automatics.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417808, form1.W5_Automatics.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417810, form1.W6_Automatics.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417818, form1.W7_Automatics.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417820, form1.W8_Automatics.Text);

                //Power Weapons
                Write_TextID(form1.XexFileName.Text, 0x417B24, form1.TextID_PW.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417828, form1.W1_PW.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417830, form1.W2_PW.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417838, form1.W3_PW.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417840, form1.W4_PW.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417848, form1.W5_PW.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417850, form1.W6_PW.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417858, form1.W7_PW.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417860, form1.W8_PW.Text);

                //Snipers
                Write_TextID(form1.XexFileName.Text, 0x417B30, form1.TextID_Snipers.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417868, form1.W1_Sniper.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417870, form1.W2_Sniper.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417878, form1.W3_Sniper.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417880, form1.W4_Sniper.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417888, form1.W5_Sniper.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417890, form1.W6_Sniper.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417898, form1.W7_Sniper.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4178A0, form1.W8_Sniper.Text);

                //Grenades
                Write_TextID(form1.XexFileName.Text, 0x417B3C, form1.TextID_Grenades.Text);
                Write_W(form1.XexFileName.Text, "1", 0x4178A8, form1.W1_Grenade.Text);
                Write_W(form1.XexFileName.Text, "2", 0x4178B0, form1.W2_Grenade.Text);
                Write_W(form1.XexFileName.Text, "3", 0x4178B8, form1.W3_Grenade.Text);
                Write_W(form1.XexFileName.Text, "4", 0x4178C0, form1.W4_Grenade.Text);
                Write_W(form1.XexFileName.Text, "5", 0x4178C8, form1.W5_Grenade.Text);
                Write_W(form1.XexFileName.Text, "6", 0x4178D0, form1.W6_Grenade.Text);
                Write_W(form1.XexFileName.Text, "7", 0x4178D8, form1.W7_Grenade.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4178E0, form1.W8_Grenade.Text);

                //Write Grenade Launchers
                Write_TextID(form1.XexFileName.Text, 0x417B54, form1.TextID_GL.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417928, form1.W1_GL.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417930, form1.W2_GL.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417938, form1.W3_GL.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417940, form1.W4_GL.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417948, form1.W5_GL.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417950, form1.W6_GL.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417958, form1.W7_GL.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417960, form1.W8_GL.Text);

                //Write Timed Mines
                Write_TextID(form1.XexFileName.Text, 0x417B60, form1.TextID_TM.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417968, form1.W1_TM.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417970, form1.W2_TM.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417978, form1.W3_TM.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417980, form1.W4_TM.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417988, form1.W5_TM.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417990, form1.W6_TM.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417998, form1.W7_TM.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4179A0, form1.W8_TM.Text);

                //Write Proximity Mines
                Write_TextID(form1.XexFileName.Text, 0x417B6C, form1.TextID_PM.Text);
                Write_W(form1.XexFileName.Text, "1", 0x4179A8, form1.W1_PM.Text);
                Write_W(form1.XexFileName.Text, "2", 0x4179B0, form1.W2_PM.Text);
                Write_W(form1.XexFileName.Text, "3", 0x4179B8, form1.W3_PM.Text);
                Write_W(form1.XexFileName.Text, "4", 0x4179C0, form1.W4_PM.Text);
                Write_W(form1.XexFileName.Text, "5", 0x4179C8, form1.W5_PM.Text);
                Write_W(form1.XexFileName.Text, "6", 0x4179D0, form1.W6_PM.Text);
                Write_W(form1.XexFileName.Text, "7", 0x4179D8, form1.W7_PM.Text);
                Write_W(form1.XexFileName.Text, "8", 0x4179E0, form1.W8_PM.Text);

                //Write Rockets
                Write_TextID(form1.XexFileName.Text, 0x417B78, form1.TextID_Rockets.Text);
                Write_W(form1.XexFileName.Text, "1", 0x4179E8, form1.W1_Rockets.Text);
                Write_W(form1.XexFileName.Text, "2", 0x4179F0, form1.W2_Rockets.Text);
                Write_W(form1.XexFileName.Text, "3", 0x4179F8, form1.W3_Rockets.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417A00, form1.W4_Rockets.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417A08, form1.W5_Rockets.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417A10, form1.W6_Rockets.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417A18, form1.W7_Rockets.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417A20, form1.W8_Rockets.Text);

                //Write Lasers
                Write_TextID(form1.XexFileName.Text, 0x417B84, form1.TextID_Lasers.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417A28, form1.W1_Lasers.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417A30, form1.W2_Lasers.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417A38, form1.W3_Lasers.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417A40, form1.W4_Lasers.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417A48, form1.W5_Lasers.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417A50, form1.W6_Lasers.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417A58, form1.W7_Lasers.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417A60, form1.W8_Lasers.Text);

                //Write Golden Gun
                Write_TextID(form1.XexFileName.Text, 0x417B90, form1.TextID_GG.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417A68, form1.W1_GG.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417A70, form1.W2_GG.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417A78, form1.W3_GG.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417A80, form1.W4_GG.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417A88, form1.W5_GG.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417A90, form1.W6_GG.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417A98, form1.W7_GG.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417AA0, form1.W8_GG.Text);

                //Write Hunting Knives
                Write_TextID(form1.XexFileName.Text, 0x417B9C, form1.TextID_HK.Text);
                Write_W(form1.XexFileName.Text, "1", 0x417AA8, form1.W1_HK.Text);
                Write_W(form1.XexFileName.Text, "2", 0x417AB0, form1.W2_HK.Text);
                Write_W(form1.XexFileName.Text, "3", 0x417AB8, form1.W3_HK.Text);
                Write_W(form1.XexFileName.Text, "4", 0x417AC0, form1.W4_HK.Text);
                Write_W(form1.XexFileName.Text, "5", 0x417AC8, form1.W5_HK.Text);
                Write_W(form1.XexFileName.Text, "6", 0x417AD0, form1.W6_HK.Text);
                Write_W(form1.XexFileName.Text, "7", 0x417AD8, form1.W7_HK.Text);
                Write_W(form1.XexFileName.Text, "8", 0x417AE0, form1.W8_HK.Text);

        }
        public static void Write_TextID(string Xex, int Text_ID_Offset, string Text_ID_Value)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Xex, FileMode.Open, FileAccess.ReadWrite)))
            {
                byte[] data = new byte[Text_ID_Value.Length / 2];
                for (int i = 0; i < Text_ID_Value.Length; i += 2)
                    data[i / 2] = Convert.ToByte(Text_ID_Value.Substring(i, 2), 16);
                writer.Seek(Text_ID_Offset, SeekOrigin.Begin);
                writer.Write(data);
            }
        }
        public static void Write_W(string Xex, string WeaponSlot, int WeaponOffset, string WeaponText)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Xex, FileMode.Open, FileAccess.ReadWrite)))
            {
                if (WeaponText == "Slapper")
                {
                    string WeaponValue = "0001000100CD0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Hunting Knife")
                {
                    string WeaponValue = "0200000100BA0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Throwing Knife")
                {
                    string WeaponValue = "030A0A0000D10100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "PP7")
                {
                    string WeaponValue = "0401320100BF0300";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "PP7 Silenced")
                {
                    string WeaponValue = "0501320100CC0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "DD4 Dostovei")
                {
                    string WeaponValue = "0601320100CD0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Klobb")
                {
                    string WeaponValue = "0701640100C10180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "KF7 Soviet")
                {
                    string WeaponValue = "0803640100B80180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "ZMG")
                {
                    string WeaponValue = "0901640100C30180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "D5K Deutsche")
                {
                    string WeaponValue = "0A01640100BD0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "D5K Silenced")
                {
                    string WeaponValue = "0B01640100CE0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Phantom")
                {
                    string WeaponValue = "0C01640100C20100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "AR33 Assault Rifle")
                {
                    string WeaponValue = "0D03640100BC0180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "RC-P90")
                {
                    string WeaponValue = "0E01640100C50100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Shotgun")
                {
                    string WeaponValue = "0F041E0100C00100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Automatic Shotgun")
                {
                    string WeaponValue = "10041E0100CF0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Sniper Rifle")
                {
                    string WeaponValue = "1103320100D20100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Cougar Magnum")
                {
                    string WeaponValue = "120C320100BE0100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Golden Gun")
                {
                    string WeaponValue = "130D0A0100D00180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Silver PP7")
                {
                    string WeaponValue = "1401320100E60100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Gold PP7")
                {
                    string WeaponValue = "15010A0100E70180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Moonraker")
                {
                    string WeaponValue = "1600000100BB0180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Grenade Launcher")
                {
                    string WeaponValue = "180B060100B90100";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Rocket Launcher")
                {
                    string WeaponValue = "1906060100D30180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Hand Grenade")
                {
                    string WeaponValue = "1A05050000C40180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Timed Mine")
                {
                    string WeaponValue = "1B09050000C90180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Proximity Mine")
                {
                    string WeaponValue = "1C08050000C80180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }
                else if (WeaponText == "Remote Mine")
                {
                    string WeaponValue = "1D07050000C70180";
                    byte[] data = new byte[WeaponValue.Length / 2];
                    for (int i = 0; i < WeaponValue.Length; i += 2)
                        data[i / 2] = Convert.ToByte(WeaponValue.Substring(i, 2), 16);
                    writer.Seek(WeaponOffset, SeekOrigin.Begin);
                    writer.Write(data);
                }

            }
        }

    }
}
