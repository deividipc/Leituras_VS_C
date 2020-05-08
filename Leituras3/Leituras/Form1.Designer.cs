namespace Leituras
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_senha
            // 
            this.Tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_senha.Location = new System.Drawing.Point(283, 168);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.PasswordChar = '*';
            this.Tb_senha.Size = new System.Drawing.Size(184, 32);
            this.Tb_senha.TabIndex = 1;
            this.Tb_senha.TextChanged += new System.EventHandler(this.Tb_senha_TextChanged);
            this.Tb_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_senha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(159, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "SENHA";
            // 
            // Bt_entrar
            // 
            this.Bt_entrar.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_entrar.ForeColor = System.Drawing.Color.Black;
            this.Bt_entrar.Location = new System.Drawing.Point(494, 168);
            this.Bt_entrar.Name = "Bt_entrar";
            this.Bt_entrar.Size = new System.Drawing.Size(105, 32);
            this.Bt_entrar.TabIndex = 2;
            this.Bt_entrar.Text = "Entrar";
            this.Bt_entrar.UseVisualStyleBackColor = true;
            this.Bt_entrar.Click += new System.EventHandler(this.Bt_entrar_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 338);
            this.Controls.Add(this.Bt_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_senha);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "inicio";
            this.Text = "LEITURAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bt_entrar;
    }
}

