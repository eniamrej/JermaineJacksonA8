
using System.Text.Json;
using JermaineJacksonA8.Model;

namespace JermaineJacksonA8
{
    public class DataImporter
    {
        private List<House> _houses;

        public DataImporter()
        {
            _houses = JsonSerializer.Deserialize<List<House>>(_jsonString) ?? throw new InvalidOperationException();
        }

        public static string JsonPath =
            @"C:\\Users\\jj00490\\Desktop\\JermaineJacksonA8\\JermaineJacksonA8\\Data\\Assignment8Data.json";

        private readonly string _jsonString = File.ReadAllText(JsonPath);
    }
}
