using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasEnfermedades
{
    public partial class agegarEnfermedades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_enfermedadP = Int32.Parse(id_enfermedad.Text);
            string salida = ws.WSinsertEnfermedad(id_enfermedadP, nombre_enfermedad.Text, tipo_enfermedad.Text, nivel_contagio.Text);
            salidaLabel.Text = salida;
        }
    }
}