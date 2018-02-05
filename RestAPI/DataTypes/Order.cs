using System;
using System.ComponentModel;

namespace RestApi.DataTypes
{
    public class Order
    {
        [DisplayName("ID")]
        public long Id { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Side")]
        public string Side { get; set; }
        [DisplayName("InstrumentType")]
        public string Instrument { get; set; }
        [DisplayName("Units")]
        public int Units { get; set; }
        [DisplayName("Time")]
        public DateTime Time { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Take Profit")]
        public double TakeProfit { get; set; }
        [DisplayName("Expiry")]
        public DateTime Expiry { get; set; }
        [DisplayName("Upper Bound")]
        public double UpperBound { get; set; }
        [DisplayName("Lower Bound")]
        public double LowerBound { get; set; }
        [DisplayName("Trailing Stop")]
        public int TrailingStop { get; set; }
    }
}
