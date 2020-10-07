using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Example01
{
    class Transportation
    {
        public string StartingPoint { get; set; }
        public string Destination { get; set; }

        public int Countdown { get; set; }
        public List<CargoItem> CargoItems { get; set; }
    }
}
