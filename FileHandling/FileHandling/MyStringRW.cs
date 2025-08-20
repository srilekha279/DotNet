using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class MyStringRW
    {
        public void MyStringReader()
        {
            string text = @"You are reading this StringReader and StringWriter in C# article at dotnettutorials.net";
            using(StringReader stringReader = new StringReader(text))
            {
                int cnt = 0;
                string line;
                while((line = stringReader.ReadLine()) != null)
                {
                    cnt++;
                    Console.WriteLine($"Line {cnt}: {line}");
                }
            }
        }
        public void MyStringWriter()
        {
            string text = "Hello \nThis is first line. \nThis is second line.";
            StringBuilder sb = new StringBuilder();
            StringWriter strWriter = new StringWriter(sb);
            strWriter.WriteLine(text);
            strWriter.Flush();
            strWriter.Close();

            StringReader reader = new StringReader(sb.ToString());
            while (reader.Peek() != -1)
                Console.WriteLine(reader.ReadLine());
        }
    }
}
