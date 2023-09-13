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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MIHAI;Initial Catalog=Teza;Integrated Security=True");

        private void button_register_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_confirm.Text == "")
            {
                MessageBox.Show("Te rog completează câmpurile.");
            }
            else if (txt_password.Text != txt_confirm.Text)
            {
                MessageBox.Show("Parola nu coincide.");
            }
            else
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
                txt_confirm.Clear();

                txt_username.Focus();
                Login login_form = new Login();
                login_form.Show();
                this.Hide();
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            txt_username.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            txt_confirm.BackColor = SystemColors.Control;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_username.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            txt_password.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            txt_confirm.BackColor = SystemColors.Control;
        }

        private void txt_confirm_TextChanged(object sender, EventArgs e)
        {
            txt_username.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;
            panel5.BackColor = Color.White;
            txt_confirm.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txt_confirm.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txt_confirm.UseSystemPasswordChar = true;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
