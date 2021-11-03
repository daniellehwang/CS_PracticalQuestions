using System;
namespace CS_PracticalQuestions
{
    public class _23_CompoundAssignment
    {
        // x = x + 2
        // x += 2
        // x++: x의 현재 값을 먼저 사용하고 x값 증가시킴
        // ++x: x를 먼저 증가시키고 사용
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            Console.WriteLine(x++);     //39를 출력하고 x는 40이 됨.
            Console.WriteLine(--x);     

        }
    }
}
