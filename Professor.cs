using System;

namespace ConsuleClass
{
    class Professor
    {
        public string firstName;
        public string lastName;
        public int bornYear;
        public bool isCar;
        public Professor(string _firstName, string _lastName, int _bornYear, bool _isCar)
        {
            firstName = _firstName;
            lastName = _lastName;
            bornYear = _bornYear;
            isCar = _isCar;
        }
        string GetDetails()
        {
            return $"firstName: {firstName}, lastName: {lastName}, bornYear: {bornYear}, isCar: {isCar}";
        }
        public void PrintDetails()
        {
            Console.WriteLine(this.GetDetails());
        }
        public void Over1995()
        {
            if (this.bornYear > 1995 && this.isCar)
            {
                Console.WriteLine($"name: {this.firstName} {this.lastName}");
            }
        }
    }
}
