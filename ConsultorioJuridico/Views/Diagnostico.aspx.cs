using System;
using juefi2.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views
{
    public partial class Diagnostico : System.Web.UI.Page
    {
        DiagnosticoController diag = new DiagnosticoController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                try
                {
                    DropRadicado.DataValueField = "idproceso";
                    DropRadicado.DataTextField = "nombre";
                    DropRadicado.DataSource = diag.llenardiagnostico(Session["idusuario"].ToString());
                    DropRadicado.DataBind();
                }
                catch (Exception ex)
                {
                    
                }


            }

        }
    }
}