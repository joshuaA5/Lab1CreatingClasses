using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);

            Person person2;
            person2 = new Person(2, "Gina", "James", "Green", 18, false);

            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);

            Person person4;                                  
            person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
      

            Console.WriteLine(person2.personID());
            Console.WriteLine(person3.ToString());
            person1.changeFavoriteColour();
            Console.WriteLine(person1.personID());
            Console.WriteLine(person4.firstName + " " + person4.lastName + "'s " + "Age is 10 years is: " + person4.getAgeInTenYears());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person3.ToString());
        }
    }
}
