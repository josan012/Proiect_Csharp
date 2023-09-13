using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teza
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm user_form = new UsersForm();
            user_form.Show();
            this.Hide();
        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            ClientsForm client_form = new ClientsForm();
            client_form.Show();
            this.Hide();
        }

        private void button_riscuri_Click(object sender, EventArgs e)
        {
            RiskForm risk_form = new RiskForm();
            risk_form.Show();
            this.Hide();
        }

        private void button_amenintari_Click(object sender, EventArgs e)
        {
            AmenintariForm amenintari_form = new AmenintariForm();
            amenintari_form.Show();
            this.Hide();
        }

        private void button_factors_Click(object sender, EventArgs e)
        {
            FactorsForm factors_form = new FactorsForm();
            factors_form.Show();
            this.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
