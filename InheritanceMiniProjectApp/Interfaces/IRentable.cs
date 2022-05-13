namespace InheritanceMiniProjectApp.Interfaces
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}