using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp
{
    class STR
    {
        public static double stateBrackets0(double income)
        {
            // TODO Auto-generated method stub
            double max = 8500;
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double stateDifference(double income)
        {
            // TODO Auto-generated method stub
            double max = 8500;
            if (income > max)
            {
                return income - max;
            }
            else

                return income;
        }

        public static double stateBrackets1(double income)
        {
            // TODO Auto-generated method stub
            double max = 11700;

            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double stateDifference1(double income)
        {
            // TODO Auto-generated method stub		
            double max = 11700.0;
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double stateBrackets2(double income)
        {
            // TODO Auto-generated method stub
            double max = 13900;
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double stateDifference2(double income)
        {
            // TODO Auto-generated method stub		
            double max = 13900.0;
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }


        public static double stateDifference3(double income)
        {
            // TODO Auto-generated method stub
            double max = 21400.0;
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }


        public static double stateBrackets3(double income)
        {
            // TODO Auto-generated method stub
            double max = 21400;
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double stateBrackets4(double income)
        {
            // TODO Auto-generated method stub
            double max = 80650;
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double stateDifference4(double income)
        {
            // TODO Auto-generated method stub
            double max = 80650.0;
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double stateBrackets5(double income)
        {
            // TODO Auto-generated method stub
            double max = 215400;
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }
        public static double stateDifference5(double income)
        {
            // TODO Auto-generated method stub
            double max = 215400.0;
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }
    }
}
