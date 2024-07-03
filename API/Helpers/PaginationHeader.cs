namespace API.Helpers
{
  public class PaginationHeader
  {
    private int _currentPage;
    private int _totalCount;
    private int _totalPages;

    public PaginationHeader(int currentPage, int totalCount, int totalPages)
    {
      _currentPage = currentPage;
      _totalCount = totalCount;
      _totalPages = totalPages;
    }

    public PaginationHeader(int currentPage, int itemsPerPage, int totalItems, int totalPages)
    {
      CurrentPage = currentPage;
      ItemsPerPage = itemsPerPage;
      TotalItems = totalItems;
      TotalPages = totalPages;
    }

    public int CurrentPage { get; set; }
    public int ItemsPerPage { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
  }
}