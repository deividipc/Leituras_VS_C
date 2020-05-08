using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Leituras
{
    public partial class Form2 : Form
    {
        private Thread cadmaq,vzmaq,lanç_leit,imp_leit,vz_leit,cad_ope,viz_ope,configu;
        public string hora;
        public Form2()
        {
            InitializeComponent();
            Bt_cadmaq.Focus();
            this.backgroundWorker1.RunWorkerAsync(2000);
            
            int dia = DateTime.Now.Day;      //  pega dia como inteiro  
            int mes = DateTime.Now.Month;        //  pega mes como inteiro     
            string ano = DateTime.Now.Year.ToString();   //  pega ano como String 
            
            Lb_dia.Text = dia + "/" + mes + "/" + ano;
            
        }
       


        private void Bt_cadmaq_Click(object sender, EventArgs e)
        {
            this.Close();
            cadmaq = new Thread(cad_maqx);
            cadmaq.SetApartmentState(ApartmentState.STA);
            cadmaq.Start();
        }
        private void cad_maqx()
        {
            Application.Run(new cad_maq());
        }

        private void Bt_viz_maq_Click(object sender, EventArgs e)
        {
            this.Close();
            vzmaq = new Thread(viz_maqx);
            vzmaq.SetApartmentState(ApartmentState.STA);
            vzmaq.Start();
        }
        private void viz_maqx()
        {
            Application.Run(new viz_maq());
        }       

        private void Bt_lanç_Click(object sender, EventArgs e)
        {
            this.Close();
            lanç_leit = new Thread(lanç_leitx);
            lanç_leit.SetApartmentState(ApartmentState.STA);
            lanç_leit.Start();
        }
        private void lanç_leitx()
        {
            Application.Run(new lançar_leituras());

        }
                
        private void Bt_imp_Click(object sender, EventArgs e)
        {
            this.Close();
            imp_leit = new Thread(imp_leitx);
            imp_leit.SetApartmentState(ApartmentState.STA);
            imp_leit.Start();
        }
        private void imp_leitx()
        {
            Application.Run(new imprimir_leitura());
        }

        private void Bt_viz_leituras_Click(object sender, EventArgs e)
        {
            this.Close();
            vz_leit = new Thread(vz_leitx);
            vz_leit.SetApartmentState(ApartmentState.STA);
            vz_leit.Start();
        }
        private void vz_leitx()
        {
            Application.Run(new vizual_leituras());
        }

      
        private void Bt_cadop_Click(object sender, EventArgs e)
        {
            this.Close();
            cad_ope = new Thread(cad_opex);
            cad_ope.SetApartmentState(ApartmentState.STA);
            cad_ope.Start();
        }

       

        private void lb_hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //hora = DateTime.Now.ToLongTimeString();
            lb_hora.Text = hora;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lb_hora.Text = hora;
        }

        private void cad_opex()
        {
            Application.Run(new cad_op());
        }

        private void Bt_viz_op_Click(object sender, EventArgs e)
        {
            this.Close();
            viz_ope = new Thread(viz_opex);
            viz_ope.SetApartmentState(ApartmentState.STA);
            viz_ope.Start();
        }
        private void viz_opex()
        {
            Application.Run(new viz_op());
        }

        private void Bt_config_Click(object sender, EventArgs e)
        {
            this.Close();
            configu = new Thread(configx);
            configu.SetApartmentState(ApartmentState.STA);
            configu.Start();
        }
        private void configx()
        {
            Application.Run(new config());

        }

        private void Bt_fechar_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            Environment.Exit(0);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            while (true)
            {
                hora = DateTime.Now.ToLongTimeString();
                backgroundWorker1.ReportProgress(1);
                Thread.Sleep(1000);
            }
        }
    }
}
