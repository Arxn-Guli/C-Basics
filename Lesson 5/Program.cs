using System.Text;

Console.Clear();

string greeting = "Hello, World!";

string name = "Alice";
string welcomeMessage = greeting + " " + name; // "Hello, World! Alice"

string sub = greeting.Substring(0, 5); // "Hello"
int index = greeting.IndexOf("World"); // 7
string newGreeting = greeting.Replace("World", "C#"); // "Hello, C#!"

int age = 30;
string formatted = $"My name is {name} and I am {age} years old.";
string str1 = "Hello";
string str2 = "hello";

bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // true
string sentence = "Hello,World,CSharp";
string[] words = sentence.Split(','); // {"Hello", "World", "CSharp"}
string result = String.Join(", ", words); // "Hello, World, CSharp"
string original = "Hello";
string modified = original.Replace("H", "J"); // "Jello"

StringBuilder sb = new();
sb.Append("Hello");
sb.Append(", ");
sb.Append("Arxn nurbaht!");
string finalString = sb.ToString(); // "Hello, World!"

Console.WriteLine(finalString);

string message = "Hello, World!" + System.Environment.NewLine + "Welcome to C#!";
Console.WriteLine(message);

