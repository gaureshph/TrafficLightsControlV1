using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrafficLightsControlV1.Web.DomainModels;

namespace TrafficLightsControlV1.Web
{
    public class TrafficJunctionViewModel
    {
        public int JunctionId { get; set; }
        public string JunctionName { get; set; }
        public IEnumerable<TrafficSignal> TrafficSignals { get; set; }
    }
}