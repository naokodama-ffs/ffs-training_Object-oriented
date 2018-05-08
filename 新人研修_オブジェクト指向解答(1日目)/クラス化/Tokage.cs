using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace クラス化
{
    class Tokage
    {
        // 位置
        public int pos;

        // しっぽがあるかどうか
        public bool hasTail;

            // コンストラクタ
        public Tokage(int in_pos)
        {
            pos = in_pos;
            hasTail = true;
        }

        // 歩く
        public void Walk()
        {
            pos++;
        }

        // 逃げる
        public void Escape()
        {
            pos--;
        }

        // 尻尾を切って逃げる
        public void TurnOffTail()
        {
            pos -= 2;
            hasTail = false;
        }

    }
}
