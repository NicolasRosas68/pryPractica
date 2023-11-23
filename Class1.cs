using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace pryPractica
{
    internal class Class1
    {
        string cadena;
        string sql;
        string sql2;
        SQLiteDataAdapter adaptador;
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();

        public DataTable personas(string sql) 
        {
            cadena = "DataSource=personas.db";
            adaptador = new SQLiteDataAdapter(sql,cadena);
            adaptador.Fill(tabla);
            return tabla;
        }

      
    }
}
