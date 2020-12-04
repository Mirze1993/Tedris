using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tedris.Properties;

namespace Tedris
{
    class OyunYeri
    {
        Label[,] labels = new Label[20, 10];
        int left = 0;
        int top = 0;
        Panel panel = new Panel();        
        public int xal = 0;
        public bool gameOver=false;

        Fiqur fq;
        int yarananFiqur;
        bool partlat;
        bool ses;

        public bool Ses { get => ses; set => ses = value; }


        //panel yaratmaq
        public Panel PanelYarat()
        {
            
            panel.AutoSize = true;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labels[i, j] = new Label();
                    labels[i, j].AutoSize = false;
                    labels[i, j].Width = labels[i, j].Height = 20;
                    labels[i, j].Left = left;
                    labels[i, j].Top = top;
                    labels[i, j].BackColor = Color.White;
                    labels[i, j].BorderStyle = BorderStyle.Fixed3D;                  
                    panel.Controls.Add(labels[i, j]);
                    left += 20;
                }
                left = 0;
                top += 20;
            }

            return panel;
        }

       
        //oynun baslamasi
        public bool OyunBaslasin()
        {
            FiqurSec();
            FiqurCek();
            return true;
        }

        //yeni partiya
        public void YeniPartiya()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    labels[i, j].BackColor = Color.White;
                }
            }
            OyunBaslasin();
        }


        void FiqurSec()
        {
            OyunYandi();
            PartlamaniYoxla();                       
            Random r = new Random();
            yarananFiqur = r.Next(1, 8);
            switch (yarananFiqur)
                {
                    case 1: fq = new FKvadrat(); break; //1
                    case 2: fq = new FLDuz(); break; //2
                    case 3: fq = new FLTers(); break; //3
                    case 4: fq = new FZduz(); break; //4
                    case 5: fq = new FZTers(); break; //5
                    case 6: fq = new FI(); break; //6
                    case 7: fq = new FT(); break; //7
                    default:
                        break;
                }
            
        }

        void FiqurCek()
        {
            if (gameOver) return;
            labels[fq.y1, fq.x1].BackColor = fq.color;
            labels[fq.y2, fq.x2].BackColor = fq.color;
            labels[fq.y3, fq.x3].BackColor = fq.color;
            labels[fq.y4, fq.x4].BackColor = fq.color;
        }

        void FiqurSil()
        {
            labels[fq.y1, fq.x1].BackColor = Color.White;
            labels[fq.y2, fq.x2].BackColor = Color.White;
            labels[fq.y3, fq.x3].BackColor = Color.White;
            labels[fq.y4, fq.x4].BackColor = Color.White;
        }


        public void Asaqi()
        {   
            // en asaqiya catarsa
            if (fq.alt == 19)
            {                
                FiqurSec();
                FiqurCek();
            }
            //asaqiya catmmazsa
            else
            {
                FiqurSil();
                //hereket ede bilmesinin kontrolu
                if (
                    labels[fq.y1 + 1, fq.x1].BackColor == Color.White &&
                    labels[fq.y2 + 1, fq.x2].BackColor == Color.White &&
                    labels[fq.y3 + 1, fq.x3].BackColor == Color.White &&
                    labels[fq.y4 + 1, fq.x4].BackColor == Color.White)
                {
                    
                    fq.Asaqi();
                    FiqurCek();
                }
                // ede bilezse sildiyimizi yeniden cekib yenisini yaradiriq
                else
                {                    
                    FiqurCek();                  
                    FiqurSec();
                    FiqurCek();
                }


            }
        }
        public void Sol()
        {
            
            FiqurSil();

            if (fq.sol > 0&&
                   labels[fq.y1, fq.x1-1].BackColor == Color.White &&
                   labels[fq.y2, fq.x2-1].BackColor == Color.White &&
                   labels[fq.y3, fq.x3-1].BackColor == Color.White &&
                   labels[fq.y4, fq.x4-1].BackColor == Color.White)
            {
                fq.Sol();
            }
                
            FiqurCek();
        }
        public void Sag()
        {
            
            FiqurSil();

            if (fq.sag <9 &&
                   labels[fq.y1, fq.x1 + 1].BackColor == Color.White &&
                   labels[fq.y2, fq.x2 + 1].BackColor == Color.White &&
                   labels[fq.y3, fq.x3 + 1].BackColor == Color.White &&
                   labels[fq.y4, fq.x4 + 1].BackColor == Color.White)
            {
                fq.Sag();
            }
                           
            FiqurCek();
        }
        public void Cevir()
        {
           
            FiqurSil();
            fq.Deyis();
            FiqurCek();
        }

        // partlamani yoxlamaq
        void PartlamaniYoxla()
        {
            partlat = true;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (labels[i, j].BackColor==Color.White)
                    {
                        partlat = false;
                    }
                    
                }
                Partlad(partlat,i);
                partlat = true;
                
            }
        }

        //partlama
        void Partlad(bool p,int setir)
        {
            if (p==true)
            {
                //SoundPlayer sp = new SoundPlayer(Resources.partlat);
                //sp.Play();
                //xal artir
                xal += 10;               
                //partt
                for (int i = setir; i >0; i--)
                {
                    for (int j = 0; j < 10; j++)
                    {
                     
                       labels[i, j].BackColor = labels[i-1, j].BackColor;
                    }
                }

                if (xal % 50 == 0) { YeniPartiya(); }
            }
        }

        //game over
        void OyunYandi()
        {
            bool son = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    if (labels[i, j].BackColor != Color.White) son = false;                
                }
            }
            if (son==false)
            {
                //MessageBox.Show("game over");
                //xal = 0;
                gameOver=true;
            }          
           
        }

    }
}
