using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            long a1 = 4111111111111111;

            GetIssuer GIA1 = new GetIssuer(a1);
            GIA1.CheckIssuer();

            Console.WriteLine("Type of card : {0}", GIA1.CheckIssuer());
            Console.ReadKey();
        }
    }
}
