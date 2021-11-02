using System;
namespace CS_PracticalQuestions
{
    public class _04_string
    {
        /// <연산자>
        ///  A  변수명
        /// 'A' 문자(char)
        /// "A" 문자열(string)
        ///
        ///  a == b string a 와 b가 같다.
        ///  a != b string a 와 b가 같지 않다.
        ///  a + b string a 와 b를 연결한다.
        /// </summary>

        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
