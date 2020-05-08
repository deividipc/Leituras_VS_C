namespace Leituras
{
    partial class vizual_leituras
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
            // vizual_leituras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_voltar);
            this.Name = "vizual_leituras";
            this.Text = "VIZUALIZAR / EDITAR LEITURAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_voltar;
    }
}