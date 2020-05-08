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
using System.Data.SqlClient;

namespace Leituras
{
    public partial class lançar_leituras : Form
    {
        Thread voltar;
        int entrada,saida,saldo;
        double comis,bruto;

        public lançar_leituras()
        {
            InitializeComponent();
            Tb_ent_atual.MaxLength = 9;
            Tb_sai_atual.MaxLength = 9;
            Tb_saldo_atual.MaxLength = 9;
            Tb_saldobruto.MaxLength = 11;
            Tb_saldocom.MaxLength = 11;
            Tb_saldoliq.MaxLength = 11;
            Tb_ent_ant.Text = "100";     //######### BUSCAR DA BASE ########
            Tb_sai_ant.Text = "100";     //######### BUSCAR DA BASE ########
            Tb_saldo_ant.Text = "100";   //######### BUSCAR DA BASE ########
            Tb_ent_ant.Enabled = false;
            Tb_sai_ant.Enabled = false;
            Tb_saldo_ant.Enabled = false;
            Tb_saldobruto.Enabled = false;
            Tb_saldocom.Enabled = false;
            Tb_saldoliq.Enabled = false;
            Tb_ent_total.Enabled = false;
            Tb_sai_total.Enabled = false;
            Tb_saldo_total.Enabled = false;
        }

        private void volta()
        {
            Application.Run(new Form2());
        }

        private void Bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            voltar = new Thread(volta);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }         
        private void Bt_lançar_Click(object sender, EventArgs e)
        {
            if (Cb_negativo.Checked)    //######## LANÇAR SE NEGATIVO ##########################
            {
                
            }

        }

        private void Cb_negativo_CheckedChanged(object sender, EventArgs e)
        {        
            if(Cb_negativo.Checked && Tb_obs.Text == "")
            {
                Tb_obs.Text = "Negativo R$ " + bruto.ToString("0.00");
            }
            else if (Cb_negativo.Checked == false)
            {
                Tb_obs.Text = "";
            }
        }

             

        private void Tb_ent_atual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Tb_ent_atual.Text != "")
            {
                entrada = Int32.Parse(Tb_ent_atual.Text) - Int32.Parse(Tb_ent_ant.Text);
                Tb_ent_total.Text = entrada.ToString();
                Tb_sai_atual.Focus();
            }
        }
        private void Tb_sai_atual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Tb_sai_atual.Text!="")
            {
                saida = Int32.Parse(Tb_sai_atual.Text) - Int32.Parse(Tb_sai_ant.Text);
                Tb_sai_total.Text = saida.ToString();
                Tb_saldo_atual.Focus();
            }
        }
        private void Tb_saldo_atual_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Tb_saldo_atual.Text != "")
            {
                saldo = Int32.Parse(Tb_saldo_atual.Text) - Int32.Parse(Tb_saldo_ant.Text);
                Tb_saldo_total.Text = saldo.ToString();
                bruto = (entrada - saida) * 0.25; ////VALOR DOS CRÈDITOS ##############
                Tb_saldobruto.Text = bruto.ToString("0.00");
                if (bruto >= 0)
                {
                    Cb_negativo.Enabled = false;
                    comis = bruto * 0.25;        /////COMISSÂO ##########################
                    Tb_saldocom.Text = comis.ToString("0.00");
                    Tb_saldoliq.Text = (bruto - comis).ToString("0.00");
                    Cb_negativo.Checked = false;
                }
                else if(bruto < 0)
                {
                    Cb_negativo.Enabled = true;
                    Tb_obs.Text = "Negativo R$ " + bruto.ToString("0.00");
                    Tb_saldocom.Text = "";
                    Tb_saldoliq.Text = "";
                    Cb_negativo.Checked = true;
                }                
                Bt_lançar.Focus();
            }
            else if (e.KeyCode == Keys.Enter && Tb_saldo_atual.Text == "")
            {
                Tb_saldo_atual.Text = "0";
                bruto = (entrada - saida) * 0.25; ////VALOR DOS CRÈDITOS ##############
                Tb_saldobruto.Text = bruto.ToString("0.00");
                if (bruto >= 0)
                {
                    Cb_negativo.Enabled = false;
                    Cb_negativo.Checked = false;
                    comis = bruto * 0.25;        /////COMISSÂO ##########################
                    Tb_saldocom.Text = comis.ToString("0.00");
                    Tb_saldoliq.Text = (bruto - comis).ToString("0.00");
                }
                if (bruto < 0)
                {
                    Cb_negativo.Enabled = true;
                    Tb_saldocom.Text = "";
                    Tb_saldoliq.Text = "";
                    Tb_obs.Text = "Negativo R$ " + bruto.ToString("0.00");
                    Cb_negativo.Checked = true;                   
                }
                Bt_lançar.Focus();
            }
        }

                   

        
    }
}
