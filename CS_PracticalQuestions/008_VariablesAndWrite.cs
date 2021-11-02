using System;
namespace CS_PracticalQuestions
{
    public class _08_VariablesAndWrite
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2);    //에러 발생
            //2개의 변수를 각각 문자열로 바꿔 연결, 하나의 문자열로 출력
            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);

            //형식 정보 사용, 여러 개의 변수나 값을 출력하는 방법
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);

            //문자열 보간 방법
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
        }
    }
}
