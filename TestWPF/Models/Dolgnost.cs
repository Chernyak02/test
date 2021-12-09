using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Dolgnost
    {
        public Dolgnost()
        {
            Bluds = new HashSet<Blud>();
            People = new HashSet<Person>();
        }

        public int DolgnostId { get; set; }
        public string Dolgnost1 { get; set; } = null!;
        public int Zarpl { get; set; }

        public virtual ICollection<Blud> Bluds { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
