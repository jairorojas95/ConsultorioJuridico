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
    }
}