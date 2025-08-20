namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStreamWriter msw = new MyStreamWriter();
            //msw.SWFunction();
            //msw.SRFunction();
            //msw.swRead();
            //msw.FileStreamFunctions();

            BinaryFiles binf = new BinaryFiles();
            //binf.BinaryFunctions();
            //binf.BinReaderFunctions();

            MyFileInfo info = new MyFileInfo();
            //info.FileInforProps();

            MyStringRW sr = new MyStringRW();
            //sr.MyStringReader();
            //sr.MyStringWriter();

            MyDirectoryInfo mdi = new MyDirectoryInfo();
            //mdi.directoryInfoMethods();

            SerializeDeSerialize sd = new SerializeDeSerialize();
            //sd.XmlSerializerFunc();
            //sd.XmlsDeserializerFunc();
            //sd.JsonSerialization();
            //sd.JsonDeserialization();
            
        }
    }
}
