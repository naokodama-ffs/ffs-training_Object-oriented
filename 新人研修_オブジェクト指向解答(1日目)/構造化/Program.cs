using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 構造化
{
    class Program
    {
        static int kamePos = 0;
        static int waniPos = 10;
        static int kame_wani_distance = 0;

        static void Main(string[] args)
        {

            int i = 0;
            while (i<10)
            {
                // カメとワニの距離を求める
                kame_wani_distance = Math.Abs(kamePos - waniPos);

                MoveKame(); // カメを動かす
                MoveWani(); // ワニを動かす

                // カメとワニの位置をチェックする
                if( kamePos == waniPos)
                {
                    Console.WriteLine("カメは食べられてしまった");
                    break;  // ループを抜ける
                }

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                i++;
            }
            Console.Read();
        }

        // カメの状況を判定し、動かす
        static void MoveKame()
        {
            if (kame_wani_distance > 2)
            {
                kamePos++;
                Console.WriteLine("カメは歩く");
            }
            else if (kame_wani_distance <= 2)
            {
                Console.WriteLine("カメは手足を引っ込める");
            }
        }

        //ワニを動かす
        static void MoveWani()
        {
            waniPos--;
            Console.WriteLine("ワニは歩く");
        }
    }
}
