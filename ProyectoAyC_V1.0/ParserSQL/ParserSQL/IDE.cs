using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using TablaSimbolos;
using Errores;
using System.Diagnostics;

namespace ParserSQL
{


    public partial class IDE : Form
    {
        int cantLineas = 0;
        string nomarchivox;
        TS tabla_simbolos = new TS();
       // TE tabla_errorres = new TE();

        public IDE()
        {
            InitializeComponent();
        }

        private void cerrarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void minimizarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorDeConsolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == System.Windows.Forms.DialogResult.OK)
            {
                //PagCodigo.SelectionColor = colorDialog1.Color; <..... esto para una parte del texto
                PagCodigo.BackColor = colorDialog1.Color;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void IDE_Load(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void IDE_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea cerrar ParserSQL ?", "Cerrar Compilador", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Metodos
        //-----------------------------METODOS DE ARCHIVOS -----------------------------------------

        //public void exportaraexcel(DataGridView tabla)
        //{

        //    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

        //    excel.Application.Workbooks.Add(true);

        //    int ColumnIndex = 0;

        //    foreach (DataGridViewColumn col in tabla.Columns)
        //    {

        //        ColumnIndex++;

        //        excel.Cells[1, ColumnIndex] = col.Name;

        //    }

        //    int rowIndex = 0;

        //    foreach (DataGridViewRow row in tabla.Rows)
        //    {

        //        rowIndex++;

        //        ColumnIndex = 0;

        //        foreach (DataGridViewColumn col in tabla.Columns)
        //        {

        //            ColumnIndex++;

        //            excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;

        //        }

        //    }

        //    excel.Visible = true;

        //    Worksheet worksheet = (Worksheet)excel.ActiveSheet;

        //    worksheet.Activate();



        //}

        public void abrirarchivo()
        {

            try
            {
                OpenFileDialog opFiled = new OpenFileDialog();

                opFiled.Title = "ParserSQL#                                                                     Abrir Archivo                                                                       ";
                opFiled.ShowDialog();
                if (File.Exists(opFiled.FileName))
                {
                    using (Stream stream = opFiled.OpenFile())
                    {
                        //MessageBox.Show("archivo encontrado:  "+ofd.FileName);
                        leerarchivo(opFiled.FileName);
                        nomarchivox = opFiled.FileName;

                        txt_direccion.Text = opFiled.FileName;
                        tabControl1.Visible = true;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("El archivo no se abrio correctamente");

               // tabla_errorres.addliste(2);
            }

        }

        public void leerarchivo(string nomarchivo)
        {
            StreamReader reader = new StreamReader(nomarchivo, System.Text.Encoding.Default);
            //string read = reader.ReadLine();
            string texto;
            // while (read != null)
            //{
            texto = reader.ReadToEnd();
            // read = read + "\n";
            reader.Close();
            PagCodigo.Text = texto;
            // read =reader.ReadLine();
            //}
        }

        public bool revisasiarchivoexiste(string nomarchivo)
        {
            bool existe;
            if (File.Exists(nomarchivo))
            {
                // el archivo existe
                existe = true;
            }
            else
            {
                // el archivo no extiste
                existe = false;
            }
            return existe;
        }

        public void guardaArchivo()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Archivos sql|*.sql";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                if (File.Exists(saveFile.FileName))
                {
                    // el archivo existe
                    //------------------- para un log que agrega eventos ..................
                    //StreamWriter writer = File.AppendText(nomarchivo);
                    //writer.WriteLine("\n <</ ---Actualizacion del " + DateTime.Now.ToString() + " />>"); 
                    //writer.Write(PagCodigo.Text); 
                    //writer.Close(); 

                    //------------------ para sobrescribir el texto ...................
                    StreamWriter codigonuevo = File.CreateText(saveFile.FileName);
                    codigonuevo.Write(PagCodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                    nomarchivox = saveFile.FileName;
                    txt_direccion.Text = saveFile.FileName;

                }
                else
                {
                    // el archivo no extiste
                    StreamWriter codigonuevo = File.CreateText(saveFile.FileName);
                    codigonuevo.Write(PagCodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Write("\n \n ");
                    codigonuevo.Close();
                    nomarchivox = saveFile.FileName;
                    txt_direccion.Text = saveFile.FileName;
                }
            }
        }

        public void guardaArchivo2(string nomarchivo)
        {
            try
            {
                if (nomarchivo == null)
                {
                    guardaArchivo();

                }
                else
                {
                    // el archivo nuevo
                    StreamWriter codigonuevo = File.CreateText(nomarchivo);
                    codigonuevo.Write(PagCodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error al guardar");
            }
        }

        public void leer_archivo_al(string nomarchivo)
        {
            //int contador_Ambitoi = 0;
            int contador_Ambitf = 0;
            int ambito = 0;
            try
            {
                StreamReader reader = new StreamReader(nomarchivo);
                string[] Palabras_Separadas;
                string read;
                int numero_de_lineas = 0;
                PagCodigo.Select(0, PagCodigo.SelectionStart);
                while (reader != null)
                {
                    numero_de_lineas = numero_de_lineas + 1;
                    read = reader.ReadLine();
                    if (reader.EndOfStream)
                    {
                        //MessageBox.Show("ultima linea");
                        break;
                    }
                    else
                    {
                        Palabras_Separadas = read.Split(' ');// se guardan las palabras separadas por un espacio en el arreglo "palabras_separadas"
                        foreach (var palabra in Palabras_Separadas)
                        {
                            #region Medicion del ambito

                            //if (palabra == "{")
                            //{
                            //    contador_Ambitoi = contador_Ambitoi + 1;
                            //}
                            if (palabra == ";")
                            {
                                contador_Ambitf = contador_Ambitf + 1;
                            }
                            ambito = contador_Ambitf;
                            #endregion
                            //-----------------------------------------------------------------------


                            if (tabla_simbolos.compararPalabraAL(palabra.ToString()) && palabra != null)// se manda a comparar la palabra con la tabla de simbolos
                            {
                                //                                                    simb  ,val, nunlin           ,tam,ambit,                 id_,           tipo,       descrip
                                //uneSentencias();

                                TabladeSimbolos objnuevo = new TabladeSimbolos(palabra, numero_de_lineas, tabla_simbolos.compararIdALRef(palabra.ToString()), "Palabra Reservada", "Palabra que coincide con la Tabla de simbolos");
                                tabla_simbolos.añadir_obj(objnuevo);

                                PagCodigo.SelectionStart = PagCodigo.Find(palabra);
                                PagCodigo.SelectionColor = Color.DodgerBlue;

                            }
                            else//de no estar en la tabla de simbolos se agrega a un campo nuevo
                            {
                                if (Regex.IsMatch(palabra, @"[a-zA-Z]") && palabra != null)//sentencia que revisa los dos texbox 
                                {
                                    // System.Windows.Forms.MessageBox.Show("esto es una palabra");
                                    TabladeSimbolos objnuevo = new TabladeSimbolos(palabra, numero_de_lineas, tabla_simbolos.contlineas(), "Palabra Nueva", "Palabra que no coincide con la Tabla de simbolos,pero no se considera error");
                                    tabla_simbolos.añadir_obj(objnuevo);
                                }
                                else if (Regex.IsMatch(palabra, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}") && palabra != null)
                                {
                                    //System.Windows.Forms.MessageBox.Show("esto es un numero");
                                    TabladeSimbolos objnuevo = new TabladeSimbolos(palabra, numero_de_lineas, tabla_simbolos.contlineas(), "Numero nuevo", "Numero");
                                    tabla_simbolos.añadir_obj(objnuevo);

                                    PagCodigo.SelectionStart = PagCodigo.Find(palabra);
                                    PagCodigo.SelectionColor = Color.Aquamarine;

                                }
                                else
                                {
                                    // System.Windows.Forms.MessageBox.Show("Error en la expresion \n no cumple con un formato correcto ");
                                }
                            }
                        }//fin del analisis lexico
                    }
                    Palabras_Separadas = null;
                    cantLineas = numero_de_lineas;
                }

                //if (contador_Ambitf != contador_Ambitoi)
                //{
                //    //MessageBox.Show("error de ambito");
                //    tabla_errorres.addliste(8);
                //}

                reader.Close();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("El archivo no se abrio correctamente");

                //tabla_errorres.addliste(2);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }


        }

        //public string[] uneSentencias()
        //{
        //    string sentencia = null;
        //    string[] sentencias = new string[cantLineas];
        //    int bandera = 0;
        //    string tipov = "";

        //    for (int i = 1; i < cantLineas; i++) //une los token de cada linea
        //    {
        //        foreach (var token in tabla_simbolos.llamatabla())
        //        {
        //            if (token.NumLinea == i && token != null)
        //            {
        //                if (bandera == 0)
        //                {
        //                    token.TipoVar = token.Simbolo;
        //                    tipov = token.Simbolo;
        //                }


        //                if (bandera != 0)
        //                {
        //                    sentencia = sentencia + " " + token.simbolo.ToString();
        //                    token.TipoVar = tipov;
        //                }
        //                else
        //                {
        //                    sentencia = sentencia + token.simbolo.ToString();
        //                    bandera = 1;
        //                }

        //            }
        //        }
        //        sentencias[i] = sentencia;
        //        sentencia = null;
        //        bandera = 0;
        //        tipov = "";
        //    }

        //    return sentencias;
        //}
        #endregion

        #region analizador sintactico
        public void AnlzdrSntctc(string[] sentencias)
        {


        }
        #endregion

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardaArchivo();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardaArchivo2(nomarchivox);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            guardaArchivo2(nomarchivox);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            abrirarchivo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirarchivo();
        }

        private void maximizarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizarVentanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void colorDeLaFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == System.Windows.Forms.DialogResult.OK)
            {
                //PagCodigo.SelectionColor = colorDialog1.Color; <..... esto para una parte del texto
                PagCodigo.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            guardaArchivo2(nomarchivox);
            tabla_simbolos.reinicialista();
            //tabla_errorres.reinicialista();
            //tabla_errorres.inicialestaE();
            tabla_simbolos.inicialistaTokEstab();
            leer_archivo_al(nomarchivox);
            //string[] sent = uneSentencias();
            //tabla_simbolos.compararALsemantic();

            if (tabla_simbolos.revisar_duplicados())
            {               
                //tabla_errorres.addliste(11);
            }

            //AnlzdrSntctc(sent);
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = tabla_simbolos.llamatabla();
           // dataGridView2.DataSource = tabla_errorres.llamatablaE(); // Tabla de abajo
           // System.Media.SystemSounds.Asterisk.Play();
        }

        private void PagCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd;
            cmd = new ProcessStartInfo("sqlcmd", "-S LAPTOP-LISBETH -i" + txt_direccion.Text);
            cmd.UseShellExecute = false;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            Process ejecutar = new Process();
            ejecutar.StartInfo = cmd;
            ejecutar.Start();
        }
    }
}
