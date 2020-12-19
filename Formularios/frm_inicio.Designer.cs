namespace WindowsFormsApp1.Formularios
{
    partial class frm_inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_parametros = new System.Windows.Forms.Button();
            this.btn_treinamento = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl_Limites1 = new WindowsFormsApp1.UserControls.UserControl_Limites();
            this.tmr_verificar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_parametros
            // 
            this.btn_parametros.Location = new System.Drawing.Point(35, 20);
            this.btn_parametros.Name = "btn_parametros";
            this.btn_parametros.Size = new System.Drawing.Size(236, 38);
            this.btn_parametros.TabIndex = 0;
            this.btn_parametros.Text = "Definir Parâmetros";
            this.btn_parametros.UseVisualStyleBackColor = true;
            this.btn_parametros.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_treinamento
            // 
            this.btn_treinamento.Enabled = false;
            this.btn_treinamento.Location = new System.Drawing.Point(35, 63);
            this.btn_treinamento.Name = "btn_treinamento";
            this.btn_treinamento.Size = new System.Drawing.Size(236, 36);
            this.btn_treinamento.TabIndex = 1;
            this.btn_treinamento.Text = "Iniciar Treinamento";
            this.btn_treinamento.UseVisualStyleBackColor = true;
            this.btn_treinamento.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(35, 104);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(236, 36);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            this.label2.Visible = false;
            // 
            // userControl_Limites1
            // 
            this.userControl_Limites1.Location = new System.Drawing.Point(1, 0);
            this.userControl_Limites1.Name = "userControl_Limites1";
            this.userControl_Limites1.Size = new System.Drawing.Size(298, 157);
            this.userControl_Limites1.TabIndex = 6;
            this.userControl_Limites1.Visible = false;
            this.userControl_Limites1.Load += new System.EventHandler(this.userControl_Limites1_Load_1);
            // 
            // tmr_verificar
            // 
            this.tmr_verificar.Enabled = true;
            this.tmr_verificar.Interval = 10;
            this.tmr_verificar.Tick += new System.EventHandler(this.tmr_verificar_Tick);
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 169);
            this.Controls.Add(this.userControl_Limites1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parametros);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_treinamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inicio";
            this.Text = "frm_inicio";
            this.Load += new System.EventHandler(this.frm_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_parametros;
        private System.Windows.Forms.Button btn_treinamento;
        private System.Windows.Forms.Button btn_sair;
        private UserControls.UserControl_Limites userControl_Limites1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmr_verificar;
    }
}