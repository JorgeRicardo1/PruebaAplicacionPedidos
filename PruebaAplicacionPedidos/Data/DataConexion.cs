using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAplicacionPedidos.Data
{
    internal class DataConexion
    {
        

        //string connectionString = "server=" + 

        public static MySqlConnection obtenerConexion()
        {
            string server = "192.168.1.190";
            string user = "prueba";
            string pasword = "qwerty";
            string dataBase = "xxxxgrup";

            try
            {
                MySqlConnection connection = new MySqlConnection("server=" + server + ";uid=" + user + "; pwd=" + pasword + ";database=" + dataBase );
                return connection;
            }
            catch(MySqlException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

    }
}
