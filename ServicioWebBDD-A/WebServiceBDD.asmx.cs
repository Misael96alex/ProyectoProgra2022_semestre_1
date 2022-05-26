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
         
        public WebServiceBDD()
        {
            servidor = "localhost";
            bd = "proyectoprogra";
            usuario = "root";
            password = "1234";
            CadenaConexion = "server = " + servidor+"; port=3306; User Id="+usuario+"; Password="+password+"; database="+bd+";";
        }

        /*
         * **********************************************
         * *                USUARIO                   * *
         * **********************************************
         * */

        [WebMethod]
        public DataSet WSselect_Usuario()
        {
            
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT u.id_usuario as ID,CONCAT(u.nombre_usuario, ' ', u.apellido_usuario) as 'NOMBRE_USUARIO', cl.nombre_clinica as CLINICA" +
                ", date_format(u.fecha_nac, "+"'%d/%m/%Y'"+") as FECHA_NACIMIENTO, u.dpi as DPI, u.nit as NIT, u.direccion as DIRECCION_USUARIO"+
                ", u.correo as CORREO, u.no_telelefono as TELEFONO FROM usuario u JOIN clinica cl on u.id_clinica = cl.id_clinica; ",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
            
        }

        [WebMethod]
        public bool WSValidar_Usuario(int id, int contrasena)
        {
            String id_ = "" + id;
            String contrasena_ = "" + contrasena;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT u.id_usuario as ID,CONCAT(u.nombre_usuario, ' ', u.apellido_usuario) as 'NOMBRE_USUARIO', cl.nombre_clinica as CLINICA" +
                ", date_format(u.fecha_nac, " + "'%d/%m/%Y'" + ") as FECHA_NACIMIENTO, u.dpi as DPI, u.nit as NIT, u.direccion as DIRECCION_USUARIO" +
                ", u.correo as CORREO, u.no_telelefono as TELEFONO, u.contrasena AS CONTRASEÑA FROM usuario u JOIN clinica cl on u.id_clinica = cl.id_clinica where id_usuario = " + id_ + " and contrasena = " +
                contrasena_ + "; ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int num = ds.Tables[0].Rows.Count;
            if (num == 1)
            {
                return true;
            } else
            {
                return false;
            }

        }

        [WebMethod]
        public DataSet WSBuscar_Usuario_ID(int id)
        {
            String id_ = "" + id;
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT u.id_usuario as ID,CONCAT(u.nombre_usuario, ' ', u.apellido_usuario) as 'NOMBRE_USUARIO', cl.nombre_clinica as CLINICA" +
                ", date_format(u.fecha_nac, " + "'%d/%m/%Y'" + ") as FECHA_NACIMIENTO, u.dpi as DPI, u.nit as NIT, u.direccion as DIRECCION_USUARIO" +
                ", u.correo as CORREO, u.no_telelefono as TELEFONO, u.contrasena AS CONTRASEÑA FROM usuario u JOIN clinica cl on u.id_clinica = cl.id_clinica where id_usuario = " + id_ + " ; ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        [WebMethod]
        public DataSet WSBuscar_Usuario_ID_Nombre( String nombre)
        {
            
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT distinct u.id_usuario as ID,CONCAT(u.nombre_usuario, ' ', u.apellido_usuario) as 'NOMBRE_USUARIO', cl.nombre_clinica as CLINICA" +
                ", date_format(u.fecha_nac, " + "'%d/%m/%Y'" + ") as FECHA_NACIMIENTO, u.dpi as DPI, u.nit as NIT, u.direccion as DIRECCION_USUARIO" +
                ", u.correo as CORREO, u.no_telelefono as TELEFONO, u.contrasena AS CONTRASEÑA FROM usuario u JOIN clinica cl on u.id_clinica = cl.id_clinica where   CONCAT(u.nombre_usuario, ' ', u.apellido_usuario) like  '%"+ nombre+ "%' ;", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }



        [WebMethod]
        public String WSinsert_Usuario( int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono, int contrasena)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = CadenaConexion;
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into usuario(id_clinica,nombre_usuario,apellido_usuario,fecha_nac,dpi,nit,direccion,correo,no_telelefono,contrasena)values('" + id_clinica + "','" + nombre_usuario + "','" + apellido_usuario + "','" + fecha_nac + "','" + dpi + "','" + nit + "','" + direccion + "','" + correo + "','" + no_telelefono + "','" + contrasena + "')";
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
        public void Actualizar_Usuario(int id_usuario, int id_clinica, string nombre_usuario, string apellido_usuario, string fecha_nac, string dpi, int nit, string direccion, string correo, int no_telelefono, int contrasena)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update usuario set id_clinica = '"+ id_clinica+"' ,nombre_usuario = '" + nombre_usuario + "' , apellido_usuario = '" + apellido_usuario + "' , fecha_nac = '" + fecha_nac + "' ,dpi = '" + dpi + "' ,nit ='" + nit + "' ,direccion = '" + direccion + "' ,correo = '" + correo + "' ,no_telelefono = '" + no_telelefono + "', contrasena = '"+contrasena+"' where id_usuario ='" + id_usuario+"'";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /*
         * **********************************************
         * *                CLINICA                   * *
         * **********************************************
         * */

        [WebMethod]
        public DataSet WSselect_Clinica()
        {

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT cl.id_clinica, cl.nombre_clinica, cl.direccion, cl.correo, cl.no_telelefono"+
                ", cl.nit FROM clinica cl; ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        [WebMethod]
        public String WSinsert_Clinica(int id_clinica, string nombre_clinica,string direccion, string correo, int no_telelefono, int nit)
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
        public void WSBorrar_Clinica(int id_clinica)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from clinica where id_clinica = " + id_clinica;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        [WebMethod]
        public void WSActualizar_Clinica(int id_clinica, string nombre_clinica, string direccion, string correo, int no_telelefono, int nit)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = CadenaConexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update clinica set nombre_clinica = '" + nombre_clinica + "' , direccion = '" + direccion + "' , correo = '" + correo + "' , no_telelefono = '" + no_telelefono + "' ,nit ='" + nit + "' where id_clinica =" + id_clinica;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}
