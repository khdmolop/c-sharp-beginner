using System;
using System.IO;
using System.Text;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\khali\OneDrive\Desktop\khalilf\g\pop");
            //لانشاء المجلداتcreate folder
             StreamWriter sw = new StreamWriter(@"C:\Users\khali\OneDrive\Desktop\khalilf\g\pop\pop1.txt", true);
            sw.WriteLine("kakbitamer");
            sw.Close();
            //create text
        }
    }
}
