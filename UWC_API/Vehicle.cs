using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UWC_API
{
    public class Vehicle
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public string status { get; set; } = String.Empty;
        public string plateNum { get; set; } = String.Empty;
        public int capacity { get; set; } = 0;
        public string collectorName { get; set; } = String.Empty;
        public string mcpName { get; set; } = String.Empty;

    }
}
