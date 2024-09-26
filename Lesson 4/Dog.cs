namespace Lesson_4;

public class Dog : Animal
{
   // 实现抽象方法
   public override void MakeSound()
   {
      Console.WriteLine($"{Name} says: Woof!");
   }
}
