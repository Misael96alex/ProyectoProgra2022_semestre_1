using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasPacientes
{
    public partial class agregarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_pacienteP = Int32.Parse(id_paciente.Text);
            int nitP = Int32.Parse(nit.Text);
            int telP = Int32.Parse(no_telelefono.Text);
            string salida = ws.WSinsertPaciente(id_pacienteP, nombre_paciente.Text, apellido_paciente.Text, familiar_responsable.Text, fecha_nac.Text, tipo_sangre.Text, enferm_preexitente.Text, dpi.Text, nitP, direccion.Text, correo.Text, telP);
            salidaLabel.Text = salida;
        }
    }
}