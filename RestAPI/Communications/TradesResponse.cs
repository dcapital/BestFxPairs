using RestApi.DataTypes;
using System.Collections.Generic;

namespace RestApi.Communications
{
    class TradesResponse
    {
        public List<TradeData> Trades { get; set; }
        public string NextPage { get; set; }
    }
}
