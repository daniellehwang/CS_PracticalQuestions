using System;
namespace CS_PracticalQuestions
{
    public class _06_ConsoleWriteLine
    {

        // double 과 float 의 차이점?
        // float는 4byte, 7자리
        // double은 8byte, 15~16자리
        static void Main(string[] args)
        {
            bool b = true;
            char c = 'A';
            decimal d = 1.234m; //m은 decimal
            double e = 1.23456789;
            float f = 1.23456789f;  //f는 float 
            int i = 1234;
            string s = "Hello";

            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine(s);

            Console.Write(b);
            Console.Write(c);
        }
    }
}
