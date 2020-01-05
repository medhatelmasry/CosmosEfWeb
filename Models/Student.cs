using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CosmosEfWeb.Models
{
    public class Student
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [Required]
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }
        [Required]
        [JsonProperty(PropertyName = "lastname")]
        public string LastName { get; set; }
        [Required]
        [JsonProperty(PropertyName = "school")]
        public string School { get; set; }
    }
}