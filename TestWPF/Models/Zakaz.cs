using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Zakaz
    {
        public int ZakazId { get; set; }
        public string ZakazKod { get; set; } = null!;
        public int ZakazKol { get; set; }
        public int BludId { get; set; }
        public int ZakazStoim { get; set; }

        public virtual Blud Blud { get; set; } = null!;
    }
}
