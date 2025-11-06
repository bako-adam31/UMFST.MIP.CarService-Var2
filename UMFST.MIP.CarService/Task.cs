using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UMFST.MIP.CarService
{
    public class Task
    {
        [Key]
        [JsonProperty("id")] // "T-1"
        public string TaskId { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("laborH")]
        public decimal LaborHours { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("mechanicId")]
        public string MechanicId { get; set; }

        // Kapcsolat
        public string WorkOrderId { get; set; }
    }
}