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
    public partial class ConsultarDiagnosticoEstudiante : System.Web.UI.Page
    {
        DiagnosticoController diag = new DiagnosticoController();
        DiagnosticoModel diagmode = new DiagnosticoModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            diagnostico.DataSource = diag.consultarproce(Session["idusuario"].ToString());
            diagnostico.DataBind();
        }
    }
}