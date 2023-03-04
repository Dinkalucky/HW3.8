using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bDay;
            int bMonth;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть день вашого народження");
            Int32.TryParse(Console.ReadLine(), out bDay);

            Console.WriteLine("Введіть місяць вашого народження");
            Int32.TryParse(Console.ReadLine(), out bMonth);

            DateTime now = DateTime.Now;
            DateTime myNextBirthday = new DateTime(DateTime.Now.Year,bMonth,bDay);
            Console.WriteLine("До наступного дня народження залишилось "+(int)(myNextBirthday-now).TotalDays + " днів");
            Console.ReadLine();
        }
    }
}
