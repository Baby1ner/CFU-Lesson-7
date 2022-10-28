using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Bank
    {
        enum tip
        {
            current,
            saving
        }



        private int Id;
        private int Balans;
        private tip Type;


        public void account()
        {
            Console.WriteLine("Введите ID банка");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            Balans = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите тип (current, saving)");
            string balla1 = Console.ReadLine();
            string balla = balla1.ToLower();
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
        public void Print()
        {
            Console.WriteLine($"Номер = {Id}, Тип: {Type}, Баланс: {Balans}");
        }
    }
}
