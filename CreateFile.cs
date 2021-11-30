using System;
using System.IO;
namespace createFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            writeFile(@"C:\Users\khali\Documents\sameh.txt", "hell file");
        }
        static void writeFile(string path,string data)
        {
            StreamWriter writeData = new StreamWriter(path);
            writeData.WriteLine(data);
            writeData.Close();

        }
    }
}
