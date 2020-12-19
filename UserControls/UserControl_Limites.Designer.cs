namespace WindowsFormsApp1.UserControls
{
    partial class UserControl_Limites
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ptMax = new System.Windows.Forms.Label();
            this.lbl_potMin = new System.Windows.Forms.Label();
            this.txtbox_maxPot = new System.Windows.Forms.TextBox();
            this.txtbox_minPot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ptMax
            // 
            this.lbl_ptMax.AutoSize = true;
            this.lbl_ptMax.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ptMax.Location = new System.Drawing.Point(3, 65);
            this.lbl_ptMax.Name = "lbl_ptMax";
            this.lbl_ptMax.Size = new System.Drawing.Size(138, 21);
            this.lbl_ptMax.TabIndex = 0;
            this.lbl_ptMax.Text = "Potência Máxima:";
            // 
            // lbl_potMin
            // 
            this.lbl_potMin.AutoSize = true;
            this.lbl_potMin.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potMin.Location = new System.Drawing.Point(3, 98);
            this.lbl_potMin.Name = "lbl_potMin";
            this.lbl_potMin.Size = new System.Drawing.Size(135, 21);
            this.lbl_potMin.TabIndex = 1;
            this.lbl_potMin.Text = "Potência Mínima:";
            // 
            // txtbox_maxPot
            // 
            this.txtbox_maxPot.Location = new System.Drawing.Point(138, 68);
            this.txtbox_maxPot.Name = "txtbox_maxPot";
            this.txtbox_maxPot.Size = new System.Drawing.Size(152, 20);
            this.txtbox_maxPot.TabIndex = 2;
            // 
            // txtbox_minPot
            // 
            this.txtbox_minPot.Location = new System.Drawing.Point(138, 101);
            this.txtbox_minPot.Name = "txtbox_minPot";
            this.txtbox_minPot.Size = new System.Drawing.Size(152, 20);
            this.txtbox_minPot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "PARÂMETROS";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(138, 127);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(152, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // UserControl_Limites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_minPot);
            this.Controls.Add(this.txtbox_maxPot);
            this.Controls.Add(this.lbl_potMin);
            this.Controls.Add(this.lbl_ptMax);
            this.Name = "UserControl_Limites";
            this.Size = new System.Drawing.Size(306, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ptMax;
        private System.Windows.Forms.Label lbl_potMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salvar;
        public System.Windows.Forms.TextBox txtbox_maxPot;
        public System.Windows.Forms.TextBox txtbox_minPot;
    }
}
