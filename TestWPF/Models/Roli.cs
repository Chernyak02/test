using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Roli
    {
        public int RoliId { get; set; }
        public string Login { get; set; } = null!;
        public string Parol { get; set; } = null!;
    }
}
