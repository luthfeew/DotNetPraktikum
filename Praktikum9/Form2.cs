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

namespace Praktikum9
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

        private string noTrans
        {
            get
            {
                con.Open();
                string nomor = "TR-0001";
                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(idTransaksi,4)) FROM transaksi", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "TR-" + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxNo.Text = noTrans;
            isiCombo();
            textBoxTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void isiCombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT idMenu,namaMenu FROM menu";

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds, "menu");
            comboBoxMenu.DataSource = ds.Tables["menu"];
            comboBoxMenu.DisplayMember = "namaMenu";
            comboBoxMenu.ValueMember = "idMenu";
        }

        private void resetData()
        {
            con.Close();
            textBoxNo.Text = noTrans;
            textBoxIdCustomer.Text = "";
            comboBoxMenu.Text = "";
            textBoxHarga.Text = "";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO transaksi VALUES('" + textBoxNo.Text + "','" + textBoxTanggal.Text + "'," +
                "'" + textBoxIdCustomer.Text + "'," +
                "'" + textBoxHarga.Text + "')";
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "INSERT INTO detailTransaksi VALUES('" + textBoxNo.Text + "'," +
                "'" + comboBoxMenu.SelectedValue + "')";
            cmd2.ExecuteNonQuery();

            resetData();
            textBoxIdCustomer.Focus();
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM menu WHERE namaMenu='" + comboBoxMenu.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                textBoxHarga.Text = rd[2].ToString();
                rd.Close();
            }
        }
    }
}
