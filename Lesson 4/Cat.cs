namespace Lesson_4;

public class Cat: Animal
{
    // 实现抽象方法
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}
