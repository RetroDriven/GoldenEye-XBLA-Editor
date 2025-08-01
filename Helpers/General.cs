using GoldenEye_XBLA_Editor.Forms.Main;
using Guna.UI2.WinForms;
using System.IO;

namespace Helpers
{
    public class General
    {
        public static void Cleanup()
        {
            if (File.Exists(@"C:\RetroDriven_Temp\xextool.exe"))
            {
                File.Delete(@"C:\RetroDriven_Temp\xextool.exe");
            }
            if (Directory.Exists(@"C:\RetroDriven_Temp"))
            {
                Directory.Delete(@"C:\RetroDriven_Temp", true);
            }
        }
        public static void Message(string Caption)
        {
            Main form1 = (Main)Application.OpenForms["Main"];

            Guna2MessageDialog Message_Box = new Guna2MessageDialog();
            Message_Box.Parent = form1;
            Message_Box.Caption = Caption;
            Message_Box.Style = MessageDialogStyle.Dark;
            Message_Box.Show();
        }
    }
}
