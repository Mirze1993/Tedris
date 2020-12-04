using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    class FZduz : Fiqur
    {
        int i = 1;
        public FZduz()
        {
            x1 = 3;x2 = x3 = 4;x4 = 5;
            y1 = y2 =0;y3 = y4 = 1;
            sol = 3; sag = 5; alt = 1;
            color = Color.Green;
        }
        public override void Deyis()
        {
            if (i == 1&&alt>1)
            {
                x1++; y1--; x2--; y3--; x4 -= 2;
                sag--;
                i = 2;
            } else
            if (i==2&&sag<9)
            {
                x1--; x2++; x4 += 2;y1++;y3++;
                sag++;
                i = 1;
            }
        }
    }
}
