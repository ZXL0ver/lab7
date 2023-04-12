using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegkoVagovuk
{
    public class Girlanda
    {
        public int h;
        public Bitmap pic;
    }


    public class FirstGirlanda : Girlanda
    {
        public FirstGirlanda()
        {
            h = 50;
            pic = new Bitmap("q.jfif");
        }
    }
    public class SecondGirlanda : Girlanda
    {
        public SecondGirlanda()
        {
            h = 100;
            pic = new Bitmap("w.jfif");
        }
    }
    public class ThirdGirlanda : Girlanda
    {
        public ThirdGirlanda()
        {
            h = 100;
            pic = new Bitmap("e.jfif");
        }
    }
    public class Girland
    {
        public int x, y;
        public Girlanda p;
        public Girland()
        {
            x = 30; y = 30;
        }

        public Girland(int x, int y, Girlanda p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
        }
        Random random = new Random();
        public void Clear()
        {

        }
       
    }
}
