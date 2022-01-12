using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            listBox1.Items.Add("Isi list :");
            foreach (int i in myList)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi list [hapus item 3] :");
            myList.Remove(3);
            foreach (int i in myList)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi list [tambah item 5] :");
            myList.Add(5);
            foreach (int i in myList)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Queue<char> antrianku = new Queue<char>();

            antrianku.Enqueue('A');
            antrianku.Enqueue('B');
            antrianku.Enqueue('C');
            antrianku.Enqueue('D');

            listBox1.Items.Add("Isi Queue :");
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Queue [mengurangi queue] :");
            antrianku.Dequeue();
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Queue [menambah queue] :");
            antrianku.Enqueue('F');
            foreach (char i in antrianku)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack<char> tumpukanku = new Stack<char>();

            tumpukanku.Push('A');
            tumpukanku.Push('B');
            tumpukanku.Push('C');
            tumpukanku.Push('D');

            listBox1.Items.Add("Isi Stack :");
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Stack [mengurangi stack] :");
            tumpukanku.Pop();
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("Isi Stack [menambah stack] :");
            tumpukanku.Push('F');
            foreach (char i in tumpukanku)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
