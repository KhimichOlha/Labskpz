using AuthenticatorSingleton;
using BuilderPerson;
using DeviceFactoryLogic;
using FactorySubscription;
using VirusPrototype;

namespace DemoSubscription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoAbstractFactory();
            // DemoFactotyMethod();
            //DemoAuthenticator();
            //DemoPrototype();
            DemoBuider();
        }

        static void DemoBuider()
        {
            HeroBuilder heroBuilder = new HeroBuilder();
            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            Character hero = heroDirector.Constrat();

            Console.WriteLine("Hero:" + hero.GetInfo());

        }

        static void DemoPrototype()
        {
            Virus virus1 = new Virus(0.01, 3, "tomovirus", "Шкідник");
            Virus virus2 = new Virus(0.01, 2, "delvirus", "Знищувач");
            Virus virus3 = new Virus(0.01, 1, "applvirus", "Хробак");
            Virus virus4 = new Virus(0.01, 1, "televirus", "Комбінований");
            virus1.AddChild(virus2);
            virus1.AddChild(virus3);
            virus1.AddChild(virus4);
            virus2.AddChild(virus3);
            virus2.AddChild(virus4);
            Virus clonvirus1 = (Virus)virus1.Clone();
            Console.WriteLine("Cloned Virus Hierarchy:\n" + virus1.DisplayInfo());
        }

        static void DemoAuthenticator()
        {
            Authenticator authenticatorone = Authenticator.GetInstance();
            Authenticator authenticatortwo = Authenticator.GetInstance();
            if (authenticatorone != authenticatortwo)
            {
                Console.WriteLine("Це два різні обєкта");
            }
            else
            {
                Console.WriteLine("Це один обєкт");
            }
        }
        static void DemoAbstractFactory()
        {
            IDevice proneDevice = new Prone();
            IDevice kiaomiDevice = new Kiaomi();
            IDevice balaxyDevice = new Balaxy();
            Console.WriteLine(proneDevice.CreateNetbook().Doing());
            Console.WriteLine(kiaomiDevice.CreateSmartphone().Doing());
            Console.WriteLine(balaxyDevice.CreateSmartphone().Doing());


        }

        static void DemoFactotyMethod()
        {
            CreatorSubscription creatorMobile = new MobileApp();
            ISubscription domesticSubscription = creatorMobile.CreateSubscription();
            CreatorSubscription creatorWeb = new WebSite();
            ISubscription educationalSubscription = creatorWeb.CreateSubscription();
            CreatorSubscription creatorManager = new ManagerCall();
            ISubscription premiumSubscription = creatorManager.CreateSubscription();
            Print(domesticSubscription);
            Print(educationalSubscription);
            Print(premiumSubscription);
        }
        static void Print(ISubscription subscription)
        {
            Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
            Console.WriteLine($"Minimum Subscription Months: {subscription.MinSubscriptionMonths}");
            Console.WriteLine("Channels:");
            foreach (var channel in subscription.Channels)
            {
                Console.WriteLine($"- {channel}");
            }
        }
    }
}
