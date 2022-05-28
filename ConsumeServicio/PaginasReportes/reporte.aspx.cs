using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasReportes
{
    public partial class reporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws.WSBusquedaCitas();
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }

        protected void verificar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws.WSBusquedaPacienteConsulta(nombreBuscar.Text);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}