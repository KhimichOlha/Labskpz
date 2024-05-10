using Composer;
using Composer.Strategy;
using Mediator;
using SupportChainofResponsibility;
using Memento;
using System.Net.Http.Headers;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DemoSupport();
            // DemoMediator();
            // DemoObserver();
            //Demostrategy();
            DemoMemento();

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
        static void DemoObserver()
        {
            LightElementNode button = new LightElementNode("button", false, false, null, null);
            EventListener click = new EventListener("click", (data) => Console.WriteLine("button clicked"));
            button.Attach(click);
            button.Notify("click", null);
        }
        static void Demostrategy()
        {
            IImageLoadingStrategy fileSystemStrategy = new FileSystemImageLoadingStrategy();
            ImageElementNode fileSystemImageNode = new ImageElementNode("photo_2024-03-04_19-21-05.jpg", fileSystemStrategy);

            
            byte[] fileSystemImageData = fileSystemImageNode.ImageData();
            Console.WriteLine($"File system image loaded. Image data length: {fileSystemImageData.Length}");

            
            IImageLoadingStrategy networkStrategy = new NetworkImageLoadingStrategy();
            ImageElementNode networkImageNode = new ImageElementNode("https://img.freepik.com/free-photo/beautiful-kitten-with-colorful-clouds_23-2150752964.jpg", networkStrategy);

            
            byte[] networkImageData = networkImageNode.ImageData();
            Console.WriteLine($"Network image loaded. Image data length: {networkImageData.Length}");

          

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static void DemoMemento()
        {
            
            TextEditor textEditor = new TextEditor();
            textEditor.CreatDocument("Dашого LightHTML з завдання");
            textEditor.SaveChanges("Покажіть скільки займає все дерево");
            textEditor.Print();
            textEditor.UndoChanges();
            textEditor.Print();
        }
    }
}
