using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_4
{
    internal class Person
    {
        private string _name;
        private DateTime _birthYear;

        public string Name 
        {
            get { return _name; }
        }

        public DateTime BirthYear 
        {
            get { return _birthYear; }
        }

        public Person()
        {
            _name = "Jon";
            _birthYear = new DateTime();
        }

        public Person(string name, DateTime birthYear) 
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - _birthYear.Year;

            if (now < _birthYear.AddYears(age)) age--;
            return age;
        }

        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            _name = Console.ReadLine();

            Console.Write("Введіть рік народження: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthYear))
            {
                _birthYear = birthYear;
            }
            else
            {
                Console.WriteLine("Невiрний формат року народження.");
            }
        }

        public void ChangeName(string NewName) 
        {
            _name = NewName;

        }
        public override string ToString()
        {
            return $"Iм'я: {_name}, Вiк: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Name == person2.Name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}

