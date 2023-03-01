using QuarzoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace QuarzoDataAccess
{
    public class ProductAccess : Connection
    {
        public List<Product> GetProductsByCategory(int category)
        {
            var products = new List<Product>();
            Connect();
            try
            {
                var command = new SqlCommand("Usp_Sel_Co_Productos",connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@pIdCategoria", category));
                var rows = command.ExecuteReader();
                while (rows.Read())
                {
                    products.Add(new Product()
                    {
                        Id = int.Parse(rows[0].ToString()),
                        Name = rows[1].ToString(),
                        Price = double.Parse(rows[2].ToString()),
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
            return products;
        }
    }
}
