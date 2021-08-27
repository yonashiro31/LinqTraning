using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Books
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
        public List<Books> books { get; set; }
        public  void Book(){
            books = new List<Books>()
            {
                
                new Books{Title = "C#プログラミングの新常識", Price = 3800 ,Pages = 378},
                new Books{Title = "ラムダ式とLINQの極意", Price = 2500 ,Pages = 385},
                new Books{Title = "ワンダフルC#ライフ", Price = 2900 ,Pages = 385},
                new Books{Title = "一人で学ぶ並列処理（略", Price =4800 ,Pages =464 },
                new Books{Title = "フレーズ（略", Price = 5300 ,Pages =604 },
                new Books{Title = "私でも分かったASP（略", Price =3200  ,Pages = 453},
                new Books{Title = "楽しいC#（略", Price = 2540 ,Pages = 348}
            };

            // 教本問題②
            // ワンダフル（略の価格とページ数を表示
            var wanderDate = books.Where(item => item.Title == "ワンダフルC#ライフ").ToList();
            Console.WriteLine("【ワンダフルの価格とページ数】：" + wanderDate[0].Price + " "  +wanderDate[0].Pages );
            // C＃が含まれている冊数をカウント
            var csCount = books.Count(item => item.Title.Contains("C#"));
            Console.WriteLine("【C#が含まれている冊数】" + csCount);
            // C#が含まれている本の平均ページ
            var csBooks = books.Where(item => item.Title.Contains("C#")).Average(item => item.Pages);

            var List1 = new List<int>();
            foreach (var item in books)
            {
                if (item.Title.Contains("C#"))
                {
                    List1.Add(item.Pages);                    
                }               
            }
            var num2 = 0;
            var num = 0;
            foreach(var i in List1)
            {
                 num2++;
                 num += i;                 
            }
            var aaaa = num / num2;
            // 価格が400以上で最初に見つかった書籍のタイトルを表示

            var over400Book = books.FirstOrDefault(item => item.Price >400);
            Console.WriteLine(over400Book.Title);
            // 価格4000以下で最大のページ数を求めるコード
            var bookk = books.FindAll(item => item.Price <= 4000).OrderByDescending(item => item.Pages).First();
            Console.WriteLine("【4000以下最大ページ数】" + bookk.Pages);
            // C#が含まれていてかつ5000ページ以下の本のタイトル表示
            var cs5000Books = books.FindAll(book => book.Title.Contains("C#")).FindAll(book => book.Pages <= 5000);
            Console.WriteLine("【5000以下かつC#が含まれている本】");
            cs5000Books.ForEach(book => Console.WriteLine(book.Title));
        }
       

    }
}
