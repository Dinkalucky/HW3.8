using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
    public class Accountant
    {
        public void AskForBonus(Post ourWorker, int ourHours)
        {
            if (ourHours > (int)ourWorker)
            {
                Console.WriteLine("Ви заслужили премію");
            }
            else
            {
                Console.WriteLine("Премії не буде");
            }
        }
    }
}
