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
    }
}