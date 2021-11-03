using System;
namespace CS_PracticalQuestions
{
    public class _29_GroupSeparator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("표시할 숫자를 입력하세요(종료: -1): ");
                string s = Console.ReadLine();
                double v = double.Parse(s);     //입력받은 숫자를 숫자로 바꿔 v에 할당.
                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));

            }
        }

        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;
            double v = Double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf('.');
                string formatStr = "{0:N" + (pos - 1) + "}";
                s = string.Format(formatStr, v);

            }
            else
                s = string.Format("{0:NO}", v);
            return s;
        }
    }
}
