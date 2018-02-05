using System;

namespace RestApi.DataTypes
{
    public class Price
    {
        public string Instrument { get; set; }
        public DateTime Time;
        public double Bid { get; set; }
        public double Ask { get; set; }
    }
}
