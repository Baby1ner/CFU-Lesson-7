using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Doma
    {

        private int Id;
        private short height;
        private byte floor;
        private short flat;
        private byte porch;


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

        public void dom()
        {
            int id1 = idk();
            Id = id1;
            Console.WriteLine("Введите высоту здания");
            height = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество этажей");
            floor = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество квартир");
            flat = short.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество подъездов");
            porch = byte.Parse(Console.ReadLine());
        }


        public void heightfloor()
        {
            Console.WriteLine($"Высота этажа {height / floor} метров");
        }
        private int flatinporch()
        {
            return flat / porch;
        }
        private int flatinfloor()
        {
            return flatinporch() / floor;
        }
        public void flatinf()
        {
            Console.WriteLine($"В подъезде: {flatinporch()} квартир, а на этаже {flatinfloor()} квартиры");
        }

        public void Print()
        {
            Console.WriteLine($"Номер: {Id}, Высота: {height}, Этажность: {floor},Количество квартир: {flat}, Количество подъездов: {porch} ");

        }


    }
}
