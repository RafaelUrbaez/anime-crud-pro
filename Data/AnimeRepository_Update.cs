using System;
using Microsoft.Data.SqlClient;

namespace AnimeCrudPro
{
    public partial class AnimeRepository
    {
        public bool Actualizar(Anime anime)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                //parámetros @ para evitar que alguien nos borre la base de datos (Inyección SQL)
                string query = "UPDATE Animes SET Titulo = @Titulo, Episodios = @Episodios WHERE Id = @Id";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", anime.Id);
                    cmd.Parameters.AddWithValue("@Titulo", anime.Titulo);
                    cmd.Parameters.AddWithValue("@Episodios", anime.Episodios);
                    
                    conn.Open();
                    // ExecuteNonQuery devuelve el número de filas afectadas
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    
                    // Si devolvió más de 0, es que el ID existía y se actualizó
                    return filasAfectadas > 0;
                }
            }
        }
    }
}