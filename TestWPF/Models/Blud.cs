using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Blud
    {
        public int? BludId { get; set; }
        public string BludName { get; set; } = null!;
        public int TovarId { get; set; }
        public int DolgnostId { get; set; }

    }
}
