using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Seagregar nuevas librerias para poder ejecutar funciones y objetos en el código.
using System.IO; //Esta permitira implematar que el archivo "csv".
using System.Reflection;

namespace PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE
{
    public partial class Form1 : Form
    {
        //Variables_globales
        string[,] configuracion;
        int[,] capacidad;
        int filas = 0;
        int columnas = 0;
        //string estanteria = "";
        int cont_rs = 1, cont_rh = 1, cont_rn = 1;
        bool pasillo = true;
        bool estado_accion = false;
        DataTable datos_componente = new DataTable();
        DataTable datos_componente_nuevo = new DataTable();

        #region pendiente
        //string[,] movimiento;
        //int filas_movimiento = 0;
        /*public void LlenarMatrizMovimiento()
        {
            movimiento = new string[filas_movimiento, 5];
            int fil = 0;
            int col = 0;

            for (int n = 0; n < movimiento.GetLength(0); n += 0)
            {

                if (configuracion[fil, col] == "C" || configuracion[fil, col] == "N" || configuracion[fil, col] == "F")
                {

                    movimiento[n, 0] = fil.ToString();
                    movimiento[n, 1] = col.ToString();
                    movimiento[n, 2] = capacidad[fil, col].ToString();
                    movimiento[n, 3] = configuracion[fil, col];
                    movimiento[n, 4] = "0";
                    n++;

                }
                col++;
                if (col == columnas)
                {
                    fil++;
                    col = 0;
                }
                if (fil == filas)
                {
                    break;
                }


            }
        }
        */

        /*private void LlenarMatrizA()
        {
            MatrizBodega.Width = 100 * columnas + 100;
            MatrizBodega.Height = 100 * filas + 100;
            for (int y = 0; y < columnas; y++)
            {
                DataGridViewColumn columnas_grid = new DataGridViewImageColumn();
                MatrizBodega.Columns.Add(columnas_grid);
            }
            MatrizBodega.Rows.Add(filas);

            for (int y = 0; y < filas; y++)
            {
                MatrizBodega.Rows[y].HeaderCell.Value = y.ToString();

                for (int x = 0; x < columnas; x++)
                {
                    MatrizBodega.Rows[y].Cells[x].Value = CargarImagen(configuracion[y, x]);
                    MatrizBodega.Rows[y].Height = 80;
                    MatrizBodega.Columns[x].Width = 80;
                }
            }
        
        }
        */

        /* private Image CargarImagen(string tipo)
{
 if (tipo.ToUpper() == "F")
 {
     return ListaImagenesMatriz.Images[0];


 }
 else if (tipo.ToUpper() == "C")
 {
     return ListaImagenesMatriz.Images[1];

 }
 else if (tipo.ToUpper() == "O")
 {
     return ListaImagenesMatriz.Images[7];
 }
 else if (tipo.ToUpper() == "N")
 {
     return ListaImagenesMatriz.Images[2];

 }
 else if (tipo.ToUpper() == "P")
 {
     return ListaImagenesMatriz.Images[6];


 }
 else if (tipo.ToUpper() == "R++")
 {
     return ListaImagenesMatriz.Images[3];


 }
 else if (tipo.ToUpper() == "R+-")
 {
     return ListaImagenesMatriz.Images[4];


 }
 else if (tipo.ToUpper() == "R--")
 {
     return ListaImagenesMatriz.Images[5];


 }
 else
 {
     MessageBox.Show("ERROR INGRESO UN ROBOT INVALIDO");
     Application.Exit();
     return null;
 }

}
*/

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        public string LeerArchivo()
        {
            filas = 0;
            columnas = 0;
            try
            {
                //Abre un navegador para buscar el archivo
                // MessageBox.Show("Busque el archivo donde encuetra su configuración");
                string FileToRead = "";
                //openFileDialog1.ShowDialog();
                FileToRead = "C:\\ProyectoC.csv";
                //lee y decompone el archivo en lineas
                string conf = "";
                using (StreamReader ReaderObject = new StreamReader(FileToRead))
                {
                    string Line;
                    int contador = 0;
                    //lee cada linea del archivo 
                    while ((Line = ReaderObject.ReadLine()) != null)
                    {

                        //un contador para poder obtener el numero de filas al momento de leer la primera linea, esto lo hace al contar los espacios en blanco 
                        if (contador == 0)
                        {
                            //agrega un espacio en blanco(se pegan las linea si no se coloca el espacio en blanco)y la linea leida del archivo
                            conf += Line + ",";
                            //por cada linea leida suma una columna
                            filas++;
                            for (int l = 0; l < conf.Length; l++)
                            {
                                if (conf[l].ToString() == "," || conf[l].ToString() == "")
                                {
                                    columnas++;
                                }
                            }
                            contador++;

                        }
                        //por cada linea leida suma una columna
                        else
                        {
                            conf += Line + ",";
                            filas++;

                        }
                    }
                    //verifica que no exeda de los limites y tenga el minimo de de filas y columnas 
                    if (filas > 10 || columnas > 10 || filas == 0 || columnas == 0)
                    {
                        MessageBox.Show("Configuracion invalida, Verifique que tenga 1 columnas y 1 filas como minimo o 10 columnas y 10 filas como maximo en la configuracion");
                    }

                }
                //con esto validamos que se leyó el archivo
                if (conf != "")
                {
                    configuracion = new string[filas, columnas];
                    capacidad = new int[filas, columnas];
                    estado_accion = true;
                }
                return conf;
            }
            catch (Exception ex)
            {
                estado_accion = false;
                return "";
            }
        }

        public void CargarEstructuraFilasColumnas()
        {
            try
            {
                //decompne la cadena de caracteres para llenar la matriz
                //filas = 0;
                //columnas = 0;
                //filas_movimiento = 0;
                //bool estado = false;
                string cadena_guardar = "";
                int posicion_matrizx = 0;
                int posicion_matrizy = 0;
                string cadena_conf = LeerArchivo().ToString();
                //if (estado)
                //{
                for (int i = 0; i < cadena_conf.Length; i++)
                {
                    if (cadena_conf[i].ToString() == ",")
                    {
                        cadena_guardar = "";
                        posicion_matrizx++;
                    }
                    else
                    {
                        cadena_guardar += cadena_conf[i].ToString();
                    }
                    //guarda el caracter en la matriz
                    if (cadena_guardar != "," && cadena_guardar != "")
                    {
                        if (cadena_guardar.ToUpper().Contains("O") || cadena_guardar.ToUpper().Contains("C") || cadena_guardar.ToUpper().Contains("N") || cadena_guardar.ToUpper().Contains("F") || cadena_guardar.ToUpper().Contains("P"))
                        {
                            configuracion[posicion_matrizy, posicion_matrizx] = cadena_guardar.Substring(0, 1);
                        }
                        if (cadena_guardar == "R++" || cadena_guardar == "R+-" || cadena_guardar == "R--")
                        {
                            configuracion[posicion_matrizy, posicion_matrizx] = cadena_guardar.Substring(0, 3);
                        }
                    }
                    //detiene el conteo de columnas al terminar una fila 
                    if (posicion_matrizx == columnas)
                    {
                        posicion_matrizy++;
                        posicion_matrizx = 0;
                    }
                    //rompe el bucle si llega al limite de filas 
                    if (posicion_matrizy == filas)
                    {
                        //LlenarMatrizMovimiento();
                        break;
                    }
                }
                //descompone la matriz para colorear los picturebox
                //}
                //else
                //{
                //    MessageBox.Show("El archivo que contiene la configuracion no se encuentra", "GESTOR BODEGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    Application.Exit();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void buscarColumnasTipoMaterial(string tipo_material, string robot)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tipo_material == configuracion[i, j])
                    {
                        ReestructuraFilasColumnas(robot, i, j);
                    }
                }
            }
        }

        public void ReestructuraFilasColumnas(string robot, int filaNueva, int columnaNueva)
        {
            if (filaNueva == 0 || columnaNueva == 0)
            {
                configuracion[filaNueva, columnaNueva] = robot;
            }
            else
            {
                configuracion[filaNueva - 1, columnaNueva - 1] = robot;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (robot == configuracion[i, j])
                    {
                        if (filaNueva - 1 == i && columnaNueva - 1 == j)
                        {
                            configuracion[i, j] = robot;
                        }
                        else
                        {
                            configuracion[i, j] = "P";
                        }
                    }
                }
            }
        }

        public void ConfigurarDiseñoEstructura()
        {
            PictureBox imagenBase = new PictureBox();
            string nombre_picture = "";
            string[] dato_configuracion_anterior = new string[3];
            datos_componente.Rows.Clear();
            for (int y = 0; y < filas; y++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    string dato_configuracion = configuracion[y, x].ToString();
                    nombre_picture = "PB_" + y.ToString() + "_" + x.ToString();
                    imagenBase = this.Controls.Find(nombre_picture, true).FirstOrDefault() as PictureBox;
                    imagenBase.Enabled = pasillo;
                    imagenBase.Visible = true;
                    imagenBase.BackColor = Codigo_Color("P");
                    int posx = imagenBase.Location.X;
                    int posy = imagenBase.Location.Y;
                    if (dato_configuracion == "R++" || dato_configuracion == "R+-" || dato_configuracion == "R--")
                    {
                        datos_componente.Rows.Add(dato_configuracion, x, y, posx, posy);
                    }
                    else
                    {
                        // utliza reflexion para poder convertir un string a picturebox ya que tienen un nombre que tiene la raiz en común
                        imagenBase.BackColor = Codigo_Color(dato_configuracion);
                    }
                }
            }
            Cargar_imagen_Tipo_Robot();
            //MessageBox.Show("Configuracion cargada exitosamente", "GESTOR BODEGA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //funcion que retorna colores de pende el tipo de cuadro
        private Color Codigo_Color(string Estanteria)
        {
            switch (Estanteria)
            {
                case "C":
                    return Color.SkyBlue;
                case "F":
                    return Color.Coral;
                case "N":
                    return Color.Yellow;
                case "O":
                    return Color.White;
                case "P":
                    return Color.Gray;
                default:
                    return Color.Transparent;
            }
        }

        //funcion que da nombre a los picturbox que contienen a los robots
        private void Tipo_Robot(string tipo_robot)
        {
            if (tipo_robot == "R++")
            {
                tipo_robot = "R++" + "_" + cont_rs.ToString();
                cont_rs++;
            }
            else if (tipo_robot == "R+-")
            {
                tipo_robot = "R+-" + "_" + cont_rh.ToString();
                cont_rh++;
            }
            else if (tipo_robot == "R--")
            {
                tipo_robot = "R--" + "+" + cont_rn.ToString();
                cont_rn++;
            }
            else
            {
                MessageBox.Show("ERROR INGRESO UN ROBOT INVALIDO");
                Application.Exit();
            }

        }

        // crea las configuraciones que tendran los picturebox de los robots
        PictureBox pic_tipo_robot;
        public void Cargar_imagen_Tipo_Robot()
        {
            bool agregar_datos = true;
            int x = 0;
            int y = 0;
            datos_componente_nuevo.Rows.Clear();
            foreach (Control cComponente in this.Controls)
            {
                if (cComponente is PictureBox)
                {
                    switch (cComponente.Name)
                    {
                        case "R++":
                        case "R+-":
                        case "R--":
                            cComponente.Visible = false;
                            break;
                    }
                }
            }
            foreach (DataRow fila in datos_componente.Rows)
            {
                foreach (DataRow fila2 in datos_componente.Rows)
                {
                    if (fila["nombre_robot"].ToString() == fila2["nombre_robot"].ToString())
                    {
                        if (Convert.ToInt16(fila["x"]) + Convert.ToInt16(fila["y"]) == Convert.ToInt16(fila2["x"]) + Convert.ToInt16(fila2["y"]))
                        {
                            foreach (DataRow fila3 in datos_componente_nuevo.Rows)
                            {
                                if (fila["nombre_robot"].ToString() == fila3["nombre_robot"].ToString())
                                {
                                    agregar_datos = false;
                                }
                            }
                            if (agregar_datos)
                            {
                                datos_componente_nuevo.Rows.Add(fila["nombre_robot"], fila["x"], fila["y"], fila["posx"], fila["posy"]);
                            }
                            break;
                        }
                    }

                }
                agregar_datos = true;
            }

            foreach (DataRow fila in datos_componente_nuevo.Rows)
            {
                //Timer timer = new Timer(1000);
                pic_tipo_robot = new PictureBox();
                pic_tipo_robot.Name = fila["nombre_robot"].ToString();
                pic_tipo_robot.Location = new Point(Convert.ToInt16(fila["posx"]) + 5, Convert.ToInt16(fila["posy"]) + 6);
                pic_tipo_robot.Width = 73;
                pic_tipo_robot.Height = 73;
                pic_tipo_robot.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_tipo_robot.Visible = true;
                pic_tipo_robot.Enabled = false;
                switch (fila["nombre_robot"])
                {
                    case "R++":
                        Robot1.Visible = false;
                        pic_tipo_robot.Image = Properties.Resources.robot_1;
                        break;
                    case "R+-":
                        Robot2.Visible = false;
                        pic_tipo_robot.Image = Properties.Resources.robot_3;
                        break;
                    case "R--":
                        Robot3.Visible = false;
                        pic_tipo_robot.Image = Properties.Resources.robot_4;
                        break;
                    default:
                        MessageBox.Show("ERROR INGRESO UN ROBOT INVALIDO");
                        break;
                }
                this.Controls.Add(pic_tipo_robot);
                pic_tipo_robot.BringToFront();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                datos_componente.Columns.Add("nombre_robot");
                datos_componente.Columns.Add("x");
                datos_componente.Columns.Add("y");
                datos_componente.Columns.Add("posx");
                datos_componente.Columns.Add("posy");
                datos_componente_nuevo.Columns.Add("nombre_robot");
                datos_componente_nuevo.Columns.Add("x");
                datos_componente_nuevo.Columns.Add("y");
                datos_componente_nuevo.Columns.Add("posx");
                datos_componente_nuevo.Columns.Add("posy");
            }
            catch (Exception)
            {
            }
            comboBox1.Items.Add("R++");
            comboBox1.Items.Add("R+-");
            comboBox1.Items.Add("R--");
            comboBox2.Items.Add("C");
            comboBox2.Items.Add("F");
            comboBox2.Items.Add("N");
            comboBox3.Items.Add("Envío automático");
            comboBox3.Items.Add("Envío manual");
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarEstructuraFilasColumnas();
            ConfigurarDiseñoEstructura();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox1.SelectedIndex = 0;
            if (comboBox3.SelectedIndex == 0)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown2.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(numericUpDown1.Value) >= 1 && Convert.ToInt16(numericUpDown1.Value) <= 3)
            {
                comboBox1.SelectedItem = "R++";
            }
            if (Convert.ToInt16(numericUpDown1.Value) >= 6 && Convert.ToInt16(numericUpDown1.Value) <= 7)
            {
                comboBox1.SelectedItem = "R+-";
            }
            if (Convert.ToInt16(numericUpDown1.Value) >= 4 && Convert.ToInt16(numericUpDown1.Value) <= 5)
            {
                comboBox1.SelectedItem = "R--";
            }
        }

        private void BTNIniciar_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        if (comboBox2.SelectedIndex != -1)
                        {
                            CargarEstructuraFilasColumnas();
                            buscarColumnasTipoMaterial(comboBox2.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
                            ConfigurarDiseñoEstructura();
                        }
                        else
                        {
                            MessageBox.Show("Configuracion invalida, seleccione un tipo de material");
                        }
                        break;
                    case 1:

                        if (comboBox1.SelectedIndex >= 0 && numericUpDown2.Value > 0 && numericUpDown3.Value > 0)
                        {
                            CargarEstructuraFilasColumnas();
                            ReestructuraFilasColumnas(comboBox1.Text, Convert.ToInt16(numericUpDown2.Value), Convert.ToInt16(numericUpDown3.Value));
                            ConfigurarDiseñoEstructura();
                        }
                        else
                        {
                            MessageBox.Show("Configuracion invalida, Verifique que se encuentre seleccionado el robot y la ubicación de estanteria");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Configuracion invalida, Verifique que se encuentre seleccionado el envío de robot");

            }


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

    }

}
