namespace SmartSchoolAPI.Helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int ItemsPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public PaginationHeader(int currentPage, int itemsPage, int totalItems, int totalPages)
        {
            CurrentPage = currentPage;
            ItemsPage = itemsPage;
            TotalItems = totalItems;
            TotalPages = totalPages;
        }
    }
}
