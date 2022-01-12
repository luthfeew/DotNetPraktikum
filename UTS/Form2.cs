using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UTS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string hitungCinta(string a, string b)
        {
            string first = a.ToUpper();
            int firstlength = a.Length;
            string second = b.ToUpper();
            int secondlength = b.Length;
            int LoveCount = 0;

            for (int Count = 0; Count < firstlength; Count++)
            {
                string singleLetter = first.Substring(Count, 1);
                if (singleLetter.Equals("A")) LoveCount += 2;
                if (singleLetter.Equals("E")) LoveCount += 2;
                if (singleLetter.Equals("I")) LoveCount += 2;
                if (singleLetter.Equals("O")) LoveCount += 2;
                if (singleLetter.Equals("U")) LoveCount += 3;
                if (singleLetter.Equals("A")) LoveCount += 1;
                if (singleLetter.Equals("E")) LoveCount += 3;
            }
            for (int Count = 0; Count < secondlength; Count++)
            {
                string singleLetter = second.Substring(Count, 1);
                if (singleLetter.Equals("A")) LoveCount += 2;
                if (singleLetter.Equals("E")) LoveCount += 2;
                if (singleLetter.Equals("I")) LoveCount += 2;
                if (singleLetter.Equals("O")) LoveCount += 2;
                if (singleLetter.Equals("U")) LoveCount += 3;
                if (singleLetter.Equals("A")) LoveCount += 1;
                if (singleLetter.Equals("E")) LoveCount += 3;
            }
            int amount = 0;
            if (LoveCount > 0) amount = 5 - ((firstlength + secondlength) / 2);
            if (LoveCount > 2) amount = 10 - ((firstlength + secondlength) / 2);
            if (LoveCount > 4) amount = 20 - ((firstlength + secondlength) / 2);
            if (LoveCount > 6) amount = 30 - ((firstlength + secondlength) / 2);
            if (LoveCount > 8) amount = 40 - ((firstlength + secondlength) / 2);
            if (LoveCount > 10) amount = 50 - ((firstlength + secondlength) / 2);
            if (LoveCount > 12) amount = 60 - ((firstlength + secondlength) / 2);
            if (LoveCount > 14) amount = 70 - ((firstlength + secondlength) / 2);
            if (LoveCount > 16) amount = 80 - ((firstlength + secondlength) / 2);
            if (LoveCount > 18) amount = 90 - ((firstlength + secondlength) / 2);
            if (LoveCount > 20) amount = 100 - ((firstlength + secondlength) / 2);
            if (LoveCount > 22) amount = 110 - ((firstlength + secondlength) / 2);
            if (firstlength == 0 || secondlength == 0) amount = 0;
            if (amount < 0) amount = 0;
            if (amount > 99) amount = 99;
            return amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c;

            a = inputSatu.Text.Trim();
            b = inputDua.Text.Trim();

            if (Regex.IsMatch(a, @"^[a-zA-Z ]+$") && Regex.IsMatch(b, @"^[a-zA-Z ]+$"))
            {
                c = hitungCinta(a, b);
                textBoxHasil.Text = c + "%";
            }
            else
            {
                MessageBox.Show("NAMA TIDAK VALID", "Error");
            }
        }
    }
}
