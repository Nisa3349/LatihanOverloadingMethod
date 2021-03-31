using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
      
        public int FindMinimum(int number1, int number2)
        {
            int min1 = (number2 < number1) ? number2 : number1;
            return min1;
        }

        public int FindMinimum( int number1, int number2, int number3 )
        {
            int min = (number1 < number3) ? number3 : number1;
            return (number2 < min) ? number2 : min;
        }

        public int FindMaximum(int number1, int number2)
        {
            int max1 = (number1 > number2) ? number1 : number2;
            return max1;
        }

        public int FindMaximum(int number1, int number2, int number3)
        {        
            int max1 = (number1 > number2) ? number1 : number2;
            return (number3 > max1) ? number3 : max1;
        }
    }
}
