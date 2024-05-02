using Adapter;
using Bridge;
using Decorator;
using Proxy;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoAdapter();
            // DemoDecorator();
            // DemoBridge();
            DemoProxy();
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
        static void DemoBridge()
        {
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();
            Shape circle = new Circle(vectorRenderer);
            Shape square = new Square(vectorRenderer);
            Shape triangle = new Triangle(rasterRenderer);
            circle.Draw();
            square.Draw();
            triangle.Draw();

        }
        static void DemoProxy()
        {
            ISmartTextReader smartTextReader = new SmartTextReader();
            ISmartTextReader textChecker = new SmartTextChecker(smartTextReader);
            ISmartTextReader lockertext = new SmartTextReaderLocker(textChecker, @"\.txt$");
            var reth1 = lockertext.ReadText("text1.txt");
            var reth2 = lockertext.ReadText("textFile1.html");
        }
    }
}
