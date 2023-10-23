using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_4
{
    internal class Person
    {
        public string Name { get; set; }   
        public string Surname {  get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            Console.WriteLine("Person Nesnesi Oluşturuldu!!!");
        }


        public virtual void Intro()
        {
            Console.WriteLine($"Name: {this.Name} Surname: {this.Surname}");
        }
    }
}
