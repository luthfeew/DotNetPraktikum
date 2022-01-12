using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MATRIXDESKTOP\SQLEXPRESS;
        Initial Catalog=kantinAmikom;
        Integrated Security=True");
        private string CaesarCipher(string value, int shift)
        {
            string[] joinCipher = new string[200];
            string joinText = "";
            string[] wordArray = value.Split(' ');

            try
            {
                for (int x = 0; x < wordArray.Length; x++)
                {
                    char[] buffer = wordArray[x].ToCharArray();

                    for (int i = 0; i < buffer.Length; i++)
                    {
                        char letter = buffer[i];

                        letter = (char)(letter + shift);

                        if (letter > 'z')
                        {
                            letter = (char)(letter - 26);
                        }
                        else if (letter < 'a')
                        {
                            letter = (char)(letter + 26);
                        }

                        buffer[i] = letter;
                    }

                    string HasilKonversi = new string(buffer);
                    joinCipher[x] = HasilKonversi;
                }
                joinText = String.Join(" ", joinCipher);
                return joinText;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" | txtPwd.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                return;
            }

            string teksCipher = null;
            teksCipher = CaesarCipher(txtPwd.Text, 17);

            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM admin WHERE userid='" + txtUser.Text + "' AND password = '" + teksCipher + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Form3 frm_menu = new Form3();
                frm_menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User id atau password tidak valid", "Peringatan");
                txtUser.Text = "";
                txtPwd.Text = "";
                txtUser.Focus();
                rd.Close();
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }
    }
}
