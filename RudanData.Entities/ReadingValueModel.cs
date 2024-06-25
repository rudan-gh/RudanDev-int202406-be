namespace RudanData.Api.models
{
    public class ReadingValueModel(double? value, bool? isExtrapolated)
    {
        public double? Value { get; } = value;
        public bool? IsExtrapolated { get; } = isExtrapolated;
    }
}
