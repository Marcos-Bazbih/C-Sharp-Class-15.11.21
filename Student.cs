using System;

namespace ConsuleClass
{
    class Student
    {
        public string fullName;
        public int age;
        public int grade;
        public Student(string _fullName, int _age, int _grade)
        {
            this.fullName = _fullName;
            this.age = _age;
            this.grade = _grade;
        }
        string GetDetails()
        {
            return $"fullName: {fullName}, age: {age}, grade: {grade}";
        }
        public void PrintDetails()
        {
            Console.WriteLine(this.GetDetails());
        }
        public void Under8()
        {
            if(this.age < 8)
            {
                Console.WriteLine("יסודי");
            }
            else
            {
                Console.WriteLine("older then 8");
            }
        }
    }
}
