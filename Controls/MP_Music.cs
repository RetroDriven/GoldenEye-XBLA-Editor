using Guna.UI2.WinForms;
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
using static System.Windows.Forms.DataFormats;

namespace GoldenEye_XBLA_Editor.Controls
{
    public partial class MP_Music : UserControl
    {
        public CultureInfo resourceCulture;

        public MP_Music()
        {
            InitializeComponent();
            General.Cleanup();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Cleanup
                General.Cleanup();

                //Checks and Errors
                if (String.IsNullOrEmpty(XexFileName.Text))
                {
                    MessageBox.Show("Please Select Xex File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (String.IsNullOrEmpty(Unique_Name.Text))
                {
                    MessageBox.Show("Please Enter Unique Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Write Tracks
                    Class_Music.Write_Tracks(XexFileName.Text, Track_1.Text, 0xDE1AF1);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_2.Text, 0xDE1AF3);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_3.Text, 0xDE1AF5);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_4.Text, 0xDE1AF7);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_5.Text, 0xDE1AF9);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_6.Text, 0xDE1AFB);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_7.Text, 0xDE1AFD);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_8.Text, 0xDE1AFF);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_9.Text, 0xDE1B01);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_10.Text, 0xDE1B03);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_11.Text, 0xDE1B05);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_12.Text, 0xDE1B07);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_13.Text, 0xDE1B09);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_14.Text, 0xDE1B0B);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_15.Text, 0xDE1B0D);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_16.Text, 0xDE1B0F);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_17.Text, 0xDE1B11);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_18.Text, 0xDE1B13);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_19.Text, 0xDE1B15);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_20.Text, 0xDE1B17);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_21.Text, 0xDE1B19);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_22.Text, 0xDE1B1B);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_23.Text, 0xDE1B1D);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_24.Text, 0xDE1B1F);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_25.Text, 0xDE1B21);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_26.Text, 0xDE1B23);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_27.Text, 0xDE1B25);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_28.Text, 0xDE1B27);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_29.Text, 0xDE1B29);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_30.Text, 0xDE1B2B);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_31.Text, 0xDE1B2D);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_32.Text, 0xDE1B2F);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_33.Text, 0xDE1B31);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_34.Text, 0xDE1B33);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_35.Text, 0xDE1B35);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_36.Text, 0xDE1B37);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_37.Text, 0xDE1B39);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_38.Text, 0xDE1B3B);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_39.Text, 0xDE1B3D);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_40.Text, 0xDE1B3F);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_41.Text, 0xDE1B41);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_42.Text, 0xDE1B43);
                    Class_Music.Write_Tracks(XexFileName.Text, Track_43.Text, 0xDE1B45);


                    //Write Unique ID
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
                        writer.Close();
                        writer.Dispose();
                    }

                    //Get Xextool
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

                    //Sign Xex File
                    string XexTool = $"/C {Xextool} -md \"{XexFileName.Text}\"";
                    System.Diagnostics.Process SignXex = new System.Diagnostics.Process();
                    SignXex.StartInfo.FileName = "cmd.exe";
                    SignXex.StartInfo.Arguments = XexTool;
                    SignXex.Start();
                    SignXex.WaitForExit();

                    //Success
                    General.Cleanup();
                    General.Message("Music Tracks Updated Successfully!");
                }

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
                Track_1.SelectedItem = "Train Theme";
                Track_2.SelectedItem = "Depot Theme";
                Track_3.SelectedItem = "Jungle Theme";
                Track_4.SelectedItem = "Citadel Theme";
                Track_5.SelectedItem = "Facility Theme";
                Track_6.SelectedItem = "Control Theme";
                Track_7.SelectedItem = "Dam Theme";
                Track_8.SelectedItem = "Frigate Theme";
                Track_9.SelectedItem = "Archives Theme";
                Track_10.SelectedItem = "Silo Theme";
                Track_11.SelectedItem = "Jungle Theme(Perimeter)";
                Track_12.SelectedItem = "Streets Theme";
                Track_13.SelectedItem = "Bunker 1 Theme";
                Track_14.SelectedItem = "Bunker 2 Theme";
                Track_15.SelectedItem = "Statue Theme";
                Track_16.SelectedItem = "Elevator Music(Control)";
                Track_17.SelectedItem = "Cradle Theme";
                Track_18.SelectedItem = "Elevator Music(Caverns)";
                Track_19.SelectedItem = "Egyptian Theme";
                Track_20.SelectedItem = "Aztec Theme";
                Track_21.SelectedItem = "Caverns Theme";
                Track_22.SelectedItem = "Surface 2 Theme";
                Track_23.SelectedItem = "Train X Theme";
                Track_24.SelectedItem = "Facility X Track";
                Track_25.SelectedItem = "Depot X Track";
                Track_26.SelectedItem = "Control X Track";
                Track_27.SelectedItem = "Caverns X Track";
                Track_28.SelectedItem = "Dam X Track";
                Track_29.SelectedItem = "Frigate X Track";
                Track_30.SelectedItem = "Archives X Track";
                Track_31.SelectedItem = "Silo X Track";
                Track_32.SelectedItem = "Streets X Track";
                Track_33.SelectedItem = "Bunker 1 X Track";
                Track_34.SelectedItem = "Bunker 2 X Track";
                Track_35.SelectedItem = "Jungle X Track";
                Track_36.SelectedItem = "Statue X Track";
                Track_37.SelectedItem = "Aztec X Track";
                Track_38.SelectedItem = "Egyptian X Track";
                Track_39.SelectedItem = "Cradle X Track";
                Track_40.SelectedItem = "Runway Theme";
                Track_41.SelectedItem = "Surface 2 X Track";
                Track_42.SelectedItem = "Runway X Track";
                Track_43.SelectedItem = "Surface 1 Theme";
                //Class_Music.Reset_Tracks();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            try
            {
                Import_Tracks();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        private void guna2ComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Import_Tracks()
        {
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

                                var cb = this.Controls.Find($"Track_{i}", true)
                                  .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                  .FirstOrDefault(); if (cb != null)
                                {
                                    cb.SelectedItem = Track_Name;
                                }
                            }
                        }
                    }
                }
            }
            //Success
            General.Message("Music Tracks Imported Successfully!");

        }
        private void btnBrowse_Click(object sender, EventArgs e)
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

                        //Read Only file handling
                        FileInfo fileInfo = new FileInfo(XexFileName.Text);
                        if (fileInfo.IsReadOnly)
                        {
                            MessageBox.Show("Xex file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            XexFileName.Text = "";
                        }
                        else
                        {
                            //Enable Controls
                            Unique_Name.Enabled = true;
                            btnEdit.Enabled = true;
                            Reset.Enabled = true;
                            Import.Enabled = true;
                            Export.Enabled = true;

                            //Get Unique ID and display it
                            byte[] data = new byte[22];
                            using (FileStream fs = new FileStream(XexFileName.Text, FileMode.Open))
                            {
                                fs.Position = 7452;
                                fs.Read(data, 0, 22);
                                String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));

                                var bytes = new byte[UniqueName.Length / 2];
                                for (var i = 0; i < bytes.Length; i++)
                                {
                                    bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                    Unique_Name.Text = Encoding.UTF8.GetString(bytes);
                                }
                                fs.Close();
                                fs.Dispose();
                            }

                            //Get Tracks from Xex
                            Get_Tracks(XexFileName.Text, 1, 0xDE1AF1);
                            Get_Tracks(XexFileName.Text, 2, 0xDE1AF3);
                            Get_Tracks(XexFileName.Text, 3, 0xDE1AF5);
                            Get_Tracks(XexFileName.Text, 4, 0xDE1AF7);
                            Get_Tracks(XexFileName.Text, 5, 0xDE1AF9);
                            Get_Tracks(XexFileName.Text, 6, 0xDE1AFB);
                            Get_Tracks(XexFileName.Text, 7, 0xDE1AFD);
                            Get_Tracks(XexFileName.Text, 8, 0xDE1AFF);
                            Get_Tracks(XexFileName.Text, 9, 0xDE1B01);
                            Get_Tracks(XexFileName.Text, 10, 0xDE1B03);
                            Get_Tracks(XexFileName.Text, 11, 0xDE1B05);
                            Get_Tracks(XexFileName.Text, 12, 0xDE1B07);
                            Get_Tracks(XexFileName.Text, 13, 0xDE1B09);
                            Get_Tracks(XexFileName.Text, 14, 0xDE1B0B);
                            Get_Tracks(XexFileName.Text, 15, 0xDE1B0D);
                            Get_Tracks(XexFileName.Text, 16, 0xDE1B0F);
                            Get_Tracks(XexFileName.Text, 17, 0xDE1B11);
                            Get_Tracks(XexFileName.Text, 18, 0xDE1B13);
                            Get_Tracks(XexFileName.Text, 19, 0xDE1B15);
                            Get_Tracks(XexFileName.Text, 20, 0xDE1B17);
                            Get_Tracks(XexFileName.Text, 21, 0xDE1B19);
                            Get_Tracks(XexFileName.Text, 22, 0xDE1B1B);
                            Get_Tracks(XexFileName.Text, 23, 0xDE1B1D);
                            Get_Tracks(XexFileName.Text, 24, 0xDE1B1F);
                            Get_Tracks(XexFileName.Text, 25, 0xDE1B21);
                            Get_Tracks(XexFileName.Text, 26, 0xDE1B23);
                            Get_Tracks(XexFileName.Text, 27, 0xDE1B25);
                            Get_Tracks(XexFileName.Text, 28, 0xDE1B27);
                            Get_Tracks(XexFileName.Text, 29, 0xDE1B29);
                            Get_Tracks(XexFileName.Text, 30, 0xDE1B2B);
                            Get_Tracks(XexFileName.Text, 31, 0xDE1B2D);
                            Get_Tracks(XexFileName.Text, 32, 0xDE1B2F);
                            Get_Tracks(XexFileName.Text, 33, 0xDE1B31);
                            Get_Tracks(XexFileName.Text, 34, 0xDE1B33);
                            Get_Tracks(XexFileName.Text, 35, 0xDE1B35);
                            Get_Tracks(XexFileName.Text, 36, 0xDE1B37);
                            Get_Tracks(XexFileName.Text, 37, 0xDE1B39);
                            Get_Tracks(XexFileName.Text, 38, 0xDE1B3B);
                            Get_Tracks(XexFileName.Text, 39, 0xDE1B3D);
                            Get_Tracks(XexFileName.Text, 40, 0xDE1B3F);
                            Get_Tracks(XexFileName.Text, 41, 0xDE1B41);
                            Get_Tracks(XexFileName.Text, 42, 0xDE1B43);
                            Get_Tracks(XexFileName.Text, 43, 0xDE1B45);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
        public void Get_Tracks(string Xex, int Track_Number, int Offset)
        {
            try
            {

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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
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
                        var cb = this.Controls.Find($"Track_{i}", true)
                                              .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                              .FirstOrDefault(); if (cb != null)
                        {
                            cb.SelectedItem = Track_Name;
                        }
                    }
                }
            }

            reader.Close();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                Export_Tracks();
            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }

        public void Export_Tracks()
        {
            try
            {
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

                                var cb = this.Controls.Find($"Track_{i}", true)
                                .OfType<Guna.UI2.WinForms.Guna2ComboBox>()
                                .FirstOrDefault(); if (cb != null)

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
                General.Message("Music Tracks Exported Successfully!");

            }
            catch (Exception Ex)
            {
                General.Message(Ex.Message.ToString());
            }
        }
    }
}
