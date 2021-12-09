using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Tovar
    {
        public int? TovarId { get; set; }
        public string TovarName { get; set; } = null!;
        public string Naznach { get; set; } = null!;
        public int SrocGodn { get; set; }
        public int TiptovaraId { get; set; }
    }
}
