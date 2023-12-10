using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_day18
{
    internal static class IntegerMirror
    {

        public static int Miror(this int number)
        {
            // 12345 ==> 54321
            int result = 0, reminder;

            while (number != 0)
            {
                reminder = number % 10;

                result = result * 10 + reminder;

                number = number / 10;


            }
            return result;
        }



    }
}
