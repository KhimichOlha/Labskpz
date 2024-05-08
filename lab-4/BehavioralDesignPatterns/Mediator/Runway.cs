using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft;
        public bool IsAvailable()
        {
            return IsBusyWithAircraft == null;
        }
        public bool IsFree()
        {
            return IsBusyWithAircraft != null && ! IsBusyWithAircraft.IsTakingOff;

        }
        public  void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {Id}.");
            IsBusyWithAircraft = aircraft;

        }
        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {Id}.");
            IsBusyWithAircraft = null;
        }
    }
}
