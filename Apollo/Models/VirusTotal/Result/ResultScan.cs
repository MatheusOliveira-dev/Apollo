using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Models.VirusTotal.Result
{
    public class Acronis
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_update { get; set; }
        public string engine_version { get; set; }
        public string method { get; set; }
        public string result { get; set; }
    }

    public class AlertContext
    {
        public string proto { get; set; }
        public string src_ip { get; set; }
        public int src_port { get; set; }
    }

    public class ALYac
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_update { get; set; }
        public string engine_version { get; set; }
        public string method { get; set; }
        public string result { get; set; }
    }

    public class APEX
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_update { get; set; }
        public string engine_version { get; set; }
        public string method { get; set; }
        public string result { get; set; }
    }

    public class Attributes
    {
        public string Filename { get; set; }
        public List<string> capabilities_tags { get; set; }
        public int creation_date { get; set; }
        public List<CrowdsourcedIdsResult> crowdsourced_ids_results { get; set; }
        public CrowdsourcedIdsStats crowdsourced_ids_stats { get; set; }
        public List<CrowdsourcedYaraResult> crowdsourced_yara_results { get; set; }
        public bool downloadable { get; set; }
        public int first_submission_date { get; set; }
        public int last_analysis_date { get; set; }
        public LastAnalysisResults last_analysis_results { get; set; }
        public LastAnalysisStats last_analysis_stats { get; set; }
        public int last_modification_date { get; set; }
        public int last_submission_date { get; set; }
        public string md5 { get; set; }
        public string meaningful_name { get; set; }
        public List<string> names { get; set; }
        public int reputation { get; set; }
        public SandboxVerdicts sandbox_verdicts { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public SigmaAnalysisStats sigma_analysis_stats { get; set; }
        public SigmaAnalysisSummary sigma_analysis_summary { get; set; }
        public int size { get; set; }
        public List<string> tags { get; set; }
        public int times_submitted { get; set; }
        public TotalVotes total_votes { get; set; }
        public string type_description { get; set; }
        public string type_tag { get; set; }
        public int unique_sources { get; set; }
        public string vhash { get; set; }
    }

    public class AVG
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_update { get; set; }
        public string engine_version { get; set; }
        public string method { get; set; }
        public string result { get; set; }
    }

    public class CrowdsourcedIdsResult
    {
        public List<AlertContext> alert_context { get; set; }
        public string alert_severity { get; set; }
        public string rule_category { get; set; }
        public string rule_id { get; set; }
        public string rule_msg { get; set; }
        public string rule_source { get; set; }
    }

    public class CrowdsourcedIdsStats
    {
        public int high { get; set; }
        public int info { get; set; }
        public int low { get; set; }
        public int medium { get; set; }
    }

    public class CrowdsourcedYaraResult
    {
        public string description { get; set; }
        public bool match_in_subfile { get; set; }
        public string rule_name { get; set; }
        public string ruleset_id { get; set; }
        public string ruleset_name { get; set; }
        public string source { get; set; }
    }

    public class Data
    {
        public Attributes attributes { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
        public string type { get; set; }
    }

    public class LastAnalysisResults
    {
        public ALYac ALYac { get; set; }
        public APEX APEX { get; set; }
        public AVG AVG { get; set; }
        public Acronis Acronis { get; set; }
    }

    public class LastAnalysisStats
    {
        [JsonProperty("confirmed-timeout")]
        public int ConfirmedTimeout { get; set; }
        public int failure { get; set; }
        public int harmless { get; set; }
        public int malicious { get; set; }
        public int suspicious { get; set; }
        public int timeout { get; set; }

        [JsonProperty("type-unsupported")]
        public int TypeUnsupported { get; set; }
        public int undetected { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class RootResultScanVirusTotal
    {
        public Data data { get; set; }
    }

    public class SandboxVerdicts
    {
        [JsonProperty("VirusTotal Jujubox")]
        public VirusTotalJujubox VirusTotalJujubox { get; set; }
    }

    public class SigmaAnalysisStats
    {
        public int critical { get; set; }
        public int high { get; set; }
        public int low { get; set; }
        public int medium { get; set; }
    }

    public class SigmaAnalysisSummary
    {
        [JsonProperty("Sigma Integrated Rule Set (GitHub)")]
        public SigmaIntegratedRuleSetGitHub SigmaIntegratedRuleSetGitHub { get; set; }
    }

    public class SigmaIntegratedRuleSetGitHub
    {
        public int critical { get; set; }
        public int high { get; set; }
        public int low { get; set; }
        public int medium { get; set; }
    }

    public class TotalVotes
    {
        public int harmless { get; set; }
        public int malicious { get; set; }
    }

    public class VirusTotalJujubox
    {
        public string category { get; set; }
        public int confidence { get; set; }
        public List<string> malware_classification { get; set; }
        public List<string> malware_names { get; set; }
        public string sandbox_name { get; set; }
    }

}
