using System.ComponentModel;

namespace RestApi.DataTypes
{
    public class Transaction
    {
        [DisplayName("ID")]
        public long Id { get; set; }
        [DisplayName("Account")]
        public int AccountId { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("InstrumentType")]
        public string Instrument { get; set; }
        [DisplayName("Units")]
        public long Units { get; set; }
        [DisplayName("Time")]
        public long DateTime { get; set; }
        [DisplayName("Price")]
        public double Price { get; set; }
        [DisplayName("Balance")]
        public double Balance { get; set; }
        [DisplayName("Interest")]
        public double Interest { get; set; }
        [DisplayName("P/L")]
        public double ProfitLoss { get; set; }
        [DisplayName("High Order Limit")]
        public double HighOrderLimit { get; set; }
        [DisplayName("Low Order Limit")]
        public double LowOrderLimit { get; set; }
        [DisplayName("Amount")]
        public double Amount { get; set; }
        [DisplayName("Stop Loss")]
        public double StopLoss { get; set; }
        [DisplayName("Take Profit")]
        public double TakeProfit { get; set; }
        [DisplayName("Duration")]
        public long Duration { get; set; }
        [DisplayName("Completion Code")]
        public int CompletionCode { get; set; }
        [DisplayName("Transaction Link")]
        public long TransactionLink { get; set; }
        [DisplayName("Order Link")]
        public long OrderLink { get; set; }
        [DisplayName("Diaspora")]
        public long Diaspora { get; set; }
        [DisplayName("Trailing Stop")]
        public int TrailingStop { get; set; }
        [DisplayName("Margin Used")]
        public double MarginUsed { get; set; }


        /// <summary>
        /// Gets a basic title for the type of transaction
        /// </summary>
        /// <returns></returns>
        public string GetTitle()
        {
            switch ( Type )
            {
                case "CloseOrder":
                    return "Order Closed";
                case "SellLimit":
                    return "Sell Limit Order Created";
                case "BuyLimit":
                    return "Buy Limit Order Created";
            }
            return Type;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetReadableString()
        {
            // TODO: make this pretty
            string readable = Units + " " + Instrument + " at " + Price;
            if ( ProfitLoss != 0 )
            {
                readable += "\nP/L: " + ProfitLoss;
            }
            return readable;
        }
    }
}
