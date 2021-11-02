using System;
namespace CS_PracticalQuestions
{
    class ConsoleReadWrite
    {
        /// <콘솔 입출력 메서드>
        ///  int Console.Read()
        ///  콘솔에서 한 글자를 읽는다.
        ///  
        ///  string Console.ReadLine()
        ///  콘솔에서 한 줄을 읽는다.
        ///  
        ///  void Console.Write(string)
        ///  콘솔에 문자열(string)을 출력.
        ///  
        ///  void Console.WriteLine(string)
        ///  콘솔에 문자열(string)을 출력하고 줄 바꿈.
        /// </summary>

        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.Write("이름을 입력하세요: ");

            string name = Console.ReadLine();   //이름을 입력받음.
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");
        }
    }
}
