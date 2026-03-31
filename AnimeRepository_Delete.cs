using System;
using Microsoft.Data.SqlClient;

namespace AnimeCrudPro
{
    public partial class AnimeRepository
    {
        public bool Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Query para borrar por ID
                string query = "DELETE FROM Animes WHERE Id = @Id";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    
                    conn.Open();
                    // ExecuteNonQuery devuelve cuántas filas se borraron
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    
                    // Si es mayor a 0, significa que el ID existía y se borró
                    return filasAfectadas > 0;
                }
            }
        }
    }
}