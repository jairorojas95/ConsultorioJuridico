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

        public DataTable consultaprocesodelestudinate(string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '" + idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarproceso(string id)
        {
            string sql = "select idproceso ,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) "
                       + " as asesor,tipo_proceso.nombre_tipo as nombre_tipo, hoja_ruta.folio as folio,hoja_ruta.actuacion as actuacion "
                       + " from proceso "
                       + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                       + " inner join usuario on proceso.usuario_idusuario = usuario.idusuario "
                       + " inner join hoja_ruta on proceso.idproceso = hoja_ruta.proceso_idproceso where  idproceso = "+ id +"; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerestudiante()
        {
            string sql = "select idusuario , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) as nombre "
                       + "from usuario where usuario.rol_idrol = 2;";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }
    }
}