using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class MyFileInfo
    {
        public void FileInforProps()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file1.txt";
            FileInfo fileInfo = new FileInfo(path);

            if(fileInfo.Exists)
            {
                Console.WriteLine($"Directory: {fileInfo.Directory}");
                Console.WriteLine($"Directory Name: {fileInfo.DirectoryName}");
                Console.WriteLine($"Length in bytes: {fileInfo.Length}");
                Console.WriteLine($"Name: {fileInfo.Name}");
                Console.WriteLine($"IsReadOnly: {fileInfo.IsReadOnly}");
                Console.WriteLine($"Exists: {fileInfo.Exists}");
            }
        }
        public void FileInfoMethods()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt";
            FileInfo fileInfo = new FileInfo(path);
            //create a text file and write to it

            StreamWriter str = fileInfo.CreateText();
            str.WriteLine("Hello");
            str.Close();

            //delete
            if(fileInfo.Exists )
            {
                fileInfo.Delete();
            }

            string path1 = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt";
            string path2 = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt";
            FileInfo fileInfo1 = new FileInfo(path1);
            FileInfo fileInfo2 = new FileInfo(path2);
            if (fileInfo1.Exists)
            {
                if (fileInfo2.Exists)
                {
                    fileInfo1.CopyTo(path2);
                    Console.WriteLine("{0} copied to {1}", path1, path2);
                }
                else
                {
                    Console.WriteLine($"Path {path2} already exists.can't copy");
                }
            }
            //moving
            string src = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt"; ;
            string dest = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt"; ;
            fileInfo = new FileInfo(src);
            fileInfo.MoveTo(dest);
            Console.WriteLine("Moved");

            //append text to file
            string path3 = @"C:\Users\admin\Desktop\code\TempFiles\file3.txt"; ;
            fileInfo = new FileInfo(path3);
            StreamWriter sw = fileInfo.AppendText();
            sw.WriteLine("Hello");
            sw.WriteLine("This is ");
            sw.WriteLine("extra");
            sw.WriteLine(" text");
            Console.WriteLine("appended");
            sw.Close();

            //read the file
            StreamReader sr = fileInfo.OpenText();
            string s = "";
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
