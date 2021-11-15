using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Errores
{
     public class TE
    {
        //tabla errores (numero de linea,error,como solucionarlo)
        public List<TabladeErrores> TErrores = new List<TabladeErrores>();
        public List<TabladeErrores> TErroresed = new List<TabladeErrores>();

        public TE()
        {

        }
        public List<TabladeErrores> TablaErrores
        {
            get { return TErrores; }
            set { TErrores = value; }
        }
        public void reinicialista()
        {
            TErrores.Clear();
            TErroresed.Clear();
        }

        public void inicialestaE()
        {

            TabladeErrores te = new TabladeErrores(0, "Sintaxis incorrecta", "Verifique la sintaxis de la instrucción", "Sintaxis diferente a la esperada");
            TErrores.Add(te);
        }

        public List<TabladeErrores> llamatablaE()
        {
            return TErroresed;
        }



        public void addliste(int id, int nl)
        {
            foreach (var error in TErrores)
            {

                if (error.Id == id)
                {
                    TabladeErrores er = new TabladeErrores();
                    er.Descripcion = error.Descripcion;
                    er.Solucion = error.Solucion;
                    er.Error = error.Error;
                    er.NumerodeLinea = nl;
                    TErroresed.Add(er);
                }

            }

        }
        public void addliste(int id)
        {
            foreach (var error in TErrores)
            {

                if (error.Id == id)
                {
                    TabladeErrores er = new TabladeErrores();
                    er.Descripcion = error.Descripcion;
                    er.Solucion = error.Solucion;
                    er.Id = error.Id;
                    TErroresed.Add(er);
                }

            }

        }

    }
}
