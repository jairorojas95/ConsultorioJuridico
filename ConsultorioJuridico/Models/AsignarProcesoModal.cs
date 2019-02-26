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
            string sql = " SELECT idusuario, concat(nombre1, ' ', nombre2, ' ', apellido1, ' ', apellido2) as nombre , usuario.semestre as Semestre, "
                        + " COUNT(proceso.usuario_proceso) as cantidad "
                        + " FROM usuario "
                        + " left JOIN  proceso ON  proceso.usuario_proceso = usuario.idusuario "
                        + " where usuario.rol_idrol = '2' "
                        + " GROUP BY usuario.idusuario; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerproceso()
        {
            string sql = "SELECT idproceso, concat  (radicado_proceso,'   --   ',tipo_proceso.nombre_tipo) as nombre from proceso "
                         + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where asignacion = 'no'; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool actualizarproceso(AsignarProcesoModal obj)
        {
            string sql = "update proceso set proceso.asignacion ='si', proceso.usuario_proceso= '" + obj.idusua + "' where proceso.idproceso ='" + obj.fk_proce + "'; ";

            return conn.EjecutarSql(sql, CommandType.Text);
        }




    }
}