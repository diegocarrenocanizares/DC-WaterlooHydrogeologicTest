using CsvHelper.Configuration.Attributes;

namespace WH.Shared.Entities
{
    public class ComboExample
    {
        [Name("Id")]
        public int Id { get; set; }
        [Name("Name")]
        public string? Name { get; set; }
    }
}