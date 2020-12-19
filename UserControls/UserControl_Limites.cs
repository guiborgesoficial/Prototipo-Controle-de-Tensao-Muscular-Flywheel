using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using WindowsFormsApp1.Formularios;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public partial class UserControl_Limites : UserControl
    {
        public UserControl_Limites()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso!");
            
            this.Visible = false;
        }
       
    }
}
