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
    public partial class CrearProceso : System.Web.UI.Page
    {
        ProcesoController proce = new ProcesoController();
        ProcesoModel procemo = new ProcesoModel();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    droplisproceso.DataSource = proce.consultarproces();
                    droplisproceso.DataValueField = "idtipo_proceso";
                    droplisproceso.DataTextField = "nombre_tipo";
                    droplisproceso.DataBind();



                    Dropasesor.DataSource = proce.traerdocentes();
                    Dropasesor.DataValueField = "id_usuario";
                    Dropasesor.DataTextField = "nombre";
                    Dropasesor.DataBind();



                }
                catch (Exception ex)
                {
                }
                                               
            }

        }

        protected void guardar(object sender, EventArgs e)
        {

            procemo.radicado = Textradicado.Text;
            procemo.accionante = Textaccionante.Text;
            procemo.accionado = Textaccionado.Text;
            procemo.asesor = Dropasesor.SelectedValue;
            procemo.tipo_proceso = droplisproceso.SelectedValue;

            procemo.registrarproceso(procemo);
            Response.Write("<script> alert('Registro Exitoso'); </script>");

            Textradicado.Text = "";
            Textaccionante.Text = "";
            Textaccionado.Text = "";


        }

        protected void lieditar_Command(object sender, CommandEventArgs e)
        {
            Response.Write("<script> alert('hola " + e.CommandArgument + "') </script>");
        }

        protected void consultaproceso_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}
