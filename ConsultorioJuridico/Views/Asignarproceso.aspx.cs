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
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                asignarproceso.DataSource = proce.consultarusuario();
                asignarproceso.DataBind();


                try
                {
                    droplisproceso.DataTextField = "nombre";
                    droplisproceso.DataValueField ="idproceso";
                    droplisproceso.DataSource = proce.traerproceso();
                    droplisproceso.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script> alert('pailas'); </script>");
                }
               
            }
        }

        protected void guardar_datos_Click(object sender, EventArgs e)
        {
            promodal.fk_proce = droplisproceso.SelectedValue;
           promodal.idusua = ViewState["id"].ToString();
           proce.actualizarpersona(promodal);
        }

        protected void asignar_Command(object sender, CommandEventArgs e)
        {
             ViewState["id"] = e.CommandArgument;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal-default');", true);

        }
    }
    }
