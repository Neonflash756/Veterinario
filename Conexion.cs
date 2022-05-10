using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306;");
        }

        public Boolean loginVeterinario(String DNI, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM usuario WHERE DNI = @DNI AND Pass = @pass", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@pass", pass);

                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return true;
                }

                conexion.Close();
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }

        }

        public String insertaUsuario(String DNI, String Nombre, String Pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO usuario (id, DNI, Nombre, Pass) VALUES (NULL, @DNI, @Nombre, @Pass)", conexion);
                consulta.Parameters.AddWithValue("@DNI", DNI);
                consulta.Parameters.AddWithValue("@Nombre", Nombre);
                consulta.Parameters.AddWithValue("@Pass", Pass);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public String insertaCliente(String DNI, String Nombre, String Tel)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO cliente (id_cliente, DNI_cliente, Nombre_cliente, Telefono) VALUES (NULL, @DNI_cliente, @Nombre_cliente, @Telefono)", conexion);
                consulta.Parameters.AddWithValue("@DNI_cliente", DNI);
                consulta.Parameters.AddWithValue("@Nombre_cliente", Nombre);
                consulta.Parameters.AddWithValue("@Telefono", Tel);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Cliente registrado con éxito";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }

        public String insertaMascota(String Nombre, String Raza, String Edad)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("INSERT INTO mascota (id_mascota, nombre, raza, edad) VALUES (NULL, @nombre, @raza, @edad)", conexion);
                consulta.Parameters.AddWithValue("@nombre", Nombre);
                consulta.Parameters.AddWithValue("@raza", Raza);
                consulta.Parameters.AddWithValue("@edad", Edad);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Mascota registrada con éxito";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }


    }
}
