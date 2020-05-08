namespace Leituras
{
    partial class cad_op
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
            this.Bt_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Tb_endereço = new System.Windows.Forms.TextBox();
            this.Tb_cpf = new System.Windows.Forms.TextBox();
            this.Tb_rg = new System.Windows.Forms.TextBox();
            this.Bt_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_voltar
            // 
            this.Bt_voltar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_voltar.Location = new System.Drawing.Point(661, 382);
            this.Bt_voltar.Name = "Bt_voltar";
            this.Bt_voltar.Size = new System.Drawing.Size(127, 56);
            this.Bt_voltar.TabIndex = 1;
            this.Bt_voltar.Text = "Voltar";
            this.Bt_voltar.UseVisualStyleBackColor = true;
            this.Bt_voltar.Click += new System.EventHandler(this.Bt_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "RG";
            // 
            // Tb_nome
            // 
            this.Tb_nome.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_nome.Location = new System.Drawing.Point(158, 40);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(598, 41);
            this.Tb_nome.TabIndex = 8;
            this.Tb_nome.TextChanged += new System.EventHandler(this.Tb_nome_TextChanged);
            // 
            // Tb_endereço
            // 
            this.Tb_endereço.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_endereço.Location = new System.Drawing.Point(158, 106);
            this.Tb_endereço.Name = "Tb_endereço";
            this.Tb_endereço.Size = new System.Drawing.Size(598, 41);
            this.Tb_endereço.TabIndex = 9;
            this.Tb_endereço.TextChanged += new System.EventHandler(this.Tb_endereço_TextChanged);
            // 
            // Tb_cpf
            // 
            this.Tb_cpf.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_cpf.Location = new System.Drawing.Point(158, 172);
            this.Tb_cpf.Name = "Tb_cpf";
            this.Tb_cpf.Size = new System.Drawing.Size(343, 41);
            this.Tb_cpf.TabIndex = 10;
            this.Tb_cpf.TextChanged += new System.EventHandler(this.Tb_cpf_TextChanged);
            // 
            // Tb_rg
            // 
            this.Tb_rg.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_rg.Location = new System.Drawing.Point(158, 238);
            this.Tb_rg.Name = "Tb_rg";
            this.Tb_rg.Size = new System.Drawing.Size(343, 41);
            this.Tb_rg.TabIndex = 11;
            this.Tb_rg.TextChanged += new System.EventHandler(this.Tb_rg_TextChanged);
            // 
            // Bt_salvar
            // 
            this.Bt_salvar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_salvar.Location = new System.Drawing.Point(519, 382);
            this.Bt_salvar.Name = "Bt_salvar";
            this.Bt_salvar.Size = new System.Drawing.Size(127, 56);
            this.Bt_salvar.TabIndex = 12;
            this.Bt_salvar.Text = "Salvar";
            this.Bt_salvar.UseVisualStyleBackColor = true;
            // 
            // cad_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_salvar);
            this.Controls.Add(this.Tb_rg);
            this.Controls.Add(this.Tb_cpf);
            this.Controls.Add(this.Tb_endereço);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_voltar);
            this.Name = "cad_op";
            this.Text = "CADASTRAR OPERADOR";
            this.Load += new System.EventHandler(this.cad_op_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.TextBox Tb_endereço;
        private System.Windows.Forms.TextBox Tb_cpf;
        private System.Windows.Forms.TextBox Tb_rg;
        private System.Windows.Forms.Button Bt_salvar;
    }
}