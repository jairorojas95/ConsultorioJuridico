using juefi2.Controllers;
using juefi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views
{
    public partial class ConsultarProceso : System.Web.UI.Page
    {
        ProcesoController proce = new ProcesoController();
        ProcesoModel procemo = new ProcesoModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                                try
                {
                    droplisestudiante.DataTextField = "nombre";
                    droplisestudiante.DataValueField = "idusuario";
                    droplisestudiante.DataSource = proce.consultarestudiante();
                    droplisestudiante.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script> alert('pailas'); </script>");
                }

                consultarproceso.DataSource = proce.consultarproce();
                consultarproceso.DataBind();
            }
        }

        //protected void consultaproceso_ItemCommand(object source, RepeaterCommandEventArgs e)
        ////{
        ////    if (e.CommandName.Equals("edit"))
        ////    {
        ////        ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "botondelmodel();", true);
        ////        labelidproceso.InnerText = e.CommandArgument.ToString();

        //    }

        //}
    }
}
