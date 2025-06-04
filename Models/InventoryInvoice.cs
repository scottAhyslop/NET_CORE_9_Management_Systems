﻿namespace NET_CORE_9_Management_Systems.Models
{
    public class InventoryInvoice
    {
        public int InventoryInvoiceId { get; set; }
        public Inventory? InventoryItem { get; set; }
        public int? ItemsSold { get; set; }
        public double? ItemTotalSale { get; set; }
        public string? ItemInvoiceDate { get; set; }
        public string? ItemLocation { get; set; }
        public List<Customer>? ItemItemSoldTo { get; set; }
    }
}
