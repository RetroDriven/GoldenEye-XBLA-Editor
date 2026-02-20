using Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class MP_Weapon_Set : UserControl
    {
        public CultureInfo resourceCulture;

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

        public void Export_Weapons()
        {
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
                        w.WriteElementString("Weapon_1", W1_Slappers.Text);
                        w.WriteElementString("Weapon_2", W2_Slappers.Text);
                        w.WriteElementString("Weapon_3", W3_Slappers.Text);
                        w.WriteElementString("Weapon_4", W4_Slappers.Text);
                        w.WriteElementString("Weapon_5", W5_Slappers.Text);
                        w.WriteElementString("Weapon_6", W6_Slappers.Text);
                        w.WriteElementString("Weapon_7", W7_Slappers.Text);
                        w.WriteElementString("Weapon_8", W8_Slappers.Text);
                        w.WriteEndElement();

                        //Pistols
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Pistols");
                        w.WriteElementString("Weapon_1", W1_Pistols.Text);
                        w.WriteElementString("Weapon_2", W2_Pistols.Text);
                        w.WriteElementString("Weapon_3", W3_Pistols.Text);
                        w.WriteElementString("Weapon_4", W4_Pistols.Text);
                        w.WriteElementString("Weapon_5", W5_Pistols.Text);
                        w.WriteElementString("Weapon_6", W6_Pistols.Text);
                        w.WriteElementString("Weapon_7", W7_Pistols.Text);
                        w.WriteElementString("Weapon_8", W8_Pistols.Text);
                        w.WriteEndElement();


                        //Throwing Knives
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Throwing Knives");
                        w.WriteElementString("Weapon_1", W1_TK.Text);
                        w.WriteElementString("Weapon_2", W2_TK.Text);
                        w.WriteElementString("Weapon_3", W3_TK.Text);
                        w.WriteElementString("Weapon_4", W4_TK.Text);
                        w.WriteElementString("Weapon_5", W5_TK.Text);
                        w.WriteElementString("Weapon_6", W6_TK.Text);
                        w.WriteElementString("Weapon_7", W7_TK.Text);
                        w.WriteElementString("Weapon_8", W8_TK.Text);
                        w.WriteEndElement();

                        //Automatics
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Automatics");
                        w.WriteElementString("Weapon_1", W1_Automatics.Text);
                        w.WriteElementString("Weapon_2", W2_Automatics.Text);
                        w.WriteElementString("Weapon_3", W3_Automatics.Text);
                        w.WriteElementString("Weapon_4", W4_Automatics.Text);
                        w.WriteElementString("Weapon_5", W5_Automatics.Text);
                        w.WriteElementString("Weapon_6", W6_Automatics.Text);
                        w.WriteElementString("Weapon_7", W7_Automatics.Text);
                        w.WriteElementString("Weapon_8", W8_Automatics.Text);
                        w.WriteEndElement();

                        //Power Weapons
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Power Weapons");
                        w.WriteElementString("Weapon_1", W1_PW.Text);
                        w.WriteElementString("Weapon_2", W2_PW.Text);
                        w.WriteElementString("Weapon_3", W3_PW.Text);
                        w.WriteElementString("Weapon_4", W4_PW.Text);
                        w.WriteElementString("Weapon_5", W5_PW.Text);
                        w.WriteElementString("Weapon_6", W6_PW.Text);
                        w.WriteElementString("Weapon_7", W7_PW.Text);
                        w.WriteElementString("Weapon_8", W8_PW.Text);
                        w.WriteEndElement();

                        //Snipers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Sniper Rifles");
                        w.WriteElementString("Weapon_1", W1_Sniper.Text);
                        w.WriteElementString("Weapon_2", W2_Sniper.Text);
                        w.WriteElementString("Weapon_3", W3_Sniper.Text);
                        w.WriteElementString("Weapon_4", W4_Sniper.Text);
                        w.WriteElementString("Weapon_5", W5_Sniper.Text);
                        w.WriteElementString("Weapon_6", W6_Sniper.Text);
                        w.WriteElementString("Weapon_7", W7_Sniper.Text);
                        w.WriteElementString("Weapon_8", W8_Sniper.Text);
                        w.WriteEndElement();

                        //Grenades
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Grenades");
                        w.WriteElementString("Weapon_1", W1_Grenade.Text);
                        w.WriteElementString("Weapon_2", W2_Grenade.Text);
                        w.WriteElementString("Weapon_3", W3_Grenade.Text);
                        w.WriteElementString("Weapon_4", W4_Grenade.Text);
                        w.WriteElementString("Weapon_5", W5_Grenade.Text);
                        w.WriteElementString("Weapon_6", W6_Grenade.Text);
                        w.WriteElementString("Weapon_7", W7_Grenade.Text);
                        w.WriteElementString("Weapon_8", W8_Grenade.Text);
                        w.WriteEndElement();

                        //Remote Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Remote Mines");
                        w.WriteElementString("Weapon_1", W1_RM.Text);
                        w.WriteElementString("Weapon_2", W2_RM.Text);
                        w.WriteElementString("Weapon_3", W3_RM.Text);
                        w.WriteElementString("Weapon_4", W4_RM.Text);
                        w.WriteElementString("Weapon_5", W5_RM.Text);
                        w.WriteElementString("Weapon_6", W6_RM.Text);
                        w.WriteElementString("Weapon_7", W7_RM.Text);
                        w.WriteElementString("Weapon_8", W8_RM.Text);
                        w.WriteEndElement();

                        //Grenade Launchers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Grenade Launchers");
                        w.WriteElementString("Weapon_1", W1_GL.Text);
                        w.WriteElementString("Weapon_2", W2_GL.Text);
                        w.WriteElementString("Weapon_3", W3_GL.Text);
                        w.WriteElementString("Weapon_4", W4_GL.Text);
                        w.WriteElementString("Weapon_5", W5_GL.Text);
                        w.WriteElementString("Weapon_6", W6_GL.Text);
                        w.WriteElementString("Weapon_7", W7_GL.Text);
                        w.WriteElementString("Weapon_8", W8_GL.Text);
                        w.WriteEndElement();

                        //Timed Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Timed Mines");
                        w.WriteElementString("Weapon_1", W1_TM.Text);
                        w.WriteElementString("Weapon_2", W2_TM.Text);
                        w.WriteElementString("Weapon_3", W3_TM.Text);
                        w.WriteElementString("Weapon_4", W4_TM.Text);
                        w.WriteElementString("Weapon_5", W5_TM.Text);
                        w.WriteElementString("Weapon_6", W6_TM.Text);
                        w.WriteElementString("Weapon_7", W7_TM.Text);
                        w.WriteElementString("Weapon_8", W8_TM.Text);
                        w.WriteEndElement();

                        //Proximity Mines
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Proximity Mines");
                        w.WriteElementString("Weapon_1", W1_PM.Text);
                        w.WriteElementString("Weapon_2", W2_PM.Text);
                        w.WriteElementString("Weapon_3", W3_PM.Text);
                        w.WriteElementString("Weapon_4", W4_PM.Text);
                        w.WriteElementString("Weapon_5", W5_PM.Text);
                        w.WriteElementString("Weapon_6", W6_PM.Text);
                        w.WriteElementString("Weapon_7", W7_PM.Text);
                        w.WriteElementString("Weapon_8", W8_PM.Text);
                        w.WriteEndElement();

                        //Rockets
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Rockets");
                        w.WriteElementString("Weapon_1", W1_Rockets.Text);
                        w.WriteElementString("Weapon_2", W2_Rockets.Text);
                        w.WriteElementString("Weapon_3", W3_Rockets.Text);
                        w.WriteElementString("Weapon_4", W4_Rockets.Text);
                        w.WriteElementString("Weapon_5", W5_Rockets.Text);
                        w.WriteElementString("Weapon_6", W6_Rockets.Text);
                        w.WriteElementString("Weapon_7", W7_Rockets.Text);
                        w.WriteElementString("Weapon_8", W8_Rockets.Text);
                        w.WriteEndElement();

                        //Lasers
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Lasers");
                        w.WriteElementString("Weapon_1", W1_Lasers.Text);
                        w.WriteElementString("Weapon_2", W2_Lasers.Text);
                        w.WriteElementString("Weapon_3", W3_Lasers.Text);
                        w.WriteElementString("Weapon_4", W4_Lasers.Text);
                        w.WriteElementString("Weapon_5", W5_Lasers.Text);
                        w.WriteElementString("Weapon_6", W6_Lasers.Text);
                        w.WriteElementString("Weapon_7", W7_Lasers.Text);
                        w.WriteElementString("Weapon_8", W8_Lasers.Text);
                        w.WriteEndElement();

                        //Golden Gun
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Golden Gun");
                        w.WriteElementString("Weapon_1", W1_GG.Text);
                        w.WriteElementString("Weapon_2", W2_GG.Text);
                        w.WriteElementString("Weapon_3", W3_GG.Text);
                        w.WriteElementString("Weapon_4", W4_GG.Text);
                        w.WriteElementString("Weapon_5", W5_GG.Text);
                        w.WriteElementString("Weapon_6", W6_GG.Text);
                        w.WriteElementString("Weapon_7", W7_GG.Text);
                        w.WriteElementString("Weapon_8", W8_GG.Text);
                        w.WriteEndElement();

                        //Hunting Knives
                        //Golden Gun
                        w.WriteStartElement("Weapon_Set");
                        w.WriteAttributeString("Name", "Hunting Knives");
                        w.WriteElementString("Weapon_1", W1_HK.Text);
                        w.WriteElementString("Weapon_2", W2_HK.Text);
                        w.WriteElementString("Weapon_3", W3_HK.Text);
                        w.WriteElementString("Weapon_4", W4_HK.Text);
                        w.WriteElementString("Weapon_5", W5_HK.Text);
                        w.WriteElementString("Weapon_6", W6_HK.Text);
                        w.WriteElementString("Weapon_7", W7_HK.Text);
                        w.WriteElementString("Weapon_8", W8_HK.Text);
                        w.WriteEndElement();

                        w.WriteEndElement();
                        w.WriteEndDocument();
                        w.Flush();
                        w.Close();
                    }
                }
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
        public void Reset_All_Weapons()
        {
            //Slappers
            W1_Slappers.SelectedItem = "Slapper";
            W1_Slappers.SelectedItem = "Slapper";
            W2_Slappers.SelectedItem = "Slapper";
            W3_Slappers.SelectedItem = "Slapper";
            W4_Slappers.SelectedItem = "Slapper";
            W5_Slappers.SelectedItem = "Slapper";
            W6_Slappers.SelectedItem = "Slapper";
            W7_Slappers.SelectedItem = "Slapper";
            W8_Slappers.SelectedItem = "Slapper";

            //Pistols
            W1_Pistols.SelectedItem = "DD4 Dostovei";
            W2_Pistols.SelectedItem = "DD4 Dostovei";
            W3_Pistols.SelectedItem = "DD4 Dostovei";
            W4_Pistols.SelectedItem = "PP7 Silenced";
            W5_Pistols.SelectedItem = "PP7 Silenced";
            W6_Pistols.SelectedItem = "PP7 Silenced";
            W7_Pistols.SelectedItem = "Cougar Magnum";
            W8_Pistols.SelectedItem = "Cougar Magnum";

            //Throwing Knives
            W1_TK.SelectedItem = "Throwing Knife";
            W2_TK.SelectedItem = "Throwing Knife";
            W3_TK.SelectedItem = "Throwing Knife";
            W4_TK.SelectedItem = "Throwing Knife";
            W5_TK.SelectedItem = "Throwing Knife";
            W6_TK.SelectedItem = "Throwing Knife";
            W7_TK.SelectedItem = "Throwing Knife";
            W8_TK.SelectedItem = "Throwing Knife";

            //Automatics
            W1_Automatics.SelectedItem = "PP7 Silenced";
            W2_Automatics.SelectedItem = "PP7 Silenced";
            W3_Automatics.SelectedItem = "DD4 Dostovei";
            W4_Automatics.SelectedItem = "DD4 Dostovei";
            W5_Automatics.SelectedItem = "Klobb";
            W6_Automatics.SelectedItem = "Klobb";
            W7_Automatics.SelectedItem = "D5K Deutsche";
            W8_Automatics.SelectedItem = "D5K Deutsche";

            //Power Weapons
            W1_PW.SelectedItem = "DD4 Dostovei";
            W2_PW.SelectedItem = "DD4 Dostovei";
            W3_PW.SelectedItem = "Cougar Magnum";
            W4_PW.SelectedItem = "Cougar Magnum";
            W5_PW.SelectedItem = "RC-P90";
            W6_PW.SelectedItem = "RC-P90";
            W7_PW.SelectedItem = "Automatic Shotgun";
            W8_PW.SelectedItem = "Automatic Shotgun";

            //Sniper Rifles
            W1_Sniper.SelectedItem = "DD4 Dostovei";
            W2_Sniper.SelectedItem = "DD4 Dostovei";
            W3_Sniper.SelectedItem = "Cougar Magnum";
            W4_Sniper.SelectedItem = "Cougar Magnum";
            W5_Sniper.SelectedItem = "Klobb";
            W6_Sniper.SelectedItem = "Klobb";
            W7_Sniper.SelectedItem = "Sniper Rifle";
            W8_Sniper.SelectedItem = "Sniper Rifle";

            //Grenades
            W1_Grenade.SelectedItem = "DD4 Dostovei";
            W2_Grenade.SelectedItem = "DD4 Dostovei";
            W3_Grenade.SelectedItem = "Klobb";
            W4_Grenade.SelectedItem = "Klobb";
            W5_Grenade.SelectedItem = "KF7 Soviet";
            W6_Grenade.SelectedItem = "KF7 Soviet";
            W7_Grenade.SelectedItem = "Hand Grenade";
            W8_Grenade.SelectedItem = "Hand Grenade";

            //Remote Mines
            W1_RM.SelectedItem = "PP7";
            W2_RM.SelectedItem = "PP7";
            W3_RM.SelectedItem = "ZMG";
            W4_RM.SelectedItem = "ZMG";
            W5_RM.SelectedItem = "AR33 Assault Rifle";
            W6_RM.SelectedItem = "AR33 Assault Rifle";
            W7_RM.SelectedItem = "Remote Mine";
            W8_RM.SelectedItem = "Remote Mine";

            //Grenade Launchers
            W1_GL.SelectedItem = "DD4 Dostovei";
            W2_GL.SelectedItem = "DD4 Dostovei";
            W3_GL.SelectedItem = "Klobb";
            W4_GL.SelectedItem = "Klobb";
            W5_GL.SelectedItem = "KF7 Soviet";
            W6_GL.SelectedItem = "KF7 Soviet";
            W7_GL.SelectedItem = "Grenade Launcher";
            W8_GL.SelectedItem = "Grenade Launcher";

            //Timed Mines
            W1_TM.SelectedItem = "PP7";
            W2_TM.SelectedItem = "PP7";
            W3_TM.SelectedItem = "ZMG";
            W4_TM.SelectedItem = "ZMG";
            W5_TM.SelectedItem = "AR33 Assault Rifle";
            W6_TM.SelectedItem = "AR33 Assault Rifle";
            W7_TM.SelectedItem = "Timed Mine";
            W8_TM.SelectedItem = "Timed Mine";

            //Proximity Mines
            W1_PM.SelectedItem = "PP7";
            W2_PM.SelectedItem = "PP7";
            W3_PM.SelectedItem = "ZMG";
            W4_PM.SelectedItem = "ZMG";
            W5_PM.SelectedItem = "AR33 Assault Rifle";
            W6_PM.SelectedItem = "AR33 Assault Rifle";
            W7_PM.SelectedItem = "Proximity Mine";
            W8_PM.SelectedItem = "Proximity Mine";

            //Rockets
            W1_Rockets.SelectedItem = "DD4 Dostovei";
            W2_Rockets.SelectedItem = "DD4 Dostovei";
            W3_Rockets.SelectedItem = "Klobb";
            W4_Rockets.SelectedItem = "Klobb";
            W5_Rockets.SelectedItem = "KF7 Soviet";
            W6_Rockets.SelectedItem = "KF7 Soviet";
            W7_Rockets.SelectedItem = "Rocket Launcher";
            W8_Rockets.SelectedItem = "Rocket Launcher";

            //Lasers
            W1_Lasers.SelectedItem = "DD4 Dostovei";
            W2_Lasers.SelectedItem = "DD4 Dostovei";
            W3_Lasers.SelectedItem = "Klobb";
            W4_Lasers.SelectedItem = "Klobb";
            W5_Lasers.SelectedItem = "KF7 Soviet";
            W6_Lasers.SelectedItem = "KF7 Soviet";
            W7_Lasers.SelectedItem = "Moonraker";
            W8_Lasers.SelectedItem = "Moonraker";

            //Golden Gun
            W1_GG.SelectedItem = "DD4 Dostovei";
            W2_GG.SelectedItem = "DD4 Dostovei";
            W3_GG.SelectedItem = "Klobb";
            W4_GG.SelectedItem = "Klobb";
            W5_GG.SelectedItem = "KF7 Soviet";
            W6_GG.SelectedItem = "KF7 Soviet";
            W7_GG.SelectedItem = "PP7 Silenced";
            W8_GG.SelectedItem = "Golden Gun";

            //Hunting Knives
            W1_HK.SelectedItem = "Hunting Knife";
            W2_HK.SelectedItem = "Hunting Knife";
            W3_HK.SelectedItem = "Hand Grenade";
            W4_HK.SelectedItem = "Hand Grenade";
            W5_HK.SelectedItem = "Hunting Knife";
            W6_HK.SelectedItem = "Hunting Knife";
            W7_HK.SelectedItem = "Sniper Rifle";
            W8_HK.SelectedItem = "Sniper Rifle";
        }
        public void Edit_Xex()
        {
            //Cleanup
            General.Cleanup();

            if (String.IsNullOrEmpty(XexFileName.Text))
            {
                General.Message("Please Select Xex File");

            }
            else if (String.IsNullOrEmpty(TextID_Slappers.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Slappers Only!");
            }
            else if (String.IsNullOrEmpty(TextID_Pistols.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Pistols!");
            }
            else if (String.IsNullOrEmpty(TextID_TK.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Throwing Knives!");
            }
            else if (String.IsNullOrEmpty(TextID_Automatics.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Automatics!");
            }
            else if (String.IsNullOrEmpty(TextID_PW.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Power Weapons!");
            }
            else if (String.IsNullOrEmpty(TextID_Snipers.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Snipers!");
            }
            else if (String.IsNullOrEmpty(TextID_Grenades.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Grenades!");
            }
            else if (String.IsNullOrEmpty(TextID_RM.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Remote Mines!");
            }
            else if (String.IsNullOrEmpty(TextID_GL.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Grenade Launchers!");
            }
            else if (String.IsNullOrEmpty(TextID_TM.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Timed Mines!");
            }
            else if (String.IsNullOrEmpty(TextID_PM.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Proximity Mines!");
            }
            else if (String.IsNullOrEmpty(TextID_Rockets.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Rockets!");
            }
            else if (String.IsNullOrEmpty(TextID_Lasers.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Lasers!");
            }
            else if (String.IsNullOrEmpty(TextID_GG.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Golden Gun!");
            }
            else if (String.IsNullOrEmpty(TextID_HK.Text))
            {
                General.Message("Please Enter Weapon Set Text ID for Hunting Knives!");
            }
            else if (String.IsNullOrEmpty(Unique_Name.Text))
            {
                General.Message("Please Enter Unique Name");
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
                General.Message("Weapon Sets Updated Successfully!");
            }
        }
        public void Sign_Xex()
        {
            string Xextool = @"C:\RetroDriven_Temp\xextool.exe";
            string XexTool = $"/C {Xextool} -md \"{XexFileName.Text}\"";
            System.Diagnostics.Process SignXex = new System.Diagnostics.Process();
            SignXex.StartInfo.FileName = "cmd.exe";
            SignXex.StartInfo.Arguments = XexTool;
            SignXex.Start();
            SignXex.WaitForExit();
        }
        public void Get_Xex_Tool()
        {
            Directory.CreateDirectory(@"C:\RetroDriven_Temp");
            string Xextool = @"C:\RetroDriven_Temp\xextool.exe";
            object ob2 = Resource1.ResourceManager.GetObject("xextool", resourceCulture);
            byte[] myResBytes2 = (byte[])ob2;
            using (FileStream fsDst2 = new FileStream(Xextool, FileMode.CreateNew))
            {
                byte[] bytes2 = myResBytes2;
                fsDst2.Write(bytes2, 0, bytes2.Length);
                fsDst2.Close();
                fsDst2.Dispose();
            }
        }
        public void Write_Unique_ID()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(XexFileName.Text, FileMode.Open, FileAccess.ReadWrite)))
            {
                int offset2 = 7452; //position you want to start editing
                string trimmed = String.Concat(Unique_Name.Text.Where(c => !Char.IsWhiteSpace(c)));
                byte[] new_data = Encoding.ASCII.GetBytes(trimmed);
                byte[] new_data2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //new data
                writer.Seek(offset2, SeekOrigin.Begin); //move your cursor to the position
                writer.Write(new_data2);
                writer.Seek(offset2, SeekOrigin.Begin);
                writer.Write(new_data);//write it
            }
        }
        public void Write_Weapons()
        {

            //Slappers
            Write_TextID(XexFileName.Text, 0x417AF4, TextID_Slappers.Text);
            Write_W(XexFileName.Text, "1", 0x417728, W1_Slappers.Text);
            Write_W(XexFileName.Text, "2", 0x417730, W2_Slappers.Text);
            Write_W(XexFileName.Text, "3", 0x417738, W3_Slappers.Text);
            Write_W(XexFileName.Text, "4", 0x417740, W4_Slappers.Text);
            Write_W(XexFileName.Text, "5", 0x417748, W5_Slappers.Text);
            Write_W(XexFileName.Text, "6", 0x417750, W6_Slappers.Text);
            Write_W(XexFileName.Text, "7", 0x417758, W7_Slappers.Text);
            Write_W(XexFileName.Text, "8", 0x417760, W8_Slappers.Text);

            //Pistols
            Write_TextID(XexFileName.Text, 0x417B00, TextID_Pistols.Text);
            Write_W(XexFileName.Text, "1", 0x417768, W1_Pistols.Text);
            Write_W(XexFileName.Text, "2", 0x417770, W2_Pistols.Text);
            Write_W(XexFileName.Text, "3", 0x417778, W3_Pistols.Text);
            Write_W(XexFileName.Text, "4", 0x417780, W4_Pistols.Text);
            Write_W(XexFileName.Text, "5", 0x417788, W5_Pistols.Text);
            Write_W(XexFileName.Text, "6", 0x417790, W6_Pistols.Text);
            Write_W(XexFileName.Text, "7", 0x417798, W7_Pistols.Text);
            Write_W(XexFileName.Text, "8", 0x4177A0, W8_Pistols.Text);

            //Throwing Knives
            Write_TextID(XexFileName.Text, 0x417B0C, TextID_TK.Text);
            Write_W(XexFileName.Text, "1", 0x4177A8, W1_TK.Text);
            Write_W(XexFileName.Text, "2", 0x4177B0, W2_TK.Text);
            Write_W(XexFileName.Text, "3", 0x4177B8, W3_TK.Text);
            Write_W(XexFileName.Text, "4", 0x4177C0, W4_TK.Text);
            Write_W(XexFileName.Text, "5", 0x4177C8, W5_TK.Text);
            Write_W(XexFileName.Text, "6", 0x4177D0, W6_TK.Text);
            Write_W(XexFileName.Text, "7", 0x4177D8, W7_TK.Text);
            Write_W(XexFileName.Text, "8", 0x4177E0, W8_TK.Text);

            //Automatics
            Write_TextID(XexFileName.Text, 0x417B18, TextID_Automatics.Text);
            Write_W(XexFileName.Text, "1", 0x4177E8, W1_Automatics.Text);
            Write_W(XexFileName.Text, "2", 0x4177F0, W2_Automatics.Text);
            Write_W(XexFileName.Text, "3", 0x4177F8, W3_Automatics.Text);
            Write_W(XexFileName.Text, "4", 0x417800, W4_Automatics.Text);
            Write_W(XexFileName.Text, "5", 0x417808, W5_Automatics.Text);
            Write_W(XexFileName.Text, "6", 0x417810, W6_Automatics.Text);
            Write_W(XexFileName.Text, "7", 0x417818, W7_Automatics.Text);
            Write_W(XexFileName.Text, "8", 0x417820, W8_Automatics.Text);

            //Power Weapons
            Write_TextID(XexFileName.Text, 0x417B24, TextID_PW.Text);
            Write_W(XexFileName.Text, "1", 0x417828, W1_PW.Text);
            Write_W(XexFileName.Text, "2", 0x417830, W2_PW.Text);
            Write_W(XexFileName.Text, "3", 0x417838, W3_PW.Text);
            Write_W(XexFileName.Text, "4", 0x417840, W4_PW.Text);
            Write_W(XexFileName.Text, "5", 0x417848, W5_PW.Text);
            Write_W(XexFileName.Text, "6", 0x417850, W6_PW.Text);
            Write_W(XexFileName.Text, "7", 0x417858, W7_PW.Text);
            Write_W(XexFileName.Text, "8", 0x417860, W8_PW.Text);

            //Snipers
            Write_TextID(XexFileName.Text, 0x417B30, TextID_Snipers.Text);
            Write_W(XexFileName.Text, "1", 0x417868, W1_Sniper.Text);
            Write_W(XexFileName.Text, "2", 0x417870, W2_Sniper.Text);
            Write_W(XexFileName.Text, "3", 0x417878, W3_Sniper.Text);
            Write_W(XexFileName.Text, "4", 0x417880, W4_Sniper.Text);
            Write_W(XexFileName.Text, "5", 0x417888, W5_Sniper.Text);
            Write_W(XexFileName.Text, "6", 0x417890, W6_Sniper.Text);
            Write_W(XexFileName.Text, "7", 0x417898, W7_Sniper.Text);
            Write_W(XexFileName.Text, "8", 0x4178A0, W8_Sniper.Text);

            //Grenades
            Write_TextID(XexFileName.Text, 0x417B3C, TextID_Grenades.Text);
            Write_W(XexFileName.Text, "1", 0x4178A8, W1_Grenade.Text);
            Write_W(XexFileName.Text, "2", 0x4178B0, W2_Grenade.Text);
            Write_W(XexFileName.Text, "3", 0x4178B8, W3_Grenade.Text);
            Write_W(XexFileName.Text, "4", 0x4178C0, W4_Grenade.Text);
            Write_W(XexFileName.Text, "5", 0x4178C8, W5_Grenade.Text);
            Write_W(XexFileName.Text, "6", 0x4178D0, W6_Grenade.Text);
            Write_W(XexFileName.Text, "7", 0x4178D8, W7_Grenade.Text);
            Write_W(XexFileName.Text, "8", 0x4178E0, W8_Grenade.Text);

            //Write Grenade Launchers
            Write_TextID(XexFileName.Text, 0x417B54, TextID_GL.Text);
            Write_W(XexFileName.Text, "1", 0x417928, W1_GL.Text);
            Write_W(XexFileName.Text, "2", 0x417930, W2_GL.Text);
            Write_W(XexFileName.Text, "3", 0x417938, W3_GL.Text);
            Write_W(XexFileName.Text, "4", 0x417940, W4_GL.Text);
            Write_W(XexFileName.Text, "5", 0x417948, W5_GL.Text);
            Write_W(XexFileName.Text, "6", 0x417950, W6_GL.Text);
            Write_W(XexFileName.Text, "7", 0x417958, W7_GL.Text);
            Write_W(XexFileName.Text, "8", 0x417960, W8_GL.Text);

            //Write Timed Mines
            Write_TextID(XexFileName.Text, 0x417B60, TextID_TM.Text);
            Write_W(XexFileName.Text, "1", 0x417968, W1_TM.Text);
            Write_W(XexFileName.Text, "2", 0x417970, W2_TM.Text);
            Write_W(XexFileName.Text, "3", 0x417978, W3_TM.Text);
            Write_W(XexFileName.Text, "4", 0x417980, W4_TM.Text);
            Write_W(XexFileName.Text, "5", 0x417988, W5_TM.Text);
            Write_W(XexFileName.Text, "6", 0x417990, W6_TM.Text);
            Write_W(XexFileName.Text, "7", 0x417998, W7_TM.Text);
            Write_W(XexFileName.Text, "8", 0x4179A0, W8_TM.Text);

            //Write Proximity Mines
            Write_TextID(XexFileName.Text, 0x417B6C, TextID_PM.Text);
            Write_W(XexFileName.Text, "1", 0x4179A8, W1_PM.Text);
            Write_W(XexFileName.Text, "2", 0x4179B0, W2_PM.Text);
            Write_W(XexFileName.Text, "3", 0x4179B8, W3_PM.Text);
            Write_W(XexFileName.Text, "4", 0x4179C0, W4_PM.Text);
            Write_W(XexFileName.Text, "5", 0x4179C8, W5_PM.Text);
            Write_W(XexFileName.Text, "6", 0x4179D0, W6_PM.Text);
            Write_W(XexFileName.Text, "7", 0x4179D8, W7_PM.Text);
            Write_W(XexFileName.Text, "8", 0x4179E0, W8_PM.Text);

            //Write Rockets
            Write_TextID(XexFileName.Text, 0x417B78, TextID_Rockets.Text);
            Write_W(XexFileName.Text, "1", 0x4179E8, W1_Rockets.Text);
            Write_W(XexFileName.Text, "2", 0x4179F0, W2_Rockets.Text);
            Write_W(XexFileName.Text, "3", 0x4179F8, W3_Rockets.Text);
            Write_W(XexFileName.Text, "4", 0x417A00, W4_Rockets.Text);
            Write_W(XexFileName.Text, "5", 0x417A08, W5_Rockets.Text);
            Write_W(XexFileName.Text, "6", 0x417A10, W6_Rockets.Text);
            Write_W(XexFileName.Text, "7", 0x417A18, W7_Rockets.Text);
            Write_W(XexFileName.Text, "8", 0x417A20, W8_Rockets.Text);

            //Write Lasers
            Write_TextID(XexFileName.Text, 0x417B84, TextID_Lasers.Text);
            Write_W(XexFileName.Text, "1", 0x417A28, W1_Lasers.Text);
            Write_W(XexFileName.Text, "2", 0x417A30, W2_Lasers.Text);
            Write_W(XexFileName.Text, "3", 0x417A38, W3_Lasers.Text);
            Write_W(XexFileName.Text, "4", 0x417A40, W4_Lasers.Text);
            Write_W(XexFileName.Text, "5", 0x417A48, W5_Lasers.Text);
            Write_W(XexFileName.Text, "6", 0x417A50, W6_Lasers.Text);
            Write_W(XexFileName.Text, "7", 0x417A58, W7_Lasers.Text);
            Write_W(XexFileName.Text, "8", 0x417A60, W8_Lasers.Text);

            //Write Golden Gun
            Write_TextID(XexFileName.Text, 0x417B90, TextID_GG.Text);
            Write_W(XexFileName.Text, "1", 0x417A68, W1_GG.Text);
            Write_W(XexFileName.Text, "2", 0x417A70, W2_GG.Text);
            Write_W(XexFileName.Text, "3", 0x417A78, W3_GG.Text);
            Write_W(XexFileName.Text, "4", 0x417A80, W4_GG.Text);
            Write_W(XexFileName.Text, "5", 0x417A88, W5_GG.Text);
            Write_W(XexFileName.Text, "6", 0x417A90, W6_GG.Text);
            Write_W(XexFileName.Text, "7", 0x417A98, W7_GG.Text);
            Write_W(XexFileName.Text, "8", 0x417AA0, W8_GG.Text);

            //Write Hunting Knives
            Write_TextID(XexFileName.Text, 0x417B9C, TextID_HK.Text);
            Write_W(XexFileName.Text, "1", 0x417AA8, W1_HK.Text);
            Write_W(XexFileName.Text, "2", 0x417AB0, W2_HK.Text);
            Write_W(XexFileName.Text, "3", 0x417AB8, W3_HK.Text);
            Write_W(XexFileName.Text, "4", 0x417AC0, W4_HK.Text);
            Write_W(XexFileName.Text, "5", 0x417AC8, W5_HK.Text);
            Write_W(XexFileName.Text, "6", 0x417AD0, W6_HK.Text);
            Write_W(XexFileName.Text, "7", 0x417AD8, W7_HK.Text);
            Write_W(XexFileName.Text, "8", 0x417AE0, W8_HK.Text);

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
        public void Write_W(string Xex, string WeaponSlot, int WeaponOffset, string WeaponText)
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

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                Export_Weapons();
                General.Message("Weapon Sets Exported Successfully!");
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_All_Weapons();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Edit_Xex();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
    }
}
