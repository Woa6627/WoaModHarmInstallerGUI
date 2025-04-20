using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoaModHarmInstallerGUI.Downloader
{
    public class Downloader
    {
        public static async Task<byte[]> downloadFile()
        {
            MAIN.AppendSTDOUT("Starting Download on WoaModHarm.dll");
            using HttpClient client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(File.ReadAllText(@"DownloadDirs\woamodharm.txt"));
            MAIN.AppendSTDOUT("Finished Downloading WoaHarmMod.dll");
            return data;
        }

        public static async Task<byte[]> downloadMusicDLC()
        {
            MAIN.AppendSTDOUT("Starting Download on mainmenumusic.woa");
            using HttpClient client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(File.ReadAllText(@"DownloadDirs\music.txt"));
            MAIN.AppendSTDOUT("Finished Downloading mainmenumusic.woa");
            return data;
        }

        public static async Task<byte[]> downloadSFXDlc()
        {
            MAIN.AppendSTDOUT("Starting Download on sfx.woa");
            using HttpClient client = new HttpClient();
            byte[] data = await client.GetByteArrayAsync(File.ReadAllText(@"DownloadDirs\sfx.txt"));
            MAIN.AppendSTDOUT("Finished Downloading sfx.woa");
            return data;
        }
    }
}
