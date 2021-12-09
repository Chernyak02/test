using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Person
    {
        public Person()
        {
            Bols = new HashSet<Bol>();
            Otpyscs = new HashSet<Otpysc>();
            Premis = new HashSet<Premi>();
            Stols = new HashSet<Stol>();
        }

        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string Familia { get; set; } = null!;
        public string? Otchestvo { get; set; }
        public int NomerPasp { get; set; }
        public int SeriaPasp { get; set; }
        public int DolgnostId { get; set; }

        public virtual Dolgnost Dolgnost { get; set; } = null!;
        public virtual ICollection<Bol> Bols { get; set; }
        public virtual ICollection<Otpysc> Otpyscs { get; set; }
        public virtual ICollection<Premi> Premis { get; set; }
        public virtual ICollection<Stol> Stols { get; set; }
    }
}
