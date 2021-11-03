using System;
namespace CS_PracticalQuestions
{
    public class _17_DivideByZero
    {

        // 0으로 나눌때 예외
        // DividedByZeroException: 10.0/0 
        // Overflow Exception: try~catch
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            Console.WriteLine(10.0 / y);
            Console.WriteLine(x / y);

            try
            {
                Console.WriteLine(x / y);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
