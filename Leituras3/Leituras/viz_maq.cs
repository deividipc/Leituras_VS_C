using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Leituras
{
    public partial class viz_maq : Form
    {
        Thread voltar;
        public viz_maq()
        {
            InitializeComponent();
            Bt_excluir.Enabled = false;
            Bt_salvar.Enabled = false;

        }

        private void Bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            voltar = new Thread(volta);        
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }
    private void volta()
    {
        Application.Run(new Form2());
    }

        private void Bt_edit_Click(object sender, EventArgs e)
        {
            Bt_excluir.Enabled = true;
            Bt_salvar.Enabled = true;
        }

        private void Bt_salvar_Click(object sender, EventArgs e)
        {
            Bt_excluir.Enabled = false;
            Bt_salvar.Enabled = false;
        }

        private void Bt_excluir_Click(object sender, EventArgs e)
        {
            Bt_excluir.Enabled = false;
            Bt_salvar.Enabled = false;
        }
    }
}
