﻿using juefi2.Models.BD;
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
        public string asunto { get; set; }



        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string tipo_documento{ get; set; }
        public string archivo { get; set; }

        public string nit{ get; set; }
        public string empresa { get; set; }
        public string representante { get; set; }

        public string fk_proce { get; set; }
        public string idusua { get; set; }




        public bool registrarproceso(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO proceso (radicado_proceso,accionante,accionado,asunto,fk_tipoproceso,archivos )  VALUES('" + obj.radicado + "','" + obj.accionante + "','" + obj.accionado + "','" + obj.asunto + "','" + obj.tipo_proceso + "','" + obj.archivo + "');";
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
            string sql = "select idproceso ,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2) "
                          + "as asesor,tipo_proceso.nombre_tipo as nombre_tipo,archivos from proceso "
                          + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso  "
                          + "inner join usuario on proceso.usuario_idusuario = usuario.idusuario where proceso.estado = 'abierto';";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarprocesodocente(string id)
        {
            string sql = "select idproceso ,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2) "
                          + "as asesor,tipo_proceso.nombre_tipo as nombre_tipo,archivos from proceso "
                          + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso  "
                          + "inner join usuario on proceso.usuario_proceso = usuario.idusuario where  proceso.usuario_idusuario='" + id+"' and proceso.asignacion='si' and proceso.estado='abierto'";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }


        public DataTable consultarproceestudiante(string id)
        {
            string sql = "select idproceso ,radicado_proceso,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2) "
                          + "as asesor,tipo_proceso.nombre_tipo as nombre_tipo,archivos from proceso "
                          + "inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso  "
                          + "inner join usuario on proceso.usuario_idusuario = usuario.idusuario where  proceso.usuario_proceso='" + id + "' and proceso.asignacion='si' and proceso.estado='abierto'";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool registrarperonsanatural(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO persona (nombre1,nombre2,apellido1,apellido2,documento,direccion,telefono,fk_tipo_documento )  VALUES('" + obj.nombre1 + "','" + obj.nombre2 + "','" + obj.apellido1 + "','" + obj.apellido2+ "','" + obj.documento+ "','"+ obj.direccion + "','" + obj.telefono+ "','" + obj.tipo_documento + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        public bool registrarperonsajuridica(ProcesoModel obj)
        {

            string sqlee = "INSERT INTO persona_juridica (nit,nombre_empresa,fk_persona )  VALUES('" + obj.nit + "','" + obj.empresa + "','"  + obj.representante + "');";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }



        public DataTable traeraccionante()
        {
            string sql = "SELECT  idpersona, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM persona  ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable traeraccionante22(string id)
        {
            string sql = "SELECT  idpersona, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2) as nombre FROM persona where idpersona != '"+id+"' ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarestudiante()
        {
            string sql = "SELECT idusuario, concat(nombre1, ' ',nombre2, ' ',apellido1, ' ', apellido2,'-' ,' Semestre:',semestre) as nombre FROM usuario where rol_idrol =2  ; ";

            return conn.EjecutarConsulta(sql, CommandType.Text);
        }
        



    }
}
