using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasClinica
{
    public partial class borrarClinica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void verificar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int idBuscarP = Int32.Parse(idBuscar.Text);
            DataSet ds = ws.WSBuscar_Clinica_ID(idBuscarP);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void borrar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int idBuscarP = Int32.Parse(idBuscar.Text);
            ws.WSBorrar_Clinica(idBuscarP);
        }
    }
}