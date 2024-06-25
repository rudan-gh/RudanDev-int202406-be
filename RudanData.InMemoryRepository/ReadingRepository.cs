
using RudanData.Entities;

namespace RudanData.InMemoryRepository
{
    public static class ReadingRepository
    {
        public static List<ReadingDTO> GetDataSeries()
        {
            var rawReadings = GetReadings();

            List<ReadingDTO> readings = new();
            rawReadings.ForEach(r => readings.Add(new ReadingDTO(r)));

            return readings;
        }

        private static List<ReadingModel> GetReadings()
        {
            // This variable represents data retrieved from an external data store.
            ReadingModel[] allReadings =[
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717200001000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717200900000).DateTime, 42.519, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717201800000).DateTime, 41.544, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717202700000).DateTime, 40.409, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717203600000).DateTime, 41.1, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717204500000).DateTime, 40.361, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717204501000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717205400000).DateTime, 39.774, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717206300000).DateTime, 39.286, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717207200000).DateTime, 41.837, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717208100000).DateTime, 41.437, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717209000000).DateTime, 41.458, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717209900000).DateTime, 42.982, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717210800000).DateTime, 43.42, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717211700000).DateTime, 21.221, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717212600000).DateTime, 19.677, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717213500000).DateTime, 18.393, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717214400000).DateTime, 18.466, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717215300000).DateTime, 32.463, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717216200000).DateTime, 32.528, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717217100000).DateTime, 32.201, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717218000000).DateTime, 32.221, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717218900000).DateTime, 31.255, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717219800000).DateTime, 26.244, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717220700000).DateTime, 18.402, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717221600000).DateTime, 26.527, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717222500000).DateTime, 34.47, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717223400000).DateTime, 26.986, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717224300000).DateTime, 28.062, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717225200000).DateTime, 42.403, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717226100000).DateTime, 32.53, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717227000000).DateTime, 32.415, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717227900000).DateTime, 38.318, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717228800000).DateTime, 37.572, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717229700000).DateTime, 32.002, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717230600000).DateTime, 33.091, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717231500000).DateTime, 37.591, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717232400000).DateTime, 37.951, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717233300000).DateTime, 37.674, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717233301000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717234200000).DateTime, 35.307, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717235100000).DateTime, 32.702, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717236000000).DateTime, 34.594, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717236900000).DateTime, 39.815, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717237800000).DateTime, 36.769, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717238700000).DateTime, 34.499, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717239600000).DateTime, 38.121, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717240500000).DateTime, 36.123, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717241400000).DateTime, 36.577, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717242300000).DateTime, 38.128, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717243200000).DateTime, 35.773, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717244100000).DateTime, 32.171, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717245000000).DateTime, 30.025, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717245900000).DateTime, 30.968, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717246800000).DateTime, 46.706, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717247700000).DateTime, 45.393, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717248600000).DateTime, 40.357, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717249500000).DateTime, 31.799, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717250400000).DateTime, 30.85, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717251300000).DateTime, 31.561, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717252200000).DateTime, 30.567, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717253100000).DateTime, 31.755, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717254000000).DateTime, 33.698, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717254900000).DateTime, 40.632, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717255800000).DateTime, 37.839, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717256700000).DateTime, 38.714, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717257600000).DateTime, 38.266, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717258500000).DateTime, 39.434, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717259400000).DateTime, 46.356, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717260300000).DateTime, 52.196, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717261200000).DateTime, 48.864, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717262100000).DateTime, 47.686, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717263000000).DateTime, 33.791, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717263001000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717263900000).DateTime, 33.389, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717264800000).DateTime, 40.216, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717265700000).DateTime, 43.519, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717266600000).DateTime, 49.631, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717267500000).DateTime, 49.599, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717268400000).DateTime, 47.097, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717269300000).DateTime, 37.816, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717270200000).DateTime, 47.626, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717271100000).DateTime, 51.271, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717272000000).DateTime, 49.732, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717272900000).DateTime, 37.913, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717273800000).DateTime, 37.285, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717274700000).DateTime, 36.722, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717275600000).DateTime, 37.247, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717276500000).DateTime, 35.28, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717277400000).DateTime, 33.147, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717278300000).DateTime, 33.512, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717279200000).DateTime, 34.076, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717279201000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717280100000).DateTime, 38.907, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717281000000).DateTime, 42.283, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717281001000).DateTime, null, false),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717281900000).DateTime, 42.106, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717282800000).DateTime, 42.529, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717283700000).DateTime, 50.497, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717284600000).DateTime, 54.285, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717285500000).DateTime, 44.618, true),
                new(new LocationModel(1723, "KAMP EL1865"),DateTimeOffset.FromUnixTimeMilliseconds(1717286400000).DateTime, 40.876, true)
            ];

            return allReadings.ToList();
        }
    }
}
