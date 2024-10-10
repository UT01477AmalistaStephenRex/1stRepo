namespace WebApplication1.DTO.Reports
{
    public class InventoryReportResponse
    {
        public List<BookInventoryInfo> Books { get; set; }
    }

    public class BookInventoryInfo
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}
