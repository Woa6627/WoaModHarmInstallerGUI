using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WoaModHarmInstallerGUI
{

    public partial class MAIN : Form
    {
        public static RichTextBox? stdout = null;
        public static CheckBox? debug = null;
        public static ProgressBar? progress = null;
        public MAIN()
        {
            InitializeComponent();
            stdout = Output;
            debug = DEBUG_CHECK;
            progress = DOWNLOAD_PROG;
        }

        private async void Install_BTN_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            if (!Directory.Exists("DownloadDirs"))
            {
                AppendSTDOUT("Missing Download Folder", true);
                return;
            }
            await DownloadFiles();
            MoveFilesToLocation();
            progress.Value = 100;
        }

        private static void MoveFilesToLocation()
        {
            MoveFiles.MoveFiles mv = new MoveFiles.MoveFiles();
            if (mv.MoveFile() == 0)
            {
                AppendSTDOUT("WoaModHarm is successfully installed");
                return;
            }
            else
            {
                AppendSTDOUT("Could not install WoaModHarm" + Environment.NewLine + "This error is rare" + Environment.NewLine + "make sure files are downloaded properly", true);
                return;
            }
        }

        public static async Task DownloadFiles()
        {
            AppendSTDOUT("Downloading WoaModHarm.dll");
            await File.WriteAllBytesAsync("WoaModHarm.dll", await Downloader.Downloader.downloadFile());
            progress.Value += 10;
            AppendSTDOUT("Downloading mainmenumusic.woa");
            await File.WriteAllBytesAsync("mainmenumusic.woa", await Downloader.Downloader.downloadMusicDLC());
            progress.Value += 10;
            AppendSTDOUT("Downloading sfx.woa");
            await File.WriteAllBytesAsync("sfx.woa", await Downloader.Downloader.downloadSFXDlc());
            progress.Value += 60;
        }

        public static void AppendSTDOUT(string content, bool isError = false)
        {
            stdout?.Invoke(() =>
            {
                stdout.BackColor = Color.Black;
                if (isError)
                {
                    stdout.SelectionColor = Color.Red;
                }
                else
                {
                    stdout.SelectionColor = Color.White;
                }
                stdout.AppendText(content + Environment.NewLine);
            });
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }

        private void VERIFYINTEGRITY_BTN_Click(object sender, EventArgs e)
        {
            progress.Value = 0;
            AppendSTDOUT("Running Integrity Check");
            if (Directory.Exists(@"bepinex\plugins"))
            {
                progress.Value = 10;
                AppendSTDOUT("Found Bepinex installation and plugins folder");
                if (File.Exists(@"bepinex\plugins\WoaModHarm.dll") && File.Exists(@"bepinex\plugins\mainmenumusic.woa") && File.Exists(@"bepinex\plugins\sfx.woa"))
                {
                    AppendSTDOUT("Found WoaModHarm.dll and required dlc");
                    AppendSTDOUT("Everything checks out enjoy");
                    progress.Value = 100;
                }
                else
                {
                    AppendSTDOUT("WoaModHarm.dll and required dlc are not installed correctly", true);
                    progress.Value = 100;
                    return;
                }
            }
            else
            {
                AppendSTDOUT("Bepinex has not been installed or the plugins folder has not been created", true);
                progress.Value = 100;
                return;
            }
        }

        private void EXIT_BTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LAUNCHGAME_Click(object sender, EventArgs e)
        {
            if(File.Exists("repo.exe"))
            {
                AppendSTDOUT("Launching REPO.exe");
                Process process = new Process();
                process.StartInfo.FileName = "repo.exe";
                process.Start();
                AppendSTDOUT("Successfully launched REPO.exe\nInstaller will now close automatically in 5 seconds");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
    }
}
