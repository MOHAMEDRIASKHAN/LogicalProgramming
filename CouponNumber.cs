using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public static class CouponNumber
    {
        public static void DisplayCouponNumber()
        {
            var chars = "abcdefghijklmnopqurstuvwxyz";
            var stringChars = new char[6];
            var random = new Random();

            for(int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = stringChars[random.Next(stringChars.Length)];
            }
            var finalString = new String(stringChars);
        }
    }
}
