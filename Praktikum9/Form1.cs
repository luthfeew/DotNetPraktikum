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

        private void showData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM menu";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds, "menu");
            dataGridViewMenu.DataSource = ds;
            dataGridViewMenu.DataMember = "menu";
            dataGridViewMenu.ReadOnly = true;
        }

        private void resetData()
        {
            inputId.Text = "";
            inputNama.Text = "";
            inputHarga.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ADDMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id", SqlDbType.VarChar);
            SqlParameter namaMenu = new SqlParameter("@nama", SqlDbType.VarChar);
            SqlParameter harga = new SqlParameter("@harga", SqlDbType.Int);

            idMenu.Value = inputId.Text;
            namaMenu.Value = inputNama.Text;
            harga.Value = inputHarga.Text;

            cmd.Parameters.Add(idMenu);
            cmd.Parameters.Add(namaMenu);
            cmd.Parameters.Add(harga);

            cmd.ExecuteNonQuery();

            con.Close();
            showData();
            resetData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELMENU";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id", SqlDbType.VarChar);

            idMenu.Value = inputId.Text;
            cmd.Parameters.Add(idMenu);
            cmd.ExecuteNonQuery();
            con.Close();
            showData();
        }
    }
}
