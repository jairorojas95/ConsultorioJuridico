using System;
using juefi2.Controllers;
using juefi2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace juefi2.Views
{
    public partial class Diagnostico : System.Web.UI.Page
    {
        DiagnosticoController diag = new DiagnosticoController();
        DiagnosticoModel diagmode = new DiagnosticoModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                if (Request.Files["UploadedFile"] != null)
                {
                    HttpPostedFile MyFile = Request.Files["UploadedFile"];

                    try
                    {

                    }
                    catch (Exception BlueScreen)
                    {
                        //Handle errors 
                    }
                }
                try
                {
                    DropRadicado.DataValueField = "idproceso";
                    DropRadicado.DataTextField = "nombre";
                    DropRadicado.DataSource = diag.llenardiagnostico(Session["idusuario"].ToString());
                    DropRadicado.DataBind();
                }
                catch (Exception ex)
                {
                    
                }

          
            }

        }

        protected void Guardar_diagnostico_Click(object sender, EventArgs e)
        {
            if (MyFile.HasFile)
            {
                ViewState["Ruta"] = "~/archivos/" + System.IO.Path.GetFileName(MyFile.FileName);
                MyFile.SaveAs(Server.MapPath(ViewState["Ruta"].ToString()));

            }
            diagmode.archivo= ViewState["Ruta"].ToString();
            diagmode.fk_proceso= DropRadicado.SelectedValue;
            diag.registro_dignostico(diagmode);


        }
    }
}