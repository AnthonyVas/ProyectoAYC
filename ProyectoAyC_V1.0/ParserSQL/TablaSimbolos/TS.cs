using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Errores;

namespace TablaSimbolos
{
    public class TS
    {
        public List<TabladeSimbolos> TSimbolos = new List<TabladeSimbolos>(); //lista en la que se guarda los tokens que ya estan establecidos 
        public List<TabladeSimbolos> TSimbolosIngre = new List<TabladeSimbolos>();  //Lista en la que estan los tokens ingresados en el richtextbox
        TE tablaerroes = new TE();


        public TS()
        {

        }
        public List<TabladeSimbolos> TablaSimbolos
        {
            get { return TSimbolos; }
            set { TSimbolos = value; }
        }

        public List<TabladeSimbolos> TablaSimbolosIngresados
        {
            get { return TSimbolosIngre; }
            set { TSimbolosIngre = value; }
        }


        public void reinicialista()
        {
            TSimbolos.Clear();
            TSimbolosIngre.Clear();
        }

        #region Tabla de Simbolos, 3
        public void inicialistaTokEstab()
        {
            //string simb,string val,int nunlin,int tam,int ambit,int id_,string tip,string descrip
            TabladeSimbolos ts = new TabladeSimbolos("create", -0, 1,"Palabra Reservada", "Palabra reservada, usada como inicio de sentencia para crear base de datos");
            TSimbolos.Add(ts);
            TabladeSimbolos ts1 = new TabladeSimbolos("database", -0, 2, "Palabra Reservada", "Palabra reservada, usada para hacer referencia a una base de datos");
            TSimbolos.Add(ts1);
            TabladeSimbolos ts2 = new TabladeSimbolos(";", -0, 3, "Punto y Coma", "Indica el final de una sentencia");
            TSimbolos.Add(ts2);
            TabladeSimbolos ts3 = new TabladeSimbolos("drop", -0, 4, "Palabra Reservada", "Palabra reservada, usada para eliminar elementos");
            TSimbolos.Add(ts3);
            TabladeSimbolos ts4 = new TabladeSimbolos("table", -0, 5, "Palabra Reservada", "Referencia a una tabla");
            TSimbolos.Add(ts4);
            TabladeSimbolos ts5 = new TabladeSimbolos("(", -0, 6, "Abre Corchetes", "Simbolo");
            TSimbolos.Add(ts5);
            TabladeSimbolos ts6 = new TabladeSimbolos(")", -0, 7, "Cierra Corchetes", "Simbolo");
            TSimbolos.Add(ts6);
            TabladeSimbolos ts7 = new TabladeSimbolos(",", -0, 8, "Coma", "Separador de elementos");
            TSimbolos.Add(ts7);
            TabladeSimbolos ts8 = new TabladeSimbolos("int", -0, 9, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts8);
            TabladeSimbolos ts9 = new TabladeSimbolos("char", -0, 10, "Palabra Reservada", "Palabra Reservada de tipo de dato");
            TSimbolos.Add(ts9);
            TabladeSimbolos ts10 = new TabladeSimbolos("varchar", -0, 11, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts10);
            TabladeSimbolos ts11 = new TabladeSimbolos("datetime", -0, 12, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts11);
            TabladeSimbolos ts12 = new TabladeSimbolos("insert", -0, 13, "Palabra Reservada", "Referencia a insertar datos");
            TSimbolos.Add(ts12);
            TabladeSimbolos ts13 = new TabladeSimbolos("into", -0, 14, "Palabra Reservada", "Referencia a una ubicación");
            TSimbolos.Add(ts13);
            TabladeSimbolos ts14 = new TabladeSimbolos("values", -0, 15, "Palabra Reservada", "Valores a insertar");
            TSimbolos.Add(ts14);
            TabladeSimbolos ts15 = new TabladeSimbolos("'", -0, 16, "Comilla Simple", "Se usa para llamar valores desde un script");
            TSimbolos.Add(ts15);
            TabladeSimbolos ts16 = new TabladeSimbolos("delete", -0, 17, "Palabra Reservada", "Hace referencia a la eliminación de un elemento");
            TSimbolos.Add(ts16);
            TabladeSimbolos ts17 = new TabladeSimbolos("from", -0, 18, "Palabra Reservada", "Referencia a un elemento");
            TSimbolos.Add(ts17);
            TabladeSimbolos ts18 = new TabladeSimbolos("where", -0, 19, "Palabra Reservada", "Condicional");
            TSimbolos.Add(ts18);
            TabladeSimbolos ts19 = new TabladeSimbolos("update", -0, 20, "Palabra Reservada", "Referencia a actualizar");
            TSimbolos.Add(ts19);
            TabladeSimbolos ts20 = new TabladeSimbolos("set", -0, 21, "Palabra Reservada", "Referencia a establecer un nuevo valor");
            TSimbolos.Add(ts20);
            TabladeSimbolos ts21 = new TabladeSimbolos("select", -0, 22, "Palabra Reservada", "Seleccion de elemento");
            TSimbolos.Add(ts21);
            TabladeSimbolos ts22 = new TabladeSimbolos("order", -0, 23, "Palabra Reservada", "Instruccion para ordenar, debe ir seguido por by");
            TSimbolos.Add(ts22);
            TabladeSimbolos ts23 = new TabladeSimbolos("by", -0, 24, "Palabra Reservada", "Instruccion para ordenar, debe estar precedido por order");
            TSimbolos.Add(ts23);
            TabladeSimbolos ts24 = new TabladeSimbolos("asc", -0, 25, "Palabra Reservada", "Orden Ascendente");
            TSimbolos.Add(ts24);
            TabladeSimbolos ts25 = new TabladeSimbolos("desc", -0, 26, "Palabra Reservada", "Orden Descendente");
            TSimbolos.Add(ts25);
            TabladeSimbolos ts26 = new TabladeSimbolos("CREATE", -0, 1, "Palabra Reservada", "Palabra reservada, usada como inicio de sentencia para crear base de datos");
            TSimbolos.Add(ts26);
            TabladeSimbolos ts27 = new TabladeSimbolos("DATABASE", -0, 26, "Palabra Reservada", "Palabra reservada, usada para hacer referencia a una base de datos");
            TSimbolos.Add(ts27);
            TabladeSimbolos ts28 = new TabladeSimbolos("DROP", -0, 27, "Palabra Reservada", "Palabra reservada, usada para eliminar elementos");
            TSimbolos.Add(ts28);
            TabladeSimbolos ts29 = new TabladeSimbolos("TABLE", -0, 28, "Palabra Reservada", "Referencia a una tabla");
            TSimbolos.Add(ts29);
            TabladeSimbolos ts30 = new TabladeSimbolos("INT", -0, 29, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts30);
            TabladeSimbolos ts31 = new TabladeSimbolos("CHAR", -0, 30, "Palabra Reservada", "Palabra Reservada de tipo de dato");
            TSimbolos.Add(ts31);
            TabladeSimbolos ts32 = new TabladeSimbolos("VARCHAR", -0, 31, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts32);
            TabladeSimbolos ts33 = new TabladeSimbolos("DATETIME", -0, 32, "Palabra Reservada", "Palabra reservada de tipo de dato");
            TSimbolos.Add(ts33);
            TabladeSimbolos ts34 = new TabladeSimbolos("INSERT", -0, 33, "Palabra Reservada", "Referencia a insertar datos");
            TSimbolos.Add(ts34);
            TabladeSimbolos ts35 = new TabladeSimbolos("INTO", -0, 34, "Palabra Reservada", "Referencia a una ubicación");
            TSimbolos.Add(ts35);
            TabladeSimbolos ts36 = new TabladeSimbolos("VALUES", -0, 35, "Palabra Reservada", "Valores a insertar");
            TSimbolos.Add(ts36);
            TabladeSimbolos ts37 = new TabladeSimbolos("DELETE", -0, 36, "Palabra Reservada", "Hace referencia a la eliminación de un elemento");
            TSimbolos.Add(ts37);
            TabladeSimbolos ts38 = new TabladeSimbolos("FROM", -0, 37, "Palabra Reservada", "Referencia a un elemento");
            TSimbolos.Add(ts38);
            TabladeSimbolos ts39 = new TabladeSimbolos("WHERE", -0, 38, "Palabra Reservada", "Condicional");
            TSimbolos.Add(ts39);
            TabladeSimbolos ts40 = new TabladeSimbolos("UPDATE", -0, 39, "Palabra Reservada", "Referencia a actualizar");
            TSimbolos.Add(ts40);
            TabladeSimbolos ts41 = new TabladeSimbolos("SET", -0, 40, "Palabra Reservada", "Referencia a establecer un nuevo valor");
            TSimbolos.Add(ts41);
            TabladeSimbolos ts42 = new TabladeSimbolos("SELECT", -0, 41, "Palabra Reservada", "Seleccion de elemento");
            TSimbolos.Add(ts42);
            TabladeSimbolos ts43 = new TabladeSimbolos("ORDER", -0, 42, "Palabra Reservada", "Instruccion para ordenar, debe ir seguido por by");
            TSimbolos.Add(ts43);
            TabladeSimbolos ts44 = new TabladeSimbolos("BY", -0, 43, "Palabra Reservada", "Instruccion para ordenar, debe estar precedido por order");
            TSimbolos.Add(ts44);
            TabladeSimbolos ts45 = new TabladeSimbolos("ASC", -0, 44, "Palabra Reservada", "Orden Ascendente");
            TSimbolos.Add(ts45);
            TabladeSimbolos ts46 = new TabladeSimbolos("DESC", -0, 45, "Palabra Reservada", "Orden Descendente");
            TSimbolos.Add(ts46);
            TabladeSimbolos ts47 = new TabladeSimbolos("+", -0, 46, "Operador Suma", "Operador Sumae");
            TSimbolos.Add(ts47);
            TabladeSimbolos ts48 = new TabladeSimbolos("-", -0, 47, "Operador Resta", "Operador Resta");
            TSimbolos.Add(ts48);
            TabladeSimbolos ts49 = new TabladeSimbolos("=", -0, 48, "Asignación", "Operador Asignación");
            TSimbolos.Add(ts49);
            TabladeSimbolos ts50 = new TabladeSimbolos(">", -0, 49, "Mayor que", "Operador mayor que");
            TSimbolos.Add(ts50);
            TabladeSimbolos ts51 = new TabladeSimbolos("<", -0, 50, "Menor que", "Operador menor que");
            TSimbolos.Add(ts51);
            TabladeSimbolos ts52 = new TabladeSimbolos("and", -0, 51, "Palabra Reservada", "And (y)");
            TSimbolos.Add(ts52);
            TabladeSimbolos ts53 = new TabladeSimbolos("or", -0, 52, "Palabra Reservada", "Or (o)");
            TSimbolos.Add(ts53);
            TabladeSimbolos ts54 = new TabladeSimbolos("AND", -0, 53, "Palabra Reservada", "And (y)");
            TSimbolos.Add(ts54);
            TabladeSimbolos ts55 = new TabladeSimbolos("OR", -0, 54, "Palabra Reservada", "Or (o)");
            TSimbolos.Add(ts55);
        }

        #endregion

        public List<TabladeSimbolos> llamatabla()
        {
            return TSimbolosIngre;
        }

        public void añadir_obj(TabladeSimbolos Ts)
        {
            TSimbolosIngre.Add(Ts);
        }

        public bool compararPalabraAL(string argusplit)
        {
            bool bandera = false;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.lexema == argusplit)
                {
                    bandera = true;
                    break;
                }
                else
                {
                    bandera = false;
                }

            }
            return bandera;
        }
        //----------------------------------------------------------------
        public bool revisar_duplicados()
        {
            bool flag = false;
            //int cont = 0;
            foreach (var sent1 in TSimbolos)
            {
                foreach (var sent2 in TSimbolos)
                {
                    if (sent1.ID == sent2.ID)//&& sent1.TipoVar == sent2.TipoVar
                    {

                        flag = true;
                        //cont += 1;
                    }
                }
            }
            return flag;
        }
        //----------------------------------------------------------------
        //public void compararALsemantic()
        //{

        //    foreach (var palabra in TSimbolos)
        //    {
        //        foreach (var palabra2 in TSimbolos)
        //        {
        //            if (palabra.Simbolo == palabra2.Simbolo)
        //            {
        //                palabra2.TipoVar = palabra.TipoVar;
        //                //break;
        //            }
        //        }
        //    }

        //}

        //----------------------------------------------------------------

        public int compararIdALRef(string argsplit) //Obtiene el id de la palabra reservada
        {
            int id = 0;
            foreach (var palabra in TSimbolos)
            {

                if (palabra.lexema == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }

        //--------------------------------------------------------------
        public int contlineas()// cuenta la cantidad de registros que hay en la lista TSimbolos
        {
            int numid = 0;
            foreach (var nlinea in TSimbolos)
            {
                numid = numid + 1;
            }
            return numid + 1;
        }

    }
}
