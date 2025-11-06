using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMFST.MIP.CarService
{
    public class Car
    {
        [Key]
        [JsonProperty("vin")] // A VIN az elsődleges kulcs
        public string VIN { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("odometerKm")] // Figyelem: a JSON-ban "odometerKm"
        public int Odometer { get; set; }

        // Kapcsolat: Melyik ügyfélhez tartozik
        public string ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
    }
}