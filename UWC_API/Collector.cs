using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UWC_API
{
    public class Collector
    {
             [Key]
            public int id  { get; set; }
            public string name { get; set; } = String.Empty;
            public bool status { get; set; }
            public string job { get; set; } = String.Empty;
            public string vehicleName { get; set; } = String.Empty;
            public int vehicleId { get; set; } = 0;


    }
}
