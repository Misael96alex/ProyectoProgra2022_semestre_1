using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasEmpleados
{
    public partial class menuEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws.WSselectEmpleado();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasEmpleados/agregarEmpleado.aspx");
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasEmpleados/agregarEmpleado.aspx");
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasEmpleados/agregarEmpleado.aspx");
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasEmpleados/agregarEmpleado.aspx");
        }
    }
}