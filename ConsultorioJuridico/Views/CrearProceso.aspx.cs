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
    public partial class CrearProceso : Page
    {
        ProcesoController proce = new ProcesoController();
        ProcesoModel procemo = new ProcesoModel();
       
       



        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                try
            {
                    droplisproceso.DataValueField = "idtipo_proceso";
                    droplisproceso.DataTextField = "nombre_tipo";
                    droplisproceso.DataSource = proce.consultarproces();
                    droplisproceso.DataBind();
                                                                      
                    Dropasesor.DataValueField = "idusuario";
                    Dropasesor.DataTextField = "nombre";
                    Dropasesor.DataSource = proce.traerdocentes();
                    Dropasesor.DataBind();


                   
                    Dropaccionante.DataTextField = "idpersona";
                    Dropaccionante.DataValueField = "nombre";
                    Dropaccionante.DataSource = proce.traeraimplicados();
                    Dropaccionante.DataBind();

                    Dropaccionado.DataTextField = "idpersona";
                    Dropaccionado.DataValueField = "nombre";
                    Dropaccionado.DataSource = proce.traeraimplicados();
                    Dropaccionado.DataBind();
                                                       
                      
                    DropDowndocument.DataValueField = "idtipo_documento";
                    DropDowndocument.DataTextField = "nombre_ducumento";
                    DropDowndocument.DataSource = proce.consultardocumento();
                    DropDowndocument.DataBind();

            }
            catch (Exception ex)
            {
            }
            }
        }

        //protected void guardar_persona(object sender, EventArgs e)
        //{

        //    procemo.nombre1 = nombre1.Text;
        //    procemo.nombre2 = nombre2.Text;
        //    procemo.apellido1 = apellido1.Text;
        //    procemo.apellido1 = apellido1.Text;
        //    procemo.documento = documento.Text;
        //    procemo.tipo_documento = DropDowndocument.SelectedValue;
        //    procemo.telefono = telefono.Text;
        //    procemo.direccion = direccion.Text;



        //}

        protected void guardar(object sender, EventArgs e)
        {



            procemo.radicado = Textradicado.Text;
            procemo.accionante = Dropaccionante.SelectedValue;
            procemo.accionado = Dropaccionado.SelectedValue;
            procemo.asesor = Dropasesor.SelectedValue;
            procemo.tipo_proceso = droplisproceso.SelectedValue;

            procemo.registrarproceso(procemo);
            Response.Write("<script> alert('Registro Exitoso'); </script>");

            Textradicado.Text = "";
        

            //if (file.ContentLength > 0) {
            //    var fileName = Path.GetFileName(file.FileName);
            //    var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
            //    file.SaveAs(path);
            //}

        }

        protected void guardar_datos_Click(object sender, EventArgs e)
        {
            procemo.nombre1 = nombre1.Text;
            procemo.nombre2 = nombre2.Text;
            procemo.apellido1 = apellido1.Text;
            procemo.apellido1 = apellido1.Text;
            procemo.documento = documento.Text;
            procemo.tipo_documento = DropDowndocument.SelectedValue;
            procemo.telefono = telefono.Text;
            procemo.direccion = direccion.Text;


            if (proce.registropersona(procemo) == true)
            {
                nombre1.Text = "";
                nombre2.Text = "";
                apellido1.Text = "";
                apellido2.Text = "";
                documento.Text = "";
                telefono.Text = "";
                direccion.Text = "";


            }
            else
            {
                Response.Write("<script> alert('dfsdfsdfsdfs'); </script>");
            }


        }

        //protected void lieditar_Command(object sender, CommandEventArgs e)
        //{
        //    Response.Write("<script> alert('hola " + e.CommandArgument + "') </script>");
        //}

        //protected void consultaproceso_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{

        //}
    }
}
