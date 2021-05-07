using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE
{
    public partial class EscogerConfiguracion : Form
    {
        public EscogerConfiguracion()
        {
            InitializeComponent();
        }

        private void IrAManual_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            VentanaManual VN = new VentanaManual();
            VN.Show();
            this.Close();
        }

        private void IrAautomatico_Click(object sender, EventArgs e)
        {
            VentanaAutomatica VA = new VentanaAutomatica();
            VA.Show();
            this.Close();
        }
    }
}
