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

            // 教本練習問題
            var traningNumbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            // 1，最大値を求め、表示してください
            var maxNum2 = traningNumbers.Max();
            Console.WriteLine("最大値" + maxNum2);
            // 2,最後から二つの要素を取り出して表示してください
            var last2Num = traningNumbers.Reverse().Take(2);
            Console.WriteLine("最後から要素を二つ取り出す");
            foreach (var item in last2Num)
            {
                Console.WriteLine(item);
            }

            // 3,それぞれの数値を文字列に変換し結果を表示してください
            var stringNum = traningNumbers.Select(item => item.ToString()).ToList();
            Console.WriteLine("数値を文字列にして表示");
            stringNum.ForEach(item =>
            Console.WriteLine(item));
        
            // 4,数の小さい順に並べ、先頭から3つを取り出し結果を表示してください
            var sortList = traningNumbers.OrderBy(item => item);
            var min3Num = sortList.Take(3);
            foreach (var item in min3Num)
            {
                Console.WriteLine("降順かつ先頭から3つ取り出した数値" +  item);
            }
                // 5,重複を排除した後、10より大きい値がいくつあるのかカウントし、結果を表示してください。
            var testNumbers = traningNumbers.Distinct();
            var over10Num = testNumbers.Count(item => item > 10);
            Console.WriteLine("重複排除10以上の数値の数" + over10Num);
            Books b = new Books();
            b.Book();
            
           

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
