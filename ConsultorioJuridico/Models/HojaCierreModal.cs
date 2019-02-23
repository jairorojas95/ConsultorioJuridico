using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class HojaCierreModal
    {
        private conecMysql conn = new conecMysql();

        public string fecha { get; set; }
        public string terminacion { get; set; }
        public string asunto{ get; set; }
        public string fk_proceso { get; set; }

        public string observacion { get; set; }
        public string id { get; set; }

        public DataTable consultaprocesodelestudinate(string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '" + idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool registrarhojacierre(HojaCierreModal obj)
        {

            string sqlee = "INSERT INTO hoja_cierre (fecha_cierre,motivo_terminacion,natulareza_asunto,fk_proceso)  VALUES('" + obj.fecha + "','" + obj.terminacion + "','" + obj.asunto+ "','" + obj.fk_proceso +  "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }


        public DataTable consultarhojacierre(string idusuario)
        {
            string sql = " select idhoja_cierre,proceso.idproceso as idproceso ,proceso.radicado_proceso as radicado, tipo_proceso.nombre_tipo as proceso_tipo,proceso.accionante as accionante,"
                        + " proceso.accionado as accionado,hoja_cierre.fecha_cierre as fecha, hoja_cierre.motivo_terminacion as terminancion ,hoja_cierre.natulareza_asunto as asunto, "
                        + " hoja_cierre.observacion as observacion from hoja_cierre"
                        + " inner join proceso on proceso.idproceso = hoja_cierre.fk_proceso"
                        + " inner join tipo_proceso on tipo_proceso.idtipo_proceso = proceso.fk_tipoproceso "
                        + " where proceso.usuario_proceso = '" + idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerestudiante()
        {
            string sql = "select idusuario , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) as nombre "
                       + "from usuario where usuario.rol_idrol = 2;";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool actualizarhojacierre(HojaCierreModal obj)
        {

            string sql = "update hoja_cierre set hoja_cierre.observacion = '" + obj.observacion + "' where hoja_cierre.idhoja_cierre = '" + obj.id + "'; ";

            return conn.EjecutarSql(sql, CommandType.Text);
        }

        public bool actualizarproceso(HojaCierreModal obj)
        {

            string sql = "update proceso set estado = 'cerrado' where idproceso = '" + obj.id + "'; ";

            return conn.EjecutarSql(sql, CommandType.Text);
        }
    }
}