namespace Host
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет консоли 

            Model.ErrorCode myVariable = Model.ErrorCode.ConnectionLost;
            Console.WriteLine("MyVariable = {0}", myVariable);

            var today = Model.Days.Sunday;
            int todayInt = (int)today;

            Console.WriteLine("Today variable = {0}", today);
            Console.WriteLine("TodayInt variable = {0}", todayInt);

            int tomorrowInt = 2;
            Model.Days tomorrowEnum = (Model.Days)tomorrowInt;

            Console.WriteLine("tomorrowEnum variable = {0}", tomorrowEnum);

            int intNine = 9;
            Model.Days nineEnum = (Model.Days)intNine;

            Console.WriteLine("nineEnum variable = {0}", nineEnum);

            if (nineEnum == Model.Days.Saturday)
            { 
            }

            if ((int)nineEnum == 32)
            {
            }

            Console.WriteLine("Weekend = {0}", (Model.Days)96);

            var lessonDays = Model.Days.Monday | Model.Days.Thursday;

            Model.Days currentDay = Model.Days.Friday;

            if (lessonDays.HasFlag(currentDay))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Flag presented = {0}", currentDay);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Flag not presented = {0}", currentDay);
            }

        }
    }
}
