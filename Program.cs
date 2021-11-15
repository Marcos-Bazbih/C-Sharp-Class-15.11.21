using System;

namespace ConsuleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog("rex", "boxer", 3, true);
            //Dog dog2 = new Dog("messi", "boxer", 3, false);
            
            //Console.WriteLine($"dog name: {dog1.name},dog breed: {dog1.breed},dog age: {dog1.age},is vaccinated: {dog1.isVaccinated}");
            //Console.WriteLine(dog1.GetDogName());
            //Console.WriteLine(dog2.GetDogName());

            //Cat cat1 = new Cat("ben", "siami", 6, false);
            //cat1.printDetails();

            Student student1 = new Student("marcos", 23, 12);
            //student1.PrintDetails();
            //student1.Under8();

            Professor professor1 = new Professor("marcos", "bazbih", 1998, false);
            professor1.PrintDetails();
            professor1.Over1995();


        }
    }

}