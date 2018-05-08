using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace クラス化
{
    class Wani
    {
        public int pos;

        public Wani(int in_pos)
        {
            pos = in_pos;
        }

        // 歩く
        // ワニは反対方向から歩いてくるものとする。
        public void Walk()
        {
            pos -= 2;
        }


    }
}
