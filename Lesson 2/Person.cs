namespace Lesson_2;

public class Person(string azanName, string jsn)
{
   public string Name { get; private set; } = azanName;
   public string Jsn { get; } = jsn;

   public void SetName(string newName)
   {
      if (newName.Length < 20) Name = newName;
   }
}
