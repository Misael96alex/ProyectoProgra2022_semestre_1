using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.Services;

namespace ServicioWebBDD_A
{
    /// <summary>
    /// Descripción breve de WebServiceBDD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceBDD : System.Web.Services.WebService
    {
        String servidor;
        String bd;
        String usuario;
        String password;
        String CadenaConexion;
         /*hola kevin
          en este momento estoy trabajando la parte del htm (index)
          si gustas anda metiendo tus select, insert, delete, update de tus tablas aqui en este archivo
         */
        public WebServiceBDD()
        {
            servidor = "localhost";
            bd = "proyectoprogra";
            usuario = "root";
            password = "1234";
            CadenaConexion = "server = " + servidor+"; port=3306; User Id="+usuario+"; Password="+password+"; database="+bd+";";
        }

        [WebMethod]
        public DataSet WSselect()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usuario;",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public String WSinsertUsuario(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = CadenaConexion;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into usuario(id_usuario,id_clinica,nombre_usuario,apellido_usuario,fecha_nac,dpi,nit,direccion,correo,no_telelefono)values('" + id_usuario + "','" + id_clinica + "','" + nombre_usuario + "','" + apellido_usuario + "','" + fecha_nac + "','" + dpi + "','" + nit + "','" + direccion + "','" + correo + "','" + no_telelefono + "')";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Insercion con exito";
            }catch(Exception e)
            {
                return "error: " + e.Message;
            }
        }

        [WebMethod]
        public String WSinsertClinica(int id_clinica, string nombre_clinica,string direccion, string correo, int no_telelefono, int nit)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = CadenaConexion;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into clinica(id_clinica,nombre_clinica,direccion,correo,no_telelefono,nit)values('" + id_clinica + "','" + nombre_clinica + "','" + direccion + "','" + correo + "','" + no_telelefono + "','" + nit + "')";
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Insercion con exito";
            }
            catch (Exception e)
            {
                return "error: " + e.Message;
            }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string Suma(int a, int b)
        {
            return "La suma es: "+ (a+b);
        }
        [WebMethod]
        public string Dividir(int a, int b)
        {
            try { 
            float resul;
            resul = a / b;
            return "La division es: " + (resul);
            }
            catch (Exception e) {
                return "error: " + e.Message;
            }
        }
    }
}
