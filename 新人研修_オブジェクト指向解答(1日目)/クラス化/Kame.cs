using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace クラス化
{
    class Kame
    {
        public int pos;

        public Kame(int in_pos)
        {
            pos = in_pos;
        }

        // 歩く
        public void Walk()
        {
            pos++;
        }

        // 手足を引っ込める
        public void Retract()
        {
            // 手足を引っ込めてるから動けないので
            // 何もしない
        }
    }
}
