using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Praktikum8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data source=MATRIXDESKTOP\SQLEXPRESS;
        initial catalog=kantinAmikom;
        integrated security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            resetData();
            showData();
        }

        private void resetData()
        {
            customerId.Text = "";
            customerName.Text = "";
            voucher.Text = "";
        }

        private void showData()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM customer";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";
            dgvcustomer.ReadOnly = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM customer WHERE namacustomer LIKE '%" + searchIn.Text + "%'";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "customer");
            dgvcustomer.DataSource = ds;
            dgvcustomer.DataMember = "customer";
            dgvcustomer.ReadOnly = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (customerId.Text == "" || customerName.Text == "" || voucher.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(voucher.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO customer VALUES ('" + customerId.Text + "','" + customerName.Text + "'," + voucher.Text + ")";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

            berhenti:;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (customerId.Text == "" || customerName.Text == "" || voucher.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(voucher.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi voucher harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE customer SET namacustomer = '" + customerName.Text + "'" +
                ", nominalIsi = " + voucher.Text + " WHERE idcustomer = '" + customerId.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

            berhenti:;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerId.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM customer WHERE idcustomer = '" + customerId.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

            berhenti:;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
