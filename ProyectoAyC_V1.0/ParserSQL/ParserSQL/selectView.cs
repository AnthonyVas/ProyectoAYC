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

namespace ParserSQL
{
    public partial class selectView : Form
    {
        //Conexion c = new Conexion();
        private string sCn;
        private SqlConnection conectar;
        public string user, tipo;
        public string servidor, usuario, clave, db, cadena, tipoConexion, consulta;

        public static string MiServidor;

        public void conec()
        {


            //servidor = ConfigurationManager.AppSettings["servidor"];
            //db = ConfigurationManager.AppSettings["db"];
            //tipoConexion = ConfigurationManager.AppSettings["tipoConexion"];
            //cadena = "server=" + servidor + ";database=" + db + ";" + tipoConexion;

            servidor = "DESKTOP-R3BTB98";
            db = "Conacyt";
            tipoConexion = "Integrated Security = true";
            cadena = "server=" + servidor + ";database=" + db + ";" + tipoConexion;



        }

        public selectView(string cons)
        {
            InitializeComponent();
            //c.conec();
            conec();
            sCn = cadena;
            consulta = cons;
            conectar = new SqlConnection(sCn);
          
        }
        
        private void selectView_Load(object sender, EventArgs e)
        {
            cargar(consulta);
        }
        private void cargar(string consulta)
        {
            SqlCommand cmd = new SqlCommand(consulta, conectar);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSelect.DataSource = dt;
            conectar.Close();
        }
    }
}
