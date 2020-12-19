using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txtbox_senha.Text == "admin" && txtbox_user.Text == "admin")
            {
                frm_inicio novo = new frm_inicio();
                this.Hide();
                novo.Show();
            }
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtbox_senha.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtbox_senha.UseSystemPasswordChar = false;
        }
    }
}
