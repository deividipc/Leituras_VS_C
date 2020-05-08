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
    public partial class config : Form
    {
        string strcon = "Data Source=(localdb)\\MSSQLLocalDB;" +
       "Initial Catalog = C:\\Users\\Deividi\\source\\repos\\Leituras4\\dB;" +
       "Integrated Security = True;" +
       "Connect Timeout = 30;" +
       "Encrypt=False;TrustServerCertificate=False;" +
       "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        Thread voltar;
        public config()
        {
            InitializeComponent();
            Tb_senha.Text = "";
            Tb_conf_senha.Text = "";
            Tb_senha.Focus();
            
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
            if (Tb_senha.Text != "" && Tb_conf_senha.Text != "")
            {
                if (Tb_senha.Text == Tb_conf_senha.Text )
                {
                    try
                    {
                        SqlConnection conexao = new SqlConnection(strcon);
                        conexao.Open();
                        SqlCommand add = new SqlCommand("UPDATE config SET senha = @senha", conexao);
                        add.Parameters.Add("@senha",SqlDbType.BigInt).Value = int.Parse(Tb_senha.Text);
                        add.CommandType = CommandType.Text;
                        add.ExecuteNonQuery();                       
                        conexao.Close();
                        MessageBox.Show("Dados atualizados");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao acessar o banco" + erro);
                    }

                }
                else
                {
                   MessageBox.Show("SENHA INCORRETA !!!");
                }
            }
        }

        private void Tb_senha_TextChanged(object sender, EventArgs e)
        {
            if (Tb_senha.TextLength == 4)
            {
                Tb_conf_senha.Focus();
            }
            else
            {
                Tb_senha.Focus();
            }
        }
    }
}
