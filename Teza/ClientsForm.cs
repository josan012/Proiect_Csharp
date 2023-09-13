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

namespace Teza
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MIHAI;Initial Catalog=Teza;Integrated Security=True");


        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.Show();
            this.Hide();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Clients VALUES (@nume, @prenume, @varsta, @suma)", con);
            cmd.Parameters.AddWithValue("@nume", txt_nume.Text);
            cmd.Parameters.AddWithValue("@prenume", txt_prenume.Text);
            cmd.Parameters.AddWithValue("@varsta", int.Parse(txt_varsta.Text));
            cmd.Parameters.AddWithValue("@suma", int.Parse(txt_bani.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adaugat cu succes");
            txt_nume.Clear();
            txt_prenume.Clear();
            txt_varsta.Clear();
            txt_bani.Clear();

            txt_nume.Focus();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clients", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Clients WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Șters cu succes");
            txt_id.Clear();

            txt_id.Focus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Clients SET Nume = @nume, Prenume = @prenume, Varsta = @varsta, Suma_de_bani = @suma WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@nume", txt_nume.Text);
            cmd.Parameters.AddWithValue("@prenume", txt_prenume.Text);
            cmd.Parameters.AddWithValue("@varsta", int.Parse(txt_varsta.Text));
            cmd.Parameters.AddWithValue("@suma", int.Parse(txt_bani.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Actualizat cu succes");
            txt_id.Clear();
            txt_nume.Clear();
            txt_prenume.Clear();
            txt_varsta.Clear();
            txt_bani.Clear();

            txt_id.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clients WHERE Nume = @nume", con);
            cmd.Parameters.AddWithValue("@nume", txt_search.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            txt_search.Clear();
            txt_search.Focus();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
