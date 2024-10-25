using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class TransportSchedule {
        public string Type { get; set; }
        public int Route { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int Price { get; set; }
        public int SeatAvailable { get; set; }
    }
}
