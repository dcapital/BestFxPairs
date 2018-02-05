using RestApi.DataTypes;
using System.Collections.Generic;

namespace RestApi.Communications
{
    class CandlesResponse
    {
        public string Instrument  { get; set; }
        public string Granularity  { get; set; }
        public List<Candle> Candles { get; set; }
    }
}
