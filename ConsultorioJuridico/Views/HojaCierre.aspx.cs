using System;
using System.Collections.Generic;
using System.Linq;
using juefi2.Controllers;
using juefi2.Models;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views
{
	public partial class HojaCierre : System.Web.UI.Page
	{
        HojaCierreModal hojamodal = new HojaCierreModal();
        HojaCierreController hojacont = new HojaCierreController();

		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
               try
                {

                    Droproceso.DataValueField = "idproceso";
                    Droproceso.DataTextField = "nombre";
                    Droproceso.DataSource = hojacont.llenarproceso(Session["idusuario"].ToString());
                    Droproceso.DataBind();
                   
                }
                catch (Exception )
                {

                }

                
            }

        }

        protected void Asignar_Persona_Click(object sender, EventArgs e)
        {
            hojamodal.fk_proceso = Droproceso.SelectedValue;
            hojamodal.terminacion = terminacion.Text;
            hojamodal.asunto = asunto.Text;
            hojamodal.fecha = datepicker1.Text;

            hojacont.registrohojacierre(hojamodal);

            terminacion.Text = "";
            asunto.Text="";
            datepicker1.Text="";
        }
    }
}