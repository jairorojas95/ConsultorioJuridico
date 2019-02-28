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
        public string archivo{ get; set; }
        public string fecha { get; set; }
        public string fk_proceso { get; set; }

        public string observacion { get; set; }
        public string id { get; set; }

        public bool registrarDiagnostico(DiagnosticoModel obj)
        {

            string sqlee = "INSERT INTO diagnostico (archivo,fk_proceso )  VALUES('" + obj.archivo + "','"  + obj.fk_proceso+ "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }


        public DataTable consultaRD( string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " inner join usuario on proceso.usuario_idusuario = usuario.idusuario "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '"+ idusuario + "' and estado='abierto' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }




        public DataTable consultarDiagnostico(string id)
        {
            string sql = "select diagnostico.iddiagnostico as iddiagnostico, radicado_proceso,accionante,accionado , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) "
                       + " as asesor, tipo_proceso.nombre_tipo as nombre_tipo,diagnostico.fecha as fecha, "
                       + "diagnostico.archivo as archivo "
                       + "from proceso "
                       + " inner join diagnostico on proceso.idproceso = diagnostico.fk_proceso "
                       + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                       + " inner join usuario on proceso.usuario_idusuario = usuario.idusuario "
                       + " WHERE proceso.usuario_proceso = " + id + " and estado='abierto'; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traerestudiante(string id) 
        {
            string sql = " select DISTINCT usuario.idusuario , concat(usuario.nombre1, ' ', usuario.nombre2, ' ', usuario.apellido1, ' ', usuario.apellido2) as nombre "
                             + "   from proceso "
                             + "   inner join usuario on usuario.idusuario = proceso.usuario_proceso"
                             + "   where usuario.rol_idrol = 2  and proceso.usuario_idusuario = '" + id + "' and proceso.asignacion = 'si'";


            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultaprocesodelestudinate(string idusuario)
        {
            string sql = "SELECT idproceso , concat( radicado_proceso,' -','    Proceso: ', tipo_proceso.nombre_tipo ) as nombre FROM proceso "
                         + " inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '" + idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool actualizardiagnostico(DiagnosticoModel obj)
        {

            string sql = "update diagnostico set diagnostico.observacion = '" + obj.observacion + "' where diagnostico.iddiagnostico = '" + obj.id + "'; ";

            return conn.EjecutarSql(sql, CommandType.Text);
        }
    }
}