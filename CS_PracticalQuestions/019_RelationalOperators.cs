using System;
namespace CS_PracticalQuestions
{
    public class _19_RelationalOperators
    {
        //관계연산자: 판단과 반복문에 사용됨
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1}:{2}", first, second, result);

            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} < {1}:{2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);

            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);
        }
    }
}
