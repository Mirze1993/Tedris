using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedris
{
    abstract class Fiqur
    {
        public int x1;
        public int x2;
        public int x3;
        public int x4;
        public int y1;
        public int y2;
        public int y3;
        public int y4;
        public int sol; public int sag; public int alt;
        public Color color;

        public void Asaqi()
        {
            if (alt < 19)
            {
                y1++; y2++; y3++; y4++;
                alt++;
            }
        }
        public void Sol()
        {
            if (sol > 0)
            {
                x1--; x2--; x3--; x4--;
                sol--; sag--;
            }
        }
        public void Sag()
        {
            if (sag <9)
            {
                x1++; x2++; x3++; x4++;
                sag++; sol++;
            }
        }

        public virtual void Deyis()
        {
           
        }

    }
}
