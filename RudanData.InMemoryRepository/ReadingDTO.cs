
namespace RudanData.Entities
{
    public class ReadingDTO(ReadingModel model)
    {
        public long Timestamp { get; set; } = ((DateTimeOffset)model.ReadingDate).ToUnixTimeSeconds();
        public double? Value { get; set; } = model.ReadingValue?.Value;
    }
}
