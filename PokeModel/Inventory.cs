namespace PokeModel
{
    public class Inventory
    {
        public int _productID;

        private string _storeName;

        public string StoreName
        {

            get { return _storeName; }
            set { _storeName = value; }
        }

        private string _prodName;
        public string ProdName
        {

            get { return _prodName; }
            set { _prodName = value; }

        }

        private int _quantity;
        public int Quantity
        {

            get { return _quantity; }
            set { _quantity = value; }

        }
        public int _storeID;

        private string _description;
        public string Description
        {

            get { return _description; }
            set { _description = value; }

        }

        public override string ToString()
        {
            // return $"Store ID: {_storeID}\nProduct ID: {_productID}\nQuantity: {Quantity}\n";
            return $"Store Name: {StoreName}\nProduct Name: {ProdName}\nProduct ID: {_productID}\nDescription: {Description}\nQuantity: {Quantity}\n";
        }


    }
}