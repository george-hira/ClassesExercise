
namespace ClassesExerciseGit
{
    class Children : Person
    {
        public Children(string firstName, string lastName, int age): base( firstName, lastName, age)
        {

            if (age > 15)
            {
                throw new ArgumentException("You are not child anymore!");
            }
            else
            {
                Console.WriteLine("Age is set corectly!");
                this.Age = age;
            }
        
        }

     
            
    }

}
