using Model;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Class1.Print();
           // Console.ReadKey();

            var a = 120;

            if (a == 1)
            {
                Console.WriteLine("1 case: 1");
            }
            else if (a > 500)
            {
                Console.WriteLine("2 case: > 500");
            }
            else if (a == 123)
            {
                Console.WriteLine("3 case: 123");
            }
            else 
            {
                Console.WriteLine("FallBack");
            }



        }
    }
}
