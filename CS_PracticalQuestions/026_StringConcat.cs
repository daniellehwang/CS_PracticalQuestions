using System;
namespace CS_PracticalQuestions
{
    public class _26_StringConcat
    {
        /// <문자열을 연결하는 4가지 방법>
        /// 1. '+' 연산자 사용
        /// 2. 문자열 보간(interpolation)
        /// 3. String.Format() 메서드
        /// 4. String.Concat() 와 String.Join()
        /// </summary>

        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";
                Console.WriteLine(strInterpolation);

            string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}
