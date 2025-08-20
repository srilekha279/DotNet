using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class BinaryFiles
    {
        
        public void BinaryFunctions()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file2.bin";
            FileStream fs = File.Open(path, FileMode.Create);
            using(BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write("0x00202230");
                writer.Write("Windows explorer stopped working");
                writer.Write(true);
            }
            Console.WriteLine("file created");
        }

        public void BinReaderFunctions()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\file2.bin";
            FileStream fs = File.Open(path, FileMode .Open);
            using(BinaryReader reader = new BinaryReader(fs))
            {
                Console.WriteLine("Error code: " + reader.ReadString());
                Console.WriteLine("Message: " + reader.ReadString());
                Console.WriteLine("Restart explorer: " + reader.ReadBoolean());
                Console.WriteLine("Reading character by character");
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                int ch;
                while((ch = reader.Read()) != -1)
                {
                    Console.Write((char)ch);
                    ch = reader.Read();
                }
            }
        }
    }
}
