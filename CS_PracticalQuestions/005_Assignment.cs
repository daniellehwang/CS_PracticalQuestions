using System;
namespace CS_PracticalQuestions
{
    public class _05_Assignment
    {
        // '대입문' =
        // (identifier)변수 = (value)값

        static void Main(string[] args)
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i = " + i + ", x = " + x);

            x = i;
            i = (int)x;
            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
