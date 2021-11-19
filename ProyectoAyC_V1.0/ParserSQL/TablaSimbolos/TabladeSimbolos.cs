using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaSimbolos
{
    public class TabladeSimbolos
    {
        public string lexema;
        
        public int NumLinea;
        
        public int id;
       
        public string token;
        public string descripcion;

        public TabladeSimbolos(string lexem, int nunlin, int id_, string tok, string descrip)
        {

            lexema = lexem;           
            NumLinea = nunlin;
            id = id_;
            token = tok;
            descripcion = descrip;
           

        }

        public TabladeSimbolos()
        {

        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Lexema
        {
            get { return lexema; }
            set { lexema = value; }
        }
       


        public int Numero_de_linea
        {
            get { return NumLinea; }
            set { NumLinea = value; }
        }
       

        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
