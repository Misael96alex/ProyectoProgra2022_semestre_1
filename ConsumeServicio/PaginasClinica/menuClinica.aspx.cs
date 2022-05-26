using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasClinica
{
    public partial class menuClinica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws.WSselect_Clinica();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasClinica/agregarClinica.aspx");
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasClinica/borrarClinica.aspx");
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasClinica/modificarClinica.aspx");
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44321/PaginasClinica/buscarClinica.aspx");
        }
    }
}