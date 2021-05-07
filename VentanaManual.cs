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
    public partial class VentanaManual : Form
    {
        public VentanaManual()
        {
            InitializeComponent();
        }

        private void VentanaManual_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("R++");
            comboBox1.Items.Add("R+-");
            comboBox1.Items.Add("R--");
            comboBox2.Items.Add("C");
            comboBox2.Items.Add("F");
            comboBox2.Items.Add("N");
        }

        private void BTNIniciarManual_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            if (comboBox1.SelectedIndex >= 0 && numericUpDown2.Value > 0 && numericUpDown3.Value > 0)
            {
                form.CargarEstructuraFilasColumnas();
                //form.ReestructuraFilasColumnas(comboBox1.SelectedItem.ToString(), Convert.ToInt16(numericUpDown2.Value), Convert.ToInt16(numericUpDown3.Value));
                form.ReestructuraFilasColumnas("R++", 2, 1);
                form.ConfigurarDiseñoEstructura();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Configuracion invalida, Verifique que se encuentre seleccionado el robot y la ubicación de estanteria");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
