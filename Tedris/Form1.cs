using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tedris.Properties;

namespace Tedris
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        OyunYeri oyunYeri = new OyunYeri();
        SoundPlayer sp = new SoundPlayer(Resources.oyunSesi);
        private void Form1_Load_1(object sender, EventArgs e)
        {           
            sp.PlayLooping();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (oyunBbasladi)
            {
                //xal
                lXal.Text = oyunYeri.xal.ToString();
                //oyunun davam edir
                if (oyunYeri.gameOver == false)
                {
                    if (e.KeyCode == Keys.Down) oyunYeri.Asaqi();
                    if (e.KeyCode == Keys.Left) oyunYeri.Sol();
                    if (e.KeyCode == Keys.Right) oyunYeri.Sag();
                    if (e.KeyCode == Keys.Up) oyunYeri.Cevir();
                }
                //oyun yanir 
                else
                {
                    bStop_Click(sender, null);
                    MessageBox.Show("sizin netice "+oyunYeri.xal);
                    oyunYeri = null;
                    panel1.Controls.Clear();
                    panelYaranan = null;
                }

            }
        }


        //exit
        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool oyunBbasladi = false;
        Panel panelYaranan;
        private void bPlay_Click(object sender, EventArgs e)
        {
            if (oyunYeri == null) oyunYeri = new OyunYeri();
            if (panelYaranan == null)
            {
                panelYaranan = oyunYeri.PanelYarat();
                //panel1.BackgroundImage = null;
                panel1.Controls.Add(panelYaranan);
                oyunYeri.OyunBaslasin();
            }
            oyunBbasladi = true;
            bPlay.Visible = false;
            bStop.Visible = true;
            timer1.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            oyunBbasladi = false;
            bPlay.Visible = true;
            bStop.Visible = false;
        }

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (oyunYeri.xal)
            {
                case 0:timer1.Interval = 1000;lSeviyye.Text = "1";break;
                case 50:timer1.Interval = 500;lSeviyye.Text = "2";break;
                case 100:timer1.Interval = 200;lSeviyye.Text = "3";break;
                case 150:timer1.Interval = 100;lSeviyye.Text = "4";break;
                case 200:timer1.Interval = 50;lSeviyye.Text = "5";break;
                default:
                    break;
            }

            Form1_KeyDown(sender, new KeyEventArgs(Keys.Down));
        }

        

        private void bSoundOn_Click(object sender, EventArgs e)
        {
            sp.Stop();
            bSoundON.Visible = false;
            bSoundOff.Visible = true;
        }

        private void bSoundOff_Click(object sender, EventArgs e)
        {
            sp.PlayLooping();
            bSoundON.Visible = true;
            bSoundOff.Visible = false;
        }
    }
}
