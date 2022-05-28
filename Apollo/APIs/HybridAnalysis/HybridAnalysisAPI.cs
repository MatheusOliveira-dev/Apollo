using Apollo.Integrations;
using Apollo.Misc;
using Apollo.Models.HybridAnalysis.Result;
using Apollo.Models.HybridAnalysis.Scan;
using Apollo.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Apollo.APIs.HybridAnalysis
{
   
    public class HybridAnalysisAPI
    {

        private string _apiKey;
        public HybridAnalysisAPI(string apiKey)
        {
            _apiKey = apiKey;
        }


        public async Task<RootResultScanHybridAnalysis> ScanAsync(string file)
        {
            RootQuickScanHybridAnalysis scanHybridAnalysis = await ScanFileAsync(file);
            Thread.Sleep(new SettingsManager().GetIntegrationsDeserialized().WaitTimeGetResult * 1000);
            RootResultScanHybridAnalysis resultScanHybridAnalysis = await GetResultScan(scanHybridAnalysis);

            resultScanHybridAnalysis.FileName = Path.GetFileName(file);

            return resultScanHybridAnalysis;
        }

        private async Task<RootQuickScanHybridAnalysis> ScanFileAsync(string file)
        {
            Helpers.CreateLog("Uploading File to Hybrid Analysis");

            RootQuickScanHybridAnalysis scanHybridAnalysis = new RootQuickScanHybridAnalysis();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), string.Format("{0}/{1}", Constants.HostApiHybridAnalysis, Constants.QuickScanFileHybridAnalysis)))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");
                        request.Headers.TryAddWithoutValidation("user-agent", "Falcon Sandbox");
                        request.Headers.TryAddWithoutValidation("api-key", _apiKey);

                        var multipartContent = new MultipartFormDataContent();
                        multipartContent.Add(new StringContent("all"), "scan_type");
                        var file1 = new ByteArrayContent(File.ReadAllBytes(file));
                        file1.Headers.Add("Content-Type", "application/x-msdownload");
                        multipartContent.Add(file1, "file", Path.GetFileName(file));
                        request.Content = multipartContent;

                        scanHybridAnalysis = JsonConvert.DeserializeObject<RootQuickScanHybridAnalysis>(await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.CreateLog(string.Format("Error on Uploading File to Hybrid Analysis | ERROR: {0}", ex.Message), true);
                throw ex;
            }



            return scanHybridAnalysis;
        }


        private async Task<RootResultScanHybridAnalysis> GetResultScan(RootQuickScanHybridAnalysis scanHybridAnalysis)
        {

            Helpers.CreateLog("Getting Hybrid Analysis Result");

            RootResultScanHybridAnalysis resultScanHybridAnalysis = new RootResultScanHybridAnalysis();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), string.Format("{0}/{1}/{2}",
                        Constants.HostApiHybridAnalysis,
                        Constants.QuickScanFileResultHybridAnalysis,
                        scanHybridAnalysis.id)))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");
                        request.Headers.TryAddWithoutValidation("user-agent", "Falcon Sandbox");
                        request.Headers.TryAddWithoutValidation("api-key", _apiKey);

                        resultScanHybridAnalysis = JsonConvert.DeserializeObject<RootResultScanHybridAnalysis>(await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.CreateLog(string.Format("Error on Getting Hybrid Analysis Result | ERROR: {0}", ex.Message), true);
                throw ex;
            }

            return resultScanHybridAnalysis;
        }

    }
}
