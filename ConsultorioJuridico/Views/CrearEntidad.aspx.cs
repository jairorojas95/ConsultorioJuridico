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
	public partial class CrearEntidad : System.Web.UI.Page
	{
        dinamicasController dinacont = new dinamicasController();
        dinamicasModel dianmode = new dinamicasModel();

		protected void Page_Load(object sender, EventArgs e)
		{
                 Dropproceso.DataTextField = "nombre_tipo";
                 Dropproceso.DataValueField = "idtipo_proceso";
                 Dropproceso.DataSource = dinacont.consultarproces();
                 Dropproceso.DataBind();


        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            dianmode.nombre = Txnuevoproceos.Text;

            if (dinacont.registro_proceso(dianmode) == true) {

                Response.Write("<script> alert('Registro Exitoso'); </script>");
                Txnuevoproceos.Text = "";

                return;

               

            }

        }
    }
}