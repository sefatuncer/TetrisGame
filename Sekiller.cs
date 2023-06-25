using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Sekiller : Form1
    {
        public PictureBox[] pBox = new PictureBox[4];
        Color SekilRengi = Color.Red;
        protected int basTop = 100;
        protected int basLeft = 180;
        private int height = 10;
        private int width = 10;
        private int SekilNo = 1;
        private int LDogrultu = 1;
        private int ZDogrultu = 1;
        private int IDogrultu = 1;
        

        public Sekiller(Form1 form)
        {

        }

        public void RasgeleSekil(Form1 form)
        {
            Random r = new Random();
            int rand = r.Next(1, 4);
            switch (rand)
            {
                case 1:
                    SekilL(form);
                    break;
                case 2:
                    SekilI(form);
                    break;
                case 3:
                    SekilZ(form);
                    break;
                default:
                    SekilZ(form);
                    break;
            }
        }
        public void SekilL(Form1 form)
        {
            SekilNo = 1;
            int[,] pBoxLoc = {{basTop,basLeft},  /* /* {height,width,top,left} */
                             {basTop+10,basLeft},
                             {basTop+10,basLeft+10},
                             {basTop+10,basLeft+20}};
            SekilOlustur(pBoxLoc, form);
        }
        public void SekilI(Form1 form)
        {
            SekilNo = 3;
            int[,] pBoxLoc = {{basTop,basLeft},  /* /* {height,width,top,left}*/
                             {basTop+10,basLeft},
                             {basTop+20,basLeft},
                             {basTop+30,basLeft}};
            SekilOlustur(pBoxLoc, form);
        }
        
        public void SekilZ(Form1 form)
        {
            SekilNo = 2;
            int[,] pBoxLoc = {{basTop,basLeft},  /* /* {height,width,top,left}*/
                             {basTop+10,basLeft},
                             {basTop+10,basLeft-10},
                             {basTop+20,basLeft-10}};
            SekilOlustur(pBoxLoc,form);
        }
        public void SekilOlustur(int[,] pBoxLoc,Form1 form)
        {
            //PictureBox[] pBox = new PictureBox[4];
            for (int i = 0; i < pBox.Length; i++)
            {
                pBox[i] = new PictureBox();
                pBox[i].BackColor = SekilRengi;
                pBox[i].BorderStyle = BorderStyle.FixedSingle;
                pBox[i].Height = height;
                pBox[i].Width = width;
                pBox[i].Location = new Point(pBoxLoc[i, 1],pBoxLoc[i, 0]); // Left , Top
                form.Controls.Add(pBox[i]);
            }
        }

        public void SekilDondur()
        {
            if (SekilNo == 1) // L Sekli
            {
                if (LDogrultu == 1) // Yatay dogrultuda ise
                {
                    pBox[0].Location = new Point(pBox[0].Left+10, pBox[0].Top); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left, pBox[1].Top-10);
                    pBox[2].Location = new Point(pBox[2].Left-10, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left-20, pBox[3].Top+10);
                    LDogrultu = 2;
                }
                else if (LDogrultu == 2) // dikey dogrultuda ise
                {
                    pBox[0].Location = new Point(pBox[0].Left, pBox[0].Top + 10); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left + 10, pBox[1].Top);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top - 10);
                    pBox[3].Location = new Point(pBox[3].Left - 10, pBox[3].Top - 20);
                    LDogrultu = 3;
                }
                else if (LDogrultu == 3) // yatay2
                {
                    pBox[0].Location = new Point(pBox[0].Left - 10, pBox[0].Top); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left, pBox[1].Top + 10);
                    pBox[2].Location = new Point(pBox[2].Left + 10, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left + 20, pBox[3].Top - 10);
                    LDogrultu = 4;
                }
                else if (LDogrultu == 4) // dikey2
                {
                    pBox[0].Location = new Point(pBox[0].Left, pBox[0].Top - 10); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left - 10, pBox[1].Top);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top + 10);
                    pBox[3].Location = new Point(pBox[3].Left + 10, pBox[3].Top + 20);
                    LDogrultu = 1;
                }
            }
            else if (SekilNo == 2) // Z sekli
            {
                if (ZDogrultu == 1) // dikey ise
                {
                    pBox[0].Location = new Point(pBox[0].Left, pBox[0].Top + 20); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left - 10, pBox[1].Top + 10);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left - 10, pBox[3].Top - 10);
                    ZDogrultu = 2;
                }
                else if (ZDogrultu == 2) // yatay ise
                {
                    pBox[0].Location = new Point(pBox[0].Left, pBox[0].Top - 20); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left + 10, pBox[1].Top - 10);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left + 10, pBox[3].Top + 10);
                    ZDogrultu = 1;
                }
            }
            else if (SekilNo == 3) // I sekli
            {
                if (IDogrultu == 1) // dikey ise
                {
                    pBox[0].Location = new Point(pBox[0].Left + 20, pBox[0].Top + 20); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left + 10, pBox[1].Top + 10);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left - 10, pBox[3].Top - 10);
                    IDogrultu = 2;
                }
                else if (IDogrultu == 2)
                {
                    pBox[0].Location = new Point(pBox[0].Left - 20, pBox[0].Top - 20); // Left , Top
                    pBox[1].Location = new Point(pBox[1].Left - 10, pBox[1].Top - 10);
                    pBox[2].Location = new Point(pBox[2].Left, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left + 10, pBox[3].Top + 10);
                    IDogrultu = 1;
                }
            }

            /* Döndürüldüğünde kutunun kenarlarına taşmaması için */
            for (int i = 0; i < pBox.Length; i++)
                if (pBox[i].Location.X > 290)
                {
                    pBox[0].Location = new Point(pBox[0].Left - 10, pBox[0].Top);
                    pBox[1].Location = new Point(pBox[1].Left - 10, pBox[1].Top);
                    pBox[2].Location = new Point(pBox[2].Left - 10, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left - 10, pBox[3].Top);
                }
            for (int i = 0; i < pBox.Length; i++)
                if (pBox[i].Location.X < 50)
                {
                    pBox[0].Location = new Point(pBox[0].Left + 10, pBox[0].Top);
                    pBox[1].Location = new Point(pBox[1].Left + 10, pBox[1].Top);
                    pBox[2].Location = new Point(pBox[2].Left + 10, pBox[2].Top);
                    pBox[3].Location = new Point(pBox[3].Left + 10, pBox[3].Top);
                }
        }

        public void AsagiKaydir()
        {
            if (pBox[0].Location.Y < 390 && pBox[3].Location.Y < 390)
                for (int i = 0; i < pBox.Length; i++)
                    pBox[i].Location = new Point(pBox[i].Left, pBox[i].Top + 10); // Left , Top
        }
        public void SagaKaydir()
        {
            if(pBox[0].Location.X < 300 && pBox[3].Location.X < 300)
                for (int i = 0; i < pBox.Length; i++)
                        pBox[i].Location = new Point(pBox[i].Left + 10, pBox[i].Top); // Left , Top
            
        }
        public void SolaKaydir()
        {
            if (pBox[0].Location.X > 50 && pBox[3].Location.X > 50)
                for (int i = 0; i < pBox.Length; i++)
                    pBox[i].Location = new Point(pBox[i].Left - 10, pBox[i].Top); // Left , Top
        }

        public bool CarptiMi()
        {
            if (pBox[0].Location.Y > 380 || pBox[3].Location.Y > 380)
                return true;
            return false;
        }

        public int getirX(int i)
        {
            return pBox[i].Location.X;            
        }

        public int getirY(int i)
        {
            return pBox[i].Location.Y;
        }

    }
}
