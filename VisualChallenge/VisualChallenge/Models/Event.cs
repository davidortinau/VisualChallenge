using System;
using System.Collections.Generic;
using System.Text;

namespace VisualChallenge.Models
{
    public class Event
    {
        public string Destination { get; set; }
        public string Airplane { get; set; }

        public string AirplaneCode { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
