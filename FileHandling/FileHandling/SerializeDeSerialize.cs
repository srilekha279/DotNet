using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileHandling
{
    internal class SerializeDeSerialize
    {
        public void XmlSerializerFunc()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\filexml2.xml";
            Student std = new() { Id = 10, Name = "Siya" };
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                xs.Serialize(sw, std);
            }
            Console.WriteLine("Object serialized to XML successfully");
        }
        public void XmlsDeserializerFunc()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\filexml2.xml";
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            using(StreamReader sr = new StreamReader(path, true))
            {
                Student std = (Student)xs.Deserialize(sr);
                Console.WriteLine("Deserialized XML:");
                Console.WriteLine($"ID: {std.Id}");
                Console.WriteLine($"Name: {std.Name}");
            }
            
        }
        public void JsonSerialization()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\data.json";
            Student std = new() { Id = 2, Name = "Riya" };
            string jsonString = JsonSerializer.Serialize<Student>(std);
            StreamWriter sw = new(path, true);
            sw.WriteLine(jsonString);
            sw.Flush();
            sw.Close();

        }
        public void JsonDeserialization()
        {
            string path = @"C:\Users\admin\Desktop\code\TempFiles\data.json";
            StreamReader sr = new StreamReader(path);
            string jsonString = sr.ReadToEnd();
            Console.WriteLine(jsonString);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
