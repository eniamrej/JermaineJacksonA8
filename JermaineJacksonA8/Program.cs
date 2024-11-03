namespace JermaineJacksonA8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataImporter dataImporter = new DataImporter();
            Console.WriteLine(dataImporter.IsDataLoaded());
        }
    }
}
