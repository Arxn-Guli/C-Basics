using Lesson_3;

IAnimal myDog = new Dog();
myDog.MakeSound();  // Output: Woof!
myDog.Move();       // Output: The dog runs.

IAnimal myBird = new Bird();
myBird.MakeSound();  // Output: Tweet!
myBird.Move(5.75f, 2.0f);       // Output: ( 5.75 , 2 ).