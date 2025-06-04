namespace NET_CORE_9_Management_Systems.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string? InventoryName { get; set; }
        public string? InventoryDescription { get; set; }
        public List<string>? InventoryMediaLinks { get; set; }
        public double? InventoryPrice { get; set; }
        public int? InventoryQuantity { get; set; }
        public string? InventoryCategory { get; set; }
        public string? InventoryDepartment { get; set; }
        public string? InventorySupplier { get; set; }
        public string? InventoryLocation { get; set; }
        public string? InventoryStatus { get; set; }
        public string? InventoryManufacturer { get; set; }

    }
}
