using System;
namespace CS_PracticalQuestions
{
    public class Variable
    {
        // 변수 == 값을 저장하는 곳
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요, ");
            Console.Write(age);
            Console.Write("세, 키는 ");
            Console.Write(height);
            Console.WriteLine("cm 이군요!");
        }
    }
}
