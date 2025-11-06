using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UMFST.MIP.CarService
{
    public class Part
    {
        [Key]
        [JsonProperty("sku")] // "GASK-12"
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("qty")]
        public int Quantity { get; set; }

        [JsonProperty("unitPrice")]
        public decimal UnitPrice { get; set; }

        // Kapcsolat
        public string WorkOrderId { get; set; }
    }
}