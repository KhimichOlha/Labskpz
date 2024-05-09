using Mediator;
using SupportChainofResponsibility;
using System.Net.Http.Headers;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoSupport();
            DemoMediator();
        }
        static void DemoSupport()
        {
            CustomerSupportSystem customerSupportSystem = new CustomerSupportSystem();
            customerSupportSystem.Start();
        }
        static void DemoMediator()
        {
            Aircraft aircraft1 = new Aircraft("Boeng");
            Aircraft aircraft2 = new Aircraft("An");
            Aircraft aircraft3 = new Aircraft("Sv");
            Runway runway1 = new Runway();
            Runway runway2 = new Runway();
            ICommandCentre command = new CommandCentre(new Runway[]{ runway1, runway2 },new Aircraft[]{  aircraft2, aircraft1 });
            command.RequestLanding(aircraft1);
            command.RequestTakeOff(aircraft2);
        }
    }
}
