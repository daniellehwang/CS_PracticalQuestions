using System;
namespace CS_PracticalQuestions
{
    /// <값 형식 value type>
    /// 변수가 실제 데이터 값을 저장하는 형식
    /// 기본 C# 형식(int, double, char, bool ..), enum, struct
    ///
    /// <참조 형식 reference type>
    /// 변수가 값이 저장되어 있는 곳의 위치(=참조, reference)를 저장하는 형식
    /// object, string, dynamic, class, interface, delegate
    ///
    /// *string/배열은 참조 형식. 긴 문자열이나 배열이 있을수 있어서,
    /// 문자열이나 배열의 데이터는 힙 영역에 저장, 스택에는 참조만 저장.
    public class _33_ValueAndReference
    {
        static void Main(string[] args)
        {
            string s = "before passing";
            Console.WriteLine(s);

            Test(s);                // 메서드 안에서 s가 변하지만, 로컬변수 s의 내용이 바뀐 것이므로 Main에서는 값이 변하지 않음.
            Console.WriteLine(s);

            Test(ref s);            // ref 키워드에 의해 s의 값이 변하면 Main에서도 바뀜.
            Console.WriteLine(s);


        }
        public static void Test(string s)
        {
            s = "after passing";
        }

        public static void Test(ref string s)
        {
            s = "after passing";
        }
    }
}
