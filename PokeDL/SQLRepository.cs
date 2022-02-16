using System.Data.SqlClient;
using PokeModel;
namespace PokeDL
{
    public class SQLRepository : IRepository
    {
        private readonly string _connectionStrings;
        public SQLRepository(string p_connectionStrings)
        {

            _connectionStrings = p_connectionStrings;
        }
        public Customer AddCustomer(Customer c_customer)
        {
            string sqlQuery = @"insert into Customer values (@custName, @custAddress, @custEmail)";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@custName", c_customer.Name);
                command.Parameters.AddWithValue("@custAddress", c_customer.Address);
                command.Parameters.AddWithValue("@custEmail", c_customer.Email);
                //command.Parameters.AddWithValue("@custName", c_customer);

                command.ExecuteNonQuery();

                return c_customer;
            }

        }

        // public Leashes AddLeashes(Leashes c_Leash)
        // {
        //     string sqlQuery2 = @"insert into Leashes values (@leashName, @leashColor, @leashSize, @leashStyle, @leashPrice)";

        //     using (SqlConnection con2 = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
        //     {
        //         con2.Open();

        //         SqlCommand command = new SqlCommand(sqlQuery2, con2);
        //         command.Parameters.AddWithValue("@leashName", c_Leash.Name);
        //         command.Parameters.AddWithValue("@leashColor", c_Leash.Color);
        //         command.Parameters.AddWithValue("@leashSize", c_Leash.Size);
        //         command.Parameters.AddWithValue("@leashStyle", c_Leash.Style);
        //         command.Parameters.AddWithValue("@leashPrice", c_Leash.Price);

        //         command.ExecuteNonQuery();

        //         return c_Leash;
        //     }



        // }

        // public List<Leashes> GetAllLeashes()
        // {
        //     List<Leashes> listOfLeashes = new List<Leashes>();

        //     string sqlQuery2 = @"select * from Leashes";

        //     using (SqlConnection con2 = new SqlConnection("Server=tcp:furrbabies.database.windows.net,1433;Initial Catalog=Furr-Babbies-Pet-Supply;Persist Security Info=False;User ID=FurrBabies;Password=RheaandLdog1$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
        //     {
        //         con2.Open();

        //         SqlCommand command = new SqlCommand(sqlQuery2, con2);

        //         SqlDataReader reader = command.ExecuteReader();

        //         while (reader.Read())
        //         {
        //             listOfLeashes.Add(new Leashes()
        //             {
        //                 ID = reader.GetInt32(0),
        //                 Name = reader.GetString(1),
        //                 Color = reader.GetString(2),
        //                 Size = reader.GetString(3),
        //                 Style = reader.GetString(4),
        //                 Price = reader.GetInt32(5)
        //             });


        //         }
        //     }
        //     return listOfLeashes;
        // }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> listOfCustomers = new List<Customer>();

            string sqlQuery = @"select * from Customer";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomers.Add(new Customer()
                    {
                        _custID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Email = reader.GetString(3)
                    });


                }
            }
            return listOfCustomers;
        }

    }
}