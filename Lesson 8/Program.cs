namespace Lesson_8;

public class Program
{
   public static void Main()
   {
      Message.MyMultiDelegate del = Message.ShowMessage;
      del += Message.ShowAnotherMessage; // 添加另一个方法
      del("Hello, Multicast Delegate!"); // 调用所有方法
   }
}
