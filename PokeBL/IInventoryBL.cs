using PokeModel;
namespace PokeBL
{
    public interface IInventoryBL
    {

        public void AddInventory(int _productID);

        public List<Inventory> SearchInventory(int p_id);

        //     public List<Inventory> GetAllInventory();
    }







}