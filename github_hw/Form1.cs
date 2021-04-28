using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = GetRandomColor();
        }

        private Color GetRandomColor()
        {
            Random r = new Random();

            int red = r.Next(255);
            int green = r.Next(255);
            int blue = r.Next(255);


            return Color.FromArgb(red, green, blue);
        }
    }
}
