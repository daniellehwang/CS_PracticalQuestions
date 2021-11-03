using System;
namespace CS_PracticalQuestions
{
    public class _20_LogicalOperators
    {
        // 논리 연산자: &&(AND), ||(OR), ^(배타적 OR), !(NOT)
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = true ^ false;
            Console.WriteLine("{0}^{1} : {2}", true, false, result);

            result = !(first > second);
            Console.WriteLine("!{0} : {1}", first > second, result);
        }
    }
}
