using Lesson_4;

Console.Clear();

Dog dog = new() { Name = "Buddy" };
dog.MakeSound(); // 输出：Buddy says: Woof!
dog.Sleep();     // 输出：Buddy is sleeping.
dog.Move();      // 输出：Buddy runs.

Cat cat = new() { Name = "Whiskers" };
cat.MakeSound(); // 输出：Whiskers says: Meow!
cat.Sleep();     // 输出：Whiskers is sleeping.
cat.Move();      // 输出：Whiskers runs.

new Cat().MakeSound(); // 输出：  says: Meow!
new Cat().Sleep();     // 输出：  is sleeping.
new Cat().Move();      // 输出：  runs.