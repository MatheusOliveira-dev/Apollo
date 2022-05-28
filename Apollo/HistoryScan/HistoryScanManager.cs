using Apollo.Models.HistoryScan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apollo.Misc;
using Newtonsoft.Json;
using System.IO;

namespace Apollo.HistoryScan
{
    public class HistoryScanManager
    {
        public void SaveScan(RootHistoryScan historyScan)
        {
            string uid = Helpers.GenerateUID();
            historyScan.uid = uid;

            Helpers.CreateOrReplaceFile(string.Format(@"HistoryScans\{0}.json", uid), JsonConvert.SerializeObject(historyScan));
        }

        public List<RootHistoryScan> GetScans()
        {
            List<RootHistoryScan> lstScans = new List<RootHistoryScan>();

            string[] scanFiles = Directory.GetFiles("HistoryScans", "*", SearchOption.AllDirectories);

            foreach (var scanFile in scanFiles)
            {
                lstScans.Add(JsonConvert.DeserializeObject<RootHistoryScan>(File.ReadAllText(scanFile)));
            }

            return lstScans;
        }
    }
}
