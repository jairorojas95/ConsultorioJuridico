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

namespace juefi2.Views.usuario
{
    public partial class registro : System.Web.UI.Page
    {
        UsuarioController p = new UsuarioController();
        UsuarioModel us = new UsuarioModel();
        conecMysql conne = new conecMysql();

        protected void Page_Load(object sender, EventArgs e)
        {

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






        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           

                us.nombre1 = nombre1.Text;
                us.nombre2 = nombre2.Text;
                us.apellido1 = apellido1.Text;
                us.apellido2 = apellido2.Text;
                us.contrasena = contrasena.Text;
                us.correo_electronico = email.Text;
                us.semestre = semestre.Text;
                us.user = usuario.Text;
           
               

                if (!(validarNombre(nombre1.Text, true) && validarNombre(nombre2.Text, false) &&
                     validarNombre(apellido1.Text, true) && validarNombre(apellido2.Text, false)))
                {
                    Response.Write("<script> alert('Verifique los nombres y apellidos'); </script>");
                    return;
                }

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
                if (!(contrasena.Text.Equals(conficontrasena.Text)))
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

                    Response.Redirect("../usuario/login.aspx");

                }
                else
                {


                    Response.Write("<script> alert('Nombres y apellidos ya existen  '); </script>");
                    return;
                }

             
                       
           
        }
    }
}

        
