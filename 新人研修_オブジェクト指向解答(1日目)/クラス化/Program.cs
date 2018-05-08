using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace クラス化
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Referee referee = new Referee();    // 動物使いインスタンス生成
            while (referee.kame != null || referee.tokage != null)
            {
                // 動物の位置をチェックして、動物に動きを指示する
                referee.InstructKame();
                referee.InstructTokage();
                referee.InstructWani();

                // 状況を判定する
                referee.JudgeDeadOrLife();

                // 1秒待機
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
            }
            Console.WriteLine("トカゲとワニは全滅");
            Console.Read();

        }
    }
}
