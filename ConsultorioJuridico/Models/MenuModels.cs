using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace juefi2.Models
{
    public class MenuModel
    {
        private conecMysql conn = new conecMysql();

        public DataTable consultarMenu(string idusuario)
        {
            string sql = @"SELECT  *
                        FROM usuario
                        INNER JOIN rol  ON idusuario= ";
                        sql += idusuario + @"  AND usuario.rol_idrol = rol.idrol
                        INNER JOIN permiso ON permiso.fk_rol = rol.idrol
                        INNER JOIN menu ON menu.idmenu = permiso.menu_idmenu
                        ORDER BY menu.item;";





            return conn.EjecutarConsulta(sql, CommandType.Text);
        }

        public int cosultarPKPersona(int idusuario)
        {
            string sql = "SELECT  usu.idusuario FROM usuario usu where usu.idusuario='" + idusuario + "'; ";
            return Int32.Parse(conn.EjecutarConsulta(sql, CommandType.Text).Rows[0]["idusuario"].ToString());
        }

    }
}