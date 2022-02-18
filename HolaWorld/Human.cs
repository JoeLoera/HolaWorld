using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWorld
{
    //add two more member variables to "Human". eyeColor and age.
    //adjust the constructor, so it requires all of the four values to be used, when creating an object of Human.
    //create two objects of type Human


    //this class is a blueprint for a datatype

    //create a public variable lastName of type string
    //change the IntroduceMyself method, so it tells the whole name
    //create two objects with full information about themself - firstName and lastName

    internal class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int myAge;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created" );
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, int myAge)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.myAge = myAge;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int myAge)
        { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.myAge = myAge;
        }

        //member method
        public void IntroduceMyself()
        {
            if (myAge != 0 && lastName != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}.", firstName, lastName, myAge, eyeColor);
            else if (myAge != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. I am {2} years old.", firstName, lastName, myAge);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}.", firstName);
            }
            else if (firstName != null && lastName != null && myAge != 0)
            {
                Console.WriteLine("Hi,I am {0} {1}. I am {2} years old.");
            }
        }
    }
}
