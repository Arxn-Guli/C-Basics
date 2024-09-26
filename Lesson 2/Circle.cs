namespace Lesson_2;

public class Circle(double radius) : IShape
{
    public double Radius { get; set; } = radius;

    public double Area()
   {
      return Math.PI * Radius * Radius; // 圆的面积
   }

   public double Perimeter()
   {
      return 2 * Math.PI * Radius; // 圆的周长
   }
}
