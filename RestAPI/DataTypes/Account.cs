using System.Collections.Generic;

namespace RestApi.DataTypes
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Homecurr { get; set; }
        public double MarginRate { get; set; }
        public List<string> AccountPropertyName;
        public string AccountProperties
        {
            get
            {
                string result = "";
                foreach ( var value in AccountPropertyName )
                {
                    result += value;
                }
                return result;
            }
        }
    }
}
