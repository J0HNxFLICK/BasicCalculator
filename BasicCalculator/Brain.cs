using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Brain
    {
        public void addition(int first, int second)
        {
            int result = first+ second;
            Console.WriteLine("The addition of the numbers is : "+result);
        }

        public void substraction(int first, int second)
        {
            int result = first- second;
            Console.WriteLine("The substraction of the number is : " + result);
        }
    }
}
