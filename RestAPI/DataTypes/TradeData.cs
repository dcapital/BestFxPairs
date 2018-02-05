using System;
using System.ComponentModel;

namespace RestApi.DataTypes
{
    public class TradeData
    {
        [DisplayName("ID")]
        public long Id { get; set; }
        [DisplayName("Units")]
        public int Units { get; set; }
        [DisplayName("Side")]
        public string Side { get; set; }
        [DisplayName("InstrumentType")]
        public string Instrument { get; set; }
        [DisplayName("Time")]
        public DateTime Time { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Take Profit")]
        public double TakeProfit { get; set; }
        [DisplayName("Stop Loss")]
        public double StopLoss { get; set; }
        [DisplayName("Trailing Stop")]
        public int TrailingStop { get; set; }
    }
}
