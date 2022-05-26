using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasClinica
{
    public partial class agregarClinica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_clinicaP = Int32.Parse(id_clinica.Text);
            int nitP = Int32.Parse(nit.Text);
            int telP = Int32.Parse(no_telelefono.Text);
            string salida = ws.WSinsert_Clinica(id_clinicaP, nombre_clinica.Text, direccion.Text, correo.Text, telP, nitP);
            salidaLabel.Text = salida;

            id_clinica.Text = "";
            nombre_clinica.Text = "";
            direccion.Text = "";
            correo.Text = "";
            no_telelefono.Text = "";
            nit.Text = "";
        }
    }
}