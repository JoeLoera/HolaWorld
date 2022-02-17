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

        //constructor
        public Human(string myFirstName, string lastName, string eyeColor, int myAge)
        { 
            firstName = myFirstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.myAge = myAge;
        }

        //member method
        public void IntroduceMyself()
        {
            if (myAge == 1)
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I am {3} year old.", firstName, lastName, eyeColor, myAge);
            else
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I am {3} years old.", firstName, lastName, eyeColor, myAge);
        }
    }
}
