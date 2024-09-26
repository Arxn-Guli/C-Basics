namespace Lesson_3;

public class Bird : IAnimal
{
   public void MakeSound()
   {
      Console.WriteLine("Tweet!");
   }

   public void Move()
   {
      Console.WriteLine("The bird flies.");
   }

   public void Move(float x, float y)
   {
      Console.WriteLine("( " + x + " , " + y + " ).");
   }
}
