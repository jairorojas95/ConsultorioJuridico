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
        public string idusua { get; set; }
        public string fk_proce { get; set; }

        public DataTable consultarusuario()
        {
            string sql = "SELECT semestre, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM usuario where rol_idrol =2  ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerproceso()
        {
            string sql = "SELECT idproceso, concat  (radicado_proceso,'   --   ',tipo_proceso.nombre_tipo) as nombre from proceso "
                         + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where asignacion = 'no'; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable actualizarproceso()
        {
            string sql = "";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool actualizrusuario(AsignarProcesoModal obj )
        {
            string sql = "update usuario set usuario.fk_proceso ='"+ obj.fk_proce + "'  where usuario.idusuario ='" + obj.idusua +"'; ";

            return conn.EjecutarSql(sql, CommandType.Text);
        }



    }
}