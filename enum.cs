using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTAPP
{
    class program2
    {
        public enum Salutation
        {
            Mr = 0,
            Ms = 1,
            Mrs = 2,
            Dr = 3
        }
        class Class1
        {
            static void Main(string[] args)
            {
                Salutation salutation;
                string name;
                Console.WriteLine("Enter the Salutation:");
                salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
                //Console.WriteLine(typeof(string));
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
                Console.Write("\nYour NAme is: {0}", salutation.ToString());
                Console.Write("." + name);
                Console.ReadLine();
            }

        }
    }
}
