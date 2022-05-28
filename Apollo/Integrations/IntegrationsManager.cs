using Apollo.Misc;
using Apollo.Models.Integrations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Integrations
{
    public class IntegrationsManager
    {
        private RootIntegrations _integrationsDeserialized;
        public IntegrationsManager()
        {
            CreateDefaultIntegrations();
            _integrationsDeserialized = JsonConvert.DeserializeObject<RootIntegrations>(File.ReadAllText(@"Integrations\integrations.json"));
        }
        public void CreateDefaultIntegrations()
        {
            if (!File.Exists(@"Integrations\integrations.json"))
            {
                RootIntegrations rootIntegrations = new RootIntegrations();

                rootIntegrations.hybrid = string.Empty;
                rootIntegrations.virustotal = string.Empty;

                Helpers.CreateOrReplaceFile(@"Integrations\integrations.json", JsonConvert.SerializeObject(rootIntegrations));
            }
        }

        public RootIntegrations GetIntegrationsDeserialized()
        {
            return _integrationsDeserialized;
        }

        public void SaveIntegrations(RootIntegrations rootIntegrations)
        {
            Helpers.CreateOrReplaceFile(@"Integrations\integrations.json", JsonConvert.SerializeObject(rootIntegrations));
        }

        public bool IsScanProvidersInformed()
        {

            if (string.IsNullOrWhiteSpace(_integrationsDeserialized.virustotal)
                && string.IsNullOrWhiteSpace(_integrationsDeserialized.hybrid))
            {
                return false;
            }

            return true;
        }


        public bool IsVirusTotalProviderActive()
        {

            if (string.IsNullOrWhiteSpace(_integrationsDeserialized.virustotal))
            {
                return false;
            }

            return true;
        }

        public bool IsHybridAnalysisProviderActive()
        {
            if (string.IsNullOrWhiteSpace(_integrationsDeserialized.hybrid))
            {
                return false;
            }

            return true;
        }
    }
}
