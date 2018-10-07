using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class ProcesoModel
    {

        private conecMysql conn = new conecMysql();
        public string radicado { get; set; }

        public string accionante { get; set; }

        public string accionado{ get; set; }
        public string tipo_proceso { get; set; }
        public string asesor { get; set; }

        public bool registrarproceso(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO proceso (radicado_proceso,accionante,accionado,fk_asesor,fk_tipoproceso )  VALUES('" + obj.radicado + "','" + obj.accionante + "','" + obj.accionado + "','" + obj.asesor + "','" + obj.tipo_proceso + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        public DataTable consulartipo_proceso()
        {
            string sql = "SELECT * FROM tipo_proceso ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerasesor()
        {
            string sql = "SELECT id_usuario, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM usuario where fk_tipopersona =3 ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarproceso()
        {
            string sql = "select idproceso,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2)"
                          + " as asesor,tipo_proceso.nombre_tipo from proceso"
                          + " inner join tipo_proceso on fk_tipoproceso= tipo_proceso.idtipo_proceso "
                          + "inner join usuario on fk_asesor = usuario.id_usuario;";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

    }
}