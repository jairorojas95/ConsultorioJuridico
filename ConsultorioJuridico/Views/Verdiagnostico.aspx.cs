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
    public partial class Verdiagnostico : System.Web.UI.Page
    {
        DiagnosticoController diag = new DiagnosticoController();
        DiagnosticoModel diagmode = new DiagnosticoModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Dropestudiante.DataValueField = "idusuario";
                    Dropestudiante.DataTextField = "nombre";
                    Dropestudiante.DataSource = diag.ctraerestudiante();
                    Dropestudiante.DataBind();

                }
                catch (Exception ex)
                {

                }
            }

        }

        protected void observacion_Command(object sender, CommandEventArgs e)
        {

            if (!Dropestudiante.SelectedValue.Equals("0"))
            {
                ViewState["id"] = e.CommandArgument.ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal-default22');", true);
            }
        }

     
        protected void Agregar_observacion_Click(object sender, EventArgs e)
        {
            diagmode.observacion = observa.Text;
            diagmode.id = ViewState["id"].ToString();
            diag.actualizardignostico(diagmode);

            observa.Text = "";

        }

        protected void Dropestudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Dropestudiante.SelectedValue.Equals("0"))
            {
                    
                                
                   diagnostico.DataSource = diag.consultarproce(Dropestudiante.SelectedValue);
                   diagnostico.DataBind();
                   
                       }
        }
    }
}