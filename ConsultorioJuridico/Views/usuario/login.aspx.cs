using juefi2.Controllers;
using juefi2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views.usuario
{
    public partial class login : System.Web.UI.Page
    {
        UsuarioController userc = new UsuarioController();
        UsuarioModel us = new UsuarioModel();
        DataRow dato;
        DataTable aux;
        private int script;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(usuario.Text) && !String.IsNullOrEmpty(contrasena.Text))
            {
                us.user = usuario.Text;
                us.contrasena = contrasena.Text;
                aux = us.ConsultarCuenta(us);

                if (aux.Rows.Count > 0)
                {
                    dato = aux.Rows[0];
                    Session["id_usuario"] = dato["id_usuario"].ToString();
                    Session["Id_Session"] = Session.SessionID.ToString();



                    Response.Redirect("../principal.aspx");
                }
                else
                {
                    Response.Write("<script> alert('VERIFIQUE USUARIO O CONTRASEÑA'); </script>");
                }
            }
            else
            {
                Response.Write("<script> alert('CAMPOS NO PUEDEN SER VACIOS'); </script>");
            }

            Response.Write("<script> alert('CONEXION A LA BASE DE DATOS EXITOSA'); </script>");

        }
                catch (Exception) { Response.Write("<script> alert('REVISE LA CONEXION A LA BASE DE DATOS'); </script>"); }
}
        }
    
}
    
