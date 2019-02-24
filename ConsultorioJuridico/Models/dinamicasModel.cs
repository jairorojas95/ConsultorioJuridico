using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using juefi2.Models.BD;

namespace juefi2.Models
{
    public class dinamicasModel
    {
        private conecMysql conn = new conecMysql();

        public string nombre { get; set; }
        public string documento{ get; set; }




        public bool registrartipo_proceso(dinamicasModel obje)
        {

            string insert = "INSERT INTO tipo_proceso (nombre_tipo ) VALUES ('" + obje.nombre+ "');";
            return conn.EjecutarSql(insert, CommandType.Text);
        }

        public DataTable tipo_procesos()
        {
            string sql = " SELECT idtipo_proceso , nombre_tipo from tipo_proceso;";
           return conn.EjecutarConsulta(sql, CommandType.Text); 

        }



        public bool registrartipo_docuemnto(dinamicasModel obje)
        {

            string insert = "INSERT INTO tipo_documento (nombre_ducumento) VALUES ('" + obje.documento + "');";
            return conn.EjecutarSql(insert, CommandType.Text);
        }
        
        public DataTable documento_tipo()
        {
            string sql = " SELECT idtipo_documento , nombre_ducumento from tipo_documento;";
            return conn.EjecutarConsulta(sql, CommandType.Text);

        }
    }
}