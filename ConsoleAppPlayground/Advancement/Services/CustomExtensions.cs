using System.Collections.Generic;

namespace ConsoleAppPlayground.Advancement.Services
{
    public static class CustomExtensions
    {
        public static Dictionary<string, object> GetDictionaryCust(this object obj) 
        {
            var dict = new Dictionary<string, object>();
            foreach (var prop in obj.GetType().GetProperties())
            {
                dict[prop.Name] = prop.GetValue(obj);
            }
            return dict;
        }
    }
}
