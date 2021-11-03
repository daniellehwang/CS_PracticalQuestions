using System;
namespace CS_PracticalQuestions
{
    public class _25_SplitMethod
    {
        static void Main(string[] args)
        {
            Console.Write("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();     //s.Split()으로 입력 문자열을 빈칸으로 나눠 string배열 v에 넣는다.
            foreach(var i in v)         //배열에 저장된 개수가 몇개인지 모르므로 foreach()문을 사용하는것이 좋다.
            {
                sum += int.Parse(i);    //int.Parse()로 배열의 각 요소 i를 정수로 변환하여 sum에 더하고 결과를 출력.
            }
            Console.WriteLine("결과는 {0}", sum);
        }
    }
}
