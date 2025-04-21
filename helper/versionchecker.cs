using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoaModHarmInstallerGUI.helper
{
    public class versionchecker
    {
        public static async Task<string> CheckLatestVersion()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage res = await client.GetAsync("");
                string content = await res.Content.ReadAsStringAsync();
                return content;
            }catch(Exception ex)
            {
                MAIN.AppendSTDOUT(ex.Message, true);
                return "";
            }
        }
    }
}
