using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace juefi2.Models.BD
{
    public class conecMysql
    {

        private static MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public Boolean Conectar()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static void Desconectar()
        {
            conexion.Close();
        }




        public DataTable EjecutarConsulta(string sentencia, CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = new MySqlCommand(sentencia, conexion);
            adaptador.SelectCommand.CommandType = TipoComando;

            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);

            return resultado.Tables[0];
        }

        public bool EjecutarSql(String sql, CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = new MySqlCommand(sql, conexion);
            adaptador.SelectCommand.CommandType = TipoComando;
            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);

            if (resultado.Tables.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool GuardarArchivo(string cadena, HttpPostedFile file)
        {
            //cmd.CommandText = "INSERT INTO imagenes(Nombre, Image) VALUES (@Nombre, @imgArr)";
            //cmd.Parameters.AddWithValue("@imgArr", doc);

            if (!Conectar()) return false;
            try
            {
                byte[] doc = new byte[file.InputStream.Length];
                file.InputStream.Read(doc, 0, doc.Length);

                using (MySqlConnection conn = conexion)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = cadena;
                        cmd.Parameters.AddWithValue("@doc", doc);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Desconectar();
                return true;
            }
            Desconectar();
            return true;
        }

        public bool Guardarimagen(string cadena, HttpPostedFile file)
        {
            //cmd.CommandText = "INSERT INTO imagenes(Nombre, Image) VALUES (@Nombre, @imgArr)";
            //cmd.Parameters.AddWithValue("@imgArr", doc);

            if (!Conectar()) return false;
            try
            {
                byte[] doc = new byte[file.InputStream.Length];
                file.InputStream.Read(doc, 0, doc.Length);

                using (MySqlConnection conn = conexion)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = cadena;
                        cmd.Parameters.AddWithValue("@doc", file);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Desconectar();
                return true;
            }
            Desconectar();
            return true;
        }


        public void listarimagen(Repeater rper)
        {

            MySqlConnection conn = conexion;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT Imagen  FROM ubicacion  order by idUbicacion ;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            DataTable ImagenesBd = new DataTable();

            ImagenesBd.Load(cmd.ExecuteReader());
            rper.DataSource = ImagenesBd;
            rper.DataBind();
            conn.Close();

        }



    }
}