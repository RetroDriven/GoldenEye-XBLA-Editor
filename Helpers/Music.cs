using GoldenEye_XBLA_Editor;
using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml;

namespace Helpers
{
    public class Class_Music
    {
        public static void Export_Tracks()
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;

                    //Write the XML
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
                    {
                        Indent = true,
                        IndentChars = "\t",
                        NewLineOnAttributes = true

                    };

                    //Write the XML
                    using (XmlWriter w = XmlWriter.Create(filePath, xmlWriterSettings))
                    {
                        //Start of XML
                        w.WriteStartDocument();
                        w.WriteStartElement("Music_Tracks");

                        //Loop through the 43 Tracks
                        for (int i = 1; i <= 43; i++)
                        {
                            string number = i.ToString();
                            w.WriteStartElement("Music_Track");
                            w.WriteAttributeString("Track_Number", number);
                            ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                            if (cb != null)
                            {
                                w.WriteElementString("Track_Name", cb.Text);
                            }
                            w.WriteEndElement();
                        }
                        w.Flush();
                        w.Close();
                    }
                }
            }
            //Success
            MessageBox.Show("Music Tracks Exported Successfully!", "Export Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Import_Tracks()
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Import the XML and set the Tracks
                    var doc = XDocument.Load(filePath);
                    var groups = doc.XPathSelectElements("/Music_Tracks/Music_Track");
                    foreach (var group in groups)
                    {
                        string Track_Number = group.Attribute("Track_Number").Value;

                        //Loop through the 43 tracks
                        for (int i = 1; i <= 43; i++)
                        {
                            string number = i.ToString();
                            if (Track_Number == number)
                            {
                                string Track_Name = group.Element("Track_Name").Value;
                                ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                                if (cb != null)
                                {
                                    cb.SelectedItem = Track_Name;
                                }

                            }
                        }
                    }
                }
            }
            //Success
            MessageBox.Show("Music Tracks Imported Successfully!", "Import Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void Reset_Tracks()
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

            form1.Track_1.SelectedItem = "Train Theme";
            form1.Track_2.SelectedItem = "Depot Theme";
            form1.Track_3.SelectedItem = "Jungle Theme";
            form1.Track_4.SelectedItem = "Citadel Theme";
            form1.Track_5.SelectedItem = "Facility Theme";
            form1.Track_6.SelectedItem = "Control Theme";
            form1.Track_7.SelectedItem = "Dam Theme";
            form1.Track_8.SelectedItem = "Frigate Theme";
            form1.Track_9.SelectedItem = "Archives Theme";
            form1.Track_10.SelectedItem = "Silo Theme";
            form1.Track_11.SelectedItem = "Jungle Theme(Perimeter)";
            form1.Track_12.SelectedItem = "Streets Theme";
            form1.Track_13.SelectedItem = "Bunker 1 Theme";
            form1.Track_14.SelectedItem = "Bunker 2 Theme";
            form1.Track_15.SelectedItem = "Statue Theme";
            form1.Track_16.SelectedItem = "Elevator Music(Control)";
            form1.Track_17.SelectedItem = "Cradle Theme";
            form1.Track_18.SelectedItem = "Elevator Music(Caverns)";
            form1.Track_19.SelectedItem = "Egyptian Theme";
            form1.Track_20.SelectedItem = "Aztec Theme";
            form1.Track_21.SelectedItem = "Caverns Theme";
            form1.Track_22.SelectedItem = "Surface 2 Theme";
            form1.Track_23.SelectedItem = "Train X Theme";
            form1.Track_24.SelectedItem = "Facility X Track";
            form1.Track_25.SelectedItem = "Depot X Track";
            form1.Track_26.SelectedItem = "Control X Track";
            form1.Track_27.SelectedItem = "Caverns X Track";
            form1.Track_28.SelectedItem = "Dam X Track";
            form1.Track_29.SelectedItem = "Frigate X Track";
            form1.Track_30.SelectedItem = "Archives X Track";
            form1.Track_31.SelectedItem = "Silo X Track";
            form1.Track_32.SelectedItem = "Streets X Track";
            form1.Track_33.SelectedItem = "Bunker 1 X Track";
            form1.Track_34.SelectedItem = "Bunker 2 X Track";
            form1.Track_35.SelectedItem = "Jungle X Track";
            form1.Track_36.SelectedItem = "Statue X Track";
            form1.Track_37.SelectedItem = "Aztec X Track";
            form1.Track_38.SelectedItem = "Egyptian X Track";
            form1.Track_39.SelectedItem = "Cradle X Track";
            form1.Track_40.SelectedItem = "Runway Theme";
            form1.Track_41.SelectedItem = "Surface 2 X Track";
            form1.Track_42.SelectedItem = "Runway X Track";
            form1.Track_43.SelectedItem = "Surface 1 Theme";
        }
        private static void Write_Tracks(string Xex, string Track_Name, int Offset)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(Xex, FileMode.Open, FileAccess.ReadWrite)))
            {
                //Get Track ID
                string Weapon_ID = Class_Music.TrackName_To_ID(Track_Name);

                byte[] data = new byte[Weapon_ID.Length / 2];
                for (int i = 0; i < Weapon_ID.Length; i += 2)
                    data[i / 2] = Convert.ToByte(Weapon_ID.Substring(i, 2), 16);
                writer.Seek(Offset, SeekOrigin.Begin);
                writer.Write(data);
                writer.Close();
                writer.Dispose();
            }
        }
        public static void Edit_Xex()
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

            //Cleanup
            General.Cleanup();

            //Checks and Errors
            if (String.IsNullOrEmpty(form1.XexFileName.Text))
            {
                MessageBox.Show("Please Select Xex File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (String.IsNullOrEmpty(form1.Unique_Name.Text))
            {
                MessageBox.Show("Please Enter Unique Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Write Tracks
                Write_Tracks(form1.XexFileName.Text, form1.Track_1.Text, 0xDE1AF1);
                Write_Tracks(form1.XexFileName.Text, form1.Track_2.Text, 0xDE1AF3);
                Write_Tracks(form1.XexFileName.Text, form1.Track_3.Text, 0xDE1AF5);
                Write_Tracks(form1.XexFileName.Text, form1.Track_4.Text, 0xDE1AF7);
                Write_Tracks(form1.XexFileName.Text, form1.Track_5.Text, 0xDE1AF9);
                Write_Tracks(form1.XexFileName.Text, form1.Track_6.Text, 0xDE1AFB);
                Write_Tracks(form1.XexFileName.Text, form1.Track_7.Text, 0xDE1AFD);
                Write_Tracks(form1.XexFileName.Text, form1.Track_8.Text, 0xDE1AFF);
                Write_Tracks(form1.XexFileName.Text, form1.Track_9.Text, 0xDE1B01);
                Write_Tracks(form1.XexFileName.Text, form1.Track_10.Text, 0xDE1B03);
                Write_Tracks(form1.XexFileName.Text, form1.Track_11.Text, 0xDE1B05);
                Write_Tracks(form1.XexFileName.Text, form1.Track_12.Text, 0xDE1B07);
                Write_Tracks(form1.XexFileName.Text, form1.Track_13.Text, 0xDE1B09);
                Write_Tracks(form1.XexFileName.Text, form1.Track_14.Text, 0xDE1B0B);
                Write_Tracks(form1.XexFileName.Text, form1.Track_15.Text, 0xDE1B0D);
                Write_Tracks(form1.XexFileName.Text, form1.Track_16.Text, 0xDE1B0F);
                Write_Tracks(form1.XexFileName.Text, form1.Track_17.Text, 0xDE1B11);
                Write_Tracks(form1.XexFileName.Text, form1.Track_18.Text, 0xDE1B13);
                Write_Tracks(form1.XexFileName.Text, form1.Track_19.Text, 0xDE1B15);
                Write_Tracks(form1.XexFileName.Text, form1.Track_20.Text, 0xDE1B17);
                Write_Tracks(form1.XexFileName.Text, form1.Track_21.Text, 0xDE1B19);
                Write_Tracks(form1.XexFileName.Text, form1.Track_22.Text, 0xDE1B1B);
                Write_Tracks(form1.XexFileName.Text, form1.Track_23.Text, 0xDE1B1D);
                Write_Tracks(form1.XexFileName.Text, form1.Track_24.Text, 0xDE1B1F);
                Write_Tracks(form1.XexFileName.Text, form1.Track_25.Text, 0xDE1B21);
                Write_Tracks(form1.XexFileName.Text, form1.Track_26.Text, 0xDE1B23);
                Write_Tracks(form1.XexFileName.Text, form1.Track_27.Text, 0xDE1B25);
                Write_Tracks(form1.XexFileName.Text, form1.Track_28.Text, 0xDE1B27);
                Write_Tracks(form1.XexFileName.Text, form1.Track_29.Text, 0xDE1B29);
                Write_Tracks(form1.XexFileName.Text, form1.Track_30.Text, 0xDE1B2B);
                Write_Tracks(form1.XexFileName.Text, form1.Track_31.Text, 0xDE1B2D);
                Write_Tracks(form1.XexFileName.Text, form1.Track_32.Text, 0xDE1B2F);
                Write_Tracks(form1.XexFileName.Text, form1.Track_33.Text, 0xDE1B31);
                Write_Tracks(form1.XexFileName.Text, form1.Track_34.Text, 0xDE1B33);
                Write_Tracks(form1.XexFileName.Text, form1.Track_35.Text, 0xDE1B35);
                Write_Tracks(form1.XexFileName.Text, form1.Track_36.Text, 0xDE1B37);
                Write_Tracks(form1.XexFileName.Text, form1.Track_37.Text, 0xDE1B39);
                Write_Tracks(form1.XexFileName.Text, form1.Track_38.Text, 0xDE1B3B);
                Write_Tracks(form1.XexFileName.Text, form1.Track_39.Text, 0xDE1B3D);
                Write_Tracks(form1.XexFileName.Text, form1.Track_40.Text, 0xDE1B3F);
                Write_Tracks(form1.XexFileName.Text, form1.Track_41.Text, 0xDE1B41);
                Write_Tracks(form1.XexFileName.Text, form1.Track_42.Text, 0xDE1B43);
                Write_Tracks(form1.XexFileName.Text, form1.Track_43.Text, 0xDE1B45);


                //Write Unique ID
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
                    writer.Close();
                    writer.Dispose();
                }

                //Get Xextool
                Directory.CreateDirectory(@"C:\RetroDriven_Temp");
                string Xextool = @"C:\RetroDriven_Temp\xextool.exe";
                object ob2 = Resource1.ResourceManager.GetObject("xextool", form1.resourceCulture);
                byte[] myResBytes2 = (byte[])ob2;
                using (FileStream fsDst2 = new FileStream(Xextool, FileMode.CreateNew))
                {
                    byte[] bytes2 = myResBytes2;
                    fsDst2.Write(bytes2, 0, bytes2.Length);
                    fsDst2.Close();
                    fsDst2.Dispose();
                }

                //Sign Xex File
                string XexTool = $"/C {Xextool} -md \"{form1.XexFileName.Text}\"";
                System.Diagnostics.Process SignXex = new System.Diagnostics.Process();
                SignXex.StartInfo.FileName = "cmd.exe";
                SignXex.StartInfo.Arguments = XexTool;
                SignXex.Start();
                SignXex.WaitForExit();

                //Success
                General.Cleanup();
                MessageBox.Show("Music Tracks Updated Successfully!", "Xex File Written", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        public static void Open_Xex()
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

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

                    //Read Only file handling
                    FileInfo fileInfo = new FileInfo(form1.XexFileName.Text);
                    if (fileInfo.IsReadOnly)
                    {
                        MessageBox.Show("Xex file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form1.XexFileName.Text = "";
                    }
                    else
                    {
                        //Enable Controls
                        form1.Unique_Name.Enabled = true;
                        form1.menuStrip1.Enabled = true;
                        form1.btnEdit.Enabled = true;
                        form1.tabControl1.Enabled = true;

                        //Get Unique ID and display it
                        byte[] data = new byte[22];
                        using (FileStream fs = new FileStream(form1.XexFileName.Text, FileMode.Open))
                        {
                            fs.Position = 7452;
                            fs.Read(data, 0, 22);
                            String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));

                            var bytes = new byte[UniqueName.Length / 2];
                            for (var i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                form1.Unique_Name.Text = Encoding.UTF8.GetString(bytes);
                            }
                            fs.Close();
                            fs.Dispose();
                        }

                        //Get Tracks from Xex
                        Get_Tracks(form1.XexFileName.Text, 1, 0xDE1AF1);
                        Get_Tracks(form1.XexFileName.Text, 2, 0xDE1AF3);
                        Get_Tracks(form1.XexFileName.Text, 3, 0xDE1AF5);
                        Get_Tracks(form1.XexFileName.Text, 4, 0xDE1AF7);
                        Get_Tracks(form1.XexFileName.Text, 5, 0xDE1AF9);
                        Get_Tracks(form1.XexFileName.Text, 6, 0xDE1AFB);
                        Get_Tracks(form1.XexFileName.Text, 7, 0xDE1AFD);
                        Get_Tracks(form1.XexFileName.Text, 8, 0xDE1AFF);
                        Get_Tracks(form1.XexFileName.Text, 9, 0xDE1B01);
                        Get_Tracks(form1.XexFileName.Text, 10, 0xDE1B03);
                        Get_Tracks(form1.XexFileName.Text, 11, 0xDE1B05);
                        Get_Tracks(form1.XexFileName.Text, 12, 0xDE1B07);
                        Get_Tracks(form1.XexFileName.Text, 13, 0xDE1B09);
                        Get_Tracks(form1.XexFileName.Text, 14, 0xDE1B0B);
                        Get_Tracks(form1.XexFileName.Text, 15, 0xDE1B0D);
                        Get_Tracks(form1.XexFileName.Text, 16, 0xDE1B0F);
                        Get_Tracks(form1.XexFileName.Text, 17, 0xDE1B11);
                        Get_Tracks(form1.XexFileName.Text, 18, 0xDE1B13);
                        Get_Tracks(form1.XexFileName.Text, 19, 0xDE1B15);
                        Get_Tracks(form1.XexFileName.Text, 20, 0xDE1B17);
                        Get_Tracks(form1.XexFileName.Text, 21, 0xDE1B19);
                        Get_Tracks(form1.XexFileName.Text, 22, 0xDE1B1B);
                        Get_Tracks(form1.XexFileName.Text, 23, 0xDE1B1D);
                        Get_Tracks(form1.XexFileName.Text, 24, 0xDE1B1F);
                        Get_Tracks(form1.XexFileName.Text, 25, 0xDE1B21);
                        Get_Tracks(form1.XexFileName.Text, 26, 0xDE1B23);
                        Get_Tracks(form1.XexFileName.Text, 27, 0xDE1B25);
                        Get_Tracks(form1.XexFileName.Text, 28, 0xDE1B27);
                        Get_Tracks(form1.XexFileName.Text, 29, 0xDE1B29);
                        Get_Tracks(form1.XexFileName.Text, 30, 0xDE1B2B);
                        Get_Tracks(form1.XexFileName.Text, 31, 0xDE1B2D);
                        Get_Tracks(form1.XexFileName.Text, 32, 0xDE1B2F);
                        Get_Tracks(form1.XexFileName.Text, 33, 0xDE1B31);
                        Get_Tracks(form1.XexFileName.Text, 34, 0xDE1B33);
                        Get_Tracks(form1.XexFileName.Text, 35, 0xDE1B35);
                        Get_Tracks(form1.XexFileName.Text, 36, 0xDE1B37);
                        Get_Tracks(form1.XexFileName.Text, 37, 0xDE1B39);
                        Get_Tracks(form1.XexFileName.Text, 38, 0xDE1B3B);
                        Get_Tracks(form1.XexFileName.Text, 39, 0xDE1B3D);
                        Get_Tracks(form1.XexFileName.Text, 40, 0xDE1B3F);
                        Get_Tracks(form1.XexFileName.Text, 41, 0xDE1B41);
                        Get_Tracks(form1.XexFileName.Text, 42, 0xDE1B43);
                        Get_Tracks(form1.XexFileName.Text, 43, 0xDE1B45);
                    }
                }
            }
        }
        public static void Get_Tracks(string Xex, int Track_Number, int Offset)
        {
            MPMusic form1 = (MPMusic)Application.OpenForms["MPMusic"];

            BinaryReader reader = new BinaryReader(new FileStream(Xex, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = Offset;
            byte[] data = reader.ReadBytes(0x1);
            string Track_ID = BitConverter.ToString(data);

            //Get Track Name
            String Track_Name = Class_Music.TrackID_To_Name(Track_ID);

            //Main Intro Theme
            if (Track_ID == "02")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Train Theme
            if (Track_ID == "03")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Depot Theme
            if (Track_ID == "04")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Jungle Theme
            if (Track_ID == "05")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Citadel Theme
            if (Track_ID == "06")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Facility Theme
            if (Track_ID == "07")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Control Theme
            if (Track_ID == "08")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Dam Theme
            if (Track_ID == "09")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Frigate Theme
            if (Track_ID == "0A")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Archives Theme
            if (Track_ID == "0B")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Silo Theme
            if (Track_ID == "0C")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Jungle Perimeter
            if (Track_ID == "0D")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Streets Theme
            if (Track_ID == "0E")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Bunker 1 Theme
            if (Track_ID == "0F")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Bunker 2 Theme
            if (Track_ID == "10")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Statue
            if (Track_ID == "11")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Elevator Music Control
            if (Track_ID == "12")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Cradle Theme
            if (Track_ID == "13")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Elevator Music Caverns
            if (Track_ID == "15")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Egyptian Theme
            if (Track_ID == "16")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Mission Select Theme
            if (Track_ID == "17")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Watch Theme
            if (Track_ID == "18")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Aztec Theme
            if (Track_ID == "19")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Caverns Theme
            if (Track_ID == "1A")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Surface 2 Theme
            if (Track_ID == "1C")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Train X Track
            if (Track_ID == "1D")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Facility X Track
            if (Track_ID == "1F")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Depot X Track
            if (Track_ID == "20")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Control X Track
            if (Track_ID == "21")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Caverns X Track
            if (Track_ID == "22")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Dam X Track
            if (Track_ID == "23")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Frigate X Track
            if (Track_ID == "24")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Archives X Track
            if (Track_ID == "25")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Silo X Track
            if (Track_ID == "26")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Streets X Track
            if (Track_ID == "28")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Bunker 1 X Track
            if (Track_ID == "29")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Bunker 2 X Track
            if (Track_ID == "2A")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Jungle X Track
            if (Track_ID == "2B")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Statue X Track
            if (Track_ID == "2D")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Aztec X Track
            if (Track_ID == "2E")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Egyptian X Track
            if (Track_ID == "2F")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Cradle X Track
            if (Track_ID == "30")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Cuba Theme
            if (Track_ID == "31")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Runway Theme
            if (Track_ID == "32")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Surface 2 X Track
            if (Track_ID == "34")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Runway X Track
            if (Track_ID == "38")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            //Surface 1 Theme
            if (Track_ID == "39")
            {
                for (int i = 1; i <= 43; i++)
                {
                    string number = i.ToString();
                    if (Track_Number == i)
                    {
                        ComboBox cb = form1.Controls.Find("Track_" + i, true).FirstOrDefault() as ComboBox;
                        if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            reader.Close();

        }

        public static string TrackName_To_ID(string Track_Name)
        {
            if (Track_Name == "Main Intro Theme")
            {
                return "02";
            }
            if (Track_Name == "Train Theme")
            {
                return "03";
            }
            if (Track_Name == "Depot Theme")
            {
                return "04";
            }
            if (Track_Name == "Jungle Theme")
            {
                return "05";
            }
            if (Track_Name == "Citadel Theme")
            {
                return "06";
            }
            if (Track_Name == "Facility Theme")
            {
                return "07";
            }
            if (Track_Name == "Control Theme")
            {
                return "08";
            }
            if (Track_Name == "Dam Theme")
            {
                return "09";
            }
            if (Track_Name == "Frigate Theme")
            {
                return "0A";
            }
            if (Track_Name == "Archives Theme")
            {
                return "0B";
            }
            if (Track_Name == "Silo Theme")
            {
                return "0C";
            }
            if (Track_Name == "Jungle Theme(Perimeter)")
            {
                return "0D";
            }
            if (Track_Name == "Streets Theme")
            {
                return "0E";
            }
            if (Track_Name == "Bunker 1 Theme")
            {
                return "0F";
            }
            if (Track_Name == "Bunker 2 Theme")
            {
                return "10";
            }
            if (Track_Name == "Statue Theme")
            {
                return "11";
            }
            if (Track_Name == "Elevator Music(Control)")
            {
                return "12";
            }
            if (Track_Name == "Cradle Theme")
            {
                return "13";
            }
            if (Track_Name == "Elevator Music(Caverns)")
            {
                return "15";
            }
            if (Track_Name == "Egyptian Theme")
            {
                return "16";
            }
            if (Track_Name == "Mission Select Theme")
            {
                return "17";
            }
            if (Track_Name == "Watch Menu")
            {
                return "18";
            }
            if (Track_Name == "Aztec Theme")
            {
                return "19";
            }
            if (Track_Name == "Caverns Theme")
            {
                return "1A";
            }
            if (Track_Name == "Surface 2 Theme")
            {
                return "1C";
            }
            if (Track_Name == "Train X Track")
            {
                return "1D";
            }
            if (Track_Name == "Facility X Track")
            {
                return "1F";
            }
            if (Track_Name == "Depot X Track")
            {
                return "20";
            }
            if (Track_Name == "Control X Track")
            {
                return "21";
            }
            if (Track_Name == "Caverns X Track")
            {
                return "22";
            }
            if (Track_Name == "Dam X Track")
            {
                return "23";
            }
            if (Track_Name == "Frigate X Track")
            {
                return "24";
            }
            if (Track_Name == "Archives X Track")
            {
                return "25";
            }
            if (Track_Name == "Silo X Track")
            {
                return "26";
            }
            if (Track_Name == "Streets X Track")
            {
                return "28";
            }
            if (Track_Name == "Bunker 1 X Track")
            {
                return "29";
            }
            if (Track_Name == "Bunker 2 X Track")
            {
                return "2A";
            }
            if (Track_Name == "Jungle X Track")
            {
                return "2B";
            }
            if (Track_Name == "Statue X Track")
            {
                return "2D";
            }
            if (Track_Name == "Aztec X Track")
            {
                return "2E";
            }
            if (Track_Name == "Egyptian X Track")
            {
                return "2F";
            }
            if (Track_Name == "Cradle X Track")
            {
                return "30";
            }
            if (Track_Name == "Cuba Theme(Credits)")
            {
                return "31";
            }
            if (Track_Name == "Runway Theme")
            {
                return "32";
            }
            if (Track_Name == "Surface 2 X Track")
            {
                return "34";
            }
            if (Track_Name == "Runway X Track")
            {
                return "38";
            }
            if (Track_Name == "Surface 1 Theme")
            {
                return "39";
            }
            else
            {
                return "";
            }
        }

        public static string TrackID_To_Name(string TrackID)
        {
            if (TrackID == "02")
            {
                return "Main Intro Theme";
            }
            if (TrackID == "03")
            {
                return "Train Theme";
            }
            if (TrackID == "04")
            {
                return "Depot Theme";
            }
            if (TrackID == "05")
            {
                return "Jungle Theme";
            }
            if (TrackID == "06")
            {
                return "Citadel Theme";
            }
            if (TrackID == "07")
            {
                return "Facility Theme";
            }
            if (TrackID == "08")
            {
                return "Control Theme";
            }
            if (TrackID == "09")
            {
                return "Dam Theme";
            }
            if (TrackID == "0A")
            {
                return "Frigate Theme";
            }
            if (TrackID == "0B")
            {
                return "Archives Theme";
            }
            if (TrackID == "0C")
            {
                return "Silo Theme";
            }
            if (TrackID == "0D")
            {
                return "Jungle Theme(Perimeter)";
            }
            if (TrackID == "0E")
            {
                return "Streets Theme";
            }
            if (TrackID == "0F")
            {
                return "Bunker 1 Theme";
            }
            if (TrackID == "10")
            {
                return "Bunker 2 Theme";
            }
            if (TrackID == "11")
            {
                return "Statue Theme";
            }
            if (TrackID == "12")
            {
                return "Elevator Music(Control)";
            }
            if (TrackID == "13")
            {
                return "Cradle Theme";
            }
            if (TrackID == "15")
            {
                return "Elevator Music(Caverns)";
            }
            if (TrackID == "16")
            {
                return "Egyptian Theme";
            }
            if (TrackID == "17")
            {
                return "Mission Select Theme";
            }
            if (TrackID == "18")
            {
                return "Watch Menu";
            }
            if (TrackID == "19")
            {
                return "Aztec Theme";
            }
            if (TrackID == "1A")
            {
                return "Caverns Theme";
            }
            if (TrackID == "1C")
            {
                return "Surface 2 Theme";
            }
            if (TrackID == "1D")
            {
                return "Train X Track";
            }
            if (TrackID == "1F")
            {
                return "Facility X Track";
            }
            if (TrackID == "20")
            {
                return "Depot X Track";
            }
            if (TrackID == "21")
            {
                return "Control X Track";
            }
            if (TrackID == "22")
            {
                return "Caverns X Track";
            }
            if (TrackID == "23")
            {
                return "Dam X Track";
            }
            if (TrackID == "24")
            {
                return "Frigate X Track";
            }
            if (TrackID == "25")
            {
                return "Archives X Track";
            }
            if (TrackID == "26")
            {
                return "Silo X Track";
            }
            if (TrackID == "28")
            {
                return "Streets X Track";
            }
            if (TrackID == "29")
            {
                return "Bunker 1 X Track";
            }
            if (TrackID == "2A")
            {
                return "Bunker 2 X Track";
            }
            if (TrackID == "2B")
            {
                return "Jungle X Track";
            }
            if (TrackID == "2D")
            {
                return "Statue X Track";
            }
            if (TrackID == "2E")
            {
                return "Aztec X Track";
            }
            if (TrackID == "2F")
            {
                return "Egyptian X Track";
            }
            if (TrackID == "30")
            {
                return "Cradle X Track";
            }
            if (TrackID == "31")
            {
                return "Cuba Theme(Credits)";
            }
            if (TrackID == "32")
            {
                return "Runway Theme";
            }
            if (TrackID == "34")
            {
                return "Surface 2 X Track";
            }
            if (TrackID == "38")
            {
                return "Runway X Track";
            }
            if (TrackID == "39")
            {
                return "Surface 1 Theme";
            }
            else
            {
                return "";
            }
        }
    }
}
