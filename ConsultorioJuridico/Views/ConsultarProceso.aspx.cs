using juefi2.Controllers;
using juefi2.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        protected void guardar_datos_Click(object sender, EventArgs e)
        {
            procemo.idusua = droplisestudiante.SelectedValue;
            procemo.fk_proce = ViewState["id"].ToString();
            //proce.actualizarpersona(procemo);
            //proce.actualizarproceso(procemo);

        }

        protected void asignar_Command(object sender, CommandEventArgs e)
        {
            ViewState["id"] = e.CommandArgument;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal-default22');", true);
           
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
