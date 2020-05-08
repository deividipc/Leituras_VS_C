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
    public partial class imprimir_leitura : Form
    {
        Thread voltar;
        public imprimir_leitura()
        {
            InitializeComponent();
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
    }
}
