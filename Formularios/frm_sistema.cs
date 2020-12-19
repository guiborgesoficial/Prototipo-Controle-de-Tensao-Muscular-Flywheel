using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class frm_sistema : Form
    {
        public frm_sistema()
        {
            InitializeComponent();       
        }

        private void cht_grafico_Click(object sender, EventArgs e)
        {
              
        }

        private void frm_sistema_Load(object sender, EventArgs e)
        {
        }
        
        private void chckbox_3d_CheckedChanged(object sender, EventArgs e)
        {
           
            if(chckbox_3d.Checked)
            {
                cht_grafico.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                cht_grafico.ChartAreas[0].Area3DStyle.Enable3D = false;
            }
        }
        int x = 1;

        private void tmr_timer_Tick(object sender, EventArgs e)
        {
            if(cht_grafico.Series[0].Points.Count  > 17)
            {
                cht_grafico.Series[0].Points.RemoveAt(0);
                cht_grafico.Update();
            }
            Random input = new Random();
            double s = 0;
            cht_grafico.Series[0].Points.AddXY(x++, s = input.NextDouble());
            lbl_entradaDados.Text = s.ToString();
            if (s + 0.19 >= double.Parse(lbl_max.Text) || s - 0.19 <= double.Parse(lbl_min.Text))
            {
                cht_grafico.Series[0].Color = Color.Red;
                lbl_warning.Visible = true;
            }
            else
            {
                cht_grafico.Series[0].Color = Color.Blue;
                lbl_warning.Visible = false;
            }
            if (s > double.Parse(lbl_max.Text) || s < double.Parse(lbl_min.Text))
            {
                btn_stop_Click(e, e);
                var music = new SoundPlayer(@"D:\Projeto Flywheel\905858473.wav");
                music.Play();
                MessageBox.Show("Limite de treino excedido!");
            }
            
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            pictbox_logo.Visible = false;
            pictbox_logo2.Visible = true;
            UserControls.UserControl_Limites novo = new UserControls.UserControl_Limites();
            novo.Visible = true;
            cht_grafico.Visible = true;
            tmr_timer.Enabled = true;
            chck_linha.Visible = true;
            cht_grafico.Legends.Clear();
            lbl_entradaDados.Visible = true;
            lbl_max.Visible = true;
            lbl_min.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            lbl_EntradaText.Visible = true;
            cht_grafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            chckbox_3d.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmr_timer.Enabled = false;
        }

        private void chck_linha_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_linha.Checked)
            {
                cht_grafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            }
            else
                cht_grafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
        }

        private void lbl_entradaDados_Click(object sender, EventArgs e)
        {

        }
        public void parametros(double maximo, double minimo)
        {
            lbl_max.Text = maximo.ToString();
            lbl_min.Text = minimo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.frm_inicio novo = new Formularios.frm_inicio();
          
            novo.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
