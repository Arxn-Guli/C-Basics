using Lesson_1;

Console.WriteLine("Hello, World!");

Console.Clear();

int num1 = 1, num2 = 2;
Calc.Warp(ref num1, ref num2);
Console.WriteLine("num1 = " + num1);
Console.WriteLine("num2 = " + num2);

int dayValue = (int)DayOfWeek.Monday;  // 1
Console.WriteLine(dayValue);

DayOfWeek day = (DayOfWeek)5;  
Console.WriteLine(day);  

DayOfWeek today = DateTime.Now.DayOfWeek;
Console.WriteLine(today);  

switch (today)
{
    case DayOfWeek.Monday:
        Console.WriteLine("Start of the work week.");
        break;
    case DayOfWeek.Friday:
        Console.WriteLine("End of the work week.");
        break;
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Weekend!");
        break;
    default:
        Console.WriteLine("Midweek day.");
        break;
}
Console.Clear();

string todayInChinese = today switch
{
    DayOfWeek.Sunday => "jeksenbı",
    DayOfWeek.Monday => "düisenbı",
    DayOfWeek.Tuesday => "seisenbı",
    DayOfWeek.Wednesday => "särsenbı",
    DayOfWeek.Thursday => "beisenbı",
    DayOfWeek.Friday => "jūma",
    DayOfWeek.Saturday => "senbı",
    _ => "belgısız"
};

Console.WriteLine(todayInChinese);  // 输出：星期几（中文）

