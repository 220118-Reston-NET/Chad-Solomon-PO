using System.Data.SqlClient;
using PokeModel;
namespace PokeDL
{
    public class OrderHistRepo : IOrderHistRepo
    {
        public List<Order> GetAllOrders()
        {

            List<Order> listOfOrders = new List<Order>();

            string sqlQuery = @"select c.custName, o.orderID, o.orderLocation, o.products, o.orderPrice from Customer c inner join Customer_Order co on c.custID = co.custID inner join Orders o on o.orderID = co.orderID";


            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    listOfOrders.Add(new Order()
                    {
                        _custName = reader.GetString(0),
                        OrderID = reader.GetInt32(1),
                        _storeID = reader.GetInt32(2),
                        _listOfProducts = reader.GetString(3),
                        TotalPrice = reader.GetInt32(4)


                    });
                }


            }
            return listOfOrders;

        }

    }


}