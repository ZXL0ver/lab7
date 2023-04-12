using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegkoVagovuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        Girland[] t = new Girland[500];
        Girlanda[] p = new Girlanda[2];
        List<Girland> plist = new List<Girland>();
        FirstGirlanda p1 = new FirstGirlanda();
        SecondGirlanda p2 = new SecondGirlanda();
        ThirdGirlanda p3 = new ThirdGirlanda();
        int count = 0;
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int y1 = 10,y2=10,y3=10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r.Next(1, 4) == 1)
            { plist.Add(new Girland(100, y1, p1)); y1 += 10; }
             if (r.Next(2, 3) == 2)
            { plist.Add(new Girland(500, y2, p2)); y2 += 10; }
             if (r.Next(2, 4) == 3)
            { plist.Add(new Girland(300, y3, p3)); y3 += 10; }


            g.DrawImage(plist[count].p.pic, new Rectangle(plist[count].x, plist[count].y, plist[count].p.h, 20));

            foreach (Girland q in plist)
            {

               
                g.Clear(Color.AliceBlue);
                for (int i = 0; i < plist.Count; i++)
                {
                    g.DrawImage(plist[i].p.pic, new Rectangle(plist[i].x, plist[i].y, plist[i].p.h, 20));
                }
            }
            if (count < 499)
                count++;
            else
                timer1.Stop();
        }
    }
}
