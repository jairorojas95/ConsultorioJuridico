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
    public partial class Consultarhojacierre : System.Web.UI.Page
    {
        HojaCierreModal hojamodal = new HojaCierreModal();
        HojaCierreController hojacont = new HojaCierreController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Dropestudiante.SelectedValue.Equals("0"))
            {


                diagnostico.DataSource = hojacont.consultarhoja(Dropestudiante.SelectedValue);
                diagnostico.DataBind();

            }

            if (!IsPostBack)
            {
                try
                {
                    Dropestudiante.DataValueField = "idusuario";
                    Dropestudiante.DataTextField = "nombre";
                    Dropestudiante.DataSource = hojacont.ctraerestudiante(Session["idusuario"].ToString());
                    Dropestudiante.DataBind();

                }
                catch (Exception )
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

        protected void Dropestudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Agregar_observacion_Click(object sender, EventArgs e)
        {
            hojamodal.observacion = observa.Text;
            hojamodal.id = ViewState["id"].ToString();
            hojacont.actualizarhojacierre(hojamodal);

            observa.Text = "";
        }

       

        protected void aceptar_Command1(object sender, CommandEventArgs e)
        {
            ViewState["idproce"] = e.CommandArgument.ToString();
            hojamodal.id = ViewState["idproce"].ToString();
            hojacont.actualizaproceso(hojamodal);

        }
    }
}