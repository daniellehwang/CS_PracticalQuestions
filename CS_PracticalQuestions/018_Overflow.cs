using System;
namespace CS_PracticalQuestions
{
    public class _18_Overflow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);

            // y = int.MaxValue + 10; 컴파일시 에러발생.

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
