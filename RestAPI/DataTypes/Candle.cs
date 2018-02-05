using System;

namespace RestApi.DataTypes
{
    public class Candle
    {
        public DateTime Time { get; set; }
        public double OpenMid { get; set; }
        public double HighMid { get; set; }
        public double LowMid { get; set; }
        public double CloseMid { get; set; }
        public bool Complete { get; set; }
    }
}
