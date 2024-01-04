using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static kacisOyunu.Form1;

namespace kacisOyunu
{
    public class Tuzaklar : PictureBox
    {
        public Tuzaklar(int x, int y, string imagePath)
        {
            Size = new Size(60, 60);
            Location = new Point(x, y);
            Image = Image.FromFile(imagePath);
            Visible = false;
        }


    }

    
}