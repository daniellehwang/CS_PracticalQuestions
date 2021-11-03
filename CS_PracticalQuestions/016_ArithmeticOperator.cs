using System;
namespace CS_PracticalQuestions
{
    public class _16_ArithmeticOperator
    { 
        // 정수/정수 = 정수
        // 정수/실수 = 실{
        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 67.89);
            Console.WriteLine(123.45 - 67.89);
            Console.WriteLine(123.45 * 67.89);
            Console.WriteLine(123.45 / 67.89);
            Console.WriteLine(123.45 % 67.89);
        }
    }
}
