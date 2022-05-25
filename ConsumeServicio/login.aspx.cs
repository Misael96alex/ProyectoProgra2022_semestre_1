using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Ingresar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int ids = Int32.Parse(Usuario.Text);
            int contras = Int32.Parse(Contra.Text);
            bool ds = ws.WSValidar_Usuario(ids, contras);
            if (ds)
            {
                Response.Redirect("https://localhost:44321/menuUsuario.aspx");
            }
        }
    }
}