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
    public partial class RiskForm : Form
    {
        public RiskForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MIHAI;Initial Catalog=Teza;Integrated Security=True");

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Risks", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.Show();
            this.Hide();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Risks VALUES (@Denumire, @Categorie, @Probabilitate)", con);
            cmd.Parameters.AddWithValue("@Denumire", txt_denumire.Text);
            cmd.Parameters.AddWithValue("@Categorie", txt_categorie.Text);
            cmd.Parameters.AddWithValue("@Probabilitate", txt_probabilitate.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adaugat cu succes");
            txt_denumire.Clear();
            txt_categorie.Clear();
            txt_probabilitate.Clear();

            txt_denumire.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Risks WHERE ID = @id", con);
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
            SqlCommand cmd = new SqlCommand("UPDATE Risks SET Denumire = @Denumire, Categorie = @Categorie, Probabilitate = @Probabilitate WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
            cmd.Parameters.AddWithValue("@Denumire", txt_denumire.Text);
            cmd.Parameters.AddWithValue("@Categorie", txt_categorie.Text);
            cmd.Parameters.AddWithValue("@Probabilitate", txt_probabilitate.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Actualizat cu succes");
            txt_denumire.Clear();
            txt_categorie.Clear();
            txt_probabilitate.Clear();
            txt_id.Clear();

            txt_id.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Risks WHERE Categorie = @Categorie", con);
            cmd.Parameters.AddWithValue("@Categorie", txt_search.Text);
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
