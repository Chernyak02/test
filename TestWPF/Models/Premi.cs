using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Premi
    {
        public int PremiId { get; set; }
        public int PersonId { get; set; }
        public int Viplata { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
