using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Bol
    {
        public int BolId { get; set; }
        public int PersonId { get; set; }
        public DateTime DataNach { get; set; }
        public DateTime DataOcanch { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
