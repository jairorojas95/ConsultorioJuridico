using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class hojarutaModel
    {
        private conecMysql conn = new conecMysql();

        public string folio { get; set; }
        public string actuacion { get; set; }
        public string fk_proceso { get; set; }


        public bool registrarhojaruta(hojarutaModel obj)
        {

            string sqlee = "INSERT INTO hoja_ruta (folio,actuacion,proceso_idproceso)  VALUES('" + obj.folio + "','" + obj.actuacion + "','" + obj.fk_proceso + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        public DataTable consultaproceso(string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '" + idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }
    }
}