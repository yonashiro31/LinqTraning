using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    /// <summary>
    /// Linq練習
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            // foreach
            class1.lis.ForEach(s => strHyouzi(s));
            // where ToLower
            IEnumerable<string> whereTestList = class1.lis.Where(s => s.Length <= 3)
                .Select(s => s.ToLower());
            foreach (var s in whereTestList)
            {
                Console.WriteLine(s);
            }
            // select 文字数表示
            var selectTestList = whereTestList.Select(s => s.Length);
            foreach (var s in selectTestList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            class1.repeatList.ForEach(s => strHyouzi(s));

            foreach (var s in class1.rangeList)
            {
                intHyouzi(s);
            }
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var ave = numbers.Average();
            Console.WriteLine(ave);
            // 最小値最大値抽出
            var minNum = numbers.Where(s => s >= 3)
            .Min();
            var maxNum = numbers.Max();
            Console.WriteLine(minNum);
            Console.WriteLine(maxNum);
            // 条件を満たす要素数を数える
            var a = numbers.Count(s => s == 3);
            Console.WriteLine(a);
            //　条件に一致する要素があるか調べる
            var check = numbers.Any(s => s == 5);
            Console.WriteLine(check);
            // 条件に一致する要素を指定数抽出
            var nums = numbers.Where(s => s >= 2)
                .Take(2);
            Console.WriteLine(nums.Count());




        }



        //

        // 表示メソッド
        public static void strHyouzi(string s)
        {
            {
                Console.WriteLine(s);
            }
        }
        public static void intHyouzi(int s)
        {
            {
                Console.WriteLine(s);
            }
        }


    }
}
