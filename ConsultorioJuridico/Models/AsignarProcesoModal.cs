using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class AsignarProcesoModal
    {
        private conecMysql conn = new conecMysql();


        public DataTable consultarusuario()
        {
            string sql = "SELECT semestre, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM usuario where rol_idrol =2  ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }






    }
}