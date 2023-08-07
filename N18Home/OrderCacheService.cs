using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18Home
{
    internal class OrderCacheService
    {
        private static OrderCacheService _instance;
        private OrderCacheService()
        {

        }
        public static OrderCacheService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OrderCacheService();
            }
            return _instance;
        }
        protected Dictionary<string, int> Dict = new Dictionary<string, int>();
        public string Get(string key)
        {
            return Dict.GetValueOrDefault(key).ToString();
        }
        
        public void Set(string key, int value)
        {
            if (Dict.ContainsKey(key) == false)
            {
                Dict.Add(key, value);
            }
        }
        public static class CacheKeyConstants
        {
            public static string CreatorKey()
            {
                return Guid.NewGuid().ToString();
            }
        }
    }
}
