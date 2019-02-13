using juefi2.Controllers;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                asignarproceso.DataSource = proce.consultarusuario();
                asignarproceso.DataBind();
            }
        }
    }
}