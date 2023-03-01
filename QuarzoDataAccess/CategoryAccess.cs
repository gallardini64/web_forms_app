using QuarzoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuarzoDataAccess
{
    public class CategoryAccess : Connection
    {
        public List<Category> GetCategories()
        {
            var categories = new List<Category>();
            Connect();
            try
            {
                var command = new SqlCommand("Usp_Sel_Co_Categorias",connection);
                command.CommandType = CommandType.StoredProcedure;
                var rows = command.ExecuteReader();
                while (rows.Read())
                {
                    categories.Add(new Category()
                    {
                        Id = int.Parse(rows[0].ToString()),
                        Description = rows[1].ToString(),
                        Activo = bool.Parse(rows[2].ToString()),
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Disconnect();
            }
            return categories;
        }

        public void CreateCategory(string description, bool active)
        {
            Connect();
            try
            {
                var command = new SqlCommand("Usp_Ins_Co_Categoria", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pDescription", description));
                command.Parameters.Add(new SqlParameter("@pEsActiva", active));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Disconnect();
            }
        }

        public void UpdateCategory(int id, string description, bool active)
        {
            Connect();
            try
            {
                var command = new SqlCommand("Usp_Upd_Co_Categoria", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pId", id));
                command.Parameters.Add(new SqlParameter("@pDescription", description));
                command.Parameters.Add(new SqlParameter("@pEsActiva", active));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
