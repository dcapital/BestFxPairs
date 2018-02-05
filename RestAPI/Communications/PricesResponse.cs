using RestApi.DataTypes;
using System.Collections.Generic;

namespace RestApi.Communications
{
    class PricesResponse
    {
        public long Time { get; set; }
        public List<Price> Prices { get; set; }
    }
}
