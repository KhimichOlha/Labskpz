namespace SupportChainofResponsibility
{
    public class LevelOneHandler :SupportHandler
    {
        public override void Hendl(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("1 інформація про ваш номер");
            }
            else
            {
                base.Hendl(request);
            }
            
        }
    }
}
