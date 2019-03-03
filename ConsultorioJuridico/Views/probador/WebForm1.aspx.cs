using juefi2.Models.BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views.probador
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void reporte1_Click(object sender, EventArgs e)
        {
            Response.Write("<script type='text/javascript'>window.open('../probador/reporte.aspx');</script>");
            
        }
    }
        
}