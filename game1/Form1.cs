using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        private int x = 50, y = 50;
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Bitmap r=new Bitmap("role.png");
            r.SetResolution(96,96);
            g.RotateTransform(30);
            g.DrawImage(r,0,0);
        }

        private void Draw(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"role.png");
            bitmap.SetResolution(96, 96);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(bitmap, x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult r1 = MessageBox.Show("有按键按下");
            if (e.KeyCode == Keys.Up){    y = y - 5; }
            if (e.KeyCode == Keys.Down) { y = y + 5; }
            if (e.KeyCode == Keys.Left) { x = x - 5; }
            if (e.KeyCode == Keys.Right) { x = x + 5; }
            Draw(sender,e);
        }
        private void Draw1()
        {
            Bitmap bitmap = new Bitmap(@"role.png");
            bitmap.SetResolution(96, 96);
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(bitmap, x, y);
        }
    }
}
