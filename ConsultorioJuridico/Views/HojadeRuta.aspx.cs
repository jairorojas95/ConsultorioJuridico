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
    public partial class Vista1 : System.Web.UI.Page
    {
        ProcesoController prueba = new ProcesoController();
        pruebaModel pru = new pruebaModel();
        conecMysql conne = new conecMysql();
        public DataTable consultar = new DataTable();
        public DataRow darowConsulta;



        public void cargar_datos() {
            consultar = pru.hoja_ruta();
            Txtarea.Text = consultar.Rows[0]["area"].ToString();
            Textasesor.Text = consultar.Rows[0]["asesor"].ToString();         
            Textaccionante.Text = consultar.Rows[0]["accionante"].ToString();
            Textentidad.Text = consultar.Rows[0]["entidad"].ToString();
            Textaccionado.Text = consultar.Rows[0]["accionado"].ToString();
            Textclaseproceso.Text = consultar.Rows[0]["clase_proceso"].ToString();
            Textestudiante.Text = consultar.Rows[0]["estudiante"].ToString();
            Textradicado.Text = consultar.Rows[0]["radicado"].ToString();

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void consulta(object sender, EventArgs e)
        {

            cargar_datos();

        }



        protected void guardar (object sender, EventArgs e)
        {
            if (conne.Conectar()== true)
            {

                pru.area = Txtarea.Text;
                pru.asesor = Textasesor.Text;
                pru.accionante = Textaccionante.Text;
                pru.entidad = Textentidad.Text;
                pru.accionado = Textaccionado.Text;
                pru.clase_proceso = Textclaseproceso.Text;
                pru.estudiante = Textestudiante.Text;
                pru.radicado = Textradicado.Text;
                prueba.registro_perosna(pru);

                Txtarea.Text = "";
                Textasesor.Text = "";
                Textaccionante.Text = "";
                Textentidad.Text = "";
                Textaccionado.Text = "";
                Textclaseproceso.Text = "";
                Textestudiante.Text = "";
                Textradicado.Text = "";
                Response.Write("<script> alert('Conexion exitosa'); </script>");
                return;
            }
            else {
                Response.Write("<script> alert('Conexion fallida'); </script>");
                return;
            }








        }
    }
}