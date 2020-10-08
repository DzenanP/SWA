using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Example01;

namespace SimpleWPF_Example
{
    public class Transportation
    {
        public string Destination { get; set; }
        public string Source { get; set; }
        public int Countdown { get; set; }
        public List<CargoItem> Cargo { get; set; }

        public override string ToString()
        {
            return $"{Source} - {Destination} - {Countdown}";
            //return Source + "-" + Destination + "-" + Countdown;
        }
    }
}