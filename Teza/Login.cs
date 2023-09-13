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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MIHAI;Initial Catalog=Teza;Integrated Security=True");

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    MenuForm form2 = new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            RegistrationForm registerration_form = new RegistrationForm();
            registerration_form.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_username.Select();
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_password.BackColor = SystemColors.Control;

        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txt_username.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;

        }

        private void btn_registrate_Click(object sender, EventArgs e)
        {
            RegistrationForm registration_form = new RegistrationForm();
            registration_form.Show();
            this.Hide();
        }
    }
}
