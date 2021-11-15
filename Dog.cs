using System;

namespace ConsuleClass
{
    class Dog
    {
        public string name;
        public string breed;
        public int age;
        public bool isVaccinated;
        public Dog(string _name, string _breed, int _age, bool _isVaccinated)
        {
            this.name = _name;
            this.breed = _breed;
            this.age = _age;
            this.isVaccinated = _isVaccinated;
        }
        public string GetDogName()
        {
            return $"dog name: {this.name},dog breed: {this.breed},dog age: {this.age},is vaccinated: {this.isVaccinated}";
        }

    }
}
