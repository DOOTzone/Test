using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            while(s.Contains(";;"))
            {
                s = s.Replace(";;", ";");
            }
            string[] slova = s.Split(';');
            for(int i = 0; i < slova.Length; i++)
            {
                bool druha = false;
                foreach(char c in slova[i])
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        if (druha)
                        { 
                            listBox1.Items.Add(slova[i]);
                            break;
                        }
                        else
                            druha = true;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            while (s.Contains(";;"))
            {
                s = s.Replace(";;", ";");
            }
            string[] slova = s.Split(';');
            int min = 999999999;
            string min_s = "";
            int min_i = 0;
            int max = 0;
            string max_s = "";
            int max_i = 0;
            for (int v = 0; v < slova.Length; v++)
            {
                if (slova[v].Length < min)
                {
                    min = slova[v].Length;
                    min_s = slova[v];
                    min_i = v;
                }
                if (slova[v].Length > max)
                {
                    max = slova[v].Length;
                    max_s = slova[v];
                    max_i = v;
                }
            }
            MessageBox.Show("Nejdelší slovo je " + max_s, "Nejdelší", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Nejkratší slovo je " + min_s, "Nejkratší", MessageBoxButtons.OK, MessageBoxIcon.Information);
            slova[min_i] = "x";
            slova[max_i] = "XXX";
            for (int x = 0; x < slova.Length; x++)
            {
                textBox2.Text += slova[x]+";";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int x = Convert.ToInt32(textBox3.Text);
            int y = Convert.ToInt32(textBox4.Text);
            if (x + y > s.Length)
            {
                MessageBox.Show("V řetězci je méně znaků, než potřebujete odstranit.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                s = s.Remove(0, x);
                s = s.Remove(s.Length - y, y);
                textBox1.Text = s;
            }
        }
    }
}
