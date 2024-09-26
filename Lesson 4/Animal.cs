namespace Lesson_4;

public abstract class Animal
{
   public string? Name { get; set; }

   // 抽象方法：没有实现，必须在派生类中实现
   public abstract void MakeSound();

   // 非抽象方法：在抽象类中可以实现
   public void Sleep()
   {
      Console.WriteLine($"{Name} is sleeping.");
   }
   public void Move()
   {
      Console.WriteLine($"{Name} runs.");
   }
}

