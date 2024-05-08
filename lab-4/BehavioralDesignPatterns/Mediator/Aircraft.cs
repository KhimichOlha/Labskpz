namespace Mediator
{
    public class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; }
        public Aircraft(string name)
        {
            Name = name;
        }
        public void RequestLanding(ICommandCentre commandCentre)
        {
            commandCentre.RequestLanding(this);

        }
        public void RequestTakeOff(ICommandCentre commandCentre)
        {
            commandCentre.RequestTakeOff(this);
        }
    }
}

