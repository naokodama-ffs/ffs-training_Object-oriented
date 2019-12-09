using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace クラス化
{
    class Referee
    {
        // フィールド
        public Kame kame;                   // カメインスタンス
        public Tokage tokage;               // トカゲインスタンス
        public Wani wani;                   // ワニインスタンス
        
        private int kame_wani_distance;
        private int tokage_wani_distance;

        // コンストラクタ
        public Referee()
        {
            kame = new Kame(0);         // 位置0にカメインスタンスを生成
            tokage = new Tokage(0);     // 位置0にトカゲインスタンスを生成
            wani = new Wani(11);        // 位置11にワニインスタンスを生成

            //変数の初期化
            kame_wani_distance = 0;
            tokage_wani_distance = 0;
        }

        /////
        //public void Execute()
        //{

        //    while (kame != null || tokage != null)
        //    {
        //        // 動物の位置をチェックして、動物に動きを指示する
        //        InstructKame();
        //        InstructTokage();
        //        InstructWani();

        //        // 状況を判定する
        //        JudgeDeadOrLife();

        //        // 1秒待機
        //        System.Threading.Thread.Sleep(1000);
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("トカゲとワニは全滅");
        //    Console.Read();
        //}

        // カメに動作指示
        public void InstructKame()
        {
            if( kame == null)
            {
                // もうカメは存在しない
                return;
            }

            // ワニとカメの位置をチェック
            int kame_wani_distance = Math.Abs(kame.pos - wani.pos);
            // 距離に応じて動物に動きを指示する
            if( kame_wani_distance > 2)
            {
                kame.Walk();
                Console.WriteLine("カメは歩く");
            }
            else if( kame_wani_distance <= 2)
            {
                kame.Retract();
                Console.WriteLine("カメが手足を引っ込める");
            }
            return;
        }

        // トカゲに動作指示
        public void InstructTokage()
        {
            if( tokage == null)
            {
                // もうトカゲは存在しないので処理しない
                return;
            }

            // ワニとトカゲの距離をチェック
            int tokage_wani_distance = Math.Abs(tokage.pos - wani.pos);

            // 距離に応じて動物に動きを指示する
            if ( tokage_wani_distance > 4)   
            {
                tokage.Walk();
                Console.WriteLine("トカゲは歩く");
            }
            else if( tokage_wani_distance >= 2)
            {
                tokage.Escape();
                Console.WriteLine("トカゲは逃げる");
            }
            else if( tokage_wani_distance == 1)
            {
                // 尻尾があるなら尻尾を切って逃げる
                if (false != tokage.hasTail)
                {
                    tokage.TurnOffTail();
                    Console.WriteLine("トカゲは尻尾を切って逃げる");
                }
                else
                {
                    tokage.Escape();
                    Console.WriteLine("トカゲは逃げる");
                }
            }
            return;
        }

        // ワニに動作指示
        public void InstructWani()
        {
            // ワニはとりあえず歩く
            wani.Walk();
            Console.WriteLine("ワニは歩く");
            return;
        }

        // ワニとの距離から生死を判定する
        public void JudgeDeadOrLife()
        {
            // カメの生死を確認
            if( kame != null && kame.pos == wani.pos)
            {
                Console.WriteLine("カメは食べられてしまった");
                kame = null;    // インスタンスを破棄
            }

            // トカゲの生死を確認
            if( tokage != null && tokage.pos == wani.pos)
            {
                Console.WriteLine("トカゲは食べられてしまった");
                tokage = null;  // インスタンスを破棄
            }
            return;
        }
    }
}
