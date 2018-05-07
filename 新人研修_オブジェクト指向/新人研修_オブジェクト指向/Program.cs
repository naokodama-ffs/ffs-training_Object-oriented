using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新人研修_オブジェクト指向
{
    class Program
    {
        static void Main(string[] args)
        {
            int kamePos = 0;
            int waniPos = 10;

            // いまカメとワニは10メートル離れた場所からお互いに向かい合って歩いている。

            kamePos++;
            Console.WriteLine("カメ は 歩く");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            // 1秒経過
            kamePos++;
            Console.WriteLine("カメ は 歩く");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            // 1秒経過
            kamePos++;
            Console.WriteLine("カメ は 歩く");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            // 1秒経過
            kamePos++;
            Console.WriteLine("カメ は 歩く");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();


            //二人の距離が2Mになった。カメは手足を引っ込める
            Console.WriteLine("カメ は 手足を引っ込める");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            // 二人の距離が1Mになった。カメは手足を引っ込め続ける
            kamePos--;
            Console.WriteLine("カメ は 逃げる");
            waniPos--;
            Console.WriteLine("ワニ は 歩く");
            System.Threading.Thread.Sleep(1000);

            // ワニがカメまで追いついた。カメは食べられてしまった
            Console.WriteLine("カメは食べられてしまった");
        }
    }
}
