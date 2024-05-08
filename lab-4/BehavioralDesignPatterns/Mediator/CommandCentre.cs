using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways = new List<Runway>() ;
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        
        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }
        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsAvailable())
                {
                    runway.Land(aircraft);
                    return;
                }
            }
            Console.WriteLine($"No available runway for landing for {aircraft.Name}");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsFree())
                {
                    runway.TakeOff(aircraft);
                    return;
                }
            }
            Console.WriteLine($"No available runway for takeoff for{aircraft.Name}");
        }
    }
}
