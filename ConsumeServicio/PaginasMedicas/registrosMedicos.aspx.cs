using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeServicio.PaginasMedicas
{
    public partial class registrosMedicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
                DataSet ds = ws.WSselectPaciente();
                id_paciente.DataSource = ds;
                id_paciente.DataTextField = "NOMBRE";
                id_paciente.DataValueField = "ID";
                id_paciente.DataBind();

                DataSet ds1 = ws.WSselect_Clinica();
                id_clinica.DataSource = ds1;
                id_clinica.DataTextField = "CLINICA";
                id_clinica.DataValueField = "ID";
                id_clinica.DataBind();

                DataSet ds2 = ws.WSselect_Usuario();
                usuario_creador.DataSource = ds2;
                usuario_creador.DataTextField = "NOMBRE_USUARIO";
                usuario_creador.DataValueField = "ID";
                usuario_creador.DataBind();

                DataSet ds3 = ws.WSselectEnfermedad();
                diagnostico.DataSource = ds3;
                diagnostico.DataTextField = "ENFERMEDAD";
                diagnostico.DataValueField = "ID";
                diagnostico.DataBind();

                DataSet ds4 = ws.WSselectMedicamento();
                medicamentos.DataSource = ds4;
                medicamentos.DataTextField = "DESCRIPCION";
                medicamentos.DataValueField = "ID";
                medicamentos.DataBind();
            }
        }

        protected void agregar_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            string salida = ws.WSinsertAgendarCita(id_cita.Text, id_paciente.Text, id_clinica.Text, usuario_creador.Text, fecha.Text, costo.Text, no_consultorio.Text, forma_pago.Text);
            salidaLabel.Text = salida;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            string salida = ws.WSTerminarConsulta(id_reg_consul.Text, id_paciente2.Text, fecha_creacion.Text, medicamentos.Text, diagnostico.Text, medico.Text, diagnostico.Text, medicamentos.Text, estudios.Text, usuario_creador2.Text);
            salidaLabel.Text = salida;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws1 = new WservicioBDD.WebServiceBDDSoapClient();
            DataSet ds = ws1.WSBuscarCita(id_reg_consul.Text);
            id_paciente2.DataSource = ds;
            id_paciente2.DataTextField = "PACIENTE";
            id_paciente2.DataValueField = "ID_PACIENTE";
            id_paciente2.DataBind();

            usuario_creador2.DataSource = ds;
            usuario_creador2.DataTextField = "USUARIO";
            usuario_creador2.DataValueField = "ID_USUARIO";
            usuario_creador2.DataBind();
        }
    }
}