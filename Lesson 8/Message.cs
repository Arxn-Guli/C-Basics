namespace Lesson_8;
public class Message
{
    public delegate void MyMultiDelegate(string message);

    public static void ShowMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    public static void ShowAnotherMessage(string message)
    {
        Console.WriteLine($"Another Message: {message}");
    }
}
