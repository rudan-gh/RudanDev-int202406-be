
using RudanData.Api.models;

namespace RudanData.Entities
{
    public class ReadingModel(LocationModel location, DateTime readingDate, double? value, bool? isExtrapolated)
    {
        public LocationModel Location { get; set; } = location;
        public DateTime ReadingDate { get; set; } = readingDate;
        public ReadingValueModel? ReadingValue { get; set; } = new ReadingValueModel(value, isExtrapolated);
    }
}
