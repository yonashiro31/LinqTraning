using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {

        public Class1()
        {
            lis = new List<string>();
            lis.Add("AAA");
            lis.Add("BBB");

            // Enumberable.Repeat 同じ値で埋める
            repeatList = Enumerable.Repeat("繰り返す", 3)
                 .ToList();
            // Enumbarable.Range　連続した値で埋める
            rangeList = Enumerable.Range(1, 4)
                .ToArray();
        }

        public List<string> lis { get; set; }
        public List<string> repeatList { get; set; }
        public int[] rangeList { get; set; }


    }
}
