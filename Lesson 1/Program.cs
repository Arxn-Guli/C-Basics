using Lesson_1;

Console.WriteLine("Hello, World!");

Console.Clear();

int num1 = 1, num2 = 2;
Calc.Warp(ref num1, ref num2);
Console.WriteLine("num1 = " + num1);
Console.WriteLine("num2 = " + num2);