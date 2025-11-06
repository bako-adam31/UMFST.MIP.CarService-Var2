using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMFST.MIP.CarService
{
    public class Test
    {
        [Key]
        public int TestId { get; set; } // Saját auto-increment ID

        [JsonProperty("workOrderId")]
        public string WorkOrderId { get; set; } // Kapcsolat a Munkalaphoz

        [ForeignKey("WorkOrderId")]
        public virtual WorkOrder WorkOrder { get; set; }

        [JsonProperty("name")]
        public string TestName { get; set; } // JSON "name"

        [JsonProperty("ok")]
        public bool Ok { get; set; } // EZ KELL a GUI piros/zöld színezéséhez
    }
}