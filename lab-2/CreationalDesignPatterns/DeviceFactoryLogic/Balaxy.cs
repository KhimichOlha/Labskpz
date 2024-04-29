namespace DeviceFactoryLogic
{
    public class Balaxy : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("Balaxy");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("Balaxy");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("Balaxy");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Balaxy");
        }
    }
}
