using MySqlConnector;
using PruebaAplicacionPedidos.Data;
using PruebaAplicacionPedidos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAplicacionPedidos.Services
{
    internal class ServicesGrupo
    {
        public List<ModelGrupo> lstGrupos;
        public ServicesGrupo() { }


        public  List<ModelGrupo> obtenerLista()
        {
            var connection = DataConexion.obtenerConexion();
            connection.Open();
            string query = "SELECT * FROM xxxxgrup";
            var command = new MySqlCommand(query, connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstGrupos.Add(new ModelGrupo
                    {
                        codigo = reader.GetString("codigo"),
                        nombre = reader.GetString("nombre"),
                        tipo = reader.GetString("tipo"),
                        librecnt = reader.GetFloat("librecnt"),
                        librecto = reader.GetFloat("librecto"),
                        acumula = reader.GetInt32("acumula")
                    });
                }
            }
            return lstGrupos;
        }
    }
}
