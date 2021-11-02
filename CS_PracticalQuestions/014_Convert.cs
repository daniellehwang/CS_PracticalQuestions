using System;
namespace CS_PracticalQuestions
{
    public class _14_Convert
    {
        // Convert 클래스
        // ToInt32(), ToSingle(), ToDouble() string을 숫자형으로 바꾸는 메서드.
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} +{1} = {2}", x, y, x + y);

            // 2진수, 8진수, 10진수, 16진수로 출력
            short value = short.MaxValue;   //Int16.MaxValue
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i={0}, {1,2}진수={2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수={2,16}", i, baseNum, s);
        }
    }
}
