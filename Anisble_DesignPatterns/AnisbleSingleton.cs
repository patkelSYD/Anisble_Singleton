using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anisble_DesignPatterns
{
   public class AnisbleSingleton 
    {
        private static readonly AnisbleSingleton singleInstance = new AnisbleSingleton();
        public string currentText = "Initial Value";
        private AnisbleSingleton()
        {}
        static AnisbleSingleton()
        {
            //readonly object are initialised in static contructor 
        }
        public static AnisbleSingleton SingleInstance
        {
            get
            {
                return singleInstance;
            }
        }
       
        public  void Print(string text)
        {
            currentText = text;
            Console.WriteLine(text);
        }

        public void Print()
        {
            Console.WriteLine(currentText);
        }
    }

}
