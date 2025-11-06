using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Ez kell a [ForeignKey]-hez

namespace UMFST.MIP.CarService
{
    public class Invoice
    {
        [Key] // Az Invoice elsődleges kulcsa...
        [ForeignKey("WorkOrder")] // ...megegyezik a WorkOrder kulcsával
        public string WorkOrderId { get; set; } // Ezt a `WorkOrder` ID-jából kapja meg

        // A JSON-ban van egy hibás: { "currency": 123 }
        // A [JsonProperty] ezt megpróbálja 'string'-ként olvasni,
        // amit a validátorban el kell kapnunk.
        [JsonProperty("currency")]
        public string Currency { get; set; }

        // A JSON-ban van egy hibás: { "paid": "no" }
        // A Newtonsoft ezt okosan `false`-ra fogja konvertálni.
        [JsonProperty("paid")]
        public bool IsPaid { get; set; } // EZ KELL a GUI színezéséhez

        // Navigációs tulajdonság vissza a "szülőhöz"
        public virtual WorkOrder WorkOrder { get; set; }
    }
}