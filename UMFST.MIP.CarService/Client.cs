using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UMFST.MIP.CarService
{
    public class Client
    {
        [Key]
        [JsonProperty("id")] // A JSON "CL-993" string ID-t ad
        public string ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("cars")]
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}