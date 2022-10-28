using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T00Much
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 7.1");
            Bank bank = new Bank();
            bank.account();
            bank.Print();
            




            Console.WriteLine("Упражнение 7.2");
            Bank2 bank2 = new Bank2();
            bank2.account();
            bank2.Print();
            


            Console.WriteLine("Упражнение 7.3");
            Bank3 bank3 = new Bank3();
            bank3.account();
            bank3.Print();
            bank3.takeoff();
            bank3.Print();
            bank3.takeon();
            bank3.Print();
            


            Console.WriteLine("Домашнее задание 7.1");
            Doma doma = new Doma();
            doma.dom();
            doma.Print();
            doma.flatinf();
            doma.heightfloor();
        }
    }

    




}
