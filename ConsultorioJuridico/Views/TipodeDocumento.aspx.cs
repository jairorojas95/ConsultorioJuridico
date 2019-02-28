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
    public partial class TipodeDocumento : System.Web.UI.Page
    {
        dinamicasController dinacont = new dinamicasController();
        dinamicasModel dianmode = new dinamicasModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dropdocument.Items.Clear();
                Dropdocument.DataTextField = "nombre_ducumento";
                Dropdocument.DataValueField = "idtipo_documento";
                Dropdocument.DataSource = dinacont.consultardocm();
                Dropdocument.DataBind();
            }
        
        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            dianmode.documento = Txnuevodocumen.Text;

            if (dinacont.registro_docum(dianmode) == true)
            {
                Response.Redirect("../Views/TipodeDocumento.aspx");
                //Response.Write("<script> alert('Registro Exitoso'); </script>");
                //Txnuevodocumen.Text = "";
                

                return;



            }

        }
    }
}