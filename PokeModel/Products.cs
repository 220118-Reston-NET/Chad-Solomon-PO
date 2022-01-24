namespace ProductsInformation
{

    public class Product
    {
        public string _productName { get; set; }
        public int _productPrice { get; set; }
        public string _productDescription { get; set; }
        public string _productCategory { get; set; }


        public Product()
        {
            _productName = "None";
            _productPrice = 0;
            _productDescription = "None";
            _productCategory = "None";

        }

    }


}