namespace BrowserProfileLauncher.Application.Models
{
    public class PaginationModel
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int IndexFrom { get; set; }
    }
}
