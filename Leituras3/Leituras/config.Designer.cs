namespace Leituras
{
    partial class config
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
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.Bt_salvar = new System.Windows.Forms.Button();
            this.Tb_conf_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_voltar
            // 
            this.Bt_voltar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_voltar.Location = new System.Drawing.Point(653, 382);
            this.Bt_voltar.Name = "Bt_voltar";
            this.Bt_voltar.Size = new System.Drawing.Size(127, 56);
            this.Bt_voltar.TabIndex = 4;
            this.Bt_voltar.Text = "Voltar";
            this.Bt_voltar.UseVisualStyleBackColor = true;
            this.Bt_voltar.Click += new System.EventHandler(this.Bt_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // Tb_senha
            // 
            this.Tb_senha.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_senha.Location = new System.Drawing.Point(175, 36);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.Size = new System.Drawing.Size(100, 46);
            this.Tb_senha.TabIndex = 1;
            this.Tb_senha.Text = " ";
            this.Tb_senha.TextChanged += new System.EventHandler(this.Tb_senha_TextChanged);
            // 
            // Bt_salvar
            // 
            this.Bt_salvar.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_salvar.Location = new System.Drawing.Point(485, 382);
            this.Bt_salvar.Name = "Bt_salvar";
            this.Bt_salvar.Size = new System.Drawing.Size(127, 56);
            this.Bt_salvar.TabIndex = 3;
            this.Bt_salvar.Text = "Salvar";
            this.Bt_salvar.UseVisualStyleBackColor = true;
            this.Bt_salvar.Click += new System.EventHandler(this.Bt_salvar_Click);
            // 
            // Tb_conf_senha
            // 
            this.Tb_conf_senha.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_conf_senha.Location = new System.Drawing.Point(570, 33);
            this.Tb_conf_senha.Name = "Tb_conf_senha";
            this.Tb_conf_senha.Size = new System.Drawing.Size(100, 46);
            this.Tb_conf_senha.TabIndex = 2;
            this.Tb_conf_senha.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirmar senha";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tb_conf_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_salvar);
            this.Controls.Add(this.Tb_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_voltar);
            this.Name = "config";
            this.Text = "CONFIGURAÇÕES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Button Bt_salvar;
        private System.Windows.Forms.TextBox Tb_conf_senha;
        private System.Windows.Forms.Label label2;
    }
}