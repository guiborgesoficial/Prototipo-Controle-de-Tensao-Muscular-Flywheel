namespace WindowsFormsApp1
{
    partial class frm_sistema
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_start = new System.Windows.Forms.Button();
            this.cht_grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmr_timer = new System.Windows.Forms.Timer(this.components);
            this.chckbox_3d = new System.Windows.Forms.CheckBox();
            this.btn_stop = new System.Windows.Forms.Button();
            this.chck_linha = new System.Windows.Forms.CheckBox();
            this.lbl_entradaDados = new System.Windows.Forms.Label();
            this.lbl_EntradaText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.btn_novoTreinamento = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictbox_logo = new System.Windows.Forms.PictureBox();
            this.pictbox_logo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cht_grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(163, 338);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(152, 37);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cht_grafico
            // 
            this.cht_grafico.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.cht_grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_grafico.Legends.Add(legend2);
            this.cht_grafico.Location = new System.Drawing.Point(48, 21);
            this.cht_grafico.Name = "cht_grafico";
            this.cht_grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.BackSecondaryColor = System.Drawing.SystemColors.HotTrack;
            series2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.LegendText = "Potência Gerada";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.MarkerSize = 4;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Potência Gerada";
            this.cht_grafico.Series.Add(series2);
            this.cht_grafico.Size = new System.Drawing.Size(697, 300);
            this.cht_grafico.TabIndex = 1;
            this.cht_grafico.Click += new System.EventHandler(this.cht_grafico_Click);
            // 
            // tmr_timer
            // 
            this.tmr_timer.Interval = 1000;
            this.tmr_timer.Tick += new System.EventHandler(this.tmr_timer_Tick);
            // 
            // chckbox_3d
            // 
            this.chckbox_3d.AutoSize = true;
            this.chckbox_3d.Location = new System.Drawing.Point(478, 349);
            this.chckbox_3d.Name = "chckbox_3d";
            this.chckbox_3d.Size = new System.Drawing.Size(77, 17);
            this.chckbox_3d.TabIndex = 2;
            this.chckbox_3d.Text = "Gráfico 3D";
            this.chckbox_3d.UseVisualStyleBackColor = true;
            this.chckbox_3d.Visible = false;
            this.chckbox_3d.CheckedChanged += new System.EventHandler(this.chckbox_3d_CheckedChanged);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(163, 381);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(152, 37);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // chck_linha
            // 
            this.chck_linha.AutoSize = true;
            this.chck_linha.Location = new System.Drawing.Point(478, 372);
            this.chck_linha.Name = "chck_linha";
            this.chck_linha.Size = new System.Drawing.Size(89, 17);
            this.chck_linha.TabIndex = 4;
            this.chck_linha.Text = "Gráfico Linha";
            this.chck_linha.UseVisualStyleBackColor = true;
            this.chck_linha.Visible = false;
            this.chck_linha.CheckedChanged += new System.EventHandler(this.chck_linha_CheckedChanged);
            // 
            // lbl_entradaDados
            // 
            this.lbl_entradaDados.AutoSize = true;
            this.lbl_entradaDados.Location = new System.Drawing.Point(648, 351);
            this.lbl_entradaDados.Name = "lbl_entradaDados";
            this.lbl_entradaDados.Size = new System.Drawing.Size(13, 13);
            this.lbl_entradaDados.TabIndex = 5;
            this.lbl_entradaDados.Text = "0";
            this.lbl_entradaDados.Visible = false;
            this.lbl_entradaDados.Click += new System.EventHandler(this.lbl_entradaDados_Click);
            // 
            // lbl_EntradaText
            // 
            this.lbl_EntradaText.AutoSize = true;
            this.lbl_EntradaText.Location = new System.Drawing.Point(563, 350);
            this.lbl_EntradaText.Name = "lbl_EntradaText";
            this.lbl_EntradaText.Size = new System.Drawing.Size(79, 13);
            this.lbl_EntradaText.TabIndex = 6;
            this.lbl_EntradaText.Text = "Potência Atual:";
            this.lbl_EntradaText.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Potência Máx.:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Potência Min:";
            this.label2.Visible = false;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(648, 373);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(13, 13);
            this.lbl_max.TabIndex = 9;
            this.lbl_max.Text = "0";
            this.lbl_max.Visible = false;
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(648, 396);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(13, 13);
            this.lbl_min.TabIndex = 10;
            this.lbl_min.Text = "0";
            this.lbl_min.Visible = false;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.ForeColor = System.Drawing.Color.Red;
            this.lbl_warning.Location = new System.Drawing.Point(563, 329);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(63, 13);
            this.lbl_warning.TabIndex = 11;
            this.lbl_warning.Text = "WARNING!";
            this.lbl_warning.Visible = false;
            // 
            // btn_novoTreinamento
            // 
            this.btn_novoTreinamento.Location = new System.Drawing.Point(321, 338);
            this.btn_novoTreinamento.Name = "btn_novoTreinamento";
            this.btn_novoTreinamento.Size = new System.Drawing.Size(152, 37);
            this.btn_novoTreinamento.TabIndex = 12;
            this.btn_novoTreinamento.Text = "NOVO TREINAMENTO";
            this.btn_novoTreinamento.UseVisualStyleBackColor = true;
            this.btn_novoTreinamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(321, 381);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(152, 37);
            this.btn_sair.TabIndex = 13;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictbox_logo
            // 
            this.pictbox_logo.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.pictbox_logo.Location = new System.Drawing.Point(59, 21);
            this.pictbox_logo.Name = "pictbox_logo";
            this.pictbox_logo.Size = new System.Drawing.Size(653, 298);
            this.pictbox_logo.TabIndex = 14;
            this.pictbox_logo.TabStop = false;
            // 
            // pictbox_logo2
            // 
            this.pictbox_logo2.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.pictbox_logo2.Location = new System.Drawing.Point(59, 338);
            this.pictbox_logo2.Name = "pictbox_logo2";
            this.pictbox_logo2.Size = new System.Drawing.Size(100, 80);
            this.pictbox_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictbox_logo2.TabIndex = 15;
            this.pictbox_logo2.TabStop = false;
            this.pictbox_logo2.Visible = false;
            // 
            // frm_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.pictbox_logo2);
            this.Controls.Add(this.pictbox_logo);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novoTreinamento);
            this.Controls.Add(this.cht_grafico);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_EntradaText);
            this.Controls.Add(this.lbl_entradaDados);
            this.Controls.Add(this.chck_linha);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.chckbox_3d);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_sistema";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.frm_sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_logo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_grafico;
        private System.Windows.Forms.Timer tmr_timer;
        private System.Windows.Forms.CheckBox chckbox_3d;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.CheckBox chck_linha;
        private System.Windows.Forms.Label lbl_entradaDados;
        private System.Windows.Forms.Label lbl_EntradaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button btn_novoTreinamento;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pictbox_logo;
        private System.Windows.Forms.PictureBox pictbox_logo2;
    }
}

