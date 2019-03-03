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
    public partial class ReporteAsignar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            conecMysql conn = new conecMysql();

            //DataSet objdatset = new DataSet();

            DataTable objdatta = new DataTable();

            probador.asignar opt = new probador.asignar();

            objdatta = conn.EjecutarConsulta(" SELECT idusuario as id, concat(nombre1, ' ', nombre2, ' ', apellido1, ' ', apellido2) as nombre , usuario.semestre as Semestre, "
                                               + "  COUNT(proceso.usuario_proceso) as cantidad "
                                               + "  FROM usuario "
                                               + " left JOIN  proceso ON  proceso.usuario_proceso = usuario.idusuario "
                                               + " where usuario.rol_idrol = '2' "
                                               + " GROUP BY usuario.idusuario; ", CommandType.Text);


            opt.SetDataSource(objdatta);
            CrystalReportViewer3.ReportSource = opt;
            CrystalReportViewer3.Width = 800;
            CrystalReportViewer3.Height = 800;
        }
    }
}