using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    class FLTers : Fiqur
    {
        int i = 1;
        public FLTers()
        {
            x1 = x2 = x3 = 5; x4 = 4;
            y1 = 0; y2 = 1; y3 = 2; y4 = 2;
            sol = 4; sag = 5; alt = 2;
            color = Color.DarkGray;
        }

        public override void Deyis()
        {
            if (i == 1&&sag<9)
            {
                x1--; y1++;x2--;y2++;x4 += 2;
                sag++;
                i = 2;
            }else
                if (i == 2)
            {
                y1--;x2++;y2 -= 2;x3--;y3--;x4 -= 2;
                sag--;
                i = 3;
            }else
                if (i==3 && sag < 9)
            {
                y1++;y2++;x3 += 2;x4 += 2;
                sag++;
                i = 4;
            }else
                if (i== 4)
            {
                x1++;y1--;x3--;y3++; x4 -= 2;
                sag--;
                i = 1;
            }
        }
    }
}
