using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Bank3
    {
        enum tip
        {
            current,
            saving
        }
        private int Id;
        private int Balans;
        private tip Type;

        private static HashSet<int> Random = new HashSet<int> { 0 };

        private int idk()
        {
            Random random = new Random();
            Id = random.Next(1, 100);
            if (!Random.Add(Id))
            {
                Id += 1;
            }
            return Id;
        }

        public void account()
        {

            int id1 = idk();
            Id = id1;
            Console.WriteLine("Введите баланс");
            Balans = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип (current, saving)");
            string balla = Console.ReadLine();
            switch (balla)
            {
                case "current":
                    Type = tip.current;
                    break;
                case "saving":
                    Type = tip.saving;
                    break;
                default:
                    Console.WriteLine("У банка нет такой услуги");
                    int ag = 0;
                    int a = ag / 0;
                    break;
            }
        }


        public void takeoff()
        {
            Console.WriteLine("Введите сумму, которую хотите снять");
            int off = int.Parse(Console.ReadLine());
            if (Balans > off)
            {
                Balans -= off;
            }
            else
            {
                Console.WriteLine("Неправильно попробуй еще раз");
                takeoff();
            }
        }

        public void takeon()
        {
            Console.WriteLine("Введите сумму, которую хотите внести");
            int on = int.Parse(Console.ReadLine());
            Balans += on;
        }

        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
    }
}
