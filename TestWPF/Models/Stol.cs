using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Stol
    {
        public int StolId { get; set; }
        public string StolName { get; set; } = null!;
        public int PersonId { get; set; }
        public string Sost { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
