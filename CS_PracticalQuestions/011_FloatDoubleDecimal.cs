using System;
namespace CS_PracticalQuestions
{
    public class _11_FloatDoubleDecimal
    {
        /// <float, double, decimal 차이>
        /// 정밀도:
        /// float는 7자리, double은 15~16자리, decimal은 28~29자리.
        /// decimal은 훨씬 정밀한 숫자를 표시할 수 있어서 금융 프로그램에 적합.
        /// 
        /// 표현할 수 있는 수의 범위:
        /// float 나 double은 decimal보다 더 크거나 작은 값을 표현 가능.
        /// 과학적인 계산이 필요한 프로그램에 적합.
        /// 
        /// 저장 공간의 크기와 계산 속도:
        /// float는 4바이트, double은 8바이트, decimal은 16바이트.
        /// float와 double이 속도가 훨씬 빠르다.
        /// 
        /// 접미사:
        /// 실수를 별도로 표시하지 않으면 double로 인식함.
        /// float(f), decimal(m)
        /// </summary>  
        static void Main(string[] args)
        {
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

            Console.WriteLine("float: {0}\ndouble : {1}\ndecimal : {2}",
                flt, dbl, dcm);
            Console.WriteLine("float : {0} bytes\ndouble : {1} bytes\ndecimal : {2} bytes",
                sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0}~{1}", float.MinValue,
                float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue,
                double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue,
                decimal.MaxValue);
        }
    }
}
