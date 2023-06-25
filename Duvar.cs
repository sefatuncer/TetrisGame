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
    class Duvar:Form1
    {
        Color DuvarRengi = Color.OrangeRed;
        public int altDuvar;
        public int sagDuvar;
        public int solDuvar;
        public Duvar(Form1 form)
        {
            AltDuvar(form);
            SolDuvar(form);
            SagDuvar(form);
            //icBolge(form);
        }

        public void AltDuvar(Form1 form)
        {
            int[] pBoxValue = {20,300,400,30}; // Height,Width,Top,Left
            altDuvar = pBoxValue[2];
            DuvarCiz(pBoxValue, form);
        }
        public void SolDuvar(Form1 form)
        {
            int[] pBoxValue = { 300, 20, 100, 30 }; // Height,Width,Top,Left
            solDuvar = pBoxValue[3];
            DuvarCiz(pBoxValue, form);
        }
        public void SagDuvar(Form1 form)
        {
            int[] pBoxValue = { 300, 20, 100, 310 }; // Height,Width,Top,Left
            DuvarCiz(pBoxValue,form);
            sagDuvar = pBoxValue[3];
        }

        public void DuvarCiz(int[] pBoxValue,Form1 form)
        {
            PictureBox pBox = new PictureBox();
            pBox.BackColor = DuvarRengi;
            pBox.BorderStyle = BorderStyle.FixedSingle;
            pBox.Height = pBoxValue[0];
            pBox.Width = pBoxValue[1];
            pBox.Top = pBoxValue[2];
            pBox.Left = pBoxValue[3];
            form.Controls.Add(pBox);
        }

        //public void icBolge(Form1 form)
        //{
        //    PictureBox[,] pBox = new PictureBox[300, 300];
        //    for (int i = 0; i < 26; i++)
        //    {
        //        for (int j = 0; j < 30; j++)
        //        {
        //            pBox[i, j] = new PictureBox();
        //            pBox[i, j].Height = 10;
        //            pBox[i, j].Width = 10;
        //            pBox[i, j].BackColor = Color.Yellow;
        //            pBox[i, j].BorderStyle = BorderStyle.FixedSingle;
        //            pBox[i, j].Location = new Point(50 + i * 10, 100 + j * 10);
        //            form.Controls.Add(pBox[i, j]);
        //        }
        //    }
        //}


    }
}
