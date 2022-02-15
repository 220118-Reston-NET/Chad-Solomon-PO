using System.Data.SqlClient;
using PokeModel;
namespace PokeDL
{
    public class SQLProductRepository : IProductRepo
    {
        public Product AddProduct(Product c_product)
        {
            string sqlQuery = @"insert into Product values (@prodName, @Description, @prodPrice)";

            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@prodName", c_product.Name);
                command.Parameters.AddWithValue("@prodDescription", c_product.Description);
                command.Parameters.AddWithValue("@prodPrice", c_product.Price);

                command.ExecuteNonQuery();

                return c_product;
            }



        }

        public List<Product> GetAllProduct()
        {
            List<Product> listOfProduct = new List<Product>();

            string sqlQuery = @"select * from Product";

            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfProduct.Add(new Product()
                    {
                        _prodID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.GetString(2),
                        Price = reader.GetInt32(3)
                    });


                }
            }
            return listOfProduct;
        }
    }
}