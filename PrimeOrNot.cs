//Prime Number or Not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int pm = 0;
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    pm = 1;
                    break;
                }
            }
            if(n==0 || n==1)
            {
                Console.WriteLine("Is neither prime or composite");
            }
            else
            {
                if(pm==0)
                {
                    Console.WriteLine("Is Prime");
                }
                else
                {
                    Console.WriteLine("Is not a prime Number");
                }
            }
        }
    }
}
