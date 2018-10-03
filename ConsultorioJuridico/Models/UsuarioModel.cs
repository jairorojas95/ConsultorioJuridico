using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace juefi2.Models
{
    public class UsuarioModel
    {

        private conecMysql conn = new conecMysql();

                
        public string nombre1 { get; set; }

        public string nombre2 { get; set; }



        public string apellido1 { get; set; }

        public string apellido2 { get; set; }

        public string user { get; set; }


        //public int rol { get; set; }


        public string correo_electronico { get; set; }


        public string contrasena { get; set; }


        public string conficontrasena { get; set; }


        public DataTable ConsultarCuenta(UsuarioModel obj)
        {
            string sql = "SELECT id_usuario FROM usuarios where usuario='" + obj.user + "' AND contrasena = Md5('" + obj.contrasena + "');";
            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool registrarusuario(UsuarioModel obj)
        {

            string sqlee = "INSERT INTO usuarios (nombre_1_usuario,nombre_2_usuario,apellido_1_usuario,apellido_2_usuario,usuario,email,contrasena )  VALUES('" + obj.nombre1 + "','" + obj.nombre2 + "','" + obj.apellido1 + "','" + obj.apellido2 + "','" + obj.user + "','" + obj.correo_electronico + "', Md5('" + obj.contrasena + "'));";
            return conn.EjecutarSql(sqlee, CommandType.Text);
        }

        //public string ConsultarNombresUsuario(int idusuario)
        //{

        //    string sql = "SELECT nombre_1_usuario, apellido_1_usuario FROM usuario where(id_usuario='" + idusuario + "');";
        //    DataTable dt = conn.EjecutarConsulta(sql, CommandType.Text);
        //    string nombres = dt.Rows[0]["nombre_1_usuario"].ToString() + ' ' + dt.Rows[0]["apellido_1_usuario"];
        //    return nombres;
        //}
        //public bool Validaremail(string email)
        //{
        //    string sql = "SELECT usu.id_usuario FROM usuario usu where usu.email='" + email + "';";

        //    return conn.EjecutarConsulta(sql, CommandType.Text).Rows.Count > 0;
        //}

        //public bool Validarusuario(string user)
        //{
        //    string sql = "SELECT usu.id_usuario FROM usuario usu where usu.usuario='" + user + "';";

        //    return conn.EjecutarConsulta(sql, CommandType.Text).Rows.Count > 0;
        //}

        //public DataTable validarinfousuario(UsuarioModel obj)
        //{
        //    string sql = "SELECT usu.id_usuario FROM usuario usu where usu.nombre_1_usuario='" + obj.nombre1 + "'usu.nombre_2_usuario='" + obj.nombre2 + "'usu.apellido_1_usuario='" + obj.apellido1 + "'usu.apellido_2_usuario='" + obj.apellido2 + "' AND usu.contrasena = Md5('" + obj.contrasena + "');";
        //    return conn.EjecutarConsulta(sql, CommandType.Text);
        //}








    }


}
