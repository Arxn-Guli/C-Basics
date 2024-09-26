namespace Lesson_2;

public class Rectangle(double width, double height) : IShape
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public double Area()
   {
      return Width * Height; // 矩形的面积
   }

   public double Perimeter()
   {
      return 2 * (Width + Height); // 矩形的周长
   }
}
