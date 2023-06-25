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
    public partial class Tetris:Form1
    {
        Sekiller[] sekil = new Sekiller[1000];
        private int k = 0;
        Duvar duvar;
        int[,] doluKordinat;
        public Tetris(Form1 form)
        {
            sekil[k] = new Sekiller(form);
            sekil[k].RasgeleSekil(form);
            this.KeyPreview = true;
            duvar = new Duvar(form);
            doluKordinat = new int[100, 100];
            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                    doluKordinat[i, j] = 0;
        }

        public void Dondur(Form1 form)
        {
            sekil[k].SekilDondur();
        }

        public void Asagi(Form1 form)
        {
            if (DurumAlt())
                sekil[k].AsagiKaydir();
            yeniSekil(form);
            SatirEritme();
        }

        public void Sag(Form1 form)
        {
            if(DurumSag())
                sekil[k].SagaKaydir();
        }

        public void Sol(Form1 form)
        {
            if(DurumSol())
                sekil[k].SolaKaydir();
        }

        public void yeniSekil(Form1 form)
        {
            if (sekil[k].CarptiMi() || !DurumAlt())
            {
                for (int i = 0; i < sekil[k].pBox.Length; i++)
                {
                    sekil[k].pBox[i].BackColor = Color.Yellow;
                    KordinatBelirle(sekil[k].getirX(i),sekil[k].getirY(i));
                }
                k++;
                sekil[k] = new Sekiller(form);
                sekil[k].RasgeleSekil(form);
            }
        }

        public void KordinatBelirle(int x, int y)
        {
            doluKordinat[x / 10, y / 10] = 1;
        }

        public bool DurumSag() // Sağında eleman varsa sağa gitmemesi için
        {
            for (int i = 0; i < 4; i++)
            {
                if (doluKordinat[1 + sekil[k].getirX(i) / 10, sekil[k].getirY(i) / 10] == 1)
                    return false;
            }
            return true;
        }

        public bool DurumSol() // Solda eleman varsa
        {
            for (int i = 0; i < 4; i++)
            {
                if (doluKordinat[sekil[k].getirX(i) / 10 - 1, sekil[k].getirY(i) / 10] == 1)
                    return false;
            }
            return true;
        }

        public bool DurumAlt() // Altta eleman varsa
        {
            for (int i = 0; i < 4; i++)
            {
                if (doluKordinat[sekil[k].getirX(i) / 10, sekil[k].getirY(i) / 10 + 1] == 1)
                    return false;
            }
            return true;
        }

        public void SatirEritme()
        {
            int eleman = 0;
            for (int i = 39; i >= 10; i--)
            {
                eleman = 0;
                for (int j = 5; j < 30; j++)
                {
                    if (doluKordinat[i, j] == 1)
                        eleman++;
                    if (eleman == 24)
                    {
                        sekil[k].pBox[0].Location = new Point(sekil[k].pBox[0].Left + 100, sekil[k].pBox[0].Top);
                    }
                }
            }
        }

        //public int SagdaElemanVarmi()
        //{
        //    int elemanVar = 0;
        //    if(k>0)
        //    for (int i = k-1; i >= 0; i--)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            if (sekil[k].getirX(0) == sekil[i].getirX(j)+10 && sekil[k].getirY(0) == sekil[i].getirY(j))
        //                elemanVar = 1;
        //            else if (sekil[k].getirX(1) == sekil[i].getirX(j)+10 && sekil[k].getirY(1) == sekil[i].getirY(j))
        //                elemanVar = 1;
        //            else if (sekil[k].getirX(2) == sekil[i].getirX(j)+10 && sekil[k].getirY(2) == sekil[i].getirY(j))
        //                elemanVar = 1;
        //            else if (sekil[k].getirX(3) == sekil[i].getirX(j)+10 && sekil[k].getirY(3) == sekil[i].getirY(j))
        //                elemanVar = 1;
        //        }
        //    }
        //    return elemanVar;
        //}

    }
}
