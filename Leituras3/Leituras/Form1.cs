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
    public partial class inicio : Form
    {
        Thread nt;
        int senha;
        string strcon = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog = C:\\Users\\Deividi\\source\\repos\\Leituras4\\dB;" +
            "Integrated Security = True;" +
            "Connect Timeout = 30;" +
            "Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public inicio()
        {
            InitializeComponent();
             try
              {
               SqlConnection conexao = new SqlConnection(strcon);
               conexao.Open();            
               SqlCommand sel = new SqlCommand("SELECT senha FROM Config",conexao);
               SqlDataReader snh;
               snh = sel.ExecuteReader();
               snh.Read();
               senha = snh.GetInt32(0);
               conexao.Close();
                MessageBox.Show("senha " + senha);
              }
            catch
              {
                MessageBox.Show("Erro ao acessar a base de dados");
              }                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bt_entrar_Click(object sender, EventArgs e)
        {
            
            if (Tb_senha.Text == senha.ToString())
            {
                this.Close();
                nt = new Thread(sistema);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("SENHA INCORRETA !!!");
                this.Close();
            }
        }

        private void sistema()
        {
            Application.Run(new Form2());
        }

        private void Tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Tb_senha.Text == senha.ToString())
                {
                    this.Close();
                    nt = new Thread(sistema);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("SENHA INCORRETA !!!");
                    this.Close();
                }
            }
        }

        private void Tb_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
