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
    public partial class Asignarproceso : System.Web.UI.Page
    {

        AsignarProcesoController proce = new AsignarProcesoController();
        AsignarProcesoModal promodal = new AsignarProcesoModal();
        ProcesoController proceso = new ProcesoController();

        protected void Page_Load(object sender, EventArgs e)
        {


            asignarproceso.DataSource = proce.consultarusuario();
            asignarproceso.DataBind();

            if (!IsPostBack)
            {
                droplisproceso.DataTextField = "nombre";
                droplisproceso.DataValueField = "idproceso";
                droplisproceso.DataSource = proce.traerproceso();
                droplisproceso.DataBind();

                Dropasesor.DataValueField = "idusuario";
                Dropasesor.DataTextField = "nombre";
                Dropasesor.DataSource = proceso.traerdocentes();
                Dropasesor.DataBind();
            }



        }

        protected void guardar_datos_Click(object sender, EventArgs e)
        {
            promodal.fk_proce = droplisproceso.SelectedValue;
            promodal.idusua = ViewState["id"].ToString();
            promodal.docente = Dropasesor.SelectedValue;
            proce.actualizarpersona(promodal);
            Response.Redirect("../Views/Asignarproceso.aspx");
        }

        protected void asignar_Command(object sender, CommandEventArgs e)
        {
            ViewState["id"] = e.CommandArgument;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal-default');", true);

        }




        protected void btnreporte_Click(object sender, EventArgs e)
        {
            Response.Write("<script type='text/javascript'>window.open('./probador/ReporteAsignar.aspx');</script>");
            //Response.Write("<script type='text/javascript'>window.open('../probador/reporte.aspx');</script>");

        }

    }
}
