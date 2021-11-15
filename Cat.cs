using System;

namespace ConsuleClass
{
    class Cat
    {
        public string name;
        public string breed;
        public int age;
        public bool isVaccinated;
        public Cat(string _name, string _breed, int _age, bool _isVaccinated)
        {
            this.name = _name;
            this.breed = _breed;
            this.age = _age;
            this.isVaccinated = _isVaccinated;
        }
        public void printDetails()
        {
            Console.WriteLine(this.GetDetails());
        }
        string GetDetails()
        {
            return $"name: {this.name}, breed: { this.breed}, age: {this.age},is Vaccinated : { this.isVaccinated}";
        }
    }
}
