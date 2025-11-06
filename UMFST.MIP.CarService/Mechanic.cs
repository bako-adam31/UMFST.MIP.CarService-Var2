using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Ez kell a [NotMapped]-hez

namespace UMFST.MIP.CarService
{
    public class Mechanic
    {
        [Key]
        [JsonProperty("id")] // A JSON "M-1", "M-2" string ID-ket ad
        public string MechanicId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("years")]
        public int Years { get; set; } // Ezt validáljuk (ne legyen negatív)

        // --- A lista kezelése EF6-ban ---

        // 1. Ebbe a listába tölt a Newtonsoft.Json
        [JsonProperty("specialization")]
        [NotMapped] // FONTOS: Az EF6 ezt *nem* próbálja menteni
        public List<string> SpecializationList { get; set; } = new List<string>();

        // 2. Ezt a mezőt mentjük az adatbázisba
        // Az importáló kódban (4. Fázis) kell majd feltölteni:
        // pl. mech.SpecializationString = string.Join(", ", mech.SpecializationList);
        public string SpecializationString { get; set; }
    }
}