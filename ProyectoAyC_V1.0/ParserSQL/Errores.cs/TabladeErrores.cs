using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    public class TabladeErrores
    {
        //tabla errores (numero de linea,error,como solucionarlo)
        public int ID;
        public int num_lineaE;
        public string error;
        public string descrip;
        public string sol_error;


        public TabladeErrores(int id, int nl, string e, string se, string d)
        {
            ID = id;
            num_lineaE = nl;
            error = e;
            sol_error = se;
            descrip = d;

        }
        public TabladeErrores(int id, string e, string se, string d)
        {

            ID = id;
            error = e;
            sol_error = se;
            descrip = d;

        }

        public TabladeErrores()
        {

        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int NumerodeLinea
        {
            get { return num_lineaE; }
            set { num_lineaE = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public string Solucion
        {
            get { return sol_error; }
            set { sol_error = value; }
        }
        public string Descripcion
        {
            get { return descrip; }
            set { descrip = value; }
        }
    }
}
