using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Models.Settings
{
    public class RootSettings
    {

        public bool MinimizeToTray { get; set; }
        public bool OpenVirusTotalGUI { get; set; }
        public int WaitTimeGetResult { get; set; }

        //public List<string> ProvidersScan { get; set; }
        //public List<string> LimitUsageNotification { get; set; }
    }
}
