using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoaModHarmInstallerGUI.MoveFiles
{
    public class MoveFiles
    {
        public int MoveFile()
        {
            if (!Directory.Exists(@"BepinEx\plugins"))
            {
                
                MAIN.AppendSTDOUT($"BepinEx is not installed or has not be initalised{Environment.NewLine}If BepinEx is installed run the game once then try again", true);
                return -1;
            }
            if (!File.Exists("WoaModHarm.dll") && !File.Exists("mainmenumusic.woa"))
            {
                MAIN.AppendSTDOUT("WoaModHarm.dll or required DLC is not downloaded", true);
                return -1;
            }
            File.Copy("WoaModHarm.dll", @"BepinEx\plugins\WoaModHarm.dll", true);
            File.Copy("mainmenumusic.woa", @"BepinEx\plugins\mainmenumusic.woa", true);
            File.Copy("sfx.woa", @"BepinEx\plugins\sfx.woa", true);
            return 0;
        }
    }
}
