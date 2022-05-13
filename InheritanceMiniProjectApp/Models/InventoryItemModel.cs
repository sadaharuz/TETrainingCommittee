using InheritanceMiniProjectApp.Interfaces;

namespace InheritanceMiniProjectApp.Models
{
    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
    }
}