using Apollo.Misc;
using Apollo.Models.VirusTotal.Result;
using Apollo.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Apollo.APIs.VirusTotal
{
    public class VirusTotalAPI
    {
        private string _apiKey;

        public VirusTotalAPI(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<RootResultScanVirusTotal> ScanAsync(string file)
        {
            ScanFileAsync(file);
            Thread.Sleep(new SettingsManager().GetIntegrationsDeserialized().WaitTimeGetResult * 1000);
            RootResultScanVirusTotal resultScanVirusTotal = await GetResultScan(file);

            resultScanVirusTotal.data.attributes.Filename = Path.GetFileName(file);

            return resultScanVirusTotal;
        }

        private async void ScanFileAsync(string file)
        {
            Helpers.CreateLog("Uploading File to VirusTotal");

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), string.Format("{0}/{1}", Constants.HostApiVirusTotal, Constants.ScanFileVirusTotal)))
                    {
                        request.Headers.TryAddWithoutValidation("x-apikey", _apiKey);

                        var multipartContent = new MultipartFormDataContent();
                        multipartContent.Add(new ByteArrayContent(File.ReadAllBytes(file)), "file", Path.GetFileName(file));
                        request.Content = multipartContent;

                        var response = await httpClient.SendAsync(request);

                        if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            Helpers.CreateLog(string.Format("Error on Uploading File to VirusTotal (StatusCode <> 200) | ERROR: {0}", await response.Content.ReadAsStringAsync()), true);
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.CreateLog(string.Format("Error on Uploading File to VirusTotal | ERROR: {0}", ex.Message), true);
            }
        }

        private async Task<RootResultScanVirusTotal> GetResultScan(string file)
        {
            Helpers.CreateLog("Getting VirusTotal Result");

            RootResultScanVirusTotal resultScanVirusTotal = new RootResultScanVirusTotal();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("GET"), string.Format("{0}/{1}/{2}",
                         Constants.HostApiVirusTotal,
                         Constants.ScanFileResultVirusTotal,
                         Helpers.GetMD5File(file))))
                    {
                        request.Headers.TryAddWithoutValidation("x-apikey", _apiKey);

                        var response = await httpClient.SendAsync(request);

                        if (response.StatusCode != System.Net.HttpStatusCode.OK)
                        {
                            Helpers.CreateLog(string.Format("Error on Getting VirusTotal Result (StatusCode <> 200) | ERROR: {0}", await response.Content.ReadAsStringAsync()), true);
                            throw new Exception();
                        }

                        resultScanVirusTotal = JsonConvert.DeserializeObject<RootResultScanVirusTotal>(await response.Content.ReadAsStringAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                Helpers.CreateLog(string.Format("Error on Getting VirusTotal Result | ERROR: {0}", ex.Message), true);
                throw;
            }

            return resultScanVirusTotal;
        }
    }
}
