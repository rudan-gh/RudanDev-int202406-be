
namespace RudanData.Entities
{
    public class ReadingDTO(ReadingModel model)
    {
        // Ispravak pretvorbe iz sekunde u milisekunde
        public long Timestamp { get; set; } = ((DateTimeOffset)model.ReadingDate).ToUnixTimeMilliseconds();

        public double? Value { get; set; } = model.ReadingValue?.Value;

        //Dodano svojstvo IsExtrapolated
        public bool? IsExtrapolated { get; set; } = model.ReadingValue?.IsExtrapolated;
    }
}
