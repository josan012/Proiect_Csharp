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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MIHAI;Initial Catalog=Teza;Integrated Security=True");

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login_new", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Login_new VALUES (@username, @password)", con);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adaugat cu succes");
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Login_new WHERE ID = @id", con);
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
            SqlCommand cmd = new SqlCommand("UPDATE Login_new SET username = @username, password = @password WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Actualizat cu succes");
            txt_username.Clear();
            txt_password.Clear();
            txt_id.Clear();

            txt_id.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login_new WHERE username = @username", con);
            cmd.Parameters.AddWithValue("@username", txt_search.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt; 
            con.Close();
            txt_search.Clear();
            txt_search.Focus();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.Show();
            this.Hide();
        }
    }
}
