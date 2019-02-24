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
    public partial class consultarproceso_estudiante : System.Web.UI.Page
    {
        ProcesoController proce = new ProcesoController();
        ProcesoModel procemo = new ProcesoModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            consultarproceso.DataSource = proce.consultarproestudiante(Session["idusuario"].ToString());
            consultarproceso.DataBind();

        }
    }
}