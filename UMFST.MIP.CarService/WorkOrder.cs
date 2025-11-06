using Newtonsoft.Json;
using System; // A DateTime-hoz
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace UMFST.MIP.CarService
{
    public class WorkOrder
    {
        [Key]
        [JsonProperty("id")] // "W1"
        public string WorkOrderId { get; set; }

        [JsonProperty("carVin")]
        public string CarVin { get; set; } // Kapcsolat az autóhoz

        [ForeignKey("CarVin")]
        public virtual Car Car { get; set; }

        [JsonProperty("receivedAt")]
        public DateTime ReceivedAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tasks")]
        public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

        [JsonProperty("parts")]
        public virtual ICollection<Part> Parts { get; set; } = new List<Part>();

        [JsonProperty("invoice")]
        public virtual Invoice Invoice { get; set; }

        [NotMapped]
        public decimal ComputedTotalCost
        {
            get
            {
                decimal taskCost = Tasks?.Sum(t => t.LaborHours * t.Rate) ?? 0;
                decimal partCost = Parts?.Sum(p => p.Quantity * p.UnitPrice) ?? 0;
                return taskCost + partCost;
            }
        }
    }
}
