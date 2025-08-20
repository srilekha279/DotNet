using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class MyStreamWriter
    {
        public void SWFunction()
        {
            //StreamWriter sw = new("C:\\Users\\admin\\Desktop\\code\\TempFiles\\file1.txt", true); //creates file if file doesn't exist
            //Console.WriteLine("Enter text");
            //string inputData = Console.ReadLine();
            //sw.Write(inputData);
            //sw.Write(DateTime.Now);
            //sw.WriteLine(inputData);
            //sw.WriteLine("New line");
            //Console.WriteLine("Data has been written to the file");
            //sw.Flush();
            //sw.Close();

            string path = @"C:\Users\admin\Desktop\code\TempFiles\file1.txt";
            int a = 15, b = 33, result = a + b;
            //no need to flush and close if we use "using"
            using(StreamWriter streamwriter = new StreamWriter(path, true)) 
            {
                streamwriter.Write($"Sum of {a} and {b} = {result}");
            }

        }
        public void SRFunction()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file1.txt";
            Console.WriteLine("File contents: ");
            using(StreamReader reader = new StreamReader(path, true))
            {
                Console.WriteLine($"Current Encoding: {reader.CurrentEncoding}");
                Console.WriteLine($"End of stream: {reader.EndOfStream}");
                Console.WriteLine($"Base stream: {reader.BaseStream}");

                //Console.WriteLine(reader.ReadToEnd());
                string strData = reader.ReadLine();
                Console.WriteLine("\nReading line by line:");
                while(strData != null)
                {
                    Console.WriteLine(strData);
                    strData = reader.ReadLine();
                }
                Console.WriteLine($"End of stream: {reader.EndOfStream}");
                //Go to Beginning
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                //Console.WriteLine(reader.ReadToEnd());

                int x = reader.Read();
                Console.WriteLine("\nReading character by character");
                while(x != -1)
                {
                    Console.Write((char)x);
                    x = reader.Read();
                }

            }
        }
        public void swRead()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file1.txt";
            using(StreamReader sr = new StreamReader(path, true))
            {
                char[] chars = null;
                while(sr.Peek() >= 0)
                {
                    chars = new char[25];
                    sr.Read(chars, 0, chars.Length);
                    Console.Write(chars);
                }
                Console.WriteLine("\n" + sr.Peek());
            }
        }

        public void FileStreamFunctions()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file1.txt";
            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                if (fs.CanRead)
                {
                    byte[] buffer = new byte[10];
                    int bytesRead;
                    Console.WriteLine("Reading data from stream");
                    while((bytesRead = fs.Read(buffer, 0, buffer.Length - 2)) > 0)
                    {
                        string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Console.WriteLine(content);
                    }
                }
                else
                {
                    Console.WriteLine("Does not support reading");
                }
            }
            Console.WriteLine("\nReading the file Object");
            foreach(string line in File.ReadLines(path))
            {
                Console.WriteLine(line);
            }
        }
    }
}
