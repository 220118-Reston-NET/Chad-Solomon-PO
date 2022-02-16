using System.Data.SqlClient;
using PokeModel;
namespace PokeDL
{
    public class OrderHistRepo : IOrderHistRepo
    {
        public List<Order> GetAllOrders(int custID)
        {

            List<Order> listOfOrders = new List<Order>();

            string sqlQuery = @"select * from Orders
                                    where custID = @custID";


            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@custID", custID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    listOfOrders.Add(new Order()
                    {

                        OrderID = reader.GetInt32(0),
                        _storeID = reader.GetInt32(1),
                        TotalPrice = reader.GetInt32(2),
                        _custID = reader.GetInt32(3)


                    });
                }


            }
            return listOfOrders;

        }

    }


}