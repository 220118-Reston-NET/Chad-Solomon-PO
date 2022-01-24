using ProductsInformation;
namespace StoreFrontInformation
{

    public class StoreFront
    {
        public string _storeName { get; set; }
        public string _storeAddress { get; set; }

        private List<Product> _products;
        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public StoreFront()
        {
            _storeName = "Furr Babies";
            _storeAddress = "321 Bepop Place, East Tennessee 33345";
            //_products = new List<ProductsInformation>();
        }


    }
}