using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForTeamCity
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = new Program().PrintSomeText("hei");

            Console.Read();
        }

        public int PrintSomeText(string t)
        {
            Console.WriteLine(t);
            return 1;

        }
    }
}
