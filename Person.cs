//You are asked to model an application for storing data about people. 
//You should be able to have a person and a child. 
//The child is derived of the person. Your task is to model the application. The only constraints are:

//    People should not be able to have negative age
//    Children should not be able to have age more than 15.

//• Person – represents the base class by which all others are implemented 
//• Child - represents a class which is derived by the Person. 

// Validate each member by throwing an ArgumentException.

namespace ClassesExerciseGit
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            if (age < 0)
            {
                throw new ArgumentException("People should not be able to have negative age");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Age is set!");
                Console.ResetColor();

            }
            this.Age = age;

        }


    }
}
