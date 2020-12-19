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
    public partial class frm_inicio : Form
    {
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Limites1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_sistema novo = new frm_sistema();
            this.Hide();
            label1.Text = userControl_Limites1.txtbox_maxPot.Text.ToString();
            label2.Text = userControl_Limites1.txtbox_minPot.Text.ToString();
            novo.parametros(double.Parse(label1.Text), double.Parse(label2.Text));
            novo.Show();
        }

        private void userControl_Limites1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {
           
        }

        private void tmr_verificar_Tick(object sender, EventArgs e)
        {
            label1.Text = userControl_Limites1.txtbox_maxPot.Text.ToString();
            label2.Text = userControl_Limites1.txtbox_minPot.Text.ToString();
            if (label1.Text == "" && label2.Text == "")
            {
                btn_treinamento.Enabled = false;
            }
            else if (!(label1.Text == "" && label2.Text == ""))
            {
                btn_treinamento.Enabled = true;
            }
        }
    }
}
