using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground
{
    public class Settings : ISettings
    {
        public int Id { get; set; }
        public string Url { get; set; }
    }
}
