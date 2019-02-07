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



        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string tipo_documento{ get; set; }



        public bool registrarproceso(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO proceso (radicado_proceso,accionante,accionado )  VALUES('" + obj.radicado + "','" + obj.accionante + "','" + obj.accionado + "','" + obj.asesor + "','" + obj.tipo_proceso + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        public DataTable consulartipo_proceso()
        {
            string sql = "SELECT * FROM tipo_proceso ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consulartipo_documento()
        {
            string sql = "SELECT * FROM tipo_documento ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerasesor()
        {
            string sql = "SELECT idusuario, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM usuario where rol_idrol =3 ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarproceso()
        {
            string sql = "select idproceso ,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2)"
                          + "as asesor,tipo_proceso.nombre_tipo as nombre_tipo from proceso"
                          + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso  "
                          + "inner join usuario on proceso.usuario_idusuario = usuario.idusuario;";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool registrarperonsanatural(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO persona (nombre1,nombre2,apellido1,apellido2,documento,direccion,telefono,fk_tipo_documento )  VALUES('" + obj.nombre1 + "','" + obj.nombre2 + "','" + obj.apellido1 + "','" + obj.apellido2+ "','" + obj.documento+ "','"+ obj.direccion + "','" + obj.telefono+ "','" + obj.tipo_documento + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

    }
}