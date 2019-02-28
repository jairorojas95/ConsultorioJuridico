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
        public string observacion { get; set; }
        public string id { get; set; }


        public bool registrarhojaruta(hojarutaModel obj)
        {

            string sqlee = "INSERT INTO hoja_ruta (folio,actuacion,proceso_idproceso)  VALUES('" + obj.folio + "','" + obj.actuacion + "','" + obj.fk_proceso + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        public DataTable consultaprocesodelestudinate(string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '" + idusuario + "'  and estado='abierto' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarproceso(string id)
        {
            string sql = "select idproceso ,radicado_proceso,accionante,accionado , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) "
                       + " as asesor,tipo_proceso.nombre_tipo as nombre_tipo,hoja_ruta.idhoja_ruta as idhoja, hoja_ruta.folio as folio,hoja_ruta.actuacion as actuacion, hoja_ruta.observaciones as observacion"
                       + " from proceso "
                       + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                       + " inner join usuario on proceso.usuario_idusuario = usuario.idusuario "
                       + " inner join hoja_ruta on proceso.idproceso = hoja_ruta.proceso_idproceso where  idproceso = "+ id + " and estado='abierto'; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerestudiante(string idsesor )
        {
            string sql =   " select DISTINCT usuario.idusuario , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) as nombre "
                         + "   from proceso "
                         + "   inner join usuario on usuario.idusuario = proceso.usuario_proceso"
                         + "   where usuario.rol_idrol = 2  and proceso.usuario_idusuario = '"+ idsesor + "' and proceso.asignacion = 'si' ;"; 

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool actualizarhojaruta(hojarutaModel obj)
        {

            string sql = "update hoja_ruta set hoja_ruta.observaciones = '" + obj.observacion + "' where hoja_ruta.idhoja_ruta = '" + obj.id + "';";

            return conn.EjecutarSql(sql, CommandType.Text);
        }

    }
}