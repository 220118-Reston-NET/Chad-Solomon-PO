
namespace PokeModel
{
    public class Customer
    {

        public string? _name { get; set; }
        public string? _address { get; set; }
        public string? _email { get; set; }


        private List<Order> _orders;
        //Above is a field and below is the property
        public List<Order> Orders
        {
            get { return _orders; }

            set
            {

            }
        }



        public Customer()
        {

            _name = "No Name";
            _address = "No Address";
            _email = "No Email";
            // _orders = new List<Orders>();

        }
    }
}
