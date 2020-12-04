﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    class FT : Fiqur
    {
        int i = 1;
        public FT()
        {
            x1 = 3;x2 = x4 = 4;x3 = 5;
            y1 = y2 = y3 = 0; y4 = 1;
            sol = 3;sag = 5;alt = 1;
            color = Color.Chocolate;
        }
        public override void Deyis()
        {
            if (i == 1&&alt>1)
            {
                y1--;x1++;x2--;x3--;
                sag--;
                i = 2;
            }else
            if (i == 2&&sag<9)
            {
                y1++;y2++;y3++;x4++;
                sag++;
                i = 3;
            }else
            if (i == 3 && alt > 1)
            {
                y1--;x1--;y2--; y3-- ;x4 -= 2;
                sag--;
                i = 4;
            }else
            if (i == 4 && sag < 9)
            {
                y1++;x2++;x3++;x4++;
                sag++;
                i = 1;
            }
            
        }
    }
}
