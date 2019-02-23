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
    public partial class consultarhoja_cierre_estudinate : System.Web.UI.Page
    {
        HojaCierreModal hojamodal = new HojaCierreModal();
        HojaCierreController hojacont = new HojaCierreController();

        protected void Page_Load(object sender, EventArgs e)
        {
            diagnostico.DataSource = hojacont.consultarhoja(Session["idusuario"].ToString());
            diagnostico.DataBind();
        }
    }
}