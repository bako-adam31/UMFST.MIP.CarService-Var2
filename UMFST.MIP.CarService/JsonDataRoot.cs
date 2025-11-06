using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace UMFST.MIP.CarService
{
    // Ez az osztály a JSON fájl legfelső szintjét képviseli
    public class JsonDataRoot
    {
        // A "garage" egyetlen objektum, ami szerelőket tartalmaz
        // Egyszerűsítés képpen a 'garage.mechanics'-ot és a 'mechanics' listát
        // egybeolvashatjuk, de most importáljuk a külön listát.
        [JsonProperty("mechanics")]
        public List<Mechanic> Mechanics { get; set; }

        [JsonProperty("clients")]
        public List<Client> Clients { get; set; }

        [JsonProperty("workOrders")]
        public List<WorkOrder> WorkOrders { get; set; }

        // A "diagnostics" egy objektum, ami két listát tartalmaz
        [JsonProperty("diagnostics")]
        public DiagnosticData Diagnostics { get; set; }
    }

    // Segédosztály a "diagnostics" objektum fogadásához
    public class DiagnosticData
    {
        [JsonProperty("obd")]
        public List<Diagnostic> ObdEntries { get; set; } // Ezt mentjük a 'Diagnostics' táblába

        [JsonProperty("tests")]
        public List<Test> Tests { get; set; } // Ezt mentjük a 'Tests' táblába
    }
}