using COMMON;
using MODEL;

Console.Clear();
#region FileHelper.GetAllFiles
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

foreach (string item in FileHelper.GetAllFiles(desktopPath))
{
   Console.WriteLine("---" + item);
}
#endregion

#region JsonHelper.SerializeObject and JsonHelper.DeserializeObject
var person = new Person { Name = "Alice", Age = 30 };
string jsonString = JsonHelper.SerializeObject(person);

Console.WriteLine(jsonString); // 输出: {"Name":"Alice","Age":30}

Person deserializedPerson = JsonHelper.DeserializeObject<Person>(jsonString);

Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}"); // 输出: Name: Alice, Age: 30

var people = new List<Person>
{
    new() { Name = "Alice", Age = 30 },
    new() { Name = "Bob", Age = 25 }
};

string jsonList = JsonHelper.SerializeObject(people);
Console.WriteLine(jsonList); // 输出: [{"Name":"Alice","Age":30},{"Name":"Bob","Age":25}]

Console.WriteLine((List<Person>?)JsonHelper.DeserializeObject<List<Person>>(jsonList));
#endregion

Console.Clear();
string ss = HtmlWebHelper.LoadHtml("https://convert.kazakhsoft.com").InnerHtml;
Console.WriteLine(ss);
