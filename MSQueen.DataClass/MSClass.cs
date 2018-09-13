using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSQueen.DataClass
{
    [Serializable]
    public class MSClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int TimeStmap { get; set; }
        public List<int> Scrores { get; set; }
    }
}
