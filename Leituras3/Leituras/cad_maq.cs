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
    public partial class cad_maq : Form
    {
        Thread voltar;
        public cad_maq()
        {
            InitializeComponent();
            Bt_salvar.Enabled = false;
            cb_valor.Items.Add("0,01");
            cb_valor.Items.Add("0,05");
            cb_valor.Items.Add("0,10");
            cb_valor.Items.Add("0,25");
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

        private void Bt_salvar_Click(object sender, EventArgs e)
        {
            Bt_salvar.Enabled = false;
            
        }

        private void Tb_num_TextChanged(object sender, EventArgs e)
        {
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Tb_ponto_TextChanged(object sender, EventArgs e)
        {
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
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
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Tb_jogo_TextChanged(object sender, EventArgs e)
        {
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void Cb_operador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
            {
                Bt_salvar.Enabled = true;
            }
            else
            {
                Bt_salvar.Enabled = false;
            }
        }

        private void cb_valor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Tb_num.Text != "" && Tb_ponto.Text != "" && Tb_endereço.Text != "" && Tb_jogo.Text != "" && cb_valor.Text != "" && Cb_operador.Text != "")
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
