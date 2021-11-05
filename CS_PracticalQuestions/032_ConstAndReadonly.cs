using System;
namespace CS_PracticalQuestions
{
    /// <const>
    /// 상수는 변하지 않는 값
    /// 선언될 때 값이 할당됨.
    /// "Classname.VariableName"으로 사용.
    /// 컴파일 시 값이 결정됨.
    /// <readlonly>
    /// 읽기 전용, 변수를 선언하는 시점과 생성자 메서드에서만 값을 변경할 수 있음.
    /// 실행될 때 또는 객체가 생성자에 의해 초기화될 때 값이 할당됨.
    /// "InstanceName.VariableName"으로 사용
    /// 런타임 시 값이 결정됨.
    class ConstEx
    {
        public const int number = 3;    //const int number를 선언하고 3을 할당. number의 값을 변경할 수 없음.
    }

    class ReadonlyEx
    {
        public readonly int number = 10;    //
        public ReadonlyEx()             //ReadonlyEx() 생성자는 number값을 20으로 할당.
        {
            number = 20;
        }
        public ReadonlyEx(int n)        //int매개변수를 갖는 ReadonlyEx(int n) 생성자는 number값을 n으로 할당.
        {
            number = n;
        }
    }


    class _32_ConstAndReadonly
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number); // const사용 "클래스이름.변수명"

            ReadonlyEx inst1 = new ReadonlyEx(); //readonly 사용 "인스턴스명.변수명"
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100); //readonly 사용
            Console.WriteLine(inst2.number);
        }
    }
}
