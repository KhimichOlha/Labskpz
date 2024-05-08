using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportChainofResponsibility
{
    public class CustomerSupportSystem
    {
        private IHandler _firsthandler;
        public CustomerSupportSystem() 
        {
            _firsthandler = new LevelOneHandler();
            IHandler twohandler = new LevelTwoHandler();
            IHandler threehandler = new LevelThreeHandler();
            IHandler fourhandler = new LevelFourHandler();
            IHandler fivehandler = new LevelFiveHandler();
            _firsthandler.SetNext(twohandler).SetNext(threehandler).SetNext(fourhandler).SetNext(fivehandler);

        }
        public void Start()
        {
            Console.WriteLine("Дщброго вечора це ваша система підтримки");
            while (true)
            {
                Console.WriteLine("Ведіть від 1 до 5. 1 інформація про ваш номер. 2 інформація про ваш баланс або тариф." +
                    " 3 Перевірка або поповнення балансу.4 Перевірка балансу. 5 Поповнення балансу. 0 для виходу ");
                int level;
                if (!int.TryParse(Console.ReadLine(), out level)||  level < 0||  level > 5)
                {
                    Console.WriteLine("Неправельний ввід. Повторіть спробу.");
                    continue;
                }
                if (level == 0)
                {
                    break;
                }
                _firsthandler.Hendl(level);
            }
        }

    }
}
