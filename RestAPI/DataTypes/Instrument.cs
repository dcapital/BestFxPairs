namespace RestApi.DataTypes
{
    public class Instrument
    {
        public string InstrumentType;
        public string DisplayName { get; set; }
        public string Pip;
        public int PipLocation;
        public int ExtraPrecision;
    }
}
