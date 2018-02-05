namespace RestApi.DataTypes
{
    public class AccountDetails
    {
        public int AccountId;
        public string Name;
        public double Balance { get; set; }
        public double UnrealizedPl { get; set; }
        public double Nav;
        public double RealizedPl { get; set; }
        public double MarginUsed { get; set; }
        public double MarginAvail { get; set; }
        public int OpenTrades;
        public int OpenOrders;
        public double MarginRate;
        public string Homecurr;
    }
}
