using PokeDL;
using PokeModel;

namespace PokeBL
{
    public class StoreHistoryBL : IStoreHistory
    {
        private ISQLStoreHistory _storehist;
        public StoreHistoryBL(ISQLStoreHistory s_storehsit)
        {

            _storehist = s_storehsit;
        }

        public List<StoreOrder> SearchStoreHistory(string s_name)
        {

            List<StoreOrder> listStoreOrder = _storehist.GetStoreOrder();

            return listStoreOrder
                .Where(order => order._storeName.Contains(s_name))
                .ToList();
        }




    }


}