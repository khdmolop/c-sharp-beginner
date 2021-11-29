using System;
using System.IO;
//لازم احط هذا  النيم سبيس
using System.Text;
//هذا النيم سبيس  من اجل Encoding

namespace streamWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  هذه لانشاء المجلدات
            //Directory.CreateDirectory("D:\\MY\\MyFiles");
            // Directory.CreateDirectory("MyFiles");
            //للانشاء
            //Directory.Delete("MyFiles");
            //للحزف

            //لانشاء الملفات
            //StreamWriter sw = new StreamWriter("MyFile.txt");
            //StreamWriter sw = new StreamWriter("MyFile.txt",true);
            //هذه ال الترو  اذا كنت كاتب كلام قديم وعايز اضيف عليه كلام جديد فهي تبقي الكلام القديم مع الجديد
            //هذا الكود ينشءه  فقط

            //StreamWriter sw = new StreamWriter("MyFile.txt",false,Encoding.ASCII);
            //الاسكي بخرب الرموز


            StreamWriter sw = new StreamWriter("MyFile.txt",false,Encoding.Unicode);
            //لو عايز اكتب في داخله
            sw.WriteLine("Hello");
            sw.Write("welcome");
            sw.Close();
            //اذا اضع كلوز  فلن اجد في داخله شيء

            //File.Delete("MyFile.txt");
            //لو عايز احذف الملف 
        }
    }
}
