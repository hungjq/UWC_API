using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UWC_API
{
    public class MCP
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } = String.Empty;
        public string address { get; set; } = String.Empty;
        public string trollerName { get; set; } = String.Empty;
        public int capacity { get; set; } = 0;
        public int status { get; set; } = 0;
        public int collectorId { get; set; } = 0;
        public string collectorName { get; set; } = String.Empty;
        public int janitorId { get; set; } = 0;
        public string janitorName { get; set; } = String.Empty;
    }
}
