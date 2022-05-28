using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Models.HistoryScan
{
    public class RootHistoryScan
    {
        public string filename { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string uid { get; set; }
        public string urlGuiVirusTotal { get; set; }
        public HybridAnalysisProvider hybridAnalysisProvider { get; set; }
        public VirusTotalProvider virusTotalProvider { get; set; }
    }
    public class AcronisScan
    {
        public string status { get; set; }
    }

    public class AlyacScan
    {
        public string status { get; set; }
    }

    public class ApexScan
    {
        public string status { get; set; }
    }

    public class AvgScan
    {
        public string status { get; set; }
    }

    public class HybridAnalysisProvider
    {
        public MetaDefenderScan metaDefenderScan { get; set; }
        public VirusTotalScan virusTotalScan { get; set; }
    }

    public class MetaDefenderScan
    {
        public int total { get; set; }
        public int malicious { get; set; }
        public string status { get; set; }
    }
    public class VirusTotalScan
    {
        public int total { get; set; }
        public int malicious { get; set; }
        public string status { get; set; }
  
    }

    public class VirusTotalProvider
    {
        public AcronisScan acronisScan { get; set; }
        public AlyacScan alyacScan { get; set; }
        public ApexScan apexScan { get; set; }
        public AvgScan avgScan { get; set; }
    }


}
