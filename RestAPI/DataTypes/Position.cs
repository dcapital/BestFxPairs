using System.ComponentModel;

namespace RestApi.DataTypes
{
    public class Position
    {
        [DisplayName("Direction")]
        public string Direction { get; set; }
        [DisplayName("InstrumentType")]
        public string Instrument { get; set; }
        [DisplayName("Units")]
        public int Units { get; set; }
        [DisplayName("Average Price")]
        public double AvgPrice { get; set; }
    }
}
