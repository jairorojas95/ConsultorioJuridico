using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class DiagnosticoModel
    {

        private conecMysql conn = new conecMysql();
        public string idusuario { get; set; }


        public DataTable consultaRD( string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo, ' -','    Asesor:   ', usuario.nombre1,'   ',usuario.apellido1 ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " inner join usuario on proceso.usuario_idusuario = usuario.idusuario "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '"+ idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }
    }
}