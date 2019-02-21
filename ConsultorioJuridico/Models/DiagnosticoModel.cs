﻿using juefi2.Models.BD;
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
                         + " where proceso.asignacion = 'si' and proceso.usuario_proceso = '"+ idusuario + "' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }
    }
}