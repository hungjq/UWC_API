using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace UWC_API
{
    public class Collector
    {
             [Key]
             public int eId  { get; set; }
            public string name { get; set; } = String.Empty;
            public string status { get; set; } = String.Empty;
            public string job { get; set; } = String.Empty;
            public string vName { get; set; } = String.Empty;
            public int vId { get; set; } = 0;
             public int rId { get; set; } = 0;
            public string rName { get; set; } = String.Empty;
            public string rAddress { get; set; } = String.Empty;

    }
}
