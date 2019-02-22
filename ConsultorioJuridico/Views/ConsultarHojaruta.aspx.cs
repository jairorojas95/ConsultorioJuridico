using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using juefi2.Controllers;
using juefi2.Models;
using System.Web.UI.WebControls;
using juefi2.Models.BD;

namespace juefi2.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        hojarutaController hojacont = new hojarutaController();
        hojarutaModel hojamodel = new hojarutaModel();
        conecMysql conne = new conecMysql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Dropestudiante.DataValueField = "idusuario";
                    Dropestudiante.DataTextField = "nombre";
                    Dropestudiante.DataSource = hojacont.ctraerestudiante();
                    Dropestudiante.DataBind();
                    
                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void Dropestudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Dropestudiante.SelectedValue.Equals("0"))
            {

               

                    try
                    {
                        Droproceso.Items.Clear();
                        Droproceso.DataValueField = "idproceso";
                        Droproceso.DataTextField = "nombre";
                        Droproceso.DataSource = hojacont.llenarproceso(Dropestudiante.SelectedValue.ToString());
                        Droproceso.DataBind();
                    }
                    catch (Exception ex)
                    {

                    }
                
            }
            

        }

        protected void Droproceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Droproceso.SelectedValue.Equals("0"))
            {
                hojaruta.DataSource = hojacont.consultarproce(Droproceso.SelectedValue);
                hojaruta.DataBind();
            }

        }

        protected void observacion_Command(object sender, CommandEventArgs e)
        {
            ViewState["id"] = e.CommandArgument.ToString();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal-default22');", true);
        }

        protected void Agregar_observacion_Click(object sender, EventArgs e)
        {
            hojamodel.observacion = observa.Text;
            hojamodel.id = ViewState["id"].ToString();
            hojacont.actualizarhoja(hojamodel);

            observa.Text = "";
        }
    }
}