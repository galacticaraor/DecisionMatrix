using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Factor
    {
        public string UUID { get; internal set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public Factor()
        {
            UUID = Guid.NewGuid().ToString();
            Weight = 0;
            Name = "";
        }
        public Factor(string uuid, string name, int weight)
        {
            UUID = uuid;
            Name = name;
            Weight = weight;
        }
    }
}
