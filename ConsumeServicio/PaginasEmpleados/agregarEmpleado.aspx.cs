using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasEmpleados
{
    public partial class agregarEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
                DataSet ds1 = ws.WSselect_Clinica();
                clinica.DataSource = ds1;
                clinica.DataTextField = "CLINICA";
                clinica.DataValueField = "ID";
                clinica.DataBind();
            }
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_clinicaP = Int32.Parse(clinica.Text);
            int nitP = Int32.Parse(nit.Text);
            int telP = Int32.Parse(telefono.Text);
            string salida = ws.WSinsertEmpleado(id_clinicaP, nombre.Text, apellido.Text,  dpi.Text, nitP, direccion.Text, correo.Text, telP);
            salidaLabel.Text = salida;

            
        }
    }
}