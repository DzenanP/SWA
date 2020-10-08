using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfApp_Example01;

namespace SimpleWPF_Example
{
    public class UILogic
    {
        public List<Transportation> WaitingList { get; set; }
        public List<Transportation> ReadyList { get; set; }
        public List<CargoItem> Details { get; set; }

        public UILogic()
        {
            WaitingList = new List<Transportation>();
            GenerateDemoEntries();
        }

        private void GenerateDemoEntries()
        {
            WaitingList.Add(new Transportation()
            {
                Countdown = 5,
                Destination = "Vienna",
                Source = "Linz",
                Cargo = new List<CargoItem>()
                {
                    new CargoItem()
                    {
                        Description = "Manna Schnitten",
                        Amount=1000,
                        Weight=2
                    },
                    new CargoItem()
                    {
                        Description = "Auer Torten Ecken",
                        Amount=2000,
                        Weight=3
                    }
                }
            });
            DispatcherTimer timer= new DispatcherTimer();

        }
    }
}
