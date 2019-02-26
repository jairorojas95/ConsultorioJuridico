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
            conecMysql conn = new conecMysql();

            //DataSet objdatset = new DataSet();

            DataTable objdattable = new DataTable();

            probador.CrystalReport1 opt = new probador.CrystalReport1();

            objdattable = conn.EjecutarConsulta(" select DISTINCT  usuario.idusuario as id ,concat (usuario.nombre1,' ',usuario.apellido1) as nombre ,"
                                             + " tipo_proceso.nombre_tipo from proceso as proceso "
                                             + " inner join usuario on usuario.idusuario = proceso.usuario_proceso "
                                             + " inner join tipo_proceso on tipo_proceso.idtipo_proceso = proceso.fk_tipoproceso ; ", CommandType.Text);


            opt.SetDataSource(objdattable);
           CrystalReportViewer1.ReportSource = opt;
           CrystalReportViewer1.Width = 800;
           CrystalReportViewer1.Height = 800;

        }
    }
}