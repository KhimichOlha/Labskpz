using Adapter;
using Decorator;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoAdapter();
            DemoDecorator();
        }
        static void DemoAdapter()
        {
            FileWriter fileWriter = new FileWriter("log.txt");
            FileLoggerAdapter fileLoggerAdapter = new FileLoggerAdapter(fileWriter);
            fileLoggerAdapter.Error("HI");
            fileLoggerAdapter.Log("How are you?");
            fileLoggerAdapter.Warn("Good");
            fileLoggerAdapter.ErrorToFile("HI");
            fileLoggerAdapter.LogToFile("How are you?");
            fileLoggerAdapter.WarnToFile("Good");

        }
        static void DemoDecorator()
        {
            Hero warior = new Warrior();
            Console.WriteLine( warior.Type());
            warior.AddInventory(new Weapon(null));
            warior.AddInventory(new Armor(new Artifact(null)));
            warior.EquipInventories();

            Hero mage = new Mage();
            Console.WriteLine(mage.Type());
            mage.AddInventory(new Weapon(null));
            mage.AddInventory(new Armor(new Artifact(null)));
            mage.EquipInventories();

            Hero palladin = new Palladin();
            Console.WriteLine(palladin.Type());
            palladin.AddInventory(new Weapon(null));
            palladin.AddInventory(new Armor(null));
            palladin.EquipInventories();




        }
    }
}
