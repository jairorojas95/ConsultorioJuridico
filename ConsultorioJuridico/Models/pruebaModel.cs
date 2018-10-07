using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using juefi2.Models.BD;

namespace juefi2.Models
{
    public class pruebaModel
    {
        private conecMysql conn = new conecMysql();

        public string area { get; set; }
        public string asesor { get; set; }

        public string accionante { get; set; }
        public string entidad { get; set; }
        public string accionado{ get; set; }
        public string clase_proceso { get; set; }
        public string estudiante { get; set; }
        public string radicado { get; set; }
      


        public bool registraPersona(pruebaModel obje)
        {

            string insert = "INSERT INTO hoja_ruta (area,asesor,accionante,entidad,accionado,clase_proceso,estudiante,radicado) VALUES ('" + obje.area+ "','" + obje.asesor + "','" + obje.accionante + "','" + obje.entidad + "','" + obje.accionado+ "','" + obje.clase_proceso + "','" + obje.estudiante + "','" + obje.radicado + "');";
            return conn.EjecutarSql(insert, CommandType.Text);
        }

        public DataTable hoja_ruta()
        {
            string sql = " SELECT *   FROM hoja_ruta ;";
           return conn.EjecutarConsulta(sql, CommandType.Text); 

        }
    }
}