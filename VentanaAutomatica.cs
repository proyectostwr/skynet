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
    public partial class VentanaAutomatica : Form
    {
        public VentanaAutomatica()
        {
            InitializeComponent();
        }

        private void VentanaAutomatica_Load(object sender, EventArgs e)
        {
            comboBox2A.Items.Add("C (materiales frios)");
            comboBox2A.Items.Add("F (materiales frágiles)");
            comboBox2A.Items.Add("N (materiales normales)");
        }
    }
}
