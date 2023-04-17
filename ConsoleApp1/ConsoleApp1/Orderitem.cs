using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Orderitem
    {
        public product Product { get; set; }
        public int id{ get; set; }
        public int TotalPrice { get; set; }
        public int count { get; set; }
    }
}
