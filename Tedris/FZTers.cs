using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    class FZTers : Fiqur
    {
        int i = 1;
        public FZTers()
        {
            x1 = x4 = 4;x2 = 5;x3 = 3;
            y1 = y2 = 0; y3 = y4 = 1;
            sol = 3; sag = 5; alt = 1;
            color = Color.DarkOrange;
        }
        public override void Deyis()
        {
            if (i == 1&alt>1)
            {
                x1--;x2 -= 2;x3++;y1--;y3--;
                sag--;
                i = 2;
            }else
                if (i==2&&sag<9)
            {
                x1++;x2 += 2;x3--;y1++;y3++;
                sag++;
                i = 1;
            }
        }
    }
}
