using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            generate();
        }

        Color[] colors = new Color[] {
            Color.Green, Color.Green, Color.Green, Color.Green,
            Color.Green, Color.Green, Color.Green, Color.Green,
            Color.Green, Color.Green, Color.Green, Color.Green,
            Color.Green, Color.Green, Color.Green, Color.Green
        };

        private void button1_Click(object sender, EventArgs e)
        {
            updateButton(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateButton(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateButton(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateButton(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateButton(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateButton(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateButton(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateButton(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateButton(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateButton(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateButton(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            updateButton(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            updateButton(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            updateButton(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            updateButton(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            updateButton(16);
        }

        private void generate()
        {
            Random random = new Random();
            int mines = random.Next(2, 6);
            List<int> indexes = new List<int>(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            List<Button> btns = this.Controls.OfType<Button>().ToList();

            for (int i = 0; i < mines; i++)
            {
                int rand = random.Next(indexes.Count);
                int index = indexes[rand];
                colors[index] = Color.Red;
                indexes.RemoveAt(rand);
            }
        }

        private void reset()
        {
            List<Button> btns = this.Controls.OfType<Button>().ToList();
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].BackColor = default(Color);
                colors[i] = Color.Green;
            }
        }

        private void updateButton(int i)
        {
            i--;
            List<Button> btns = this.Controls.OfType<Button>().ToList();
            btns[i].BackColor = colors[i];

            if(colors[i] == Color.Red)
            {
                MessageBox.Show("You lost");
                reset();
                generate();
            }
        }
    }
}
