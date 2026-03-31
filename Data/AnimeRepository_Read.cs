using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace AnimeCrudPro
{
    public partial class AnimeRepository
    {
        public List<Anime> ObtenerTodos()
        {
            var lista = new List<Anime>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, Titulo, Episodios FROM Animes";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Anime
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Titulo = reader["Titulo"].ToString() ?? "",
                                Episodios = Convert.ToInt32(reader["Episodios"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}