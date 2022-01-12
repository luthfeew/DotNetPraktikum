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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MATRIXDESKTOP\SQLEXPRESS;
        Initial Catalog=kantinAmikom;
        Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
            resetData();
        }

        private void resetData()
        {
            txtUser.Text = "";
            txtPwd.Text = "";
        }

        private void showData()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM admin";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "admin");
            dgvUser.DataSource = ds;
            dgvUser.DataMember = "admin";
            dgvUser.ReadOnly = true;
        }

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
            string teksCipher = null;
            teksCipher = CaesarCipher(txtPwd.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO admin VALUES('" +txtUser.Text+ "','" + teksCipher + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            showData();
            resetData();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToLower());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM admin WHERE userid = '"+ txtUser.Text +"'";
            cmd.ExecuteNonQuery();
            con.Close();

            showData();
            resetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string teksCipher = null;
            teksCipher = CaesarCipher(txtPwd.Text, 17);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE admin SET password = '"+ teksCipher +"' WHERE userid = '"+ txtUser.Text +"'";
            cmd.ExecuteNonQuery();
            con.Close();

            showData();
            resetData();
        }
    }
}
