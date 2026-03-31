using System;
using Microsoft.Data.SqlClient;

namespace AnimeCrudPro
{
    public partial class AnimeRepository
    {
        public void Crear(Anime anime)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Animes (Titulo, Episodios) VALUES (@Titulo, @Episodios)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", anime.Titulo);
                    cmd.Parameters.AddWithValue("@Episodios", anime.Episodios);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}