using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Otpysc
    {
        public int OtpyscId { get; set; }
        public int PersonId { get; set; }
        public DateTime DataNach { get; set; }
        public DateTime DataOcanch { get; set; }
        public int Viplata { get; set; }

        public virtual Person Person { get; set; } = null!;
    }
}
