using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 自體顏色與背景顏色
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;

            // 生成亂數物件
            Random rand = new Random();

            // 次數
            int count = 1;
            

            // 重複產生
            while (count <= 10)
            {
                Console.Clear();

                // 產生六個亂數
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                // 上外框
                Console.WriteLine("╒═╤═╤═╤═╤═╤═╕");

                // 顯示亂數
                Console.WriteLine("{0:00}  {1:00}  {2:00}  {3:00}  {4:00}  {5:00}  {6:00}",count, r1, r2, r3, r4, r5, r6);

                // 下外框
                Console.WriteLine("╘═╧═╧═╧═╧═╧═╛");

                // 次數+1
                count++;

                //延遲0.1秒
                Thread.Sleep(100);
            }
            
            // 暫停畫面
            Console.ReadKey();
        }
    }
}
