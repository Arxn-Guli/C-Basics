namespace Lesson_3;

public class Dog : IAnimal
{
   public void MakeSound()
   {
      Console.WriteLine("Woof!");
   }

   public void Move()
   {
      Console.WriteLine("The dog runs.");
   }

   public void Move(float x, float y)
   {
      Console.WriteLine("( " + y + " ).");
   }
}