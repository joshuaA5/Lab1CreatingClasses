using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Test
{
    internal class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string firstName = this.firstName;
            string lastName = this.lastName;

            Console.WriteLine(firstName + " " + lastName);
        }

        public string personID()
        {
            return personId + ":" + " " + firstName + " " + lastName + "'s" + " " + "favorite color is" + " " + favoriteColour;
        }

        public void changeFavoriteColour()
        {
            favoriteColour = "white";         
        }

        public int getAgeInTenYears()
        {
            int age = this.age;
            return age + 10;
        }

        public override string ToString()
        {
            return "PersonId: " + personId + "\nFirstName: " + firstName + "\nLastName: " + lastName + "\nFavoriteColour: " + favoriteColour + "\nAge: " + age + "\nIsWorking: " + isWorking;     
        }




    }

        
}
