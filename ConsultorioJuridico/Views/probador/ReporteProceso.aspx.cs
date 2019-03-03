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
    public partial class reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            conecMysql conn = new conecMysql();

            //DataSet objdatset = new DataSet();

            DataTable objdattable = new DataTable();

            probador.proceso opt = new probador.proceso();

            objdattable = conn.EjecutarConsulta(" select idproceso as id ,radicado_proceso as radicado ,accionante,accionado,concat(usuario.nombre1, ' ',usuario.nombre2, ' ',usuario.apellido1, ' ', usuario.apellido2) "
                                               + "  as asesor, tipo_proceso.nombre_tipo as nombre_tipo from proceso "
                                               + "  inner join tipo_proceso on proceso.fk_tipoproceso = tipo_proceso.idtipo_proceso "
                                               + "  inner join usuario on proceso.usuario_idusuario = usuario.idusuario where proceso.estado = 'abierto'; ", CommandType.Text);


            opt.SetDataSource(objdattable);
            CrystalReportViewer1.ReportSource = opt;
            CrystalReportViewer1.Width = 800;
            CrystalReportViewer1.Height = 800;

        }
    }
}