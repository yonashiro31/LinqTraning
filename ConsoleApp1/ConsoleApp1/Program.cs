using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    // linq練習
    class Program
    {
        　
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            // foreach
            class1.lis.ForEach(s => hyouzi(s));
            // where ToLower
            IEnumerable<string> whereTestList = class1.lis.Where(s => s.Length <= 3)
                .Select(s => s.ToLower());
            foreach(var s in whereTestList)
            {
                Console.WriteLine(s);
            }
            // select 文字数表示
            var selectTestList = whereTestList.Select(s => s.Length);
            foreach (var s in selectTestList)
            {
                Console.WriteLine(s);
            }

            // 
        }
        // 表示メソッド
        public static void hyouzi(string s)
        { 
            {
                Console.WriteLine(s);
            }
        }


    }
}
