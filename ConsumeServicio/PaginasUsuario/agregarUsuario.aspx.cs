using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio.Paginas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
                DataSet ds1 = ws.WSselect_Clinica();
                clinica.DataSource = ds1;
                clinica.DataTextField = "nombre_clinica";
                clinica.DataValueField = "id_clinica";
                clinica.DataBind();
            }
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int id_clinicaP = Int32.Parse(clinica.Text);
            int nitP = Int32.Parse(nit.Text);
            int telP = Int32.Parse(telefono.Text);
            int contP = Int32.Parse(contrasena.Text);
            string salida = ws.WSinsert_Usuario(id_clinicaP, nombre.Text, apellido.Text, fecha_nac.Text, dpi.Text, nitP, direccion.Text, correo.Text, telP, contP);
            salidaLabel.Text = salida;
            
            nombre.Text = "";
            apellido.Text = "";
            fecha_nac.Text = "";
            dpi.Text = "";
            nit.Text = "";
            direccion.Text = "";
            correo.Text = "";
            telefono.Text = "";
            contrasena.Text = "";
        }
    }
}