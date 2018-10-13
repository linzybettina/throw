using System;
using System.Collections.Generic;
using System.Text;

namespace throwkeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ourmoney = OurMoney(10, -10);

        }
        public static int OurMoney(int mymoney, int yourmoney)
        {
            if (mymoney < 0 || yourmoney < 0) throw new ArithmeticException("my money or your money is not valid");
            return mymoney + yourmoney;
        }
                
    }
}
