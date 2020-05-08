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
    public partial class cad_op : Form
    {
        Thread voltar;
        public cad_op()
        {
            InitializeComponent();
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

        private void cad_op_Load(object sender, EventArgs e)
        {
            
        }

        private void Tb_nome_TextChanged(object sender, EventArgs e)
        {
            if (Tb_nome.Text!="" && Tb_endereço.Text!="" && Tb_cpf.Text!="" && Tb_rg.Text!="")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Tb_endereço_TextChanged(object sender, EventArgs e)
        {
            if (Tb_nome.Text != "" && Tb_endereço.Text != "" && Tb_cpf.Text != "" && Tb_rg.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Tb_cpf_TextChanged(object sender, EventArgs e)
        {
            if (Tb_nome.Text != "" && Tb_endereço.Text != "" && Tb_cpf.Text != "" && Tb_rg.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Tb_rg_TextChanged(object sender, EventArgs e)
        {
            if (Tb_nome.Text != "" && Tb_endereço.Text != "" && Tb_cpf.Text != "" && Tb_rg.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }
    }
}
