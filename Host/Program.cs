using Model;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // && - условное И. если первое выражение фолс, то прирывает 
            // & - бинарное И. требуется все выражения в условии 

            /*
            0010 // 2
            &
            0110 // 6
            ===
            0010
            */

            /*
            1100 // 12
            &
            1010 // 8
            ===
            1000 // 8
            */

            /*
            1100  // 12
            |  OR
            1010  // 10
            ===
            1110  // 14
            */

            bool isHungry = false;

            if (isHungry & GetAndCheckCake())
            {
                Console.WriteLine("Задуваем свечи");
            }

            Console.WriteLine("EXIT");

            int a = 12;
            int b = 10;
            int resultAnd = a & b;

            Console.WriteLine("Result And = " + resultAnd);

            int resultOr = a | b;

            Console.WriteLine("Result Or = " + resultOr);
        }

        static bool GetAndCheckCake()
        {
            Console.WriteLine("going...");

            return true;
        }
    }
}
