using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasMedicamentos
{
    public partial class agregarMedicamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_medicamentoP = Int32.Parse(id_medicamento.Text);
            string salida = ws.WSinsertMedicamento(id_medicamentoP, descripcion.Text, precio.Text, marca.Text, cantidad.Text, dosis.Text, presentacion.Text);
            salidaLabel.Text = salida;

        }
    }
}