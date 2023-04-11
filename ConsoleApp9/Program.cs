using System;
namespace project
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("inter an integer number(x)");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter an integer number(y)");
            int y = Convert.ToInt32(Console.ReadLine());
            calc(x, y);

        }//end main
        private static void calc(int x, int y)
        {
            Double Result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine(Result);
        }//end function

    }//end class
}//end name space