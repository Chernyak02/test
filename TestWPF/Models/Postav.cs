using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Postav
    {
        public int PostavId { get; set; }
        public string PostavName { get; set; } = null!;
        public int PostavOpl { get; set; }
        public DateTime Dost { get; set; }
    }
}
