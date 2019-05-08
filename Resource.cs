using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp
{
    class Resource
    {
        //Form1 f1 = new Form1();
        public static double brackets0(double income, string status)
        {
            // TODO Auto-generated method stub
            //Console.Write(Form1.deduction);
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 9525;
            }else if(status == "Married filing jointly")
            {
                max = 19050;
            }else if(status == "Head of Household")
            {
                max = 13600;
            }

            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double difference(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 9525;
            }
            else if (status == "Married filing jointly")
            {
                max = 19050;
            }
            else if (status == "Head of Household")
            {
                max = 13600;
            }
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double brackets1(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 38700;
            }
            else if (status == "Married filing jointly")
            {
                max = 77400;
            }
            else if (status == "Head of Household")
            {
                max = 51800;
            }

            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double difference1(double income, string status)
        {
            // TODO Auto-generated method stub		
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 38700;
            }
            else if (status == "Married filing jointly")
            {
                max = 77400;
            }
            else if (status == "Head of Household")
            {
                max = 51800;
            }
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double brackets2(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 82500;
            }
            else if (status == "Married filing jointly")
            {
                max = 165000;
            }
            else if (status == "Head of Household")
            {
                max = 82500;
            }
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double difference2(double income, string status)
        {
            // TODO Auto-generated method stub		
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 82500;
            }
            else if (status == "Married filing jointly")
            {
                max = 165000;
            }
            else if (status == "Head of Household")
            {
                max = 82500;
            }
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double difference3(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 157500;
            }
            else if (status == "Married filing jointly")
            {
                max = 315000;
            }
            else if (status == "Head of Household")
            {
                max = 157500;
            }
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

        public static double brackets3(double income, string status)
        {
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 157500;
            }
            else if (status == "Married filing jointly")
            {
                max = 315000;
            }
            else if (status == "Head of Household")
            {
                max = 157500;
            }
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }

        public static double brackets4(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 200000;
            }
            else if (status == "Married filing jointly")
            {
                max = 400000;
            }
            else if (status == "Head of Household")
            {
                max = 200000;
            }
            if (income > max)
            {
                return max;
            }
            else
                return income;
        }
        public static double difference4(double income, string status)
        {
            // TODO Auto-generated method stub
            double max = 0;
            if (status == "Single" || status == "Married filing separately" || status == "")
            {
                max = 200000;
            }
            else if (status == "Married filing jointly")
            {
                max = 400000;
            }
            else if (status == "Head of Household")
            {
                max = 200000;
            }
            if (income > max)
            {
                return income - max;
            }
            else

                return 0;
        }

    }
}
