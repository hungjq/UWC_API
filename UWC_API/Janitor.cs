using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UWC_API
{
    public class Janitor
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public string status { get; set; } = String.Empty;
        public string job { get; set; } = String.Empty;
        public string vehicleName { get; set; } = String.Empty;
        public int vehicleId { get; set; } = 0;
        public int mcpId { get; set; } = 0;
        public string mcpName { get; set; } = String.Empty;
    }
}
