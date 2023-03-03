using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._2
{
internal class Program
    {
        static void Main(string[] args)
        {

            string stroka;
            string color;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Яку строку необхідно вивести?");
            stroka = Console.ReadLine();
            Console.WriteLine("Яким кольором?");

            color = Console.ReadLine();
            switch (color)
            {
                case "Red":
                PrintColor.Print(stroka, (int)Colors.Red);
                break;
                case "Green":
                    PrintColor.Print(stroka, (int)Colors.Green);
                    break;
                case "Blue":
                    PrintColor.Print(stroka, (int)Colors.Blue);
                    break;

            }

            Console.ReadLine();
        }
    }
}
