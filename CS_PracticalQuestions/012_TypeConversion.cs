using System;
namespace CS_PracticalQuestions
{
    public class _12_TypeConversion
    {
        // 형변환: 하나의 자료형을 다른 자료형으로 바꾸는것
        // 암시적 형변환: float에서 double로 형변환(작은 자료형-> 큰 자료형)은 데이터 손실이 없음.
        //              자동으로 형이 변환됨.
        // 명시적 형변환: double에서 int(큰 자료형-> 작은 자료형)은 데이터 손실 생김.
        //              강제로 형변환.
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;      //암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;             //강제 형변환
            Console.WriteLine(a);
        }
    }
}
