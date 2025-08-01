using GoldenEye_XBLA_Editor;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Helpers
{
    public class Class_Injector
    {
        public static void WriteUniqueName(int Offset, string XexFile, string UniqueName)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(XexFile, FileMode.Open, FileAccess.ReadWrite)))
            {
                int offset = Offset; //position you want to start editing
                string trimmed = String.Concat(UniqueName.Where(c => !Char.IsWhiteSpace(c)));
                byte[] new_data = Encoding.ASCII.GetBytes(trimmed);
                byte[] new_data2 = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; //new data
                writer.Seek(offset, SeekOrigin.Begin); //move your cursor to the position
                writer.Write(new_data2);
                writer.Seek(offset, SeekOrigin.Begin);
                writer.Write(new_data);//write it      
            }
        }
        public static void Open_Bin()
        {
            BinFileInjector form1 = (BinFileInjector)Application.OpenForms["BinFileInjector"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //string path = Directory.GetCurrentDirectory();
                //string path = @"C:\";
                //openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "Set Files (*.bin)|*.bin";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //MessageBox.Show(path);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    form1.textBox3.Text = filePath;

                    FileInfo fileInfo = new FileInfo(filePath);

                    if (form1.textBox1.Text != "" && form1.textBox3.Text != "")
                    {
                        form1.textBox2.Enabled = true;
                        form1.textBox4.Enabled = true;
                        form1.btnGo.Enabled = true;
                    }

                    if (fileInfo.IsReadOnly)
                    {
                        MessageBox.Show("Bin file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form1.textBox3.Text = "";
                        form1.textBox2.Enabled = false;
                        form1.textBox4.Enabled = false;
                        form1.btnGo.Enabled = false;
                    }
                    else
                    {

                        form1.textBox3.SelectionStart = form1.textBox3.Text.Length;
                        form1.textBox3.ScrollToCaret();
                        form1.textBox3.Refresh();

                        var file = System.IO.Path.GetFileNameWithoutExtension(filePath);

                        if (file.Contains("_"))
                        {
                            string lastFragment = file.Split('_').Last();
                            form1.textBox4.Text = lastFragment;
                        }
                    }
                }
            }

        }
        public static void Inject_Xex()
        {
            BinFileInjector form1 = (BinFileInjector)Application.OpenForms["BinFileInjector"];

            //Cleanup
            General.Cleanup();

            if (String.IsNullOrEmpty(form1.textBox1.Text))
            {
                MessageBox.Show("Please Select Xex File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.textBox3.Text))
            {
                MessageBox.Show("Please Select Bin File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.textBox2.Text))
            {
                MessageBox.Show("Please Enter Unique Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(form1.textBox4.Text))
            {
                MessageBox.Show("Please Enter Offset Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(form1.textBox1.Text, FileMode.Open, FileAccess.ReadWrite)))
                {

                    int offset = Convert.ToInt32(form1.textBox4.Text, 16); //Convert the Offset Input String to a Decimal Integer
                    byte[] BinFile = System.IO.File.ReadAllBytes(form1.textBox3.Text); //Open Bin file and grab the data
                    writer.Seek(offset, SeekOrigin.Begin); //Goto the Offset
                    writer.Write(BinFile); //Write the data from the Bin file
                }


                WriteUniqueName(7452, form1.textBox1.Text, form1.textBox2.Text);

                //Get Xextool
                System.IO.Directory.CreateDirectory(@"C:\RetroDriven_Temp");
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
                string XexTool = $"/C {Xextool} -md \"{form1.textBox1.Text}\"";
                System.Diagnostics.Process SignXex = new System.Diagnostics.Process();
                SignXex.StartInfo.FileName = "cmd.exe";
                SignXex.StartInfo.Arguments = XexTool;
                SignXex.Start();
                SignXex.WaitForExit();

                General.Cleanup();

                MessageBox.Show("Bin Injection Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public static void Open_Xex()
        {
            BinFileInjector form1 = (BinFileInjector)Application.OpenForms["BinFileInjector"];

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //string path = @"C:\";
                //openFileDialog.InitialDirectory = path;
                openFileDialog.Filter = "Xex Files (*.xex)|*.xex";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //MessageBox.Show(path);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    form1.textBox1.Text = filePath;

                    form1.textBox1.SelectionStart = form1.textBox1.Text.Length;
                    form1.textBox1.ScrollToCaret();
                    form1.textBox1.Refresh();
                    FileInfo fileInfo = new FileInfo(filePath);


                    if (form1.textBox1.Text != "" && form1.textBox3.Text != "")
                    {
                        form1.textBox2.Enabled = true;
                        form1.textBox4.Enabled = true;
                        form1.btnGo.Enabled = true;
                    }

                    if (fileInfo.IsReadOnly)
                    {
                        MessageBox.Show("Xex file is Read Only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        form1.textBox1.Text = "";
                        form1.textBox2.Enabled = false;
                        form1.textBox4.Enabled = false;
                        form1.btnGo.Enabled = false;
                    }
                    else
                    {

                        byte[] data = new byte[22];

                        using (FileStream fs = new FileStream(form1.textBox1.Text, FileMode.Open))
                        {
                            fs.Position = 7452;
                            fs.Read(data, 0, 22);
                            String UniqueName = string.Join("", data.Select(x => x.ToString("X2")));
                            //textBox2.Text = UniqueName;

                            var bytes = new byte[UniqueName.Length / 2];
                            for (var i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] = Convert.ToByte(UniqueName.Substring(i * 2, 2), 16);
                                form1.textBox2.Text = Encoding.UTF8.GetString(bytes);
                            }
                        }

                    }
                }
            }
        }
    }
}
