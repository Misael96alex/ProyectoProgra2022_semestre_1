using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasPacientes
{
    public partial class menuPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws.WSselectPaciente();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasPacientes/agregarPaciente.aspx");
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void Modificar_Click(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {

        }
    }
}