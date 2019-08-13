using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shirts.Models
{
    public class Shirt
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public double? Dirtiness { get; set; }

        public decimal? Price{ get; set; }

    }
}
