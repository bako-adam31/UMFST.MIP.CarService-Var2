using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMFST.MIP.CarService
{
    // Ez egy bejegyzést képvisel a "diagnostics.obd" listából
    public class Diagnostic
    {
        [Key]
        public int DiagnosticId { get; set; } // Saját auto-increment ID

        [JsonProperty("carVin")]
        public string CarVin { get; set; } // Kapcsolat az Autóhoz

        [ForeignKey("CarVin")]
        public virtual Car Car { get; set; }

        // --- A 'codes' lista kezelése EF6-ban ---

        // 1. Ebbe a listába tölt a Newtonsoft
        // A JSON { "dtc": "...", "status": "..." } objektumokat tartalmaz
        [JsonProperty("codes")]
        [NotMapped] // EF6 ignoralja
        public List<DiagnosticCode> CodesList { get; set; } = new List<DiagnosticCode>();

        // 2. Ezt mentjük az adatbázisba
        // Az import kódodban kell feltölteni:
        // pl. diag.CodesString = string.Join(", ", diag.CodesList.Select(c => c.ToString()));
        public string CodesString { get; set; }
    }

    // Segédosztály, amit *csak* a JSON olvasáshoz használunk
    // Ezt NEM mentjük adatbázisba
    [NotMapped]
    public class DiagnosticCode
    {
        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        // Egy segédfüggvény, hogy könnyen string-gé alakítsuk
        public override string ToString()
        {
            return $"{Dtc} ({Status})";
        }
    }
}