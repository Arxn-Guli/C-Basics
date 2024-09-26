using System.IO;
Console.Clear();


string path = "example.txt";
string content = "Hello, World!";
string newPath = "new_example.txt";
bool fileExists = File.Exists(path);

if (fileExists) File.Delete(path);
if (File.Exists(newPath)) File.Delete(newPath);

File.WriteAllText(path, content); // 创建文件并写入内容

string readContent = File.ReadAllText(path);
Console.WriteLine(readContent); // 输出：Hello, World!

string additionalContent = "\nWelcome to C#!";
File.AppendAllText(path, additionalContent); // 追加内容

if (fileExists)
{
   File.Move(path, newPath);

   string[] lines = File.ReadAllLines(newPath);
   foreach (string line in lines)
   {
      Console.WriteLine(line); // 输出文件的每一行
   }

   FileInfo fileInfo = new(newPath);
   Console.WriteLine($"File Size: {fileInfo.Length} bytes");
   Console.WriteLine($"Created: {fileInfo.CreationTime}");
}

try
{
   File.WriteAllText("example.txt", "Hello!");
}
catch (IOException ex)
{
   Console.WriteLine($"An error occurred: {ex.Message}");
}


