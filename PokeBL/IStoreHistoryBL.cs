using PokeModel;

namespace PokeBL
{
    public interface IStoreHistory
    {
        public List<StoreOrder> SearchStoreHistory(string s_name);
    }
}