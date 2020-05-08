namespace Leituras
{
    partial class Form2
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
            this.Bt_cadmaq = new System.Windows.Forms.Button();
            this.Bt_lanç = new System.Windows.Forms.Button();
            this.Bt_imp = new System.Windows.Forms.Button();
            this.Bt_viz_maq = new System.Windows.Forms.Button();
            this.Bt_fechar = new System.Windows.Forms.Button();
            this.Bt_cadop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_viz_leituras = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Bt_viz_op = new System.Windows.Forms.Button();
            this.Bt_config = new System.Windows.Forms.Button();
            this.Lb_dia = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_cadmaq
            // 
            this.Bt_cadmaq.Location = new System.Drawing.Point(8, 37);
            this.Bt_cadmaq.Name = "Bt_cadmaq";
            this.Bt_cadmaq.Size = new System.Drawing.Size(127, 56);
            this.Bt_cadmaq.TabIndex = 1;
            this.Bt_cadmaq.Text = "Cadastrar Máquina";
            this.Bt_cadmaq.UseVisualStyleBackColor = true;
            this.Bt_cadmaq.Click += new System.EventHandler(this.Bt_cadmaq_Click);
            // 
            // Bt_lanç
            // 
            this.Bt_lanç.Location = new System.Drawing.Point(8, 32);
            this.Bt_lanç.Name = "Bt_lanç";
            this.Bt_lanç.Size = new System.Drawing.Size(127, 56);
            this.Bt_lanç.TabIndex = 5;
            this.Bt_lanç.Text = "Lançar Leituras";
            this.Bt_lanç.UseVisualStyleBackColor = true;
            this.Bt_lanç.Click += new System.EventHandler(this.Bt_lanç_Click);
            // 
            // Bt_imp
            // 
            this.Bt_imp.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_imp.Location = new System.Drawing.Point(159, 32);
            this.Bt_imp.Name = "Bt_imp";
            this.Bt_imp.Size = new System.Drawing.Size(127, 56);
            this.Bt_imp.TabIndex = 6;
            this.Bt_imp.Text = "Imprimir Leituras";
            this.Bt_imp.UseVisualStyleBackColor = true;
            this.Bt_imp.Click += new System.EventHandler(this.Bt_imp_Click);
            // 
            // Bt_viz_maq
            // 
            this.Bt_viz_maq.Location = new System.Drawing.Point(159, 37);
            this.Bt_viz_maq.Name = "Bt_viz_maq";
            this.Bt_viz_maq.Size = new System.Drawing.Size(127, 56);
            this.Bt_viz_maq.TabIndex = 2;
            this.Bt_viz_maq.Text = "Visualizar";
            this.Bt_viz_maq.UseVisualStyleBackColor = true;
            this.Bt_viz_maq.Click += new System.EventHandler(this.Bt_viz_maq_Click);
            // 
            // Bt_fechar
            // 
            this.Bt_fechar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_fechar.Location = new System.Drawing.Point(650, 347);
            this.Bt_fechar.Name = "Bt_fechar";
            this.Bt_fechar.Size = new System.Drawing.Size(127, 56);
            this.Bt_fechar.TabIndex = 9;
            this.Bt_fechar.Text = "FECHAR";
            this.Bt_fechar.UseVisualStyleBackColor = true;
            this.Bt_fechar.Click += new System.EventHandler(this.Bt_fechar_Click);
            // 
            // Bt_cadop
            // 
            this.Bt_cadop.Location = new System.Drawing.Point(8, 32);
            this.Bt_cadop.Name = "Bt_cadop";
            this.Bt_cadop.Size = new System.Drawing.Size(127, 56);
            this.Bt_cadop.TabIndex = 3;
            this.Bt_cadop.Text = "Cadastrar Operador";
            this.Bt_cadop.UseVisualStyleBackColor = true;
            this.Bt_cadop.Click += new System.EventHandler(this.Bt_cadop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bt_cadmaq);
            this.groupBox1.Controls.Add(this.Bt_viz_maq);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Máquinas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_viz_leituras);
            this.groupBox2.Controls.Add(this.Bt_lanç);
            this.groupBox2.Controls.Add(this.Bt_imp);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 109);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leituras";
            // 
            // Bt_viz_leituras
            // 
            this.Bt_viz_leituras.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_viz_leituras.Location = new System.Drawing.Point(310, 32);
            this.Bt_viz_leituras.Name = "Bt_viz_leituras";
            this.Bt_viz_leituras.Size = new System.Drawing.Size(127, 56);
            this.Bt_viz_leituras.TabIndex = 7;
            this.Bt_viz_leituras.Text = "Visualizar";
            this.Bt_viz_leituras.UseVisualStyleBackColor = true;
            this.Bt_viz_leituras.Click += new System.EventHandler(this.Bt_viz_leituras_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Bt_viz_op);
            this.groupBox3.Controls.Add(this.Bt_cadop);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 109);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operador";
            // 
            // Bt_viz_op
            // 
            this.Bt_viz_op.Location = new System.Drawing.Point(159, 32);
            this.Bt_viz_op.Name = "Bt_viz_op";
            this.Bt_viz_op.Size = new System.Drawing.Size(127, 56);
            this.Bt_viz_op.TabIndex = 4;
            this.Bt_viz_op.Text = "Visualizar";
            this.Bt_viz_op.UseVisualStyleBackColor = true;
            this.Bt_viz_op.Click += new System.EventHandler(this.Bt_viz_op_Click);
            // 
            // Bt_config
            // 
            this.Bt_config.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_config.Location = new System.Drawing.Point(650, 248);
            this.Bt_config.Name = "Bt_config";
            this.Bt_config.Size = new System.Drawing.Size(127, 56);
            this.Bt_config.TabIndex = 8;
            this.Bt_config.Text = "CONFIGURAÇÕES";
            this.Bt_config.UseVisualStyleBackColor = true;
            this.Bt_config.Click += new System.EventHandler(this.Bt_config_Click);
            // 
            // Lb_dia
            // 
            this.Lb_dia.AutoSize = true;
            this.Lb_dia.BackColor = System.Drawing.Color.Transparent;
            this.Lb_dia.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_dia.ForeColor = System.Drawing.Color.Black;
            this.Lb_dia.Location = new System.Drawing.Point(9, 34);
            this.Lb_dia.Name = "Lb_dia";
            this.Lb_dia.Size = new System.Drawing.Size(117, 40);
            this.Lb_dia.TabIndex = 14;
            this.Lb_dia.Text = "          ";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.BackColor = System.Drawing.Color.Transparent;
            this.lb_hora.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.ForeColor = System.Drawing.Color.Black;
            this.lb_hora.Location = new System.Drawing.Point(9, 89);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(107, 40);
            this.lb_hora.TabIndex = 15;
            this.lb_hora.Text = "         ";
            this.lb_hora.TextChanged += new System.EventHandler(this.lb_hora_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lb_dia);
            this.groupBox4.Controls.Add(this.lb_hora);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(359, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 147);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data / hora";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Bt_config);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_fechar);
            this.Name = "Form2";
            this.Text = "SISTEMA GERADOR E CONTROLADOR DE LEITURAS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_cadmaq;
        private System.Windows.Forms.Button Bt_lanç;
        private System.Windows.Forms.Button Bt_imp;
        private System.Windows.Forms.Button Bt_viz_maq;
        private System.Windows.Forms.Button Bt_fechar;
        private System.Windows.Forms.Button Bt_cadop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bt_viz_leituras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Bt_viz_op;
        private System.Windows.Forms.Button Bt_config;
        private System.Windows.Forms.Label Lb_dia;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}