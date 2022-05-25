using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace ConsumeServicio
{
    public partial class prueba_validacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WservicioBDD.WebServiceBDDSoapClient ws = new WservicioBDD.WebServiceBDDSoapClient();
            int idi = Int32.Parse(id.Text);
            int contrai = Int32.Parse(contra.Text);
            DataSet ds = ws.WSValidar_Usuario1(idi, contrai);
            int num = ws.WSValidar_Usuario2(idi, contrai);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            Label1.Text = ""+num;

        }
    }
}