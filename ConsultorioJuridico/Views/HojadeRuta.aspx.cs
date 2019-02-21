using juefi2.Controllers;
using juefi2.Models;
using juefi2.Models.BD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



namespace juefi2.Views
{
    public partial class Vista1 : Page
    {
        hojarutaController hojacont = new hojarutaController();
        hojarutaModel hojamodel = new hojarutaModel();
        conecMysql conne = new conecMysql();
        public string id;


        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                agregarhojaderuta.Enabled = false;

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

                    Droproceso.Items.Clear();
                    Droproceso.DataValueField = "idproceso";
                    Droproceso.DataTextField = "nombre";
                    Droproceso.DataSource = hojacont.llenarproceso(Session["idusuario"].ToString());
                    Droproceso.DataBind();
                    //if (Droproceso.SelectedIndex != 1) {
                    //    agregarhojaderuta.Enabled = true;

                    //}
                    //id = Droproceso.SelectedValue;

                }
                catch (Exception ex)
                {

                }

               

            }


        }
               
        
               protected void agregarhojaderuta_Command(object sender, CommandEventArgs e)
        {
            if(!Droproceso.SelectedValue.Equals("0")) {
                ViewState["id"] = Droproceso.SelectedValue;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", "mostrarModal('modal_cierre');", true);
            }
        }

        protected void guardar_hoja_Click(object sender, EventArgs e)
        {
            hojamodel.fk_proceso = ViewState["id"].ToString();
            hojamodel.folio = Textfolio.Text;
            hojamodel.actuacion = actuac.Text;
            hojacont.registro_hojaruta(hojamodel);

            Textfolio.Text = "";
            actuac.Text = "";


        }

        protected void Droproceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!Droproceso.SelectedValue.Equals("0")) {
                hojaruta.DataSource = hojacont.consultarproce(Droproceso.SelectedValue);
                hojaruta.DataBind();
                
            }
        }
    }
}