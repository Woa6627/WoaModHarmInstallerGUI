using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoaModHarmInstallerGUI.helper
{
    public class versionchecker
    {
        public static async Task<double> CheckLatestVersion()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage res = await client.GetAsync("https://raw.githubusercontent.com/Woa6627/WoaModHarmInstallerGUI/main/version.txt");
                string content = await res.Content.ReadAsStringAsync();
                double result;
                double.TryParse(content, out result);
                return result;
            }catch(Exception ex)
            {
                MAIN.AppendSTDOUT(ex.Message, true);
                return 0.0;
            }
        }
    }
}
