using juefi2.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views.pagina_maestra
{
    public partial class paginamaestra : System.Web.UI.MasterPage
    {
        MenuController menu = new MenuController();
        public DataTable databMenu = new DataTable();
        public DataRow daroMenu;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idusuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                if (!this.IsPostBack)
                {
                    this.CargarMenu(Session["idusuario"].ToString());
                }
            }
        }


        public void CargarMenu(string idCuenta)
        {
            databMenu = menu.consultarMenu(idCuenta);
            if (databMenu.Rows.Count > 0)
            {
                daroMenu = databMenu.Rows[0];
            }

            menurepeter.DataSource = databMenu;
            menurepeter.DataBind();

            MenuController userc = new MenuController();
            string saludo = userc.GetNombresUsuario(Int32.Parse(Session["idusuario"].ToString())).ToUpper();
            //Session["NombreUsuario"] = saludo;
            Label1.Text = saludo;
            Label2.Text = saludo;
            lblbnombre.Text = saludo;
        }









        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.Redirect("../usuario/login.aspx");
        }

    }
}