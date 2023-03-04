using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            accountant.AskForBonus(Post.SEO,310);
            Console.ReadLine();
        }
    }
}
