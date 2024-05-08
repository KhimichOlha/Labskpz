using SupportChainofResponsibility;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoSupport();
        }
        static void DemoSupport()
        {
            CustomerSupportSystem customerSupportSystem = new CustomerSupportSystem();
            customerSupportSystem.Start();
        }
    }
}
