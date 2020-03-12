using System.Collections.Generic;
using System.Linq;

namespace GenericsIntro
{
  public class Pager<T>
  {
    public int ItemsPerPage { get; set; }
    public int PageNumber { get; set; }
    public List<T> AllItems { get; set; }

    public List<T> GetPage()
    {
      return AllItems
      .Skip(ItemsPerPage * PageNumber)
      .Take(ItemsPerPage)
      .ToList();
    }
  }
}