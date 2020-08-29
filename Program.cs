using System;

namespace Findbiggernumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(33, 44, 12));
            Console.WriteLine(GetMaxBy1(33, 64, 55));
            Console.WriteLine(GetMaxByShort(88, 64, 555));

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2, int num3 )
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }else if (num2 >= num3 && num2 >= num1 )
            {
                result = num2;
            }else
            {
                result = num3;
            }

            return result;
        }
        static int GetMaxBy1 (int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num2 >= num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
        static int GetMaxByShort(int num1, int num2, int num3)
        {
            return (num1 >= num2 && num1 >= num3) ? num1
                 : (num2 >= num3) ? num2 : num3;
        }        
    }
}
