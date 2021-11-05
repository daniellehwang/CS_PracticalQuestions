using System;
namespace CS_PracticalQuestions
{
    public class _34_PassingArrayAndObject
    {
        // 배열은 참조형, 배열의 이름은 그 배열이 저장된 곳의 참조이다.
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);
            Change(arr);
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);

            Student s1 = new Student();
            s1.name = "Alpha";
            Console.WriteLine("Main() before: " + s1.name);
            Change(s1);
            Console.WriteLine("Main() after: " + s1.name);
        }
        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student s1)
        {
            s1.name = "Beta";
        }
    }
    class Student
    {
        public string name;
    }
}
