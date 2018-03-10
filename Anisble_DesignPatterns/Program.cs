using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anisble_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            AnisbleSingleton.SingleInstance.currentText = "From Prg";
            AnisbleSingleton.SingleInstance.Print();
            Console.ReadLine();


            AnisbleSingleton.SingleInstance.Print();
            Console.ReadLine();

            AnisbleSingleton.SingleInstance.Print("First");
            Console.ReadLine();

            AnisbleSingleton.SingleInstance.Print("Second");
            Console.ReadLine();

            AnisbleSingleton.SingleInstance.Print();
            Console.ReadLine();

             
    }
    }
}
