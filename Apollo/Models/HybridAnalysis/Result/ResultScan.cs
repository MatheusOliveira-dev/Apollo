using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Models.HybridAnalysis.Result
{
    public class RootResultScanHybridAnalysis
    {
        public string id { get; set; }
        public string sha256 { get; set; }
        public string FileName { get; set; }
        public List<Scanner> scanners { get; set; }
        public List<Whitelist> whitelist { get; set; }
        public List<object> reports { get; set; }
        public bool finished { get; set; }
    }

    public class Scanner
    {
        public string name { get; set; }
        public string status { get; set; }
        public object error_message { get; set; }
        public int progress { get; set; }
        public int? total { get; set; }
        public int? positives { get; set; }
        public int? percent { get; set; }
        public List<object> anti_virus_results { get; set; }
    }

    public class Whitelist
    {
        public string id { get; set; }
        public bool value { get; set; }
    }
}
