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

            if (!Page.IsPostBack)
            {
                if (Request.Files["UploadedFile"] != null)
                {
                    HttpPostedFile MyFile = Request.Files["UploadedFile"];

                    try
                    {

                    }
                    catch (Exception)
                    {
                        //Handle errors 
                    }
                }


                try
                {

                    Dropaccionante.DataTextField = "nombre";
                    Dropaccionante.DataValueField = "idpersona";
                    Dropaccionante.DataSource = proce.traeraimplicados();
                    Dropaccionante.DataBind();

                    DropDownRepresentante.DataTextField = "nombre";
                    DropDownRepresentante.DataValueField = "idpersona";
                    DropDownRepresentante.DataSource = proce.traeraimplicados();
                    DropDownRepresentante.DataBind();


                    droplisproceso.DataValueField = "idtipo_proceso";
                    droplisproceso.DataTextField = "nombre_tipo";
                    droplisproceso.DataSource = proce.consultarproces();
                    droplisproceso.DataBind();





                    DropDowndocument.DataValueField = "idtipo_documento";
                    DropDowndocument.DataTextField = "nombre_ducumento";
                    DropDowndocument.DataSource = proce.consultardocumento();
                    DropDowndocument.DataBind();

                }
                catch (Exception)
                {
                }

            }

        }


        protected bool validarNombre(string h, bool requerido)
        {
            h = h.ToUpper();
            if (requerido)
            {
                if (h.Length < 3) return false;
            }
            else
            {
                if (h.Length > 0 && h.Length < 3) return false;
            }
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i] < 'A' || h[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
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
            Dropaccionante.Items.Clear();
            Dropaccionante.DataTextField = "nombre";
            Dropaccionante.DataValueField = "idpersona";
            Dropaccionante.DataSource = proce.traeraimplicados();
            Dropaccionante.DataBind();

            //Response.Redirect("../Views/CrearProceso.aspx");
        }



        protected void Guardar_juridico_Click(object sender, EventArgs e)
        {
            procemo.nit = nit.Text;
            procemo.empresa = empresa.Text;
            procemo.representante = DropDownRepresentante.SelectedValue;

            if (proce.registropersonajuridica(procemo) == true)
            {

                nit.Text = "";
                empresa.Text = "";

            }
            else
            {
                Response.Write("<script> alert('Verifique Datos'); </script>");
            }

            //Response.Redirect("../Views/CrearProceso.aspx");

        }



        protected void Dropaccionante_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Dropaccionado.DataTextField = "nombre";
            Dropaccionado.DataValueField = "idpersona";
            Dropaccionado.DataSource = proce.traeraimplicados2(Dropaccionante.SelectedValue);
            Dropaccionado.DataBind();

        }

        //protected void Btn_Guardar_Click(object sender, EventArgs e)
        //{
        //    if (MyFile.HasFile)
        //    {
        //        ViewState["Ruta"] = "~/archivos/" + System.IO.Path.GetFileName(MyFile.FileName);
        //        MyFile.SaveAs(Server.MapPath(ViewState["Ruta"].ToString()));
        //        procemo.archivo = ViewState["Ruta"].ToString();

        //    }
        //    procemo.radicado = Textradicado.Text;
        //    procemo.accionante = Dropaccionante.SelectedItem.Text;
        //    procemo.accionado = Dropaccionado.SelectedItem.Text;
        //    procemo.asesor = Dropasesor.SelectedValue;
        //    procemo.tipo_proceso = droplisproceso.SelectedValue;
        //    proce.Registraproceso(procemo);
        //}

        protected void BTnguardar222_Click(object sender, EventArgs e)
        {


            if (MyFile.HasFile)
            {
                ViewState["Ruta"] = "~/archivos/" + System.IO.Path.GetFileName(MyFile.FileName);
                MyFile.SaveAs(Server.MapPath(ViewState["Ruta"].ToString()));
                procemo.archivo = ViewState["Ruta"].ToString();

            }
            procemo.radicado = Textradicado.Text;
            procemo.accionante = Dropaccionante.SelectedItem.Text;
            procemo.accionado = Dropaccionado.SelectedItem.Text;
            procemo.asunto = asunto.Text;
            procemo.tipo_proceso = droplisproceso.SelectedValue;

            if (droplisproceso.SelectedIndex == 0 || Dropaccionante.SelectedIndex == 0 || Dropaccionado.SelectedIndex == 0 ||
                Textradicado.Text.Equals("") || asunto.Text.Equals(""))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('Alerta', 'Debe llenar todos los campos', 'info');", true);
            }
            else
            {
                if (proce.Registraproceso(procemo) == true)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('Exito', 'Datos agregados correctamente', 'success');", true);



                    Textradicado.Text = "";
                    asunto.Text = "";
                    droplisproceso.SelectedIndex = 0;
                    Dropaccionado.SelectedIndex = 0;
                    Dropaccionante.SelectedIndex = 0;

                }
                else
                {
                    Response.Write("<script> alert('verifique Datos  '); </script>");
                    return;
                }
            }





        }
    }
}
