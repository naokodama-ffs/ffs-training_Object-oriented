using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace クラス化
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Referee referee = new Referee();    // 動物使いインスタンス生成
            referee.Execute();                  // 動作開始
        }
    }
}
