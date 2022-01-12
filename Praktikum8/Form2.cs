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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data source=MATRIXDESKTOP\SQLEXPRESS;
        initial catalog=kantinAmikom;
        integrated security=True;");
        DataTable dt = new DataTable();
        BindingSource bS = new BindingSource();

        private void Form2_Load(object sender, EventArgs e)
        {
            showData();
            resetData();
            bindingdata();
        }

        private void resetData()
        {
            idMenu.Text = "";
            namaMenu.Text = "";
            harga.Text = "";
        }

        private void bindingdata()
        {
            dt.Clear();

            idMenu.DataBindings.Clear();
            namaMenu.DataBindings.Clear();
            harga.DataBindings.Clear();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM menu", con);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            da.Fill(dt);

            bS.DataSource = dt;
            dgvmenu.DataSource = bS;

            idMenu.DataBindings.Add("Text", bS, "idMenu");
            namaMenu.DataBindings.Add("Text", bS, "namaMenu");
            harga.DataBindings.Add("Text", bS, "harga");
        }

        private void showData()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM menu";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "menu");
            dgvmenu.DataSource = ds;
            dgvmenu.DataMember = "menu";
            dgvmenu.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idMenu.Text == "" || namaMenu.Text == "" || harga.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(harga.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO menu VALUES ('" + idMenu.Text + "'," +
                "'" + namaMenu.Text + "'," + int.Parse(harga.Text) + ")";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

            berhenti:;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idMenu.Text == "" || namaMenu.Text == "" || harga.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            int num;
            bool isNum = int.TryParse(harga.Text.ToString(), out num);

            if (!isNum)
            {
                MessageBox.Show("Isi harga harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE menu SET namaMenu = '" + namaMenu.Text + "'" +
                ", harga = " + int.Parse(harga.Text) + " WHERE idMenu = '" + idMenu.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

            berhenti:;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idMenu.Text == "")
            {
                MessageBox.Show("Semua data harus diisi", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM menu WHERE idMenu = '" + idMenu.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();

        berhenti:;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            resetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bS.Filter = "namaMenu like '%" + searchIn.Text + "%'";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bS.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bS.MoveNext();
        }
    }
}
