using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class MP_Weapon_Set : UserControl
    {
        public MP_Weapon_Set()
        {
            InitializeComponent();
            General.Cleanup();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                Import_Weapons();
                General.Message("Weapon Sets Imported Successfully!");
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
        public void Import_Weapons()
        {
            try
            {

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
                                W1_Slappers.SelectedItem = Weapon_1;
                                W2_Slappers.SelectedItem = Weapon_2;
                                W3_Slappers.SelectedItem = Weapon_3;
                                W4_Slappers.SelectedItem = Weapon_4;
                                W5_Slappers.SelectedItem = Weapon_5;
                                W6_Slappers.SelectedItem = Weapon_6;
                                W7_Slappers.SelectedItem = Weapon_7;
                                W8_Slappers.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Pistols")
                            {
                                W1_Pistols.SelectedItem = Weapon_1;
                                W2_Pistols.SelectedItem = Weapon_2;
                                W3_Pistols.SelectedItem = Weapon_3;
                                W4_Pistols.SelectedItem = Weapon_4;
                                W5_Pistols.SelectedItem = Weapon_5;
                                W6_Pistols.SelectedItem = Weapon_6;
                                W7_Pistols.SelectedItem = Weapon_7;
                                W8_Pistols.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Throwing Knives")
                            {
                                W1_TK.SelectedItem = Weapon_1;
                                W2_TK.SelectedItem = Weapon_2;
                                W3_TK.SelectedItem = Weapon_3;
                                W4_TK.SelectedItem = Weapon_4;
                                W5_TK.SelectedItem = Weapon_5;
                                W6_TK.SelectedItem = Weapon_6;
                                W7_TK.SelectedItem = Weapon_7;
                                W8_TK.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Automatics")
                            {
                                W1_Automatics.SelectedItem = Weapon_1;
                                W2_Automatics.SelectedItem = Weapon_2;
                                W3_Automatics.SelectedItem = Weapon_3;
                                W4_Automatics.SelectedItem = Weapon_4;
                                W5_Automatics.SelectedItem = Weapon_5;
                                W6_Automatics.SelectedItem = Weapon_6;
                                W7_Automatics.SelectedItem = Weapon_7;
                                W8_Automatics.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Power Weapons")
                            {
                                W1_PW.SelectedItem = Weapon_1;
                                W2_PW.SelectedItem = Weapon_2;
                                W3_PW.SelectedItem = Weapon_3;
                                W4_PW.SelectedItem = Weapon_4;
                                W5_PW.SelectedItem = Weapon_5;
                                W6_PW.SelectedItem = Weapon_6;
                                W7_PW.SelectedItem = Weapon_7;
                                W8_PW.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Sniper Rifles")
                            {
                                W1_Sniper.SelectedItem = Weapon_1;
                                W2_Sniper.SelectedItem = Weapon_2;
                                W3_Sniper.SelectedItem = Weapon_3;
                                W4_Sniper.SelectedItem = Weapon_4;
                                W5_Sniper.SelectedItem = Weapon_5;
                                W6_Sniper.SelectedItem = Weapon_6;
                                W7_Sniper.SelectedItem = Weapon_7;
                                W8_Sniper.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Grenades")
                            {
                                W1_Grenade.SelectedItem = Weapon_1;
                                W2_Grenade.SelectedItem = Weapon_2;
                                W3_Grenade.SelectedItem = Weapon_3;
                                W4_Grenade.SelectedItem = Weapon_4;
                                W5_Grenade.SelectedItem = Weapon_5;
                                W6_Grenade.SelectedItem = Weapon_6;
                                W7_Grenade.SelectedItem = Weapon_7;
                                W8_Grenade.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Remote Mines")
                            {
                                W1_RM.SelectedItem = Weapon_1;
                                W2_RM.SelectedItem = Weapon_2;
                                W3_RM.SelectedItem = Weapon_3;
                                W4_RM.SelectedItem = Weapon_4;
                                W5_RM.SelectedItem = Weapon_5;
                                W6_RM.SelectedItem = Weapon_6;
                                W7_RM.SelectedItem = Weapon_7;
                                W8_RM.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Grenade Launchers")
                            {
                                W1_GL.SelectedItem = Weapon_1;
                                W2_GL.SelectedItem = Weapon_2;
                                W3_GL.SelectedItem = Weapon_3;
                                W4_GL.SelectedItem = Weapon_4;
                                W5_GL.SelectedItem = Weapon_5;
                                W6_GL.SelectedItem = Weapon_6;
                                W7_GL.SelectedItem = Weapon_7;
                                W8_GL.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Timed Mines")
                            {
                                W1_TM.SelectedItem = Weapon_1;
                                W2_TM.SelectedItem = Weapon_2;
                                W3_TM.SelectedItem = Weapon_3;
                                W4_TM.SelectedItem = Weapon_4;
                                W5_TM.SelectedItem = Weapon_5;
                                W6_TM.SelectedItem = Weapon_6;
                                W7_TM.SelectedItem = Weapon_7;
                                W8_TM.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Proximity Mines")
                            {
                                W1_PM.SelectedItem = Weapon_1;
                                W2_PM.SelectedItem = Weapon_2;
                                W3_PM.SelectedItem = Weapon_3;
                                W4_PM.SelectedItem = Weapon_4;
                                W5_PM.SelectedItem = Weapon_5;
                                W6_PM.SelectedItem = Weapon_6;
                                W7_PM.SelectedItem = Weapon_7;
                                W8_PM.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Rockets")
                            {
                                W1_Rockets.SelectedItem = Weapon_1;
                                W2_Rockets.SelectedItem = Weapon_2;
                                W3_Rockets.SelectedItem = Weapon_3;
                                W4_Rockets.SelectedItem = Weapon_4;
                                W5_Rockets.SelectedItem = Weapon_5;
                                W6_Rockets.SelectedItem = Weapon_6;
                                W7_Rockets.SelectedItem = Weapon_7;
                                W8_Rockets.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Lasers")
                            {
                                W1_Lasers.SelectedItem = Weapon_1;
                                W2_Lasers.SelectedItem = Weapon_2;
                                W3_Lasers.SelectedItem = Weapon_3;
                                W4_Lasers.SelectedItem = Weapon_4;
                                W5_Lasers.SelectedItem = Weapon_5;
                                W6_Lasers.SelectedItem = Weapon_6;
                                W7_Lasers.SelectedItem = Weapon_7;
                                W8_Lasers.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Golden Gun")
                            {
                                W1_GG.SelectedItem = Weapon_1;
                                W2_GG.SelectedItem = Weapon_2;
                                W3_GG.SelectedItem = Weapon_3;
                                W4_GG.SelectedItem = Weapon_4;
                                W5_GG.SelectedItem = Weapon_5;
                                W6_GG.SelectedItem = Weapon_6;
                                W7_GG.SelectedItem = Weapon_7;
                                W8_GG.SelectedItem = Weapon_8;
                            }
                            if (Set_Name == "Hunting Knives")
                            {
                                W1_HK.SelectedItem = Weapon_1;
                                W2_HK.SelectedItem = Weapon_2;
                                W3_HK.SelectedItem = Weapon_3;
                                W4_HK.SelectedItem = Weapon_4;
                                W5_HK.SelectedItem = Weapon_5;
                                W6_HK.SelectedItem = Weapon_6;
                                W7_HK.SelectedItem = Weapon_7;
                                W8_HK.SelectedItem = Weapon_8;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Open_Xex();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
        public void Open_Xex()
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

                        XexFileName.Text = filePath;
                        XexFileName.SelectionStart = XexFileName.Text.Length;
                        XexFileName.ScrollToCaret();
                        XexFileName.Refresh();

                        FileInfo fileInfo = new FileInfo(XexFileName.Text);
                        if (fileInfo.IsReadOnly)
                        {
                            MessageBox.Show("Xex file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            XexFileName.Text = "";
                        }
                        else
                        {

                            Unique_Name.Enabled = true;
                            btnEdit.Enabled = true;
                            Import.Enabled = true;
                            Export.Enabled = true;
                            Reset.Enabled = true;
                            Reset_GG.Enabled = true;
                            Reset_GL.Enabled = true;
                            Reset_Grenades.Enabled = true;
                            Reset_Pistols.Enabled = true;
                            Reset_Automatics.Enabled = true;
                            Reset_HK.Enabled = true;
                            Reset_Lasers.Enabled = true;
                            Reset_PM.Enabled = true;
                            Reset_PW.Enabled = true;
                            Reset_Rockets.Enabled = true;
                            Reset_RM.Enabled = true;
                            Reset_Slappers.Enabled = true;
                            Reset_Sniper.Enabled = true;
                            Reset_TK.Enabled = true;
                            Reset_TM.Enabled = true;

                            byte[] data = new byte[22];

                            using (FileStream fs = new FileStream(XexFileName.Text, FileMode.Open))
                            {
                                fs.Position = 7452;
                                fs.Read(data, 0, 22);
                                String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));
                                //textBox2.Text = UniqueName;

                                var bytes = new byte[UniqueName.Length / 2];
                                for (var i = 0; i < bytes.Length; i++)
                                {
                                    bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                    Unique_Name.Text = Encoding.UTF8.GetString(bytes);
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
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
        public void Get_Weapons()
        {
            //Get Slappers
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417728, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417730, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417738, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417740, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417748, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417750, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417758, "_Slappers");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417760, "_Slappers");


            //Get Pistols
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417768, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417770, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417778, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417780, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417788, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417790, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417798, "_Pistols");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4177A0, "_Pistols");

            //Get Throwing Knives
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4177A8, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4177B0, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4177B8, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x4177C0, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x4177C8, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x4177D0, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x4177D8, "_TK");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4177E0, "_TK");

            //Get Automatics
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4177E8, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4177F0, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4177F8, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417800, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417808, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417810, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417818, "_Automatics");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417820, "_Automatics");

            //Get Power Weapons
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417828, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417830, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417838, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417840, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417848, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417850, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417858, "_PW");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417860, "_PW");

            //Get Snipers
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417868, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417870, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417878, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417880, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417888, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417890, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417898, "_Sniper");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4178A0, "_Sniper");

            //Get Grenades
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4178A8, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4178B0, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4178B8, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x4178C0, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x4178C8, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x4178D0, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x4178D8, "_Grenade");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4178E0, "_Grenade");

            //Get Remote Mines
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4178E8, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4178F0, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4178F8, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417900, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417908, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417910, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417918, "_RM");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417920, "_RM");

            //Get Grenade Launcher
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417928, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417930, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417938, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417940, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417948, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417950, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417958, "_GL");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417960, "_GL");

            //Get Timed Mines
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417968, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417970, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417978, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417980, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417988, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417990, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417998, "_TM");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4179A0, "_TM");

            //Get Proximity Mines
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4179A8, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4179B0, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4179B8, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x4179C0, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x4179C8, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x4179D0, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x4179D8, "_PM");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x4179E0, "_PM");

            //Get Rockets
            Get_Weapons_Populate(XexFileName.Text, "1", 0x4179E8, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x4179F0, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x4179F8, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417A00, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417A08, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417A10, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417A18, "_Rockets");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417A20, "_Rockets");

            //Get Lasers
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417A28, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417A30, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417A38, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417A40, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417A48, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417A50, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417A58, "_Lasers");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417A60, "_Lasers");

            //Get Golden Gun
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417A68, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417A70, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417A78, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417A80, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417A88, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417A90, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417A98, "_GG");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417AA0, "_GG");

            //Get Hunting Knives
            Get_Weapons_Populate(XexFileName.Text, "1", 0x417AA8, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "2", 0x417AB0, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "3", 0x417AB8, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "4", 0x417AC0, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "5", 0x417AC8, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "6", 0x417AD0, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "7", 0x417AD8, "_HK");
            Get_Weapons_Populate(XexFileName.Text, "8", 0x417AE0, "_HK");
        }
        public void Get_Weapons_Populate(string Xex, string WeaponSlot, int WeaponOffset, string ComboName)
        {
            BinaryReader reader = new BinaryReader(new FileStream(Xex, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = WeaponOffset;     // The offset you are reading the data from
            byte[] data = reader.ReadBytes(0x1); // Read 16 bytes into an array
            string WeaponID = BitConverter.ToString(data);

            for (int i = 1; i <= 8; i++)
            {
                var cb1 = this.Controls.Find($"W{i}{ComboName}", true)
                .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                .FirstOrDefault();

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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true)
                        .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                        .FirstOrDefault();

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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
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
                        var cb = this.Controls.Find($"W{i}{ComboName}", true).OfType<Guna.UI2.WinForms.Guna2ComboBox>().FirstOrDefault();
                        if (cb != null)
                        {
                            cb.SelectedItem = WeaponName;
                        }
                    }
                }
            }

            reader.Close();
        }
        public void Text_ID()
        {

            TextID_Slappers.Enabled = true;
            GetTextID(XexFileName.Text, "Slappers", 0x417AF4);
            TextID_Slappers_Offset.Enabled = true;
            TextID_Slappers_Offset.Text = "417AF4";

            TextID_Pistols.Enabled = true;
            GetTextID(XexFileName.Text, "Pistols", 0x417B00);
            TextID_Pistols_Offset.Enabled = true;
            TextID_Pistols_Offset.Text = "417B00";

            TextID_TK.Enabled = true;
            GetTextID(XexFileName.Text, "Throwing Knives", 0x417B0C);
            TextID_TK_Offset.Enabled = true;
            TextID_TK_Offset.Text = "417B0C";

            TextID_Automatics.Enabled = true;
            GetTextID(XexFileName.Text, "Automatics", 0x417B18);
            TextID_Automatics_Offset.Enabled = true;
            TextID_Automatics_Offset.Text = "417B18";

            TextID_PW.Enabled = true;
            GetTextID(XexFileName.Text, "Power Weapons", 0x417B24);
            TextID_PW_Offset.Enabled = true;
            TextID_PW_Offset.Text = "417B24";

            TextID_Snipers.Enabled = true;
            GetTextID(XexFileName.Text, "Snipers", 0x417B30);
            TextID_Snipers_Offset.Enabled = true;
            TextID_Snipers_Offset.Text = "417B30";

            TextID_Grenades.Enabled = true;
            GetTextID(XexFileName.Text, "Grenades", 0x417B3C);
            TextID_Grenades_Offset.Enabled = true;
            TextID_Grenades_Offset.Text = "417B3C";

            TextID_RM.Enabled = true;
            GetTextID(XexFileName.Text, "Remote Mines", 0x417B48);
            TextID_RM_Offset.Enabled = true;
            TextID_RM_Offset.Text = "417B48";

            TextID_GL.Enabled = true;
            GetTextID(XexFileName.Text, "Grenade Launchers", 0x417B54);
            TextID_GL_Offset.Enabled = true;
            TextID_GL_Offset.Text = "417B54";

            TextID_TM.Enabled = true;
            GetTextID(XexFileName.Text, "Timed Mines", 0x417B60);
            TextID_TM_Offset.Enabled = true;
            TextID_TM_Offset.Text = "417B60";

            TextID_PM.Enabled = true;
            GetTextID(XexFileName.Text, "Proximity Mines", 0x417B6C);
            TextID_PM_Offset.Enabled = true;
            TextID_PM_Offset.Text = "417B6C";

            TextID_Rockets.Enabled = true;
            GetTextID(XexFileName.Text, "Rockets", 0x417B78);
            TextID_Rockets_Offset.Enabled = true;
            TextID_Rockets_Offset.Text = "417B78";

            TextID_Lasers.Enabled = true;
            GetTextID(XexFileName.Text, "Lasers", 0x417B84);
            TextID_Lasers_Offset.Enabled = true;
            TextID_Lasers_Offset.Text = "417B84";

            TextID_GG.Enabled = true;
            GetTextID(XexFileName.Text, "Golden Gun", 0x417B90);
            TextID_GG_Offset.Enabled = true;
            TextID_GG_Offset.Text = "417B90";

            TextID_HK.Enabled = true;
            GetTextID(XexFileName.Text, "Hunting Knives", 0x417B9C);
            TextID_HK_Offset.Enabled = true;
            TextID_HK_Offset.Text = "417B9C";
        }
        public void GetTextID(string Xex, string WeaponSet, int TextIDOffset)
        {
            BinaryReader reader = new BinaryReader(new FileStream(Xex, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = TextIDOffset; // The offset you are reading the data from
            byte[] data = reader.ReadBytes(0x2); // Read 2 bytes into an array
            string TextID = BitConverter.ToString(data);
            TextID = TextID.Replace("-", ""); //Remove "-" between the bytes

            if (WeaponSet == "Slappers")
            {
                TextID_Slappers.Text = TextID;
            }
            else if (WeaponSet == "Pistols")
            {
                TextID_Pistols.Text = TextID;
            }
            else if (WeaponSet == "Throwing Knives")
            {
                TextID_TK.Text = TextID;
            }
            else if (WeaponSet == "Automatics")
            {
                TextID_Automatics.Text = TextID;
            }
            else if (WeaponSet == "Power Weapons")
            {
                TextID_PW.Text = TextID;
            }
            else if (WeaponSet == "Snipers")
            {
                TextID_Snipers.Text = TextID;
            }
            else if (WeaponSet == "Grenades")
            {
                TextID_Grenades.Text = TextID;
            }
            else if (WeaponSet == "Remote Mines")
            {
                TextID_RM.Text = TextID;
            }
            else if (WeaponSet == "Grenade Launchers")
            {
                TextID_GL.Text = TextID;
            }
            else if (WeaponSet == "Timed Mines")
            {
                TextID_TM.Text = TextID;
            }
            else if (WeaponSet == "Proximity Mines")
            {
                TextID_PM.Text = TextID;
            }
            else if (WeaponSet == "Rockets")
            {
                TextID_Rockets.Text = TextID;
            }
            else if (WeaponSet == "Lasers")
            {
                TextID_Lasers.Text = TextID;
            }
            else if (WeaponSet == "Golden Gun")
            {
                TextID_GG.Text = TextID;
            }
            else if (WeaponSet == "Hunting Knives")
            {
                TextID_HK.Text = TextID;
            }

            reader.Close();
        }

        public void Reset_Weapons(string Weapon_Set)
        {
            try
            {
                if (Weapon_Set == "Slappers")
                {
                    W1_Slappers.SelectedItem = "Slapper";
                    W2_Slappers.SelectedItem = "Slapper";
                    W3_Slappers.SelectedItem = "Slapper";
                    W4_Slappers.SelectedItem = "Slapper";
                    W5_Slappers.SelectedItem = "Slapper";
                    W6_Slappers.SelectedItem = "Slapper";
                    W7_Slappers.SelectedItem = "Slapper";
                    W8_Slappers.SelectedItem = "Slapper";
                }
                if (Weapon_Set == "Pistols")
                {
                    W1_Pistols.SelectedItem = "DD4 Dostovei";
                    W2_Pistols.SelectedItem = "DD4 Dostovei";
                    W3_Pistols.SelectedItem = "DD4 Dostovei";
                    W4_Pistols.SelectedItem = "PP7 Silenced";
                    W5_Pistols.SelectedItem = "PP7 Silenced";
                    W6_Pistols.SelectedItem = "PP7 Silenced";
                    W7_Pistols.SelectedItem = "Cougar Magnum";
                    W8_Pistols.SelectedItem = "Cougar Magnum";
                }
                if (Weapon_Set == "TK")
                {
                    W1_TK.SelectedItem = "Throwing Knife";
                    W2_TK.SelectedItem = "Throwing Knife";
                    W3_TK.SelectedItem = "Throwing Knife";
                    W4_TK.SelectedItem = "Throwing Knife";
                    W5_TK.SelectedItem = "Throwing Knife";
                    W6_TK.SelectedItem = "Throwing Knife";
                    W7_TK.SelectedItem = "Throwing Knife";
                    W8_TK.SelectedItem = "Throwing Knife";
                }
                if (Weapon_Set == "Automatics")
                {
                    W1_Automatics.SelectedItem = "PP7 Silenced";
                    W2_Automatics.SelectedItem = "PP7 Silenced";
                    W3_Automatics.SelectedItem = "DD4 Dostovei";
                    W4_Automatics.SelectedItem = "DD4 Dostovei";
                    W5_Automatics.SelectedItem = "Klobb";
                    W6_Automatics.SelectedItem = "Klobb";
                    W7_Automatics.SelectedItem = "D5K Deutsche";
                    W8_Automatics.SelectedItem = "D5K Deutsche";
                }
                if (Weapon_Set == "PW")
                {
                    W1_PW.SelectedItem = "DD4 Dostovei";
                    W2_PW.SelectedItem = "DD4 Dostovei";
                    W3_PW.SelectedItem = "Cougar Magnum";
                    W4_PW.SelectedItem = "Cougar Magnum";
                    W5_PW.SelectedItem = "RC-P90";
                    W6_PW.SelectedItem = "RC-P90";
                    W7_PW.SelectedItem = "Automatic Shotgun";
                    W8_PW.SelectedItem = "Automatic Shotgun";
                }
                if (Weapon_Set == "Snipers")
                {
                    W1_Sniper.SelectedItem = "DD4 Dostovei";
                    W2_Sniper.SelectedItem = "DD4 Dostovei";
                    W3_Sniper.SelectedItem = "Cougar Magnum";
                    W4_Sniper.SelectedItem = "Cougar Magnum";
                    W5_Sniper.SelectedItem = "Klobb";
                    W6_Sniper.SelectedItem = "Klobb";
                    W7_Sniper.SelectedItem = "Sniper Rifle";
                    W8_Sniper.SelectedItem = "Sniper Rifle";
                }
                if (Weapon_Set == "Grenades")
                {
                    W1_Grenade.SelectedItem = "DD4 Dostovei";
                    W2_Grenade.SelectedItem = "DD4 Dostovei";
                    W3_Grenade.SelectedItem = "Klobb";
                    W4_Grenade.SelectedItem = "Klobb";
                    W5_Grenade.SelectedItem = "KF7 Soviet";
                    W6_Grenade.SelectedItem = "KF7 Soviet";
                    W7_Grenade.SelectedItem = "Hand Grenade";
                    W8_Grenade.SelectedItem = "Hand Grenade";
                }
                if (Weapon_Set == "RM")
                {
                    W1_RM.SelectedItem = "PP7";
                    W2_RM.SelectedItem = "PP7";
                    W3_RM.SelectedItem = "ZMG";
                    W4_RM.SelectedItem = "ZMG";
                    W5_RM.SelectedItem = "AR33 Assault Rifle";
                    W6_RM.SelectedItem = "AR33 Assault Rifle";
                    W7_RM.SelectedItem = "Remote Mine";
                    W8_RM.SelectedItem = "Remote Mine";
                }
                if (Weapon_Set == "GL")
                {
                    W1_GL.SelectedItem = "DD4 Dostovei";
                    W2_GL.SelectedItem = "DD4 Dostovei";
                    W3_GL.SelectedItem = "Klobb";
                    W4_GL.SelectedItem = "Klobb";
                    W5_GL.SelectedItem = "KF7 Soviet";
                    W6_GL.SelectedItem = "KF7 Soviet";
                    W7_GL.SelectedItem = "Grenade Launcher";
                    W8_GL.SelectedItem = "Grenade Launcher";
                }
                if (Weapon_Set == "TM")
                {
                    W1_TM.SelectedItem = "PP7";
                    W2_TM.SelectedItem = "PP7";
                    W3_TM.SelectedItem = "ZMG";
                    W4_TM.SelectedItem = "ZMG";
                    W5_TM.SelectedItem = "AR33 Assault Rifle";
                    W6_TM.SelectedItem = "AR33 Assault Rifle";
                    W7_TM.SelectedItem = "Timed Mine";
                    W8_TM.SelectedItem = "Timed Mine";
                }
                if (Weapon_Set == "PM")
                {
                    W1_PM.SelectedItem = "PP7";
                    W2_PM.SelectedItem = "PP7";
                    W3_PM.SelectedItem = "ZMG";
                    W4_PM.SelectedItem = "ZMG";
                    W5_PM.SelectedItem = "AR33 Assault Rifle";
                    W6_PM.SelectedItem = "AR33 Assault Rifle";
                    W7_PM.SelectedItem = "Proximity Mine";
                    W8_PM.SelectedItem = "Proximity Mine";
                }
                if (Weapon_Set == "Rockets")
                {
                    W1_Rockets.SelectedItem = "DD4 Dostovei";
                    W2_Rockets.SelectedItem = "DD4 Dostovei";
                    W3_Rockets.SelectedItem = "Klobb";
                    W4_Rockets.SelectedItem = "Klobb";
                    W5_Rockets.SelectedItem = "KF7 Soviet";
                    W6_Rockets.SelectedItem = "KF7 Soviet";
                    W7_Rockets.SelectedItem = "Rocket Launcher";
                    W8_Rockets.SelectedItem = "Rocket Launcher";
                }
                if (Weapon_Set == "Lasers")
                {
                    W1_Lasers.SelectedItem = "DD4 Dostovei";
                    W2_Lasers.SelectedItem = "DD4 Dostovei";
                    W3_Lasers.SelectedItem = "Klobb";
                    W4_Lasers.SelectedItem = "Klobb";
                    W5_Lasers.SelectedItem = "KF7 Soviet";
                    W6_Lasers.SelectedItem = "KF7 Soviet";
                    W7_Lasers.SelectedItem = "Moonraker";
                    W8_Lasers.SelectedItem = "Moonraker";
                }
                if (Weapon_Set == "GG")
                {
                    W1_GG.SelectedItem = "DD4 Dostovei";
                    W2_GG.SelectedItem = "DD4 Dostovei";
                    W3_GG.SelectedItem = "Klobb";
                    W4_GG.SelectedItem = "Klobb";
                    W5_GG.SelectedItem = "KF7 Soviet";
                    W6_GG.SelectedItem = "KF7 Soviet";
                    W7_GG.SelectedItem = "PP7 Silenced";
                    W8_GG.SelectedItem = "Golden Gun";
                }
                if (Weapon_Set == "HK")
                {
                    W1_HK.SelectedItem = "Hunting Knife";
                    W2_HK.SelectedItem = "Hunting Knife";
                    W3_HK.SelectedItem = "Hand Grenade";
                    W4_HK.SelectedItem = "Hand Grenade";
                    W5_HK.SelectedItem = "Hunting Knife";
                    W6_HK.SelectedItem = "Hunting Knife";
                    W7_HK.SelectedItem = "Sniper Rifle";
                    W8_HK.SelectedItem = "Sniper Rifle";
                }
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }

        }
        private void Reset_Slappers_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Slappers");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }
        private void Reset_Pistols_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Pistols");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_TK_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("TK");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_Automatics_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Automatics");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_PW_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("PW");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_Sniper_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Snipers");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_Grenades_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Grenades");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_RM_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("RM");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_GL_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("GL");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_TM_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("TM");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_PM_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("PM");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_Rockets_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Rockets");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_Lasers_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("Lasers");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_GG_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("GG");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }

        private void Reset_HK_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Weapons("HK");
            }
            catch (Exception ex)
            {
                General.Message(ex.Message.ToString());
            }
        }
    }
}
