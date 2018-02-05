using RestApi.DataTypes;
using System.Collections.Generic;

namespace RestApi.Communications
{
    class OrdersResponse
    {
        public List<Order> Orders { get; set; }
        public string NextPage { get; set; }
    }
}
