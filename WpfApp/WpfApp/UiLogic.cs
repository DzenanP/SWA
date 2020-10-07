using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_Example01;

namespace WpfApp_Example01
{
    public class UiLogic
    {
        public List<Transportation> WaitingList { get; set; }

        public List<Transportation> ReadyList { get; set; }
         public UiLogic()
         {
            WaitingList = new List<Transportation>();
            ReadyList = new List<Transportation>();
             LoadData();
         }

        private void LoadData()
        {
            WaitingList.Add(new Transportation()
            {
                Destination = "Wien",
                StartingPoint = "Salzburg",
                Countdown = 5,
                CargoItems = new List<CargoItem>()
                {
                    new CargoItem(){
                Amount = 5000,
                Description = "Manner Schnitten",
                Weight = 1000 },
                }
            });
        }
    }
}
