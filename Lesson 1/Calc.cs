namespace Lesson_1;

public class Calc
{
   public static void Warp(ref int num1, ref int num2)
   {
      (num1, num2) = (num2, num1);
   }
}