namespace InheritanceMiniProjectApp.Interfaces
{
    public interface IInventoryItem
    {
        string ProductName { get; set; }
        int QuantityInStock { get; set; }
    }
}