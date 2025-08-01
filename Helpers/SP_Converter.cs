using GoldenEye_XBLA_Editor;
using GoldenEye_XBLA_Editor.Controls;
using System.Diagnostics;
using System.Globalization;

namespace Helpers
{
    public class Class_SP_Converter
    {
        //Define Public Variables
        public static string Stock_Map_Size { get; set; }
        public static string SP_Offset { get; set; }
        public static string SP_Value { get; set; }
        public static string MP_Offset { get; set; }
        public static string MP_Value { get; set; }
        public static string Offset { get; set; }
        public static string Setup_Value { get; set; }
        public static string Name_Offset { get; set; }
        public static string Name_Value { get; set; }
        public static string Level_ID { get; set; }
        public static string Map { get; set; }
        public static string Level_ID_Offset { get; set; }
        
        public static CultureInfo resourceCulture;
        public static string TempBin = @"C:\RetroDriven_Temp\Temp.bin";
        public static void SP_Maps(string Map_Name)
        {
            //Archives
            if (Map_Name == "Archives")
            {
                SP_Offset = "84B088";
                SP_Value = "82CA1480";
                MP_Offset = "84B08C";
                //MP_Value = "82DC8640";
                MP_Value = "00000000";
                Offset = "C7DF38";
                Setup_Value = "82C8AF38";
                Name_Offset = "71EA20";
                Name_Value = "9CA89CA9";
                Level_ID = "18";
                Level_ID_Offset = "71EA2B";
                Map = "Archives";
                Stock_Map_Size = "1658F";
            }
            //Aztec
            else if (Map_Name == "Aztec")
            {
                SP_Offset = "84B168";
                SP_Value = "82CD9988";
                MP_Offset = "84B16C";
                MP_Value = "00000000";
                Offset = "CBB4B8";
                Setup_Value = "82CC84B8";
                Name_Value = "9C969C96";
                Level_ID = "1C";
                Map = "Aztec";
                Stock_Map_Size = "11517";
            }
            //Basement
            else if (Map_Name == "Basement")
            {
                SP_Offset = "84B520";
                SP_Value = "00000000";
                MP_Offset = "84B524";
                //MP_Value = "82DE39A0";
                MP_Value = "00000000";
                Offset = "DD4A20";
                Setup_Value = "82DE1A20";
                Name_Offset = "71E990";
                Name_Value = "9D0D9D0E";
                Level_ID = "2D";
                Level_ID_Offset = "71E99B";
                Map = "Basement";
                Stock_Map_Size = "1FC7";
            }
            //Bunker 1
            else if (Map_Name == "Bunker 1")
            {
                SP_Offset = "84B130";
                SP_Value = "82D74C10";
                MP_Offset = "84B134";
                //MP_Value = "82DECF18";
                MP_Value = "00000000";
                Offset = "D4F280";
                Setup_Value = "82D5C280";
                Name_Offset = "71EA08";
                Name_Value = "9CA69CA7";
                Level_ID = "09";
                Level_ID_Offset = "71EA13";
                Map = "Bunker1";
                Stock_Map_Size = "9787";
            }
            //Bunker 2
            else if (Map_Name == "Bunker 2")
            {
                SP_Offset = "84B130";
                SP_Value = "82D74C10";
                MP_Offset = "84B134";
                //MP_Value = "82DECF18";
                MP_Value = "00000000";
                Offset = "D58A08";
                Setup_Value = "82D65A08";
                Name_Offset = "71EA08";
                Name_Value = "9CA69CA7";
                Level_ID = "1B";
                Level_ID_Offset = "71EA13";
                Map = "Bunker2";
                Stock_Map_Size = "F24F";
            }
            //Caverns
            else if (Map_Name == "Caverns")
            {
                SP_Offset = "84B3D0";
                SP_Value = "82CEF420";
                MP_Offset = "84B3D4";
                //MP_Value = "82DD1D18";
                MP_Value = "00000000";
                Offset = "CCC9D0";
                Setup_Value = "82CD99D0";
                Name_Offset = "71EA50";
                Name_Value = "9CAA9CAB";
                Level_ID = "27";
                Level_ID_Offset = "71EA5B";
                Map = "Caverns";
                Stock_Map_Size = "15A97";

            }
            //Caves
            else if (Map_Name == "Caves")
            {
                SP_Offset = "84B638";
                SP_Value = "00000000";
                MP_Offset = "84B63C";
                //MP_Value = "82DE51F8";
                MP_Value = "00000000";
                Offset = "DD69E8";
                Setup_Value = "82DE39E8";
                Name_Offset = "71E960";
                Name_Value = "9CA29CA3";
                Level_ID = "32";
                Level_ID_Offset = "71E96B";
                Map = "Caves";
                Stock_Map_Size = "1857";
            }
            //Complex
            else if (Map_Name == "Complex")
            {
                SP_Offset = "84B210";
                SP_Value = "00000000";
                MP_Offset = "84B214";
                //MP_Value = "82DE6D38";
                MP_Value = "00000000";
                Offset = "DD8240";
                Setup_Value = "82DE5240";
                Name_Offset = "71E948";
                Name_Value = "9C9E9C9F";
                Level_ID = "1F";
                Level_ID_Offset = "71E953";
                Map = "Complex";
                Stock_Map_Size = "1B3F";
            }
            //Control
            else if (Map_Name == "Control")
            {
                SP_Offset = "84B050";
                SP_Value = "82CB1CF8";
                MP_Offset = "84B054";
                MP_Value = "00000000";
                Offset = "C944C8";
                Setup_Value = "82CA14C8";
                Name_Offset = "71E7DC";
                Name_Value = "9C8E9C8F";
                Level_ID = "17";
                Level_ID_Offset = "71E7E3";
                Map = "Control";
                Stock_Map_Size = "10877";
            }
            //Cradle
            else if (Map_Name == "Cradle")
            {
                SP_Offset = "84B440";
                SP_Value = "82CF4B08";
                MP_Offset = "84B444";
                MP_Value = "00000000";
                Offset = "CE2468";
                Setup_Value = "82CEF468";
                Name_Offset = "71E814";
                Name_Value = "9C929C93";
                Level_ID = "29";
                Level_ID_Offset = "71E81B";
                Map = "Cradle";
                Stock_Map_Size = "56E7";
            }
            //Dam
            else if (Map_Name == "Dam")
            {
                SP_Offset = "84B280";
                SP_Value = "82D115F0";
                MP_Offset = "84B284";
                //MP_Value = "82DD6B00";
                MP_Value = "00000000";
                Offset = "CF0C20";
                Setup_Value = "82CFDC20";
                Name_Offset = "71E9C0";
                Name_Value = "9C799CB7";
                Level_ID = "21";
                Level_ID_Offset = "71E9CB";
                Map = "Dam";
                Stock_Map_Size = "13A17";
            }
            //Depot
            else if (Map_Name == "Depot")
            {
                SP_Offset = "84B1D8";
                SP_Value = "82D1EA40";
                MP_Offset = "84B1DC";
                //MP_Value = "82DDA038";
                MP_Value = "00000000";
                Offset = "D04638";
                Setup_Value = "82D11638";
                Name_Offset = "71EA38";
                Name_Value = "9C8A9CB5";
                Level_ID = "1E";
                Level_ID_Offset = "71EA43";
                Map = "Depot";
                Stock_Map_Size = "D44F";
            }
            //Egyptian
            else if (Map_Name == "Egyptian")
            {
                SP_Offset = "84B248";
                SP_Value = "82CFDBD8";
                MP_Offset = "84B24C";
                //MP_Value = "82DD3508";
                MP_Value = "00000000";
                Offset = "CE7B50";
                Setup_Value = "82CF4B50";
                Name_Offset = "71EA68";
                Name_Value = "9CAC9CAD";
                Level_ID = "20";
                Level_ID_Offset = "71EA73";
                Map = "Egyptian";
                Stock_Map_Size = "90CF";
            }
            //Facility
            else if (Map_Name == "Facility")
            {
                SP_Offset = "84B2B8";
                SP_Value = "82CC8470";
                MP_Offset = "84B2BC";
                //MP_Value = "82DCB990";
                MP_Value = "00000000";
                Offset = "CA4D40";
                Setup_Value = "82CB1D40";
                Name_Offset = "71E9D8";
                Name_Value = "9CA49CA5";
                Level_ID = "22";
                Level_ID_Offset = "71E9E3";
                Map = "Facility";
                Stock_Map_Size = "16777";
            }
            //Frigate
            else if (Map_Name == "Frigate")
            {
                SP_Offset = "84B0F8";
                SP_Value = "82D2C3E8";
                MP_Offset = "84B0FC";
                //MP_Value = "82DDF970";
                MP_Value = "00000000";
                Offset = "D11A88";
                Setup_Value = "82D1EA88";
                Name_Offset = "71E9F0";
                Name_Value = "9C839CAF";
                Level_ID = "1A";
                Level_ID_Offset = "71E9FB";
                Map = "Frigate";
                Stock_Map_Size = "D9A7";
            }
            //Jungle
            else if (Map_Name == "Jungle")
            {
                SP_Offset = "84B360";
                SP_Value = "82D44440";
                MP_Offset = "84B364";
                MP_Value = "00000000";
                Offset = "D1F430";
                Setup_Value = "82D2C430";
                Name_Value = "9C8D9C8D";
                Level_ID = "25";
                Map = "Jungle";
                Stock_Map_Size = "18057";
            }
            //Library
            else if (Map_Name == "Library")
            {
                SP_Offset = "84B5C8";
                SP_Value = "00000000";
                MP_Offset = "84B5CC";
                //MP_Value = "82DC5CC0";
                MP_Value = "00000000";
                Offset = "DB4C98";
                Setup_Value = "82DC1C98";
                Name_Offset = "71E978";
                Name_Value = "9CA09CA1";
                Level_ID = "30";
                Level_ID_Offset = "71E983";
                Map = "Library";
                Stock_Map_Size = "406F";
            }
            //Runway
            else if (Map_Name == "Runway")
            {
                SP_Offset = "84B2F0";
                SP_Value = "82D5C238";
                MP_Offset = "84B2F4";
                //MP_Value = "82DE9028";
                MP_Value = "00000000";
                Offset = "D47CE8";
                Setup_Value = "82D54CE8";
                Name_Value = "9C7B9C7B";
                Level_ID = "23";
                Map = "Runway";
                Stock_Map_Size = "75F7";
            }
            //Silo
            else if (Map_Name == "Silo")
            {
                SP_Offset = "84AFE0";
                SP_Value = "82DA7AC8";
                MP_Offset = "84AFE4";
                MP_Value = "00000000";
                Offset = "D86D18";
                Setup_Value = "82D93D18";
                Name_Value = "9C819C81";
                Level_ID = "14";
                Map = "Silo";
                Stock_Map_Size = "13DF7";
            }
            //Stack
            else if (Map_Name == "Stack")
            {
                SP_Offset = "84B558";
                SP_Value = "00000000";
                MP_Offset = "84B55C";
                //MP_Value = "82DCF048";
                MP_Value = "00000000";
                Offset = "DBE9D8";
                Setup_Value = "82DCB9D8";
                Name_Offset = "71E9A8";
                Name_Value = "9D0F9D10";
                Level_ID = "2E";
                Level_ID_Offset = "71E9B3";
                Map = "Stack";
                Stock_Map_Size = "36B7";
            }
            //Statue
            else if (Map_Name == "Statue")
            {
                SP_Offset = "84B018";
                SP_Value = "82DAE8C0";
                MP_Offset = "84B01C";
                MP_Value = "00000000";
                Offset = "D9AB10";
                Setup_Value = "82DA7B10";
                Name_Offset = "71E718";
                Name_Value = "9C859C86";
                Level_ID = "16";
                Level_ID_Offset = "71E71F";
                Map = "Statue";
                Stock_Map_Size = "6DF7";
            }
            //Streets
            else if (Map_Name == "Streets")
            {
                SP_Offset = "84B1A0";
                SP_Value = "82D54C40";
                MP_Offset = "84B1A4";
                MP_Value = "00000000";
                Offset = "D39940";
                Setup_Value = "82D46940";
                Name_Value = "9C899C89";
                Level_ID = "1D";
                Map = "Streets";
                Stock_Map_Size = "E3A7";
            }
            //Surface 1
            else if (Map_Name == "Surface 1")
            {
                SP_Offset = "84B328";
                SP_Value = "82D857E8";
                MP_Offset = "84B32C";
                MP_Value = "00000000";
                Offset = "D67C58";
                Setup_Value = "82D74C58";
                Name_Value = "9C7D9C7D";
                Level_ID = "24";
                Map = "Surface1";
                Stock_Map_Size = "10BD7";
            }
            //Surface 2
            else if (Map_Name == "Surface 2")
            {
                SP_Offset = "84B4B0";
                SP_Value = "82D93CD0";
                MP_Offset = "84B4B4";
                MP_Value = "00000000";
                Offset = "D78830";
                Setup_Value = "82D85830";
                Name_Value = "9C7D9C7D";
                Level_ID = "2B";
                Map = "Surface2";
                Stock_Map_Size = "E4E7";
            }
            //Temple
            else if (Map_Name == "Temple")
            {
                SP_Offset = "84B398";
                SP_Value = "00000000";
                MP_Offset = "84B39C";
                //MP_Value = "82DE19D8";
                MP_Value = "00000000";
                Offset = "DD29B8";
                Setup_Value = "82DDF9B8";
                Name_Offset = "71E930";
                Name_Value = "9C9C9C9D";
                Level_ID = "26";
                Level_ID_Offset = "71E93B";
                Map = "Temple";
                Stock_Map_Size = "2067";
            }
            //Train
            else if (Map_Name == "Train")
            {
                SP_Offset = "84B0C0";
                SP_Value = "82DC1C50";
                MP_Offset = "84B0C4";
                MP_Value = "00000000";
                Offset = "DA1908";
                Setup_Value = "82DAE908";
                Name_Value = "9C8B9C8B";
                Level_ID = "19";
                Map = "Train";
                Stock_Map_Size = "1338F";
            }
        }

        public static void Convert_Map(string Xex, string Set)
        {

            //Cleanup
            General.Cleanup();
            if (String.IsNullOrEmpty(Xex))
            {
                General.Message("Please Select Xex File");

            }
            else if (String.IsNullOrEmpty(Set))
            {
                General.Message("Please Select Setup File");

            }
            else
            {

                //Create Temp Directory
                Cleanup();
                if (Directory.Exists(@"C:\RetroDriven_Temp"))
                {
                    Directory.Delete(@"C:\RetroDriven_Temp", true);
                }
                if (File.Exists(@"C:\RetroDriven_Temp\Temp.bin"))
                {
                    File.Delete(@"C:\RetroDriven_Temp\Temp.bin");
                }
                Directory.CreateDirectory(@"C:\RetroDriven_Temp");
                //string TempBin = @"C:\RetroDriven_Temp\Temp.bin";

                //Get Embeded Setup Converter and copy to Temp Directory
                string SetupConverter = Get_File("setup_converter", "exe");

                //Run the Setup Converter Exe
                Run_Converter(SetupConverter, @Set, @TempBin, Setup_Value);

                //Get Size of Converted Map
                long ConvertedBinSize = new FileInfo(TempBin).Length;

                //Get Stock Map Size
                int StockMapSizeCheck = Convert.ToInt32(Stock_Map_Size, 16) + 1;
                int StockMapSize = Convert.ToInt32(Stock_Map_Size, 16);

                //Check File Sizes
                /*
                if (ConvertedBinSize > StockMapSizeCheck)
                {
                    string Hex_Difference = File_Difference(ConvertedBinSize, StockMapSizeCheck);
                    General.Message(string.Format("Your Map is Too Large by: {0} (Hex/Length)"));
                }
                else
                {
                */
                    //Backup Xex File
                    Backup_Xex(@Xex);

                    //Write blank Dummy Map(Same size as the Stock Map)
                    string StockMap = @"C:\RetroDriven_Temp\Dummy_Map.bin";
                    Write_Blank_Map(StockMapSize);

                    //SP Selected
                    //Convert Strings to Int
                    int offset = Convert.ToInt32(Offset, 16); //Convert the Offset Input String to a Decimal Integer
                    int SPOffset = Convert.ToInt32(SP_Offset, 16);
                    int MPOffset = Convert.ToInt32(MP_Offset, 16);

                using (BinaryWriter writer = new BinaryWriter(File.Open(@Xex, FileMode.Open, FileAccess.ReadWrite)))
                    {

                        //Convert String to Bytes SP Only
                        byte[] SPOnly = new byte[Setup_Value.Length / 2];
                        for (int i = 0; i < Setup_Value.Length; i += 2)
                            SPOnly[i / 2] = Convert.ToByte(Setup_Value.Substring(i, 2), 16);

                        //Convert String to Bytes SP Bytes
                        byte[] SPbytes = new byte[SP_Value.Length / 2];
                        for (int i = 0; i < SP_Value.Length; i += 2)
                            SPbytes[i / 2] = Convert.ToByte(SP_Value.Substring(i, 2), 16);

                        //Convert String to Bytes MP Bytes
                        byte[] MPbytes = new byte[MP_Value.Length / 2];
                        for (int i = 0; i < MP_Value.Length; i += 2)
                            MPbytes[i / 2] = Convert.ToByte(MP_Value.Substring(i, 2), 16);

                        //Convert String to Bytes Map Name
                        byte[] MapNameBytes = new byte[Name_Value.Length / 2];
                            for (int i = 0; i < Name_Value.Length; i += 2)
                                MapNameBytes[i / 2] = Convert.ToByte(Name_Value.Substring(i, 2), 16);

                        //Convert String to Bytes Level ID
                        byte[] LevelIDbytes = new byte[Level_ID.Length / 2];
                        for (int i = 0; i < Level_ID.Length; i += 2)
                            LevelIDbytes[i / 2] = Convert.ToByte(Level_ID.Substring(i, 2), 16);

                        //Write Stock Map Data
                        byte[] StockBinFile = File.ReadAllBytes(StockMap); //Open Bin file and grab the data
                        writer.Seek(offset, SeekOrigin.Begin); //Goto the Offset
                        writer.Write(StockBinFile); //Write the data from the Bin file

                        writer.Seek(SPOffset, SeekOrigin.Begin);
                        writer.Write(SPOnly);

                        //Write MP Bytes
                        writer.Seek(MPOffset, SeekOrigin.Begin);
                        writer.Write(MPbytes);

                        //Write Converted Map Data
                        byte[] BinFile = File.ReadAllBytes(TempBin); //Open Bin file and grab the data
                            writer.Seek(offset, SeekOrigin.Begin); //Goto the Offset
                            writer.Write(BinFile); //Write the data from the Bin file
                            writer.Close();
                            writer.Dispose();
                    }

                    //Get Xextool
                    String Xextool = Get_File("xextool", "exe");

                    //Sign Xex File
                    Sign_Xex(Xextool, @Xex);

                    //Cleanup
                    Cleanup();

                    //Success!
                    General.Message("Conversion Complete!");
                //}
            }

        }
        public static void Write_Blank_Map(long StockMapSize)
        {

            FileStream fs = new FileStream(@"C:\RetroDriven_Temp\Dummy_Map.bin", FileMode.CreateNew);
            fs.Seek(StockMapSize, SeekOrigin.Begin);
            fs.WriteByte(0);
            fs.Close();
            fs.Dispose();
        }
        public static void Backup_Xex(string XexFile)
        {
            string CurrentFolder = Path.GetDirectoryName(@XexFile);
            string BackupFolder = @CurrentFolder + "\\Xex_Backups";
            System.IO.Directory.CreateDirectory(BackupFolder);

            string sourceFile = @XexFile;
            string strFileName = Path.GetFileNameWithoutExtension(@sourceFile);
            string destinationFile = @BackupFolder + "\\" + string.Format(strFileName + "-{0:MM-dd-yyyy_hh-mm-ss}.xex", DateTime.Now);

            File.Copy(@sourceFile, @destinationFile);
        }
        public static string File_Difference(long ConvertedBinSize, long StockMapSizeCheck)
        {
            long Size = ConvertedBinSize - StockMapSizeCheck;
            String Size_String = Size.ToString();
            int number = int.Parse(Size_String);
            string hex = number.ToString("x");
            string Hex_Difference = Convert.ToString(int.Parse(Size_String), 16);
            return Hex_Difference;
        }
        public static void Run_Converter(string Converter, string SetupFile, string TempBin, string NewSetup)
        {
            var startInfo = new ProcessStartInfo(Converter, $"\"{@SetupFile}\"" + " " + @TempBin + " " + NewSetup);
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            var Convert = Process.Start(startInfo);
            Convert.WaitForExit();
        }
        public static void Sign_Xex(string XexToolExe, string XexFile)
        {
            var startInfo = new ProcessStartInfo(XexToolExe, $"-md \"{@XexFile}\"");
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            var SignXex = Process.Start(startInfo);
            SignXex.WaitForExit();

        }
        public static string Get_File(string File_Name, string Extension)
        {
            string File_Path = @"C:\RetroDriven_Temp\";
            string File = File_Path + File_Name + "." + Extension;
            object ob = Resource1.ResourceManager.GetObject(File_Name, resourceCulture);
            byte[] myResBytes = (byte[])ob;
            using (FileStream fsDst = new FileStream(File, FileMode.CreateNew))
            {
                byte[] bytes = myResBytes;
                fsDst.Write(bytes, 0, bytes.Length);
                fsDst.Close();
                fsDst.Dispose();
                return File;
            }
        }
        public static void Cleanup()
        {
            if (File.Exists(@"C:\RetroDriven_Temp\SetupConverter.exe"))
            {
                File.Delete(@"C:\RetroDriven_Temp\SetupConverter.exe");
            }
            if (File.Exists(@"C:\RetroDriven_Temp\xextool.exe"))
            {
                File.Delete(@"C:\RetroDriven_Temp\xextool.exe");
            }
            if (Directory.Exists(@"C:\RetroDriven_Temp"))
            {
                Directory.Delete(@"C:\RetroDriven_Temp", true);
            }
        }

    }
}
