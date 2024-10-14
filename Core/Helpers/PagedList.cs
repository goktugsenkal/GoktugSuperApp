namespace Core.Helpers;

public class PagedList<T>
{
    public List<T> items { get; set; }
    public int Skip { get; set; }
}