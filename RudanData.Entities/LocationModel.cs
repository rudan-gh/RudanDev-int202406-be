
namespace RudanData.Entities
{
    public class LocationModel(int id, string? name)
    {
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
    }
}