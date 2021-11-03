using System;
namespace CS_PracticalQuestions
{
    public class _27_StringContains
    {
        // 문자열 검색 메서드
        // 1. Contains() 메서드
        // 2. IndexOf() 메서드: 특정 문자 또는 문자열이 나타나는 인덱스를 리턴해줌
        // 3. 대소문자를 구분하지 않는 비교
        // 4. String.StartsWith() 와 String.EndsWith() 메서드 
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow";      //s2 = "cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);

            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }

            if(s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1);
            }
        }
    }
}
