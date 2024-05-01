namespace Decorator
{
    public abstract class Hero
    {
        protected List<IInventory> inventories = new List<IInventory>();
        public abstract string Type();
        public void AddInventory(IInventory inventory)
        {
            inventories.Add(inventory);

        }
        public void EquipInventories()
        {
            foreach (var inventory in  inventories)
            {
                inventory.Equip();

            }
        }
    }
}
