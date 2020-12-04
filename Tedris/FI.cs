using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    class FI : Fiqur
    {
        int i = 1;
        public FI()
        {
            x1 = 3;x2 = 4;x3 = 5; x4 = 6;
            y1 = y2 =y3 = y4 = 0;
            sol = 3;sag = 6;alt = 0;
            color = Color.DarkOliveGreen;
        }
        public override void Deyis()
        {
            if (i % 2 == 1&&y1>=3)
            {
                x1 = x3 = x4 = x2;
                y1 = y1 - 3;
                y2 = y2 - 2;
                y3 = y3 - 1;
                sol = sag = sol+1;                
                i++;
            }else
            if (i % 2 == 0 && sol>=1&&sag<=7)
            {
                x1 = x1 - 1;x3 = x3 + 1; x4 = x4 + 2;
                y1 = y2 = y3 = y4;
                sol = sol-1; sag = sag + 2;                
                i++;
            }
        }
    }
}
