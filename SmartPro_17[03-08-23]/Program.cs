using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_17_03_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double _user_number;

            do
            {
                Console.Clear();
                Console.Write("Positive Number: ");
                _user_number = double.Parse(Console.ReadLine());
                
            }
            while (_user_number < 0);

            Console.Clear();
            Console.WriteLine("Your Positive Number: " + _user_number);
            Console.ReadKey();

        }
    }
}
