namespace PokeModel
{


    public class Order
    {
        public string _product { get; set; }
        public int _quantity { get; set; }


        public Order()
        {

            _product = "None";
            _quantity = 0;
        }
    }
}