using RestApi.DataTypes;
using System.Collections.Generic;

namespace RestApi.Communications
{
    public class TransactionsResponse
    {
        public List<Transaction> Transactions;
        public string NextPage;
    }
}
