using juefi2.Controllers;
using juefi2.Models;
using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views
{
    public partial class CrearPersona : System.Web.UI.Page
    {
        UsuarioController p = new UsuarioController();
        UsuarioModel us = new UsuarioModel();
        conecMysql conne = new conecMysql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                   
                    DropRol.DataValueField = "idrol";
                    DropRol.DataTextField = "tipo_rol";
                    DropRol.DataSource = p.consultarrol();
                    DropRol.DataBind();

                                  
                }
                catch (Exception ex)
                {
                }

            }


        }

        protected bool validarNombre(string h, bool requerido)
        {
            h = h.ToUpper();
            if (requerido)
            {
                if (h.Length < 3) return false;
            }
            else
            {
                if (h.Length > 0 && h.Length < 3) return false;
            }
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] < 'A' || h[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        public bool validarCorreo(string valor)
        {
            valor = valor.Trim();
            var n = valor.IndexOf("@");

            return (!(valor.Contains(" ") || n == -1 || n != valor.LastIndexOf("@")
                || valor.Length - n < 3 || n == 0 || valor[n + 1] == '.'));
        }


        public bool validarUsuarioPassword(String user, String pass)
        {
            Regex reg = new Regex("[^A-Z ^a-z ^0-9 ^.]");
            return (!reg.IsMatch(user) && !reg.IsMatch(pass));
        }

        protected void guardar(object sender, EventArgs e)
        {

            us.nombre1 = nombre1.Text;
            us.nombre2 = nombre2.Text;
            us.apellido1 = apellido1.Text;
            us.apellido2 = apellido2.Text;
            us.contrasena = contrasena.Text;
            us.correo_electronico = email.Text;
            us.user = usuario.Text;
            us.rol = DropRol.SelectedValue;



            

            if (!validarCorreo(email.Text))
            {
                Response.Write("<script> alert('verifique correo electronico'); </script>");
                return;
            }
            if (!validarUsuarioPassword(usuario.Text, contrasena.Text))
            {
                Response.Write("<script> alert('Caracteres no valido en usuario y/o password'); </script>");
                return;
            }
            if (contrasena.Text.Length < 5)
            {

                Response.Write("<script> alert('Usuario y Password debe ser de al menos 5 caracteres'); </script>");
                return;
            }
            if (!(contrasena.Text.Equals(contrasena2.Text)))
            {
                Response.Write("<script> alert('password no coinciden'); </script>");
                return;
            }

            if (p.usuarioExiste(us.user) == true)
            {

                Response.Write("<script> alert('Usuario ya existe'); </script>");
                return;

            }
            if (p.emailExiste(us.correo_electronico) == true)
            {

                Response.Write("<script> alert('Correo electronico  ya existe'); </script>");
                return;
            }
            if (p.Registrarse(us) == true)
            {

                Response.Write("<script> alert('Registro Exitoso'); </script>");
              

                nombre1.Text = "";
                 nombre2.Text = "";
                apellido1.Text = "";
                apellido2.Text = "";
                contrasena.Text = "";
                email.Text = "";
                usuario.Text = "";

                return;


            }
            else
            {


                Response.Write("<script> alert('Nombres y apellidos ya existen  '); </script>");
                return;
            }



        }
    }
}