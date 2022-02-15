using System.Data.SqlClient;
using PokeModel;


namespace PokeDL
{
    public class SQLOrderRepository : IOrderRepo
    {

        public void AddOrder(int _orderLocation, int _price, int _custID)
        {

            //First we need setup a sqlQuery
            // and establish a connection

            //SQL like query statement we want to insert into the order table these values
            string sqlQuery = @"insert into Orders
            Values (@orderLoaction, @orderPrice, @custID)";

            string sqlQuery1 = @"insert into LineItems values (@prodID, @orderID, @Quantity)";

            string sqlQuery2 = @"update StoreInventory set Quantity = Quantity where storeID = storeID and prodID = prodID";


            //To connect we use a using block
            //implementing the SqlConnection class
            //which connects us to the sql database
            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                //this keeps the connection open
                con.Open();

                //map out which values we want to add to the Order table in connectionwith order model in c#
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@orderLocation", _orderLocation);
                command.Parameters.AddWithValue("@custID", _custID);
                command.Parameters.AddWithValue("@orderPrice", _price);

                //what will execute the above commands
                command.ExecuteNonQuery();

                //return c_order;

            }


        }

        //public int Calculate

        public List<Order> SearchOrder(int orderID)
        {
            List<Order> listOfOrder = GetOrder();

            string sqlQuery = @"select * from Orders where orderID = orderID";

            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);


                command.ExecuteNonQuery();
            }

            foreach (var order in listOfOrder)
            {
                Console.WriteLine(order);
            }

            return listOfOrder;

        }

        public List<Order> GetOrder()
        {
            List<Order> listOfOrder = new List<Order>();

            string sqlQuery = @"select * from Orders";

            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {

                SqlCommand command = new SqlCommand(sqlQuery, con);

                //SqlDataReader is like the middle man between SQL and C#
                //Since SQL only understands table and c# only understands objects and classes

                SqlDataReader reader = command.ExecuteReader();
                //setting the condition of the while loop to say 
                //as long as there is data to still be read keep reading it
                while (reader.Read())
                {

                    listOfOrder.Add(new Order()
                    {

                        OrderID = reader.GetInt32(0),
                        _storeID = reader.GetInt32(1),
                        TotalPrice = reader.GetInt32(2),
                        _custID = reader.GetInt32(3)
                    });
                }
            }

            return listOfOrder;

        }


        public void AddLineItems(LineItems _item)
        {

            string sqlQuery = @"insert into LineItems values (@prodID, @orderID, @Quantity)";

            using (SqlConnection con = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {

                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@prodID", _item.Product);
                command.Parameters.AddWithValue("@orderID", _item._orderID);
                command.Parameters.AddWithValue("@Quantity", _item.Quantity);

                command.ExecuteNonQuery();


            }
        }

    }
}