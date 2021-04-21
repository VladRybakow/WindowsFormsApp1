using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(Color.Black, 3);
            Graphics g = panel2.CreateGraphics();
            g.DrawEllipse(pn, 150, 20, 200, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            g.Clear(Color.White);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
