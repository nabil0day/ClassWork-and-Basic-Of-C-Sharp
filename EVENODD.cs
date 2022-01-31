// Even or Odd Number
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=15;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i);
                    Console.WriteLine(" is Even Number! ");
                }
                else if(i%2!=0)
                {
                    Console.Write(i);
                    Console.WriteLine(" is Odd Number!");
                }
                

                
            }
        }
    }
}
