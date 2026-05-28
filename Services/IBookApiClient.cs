using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore_API_Entity.Catalog;

namespace BookStore_API_Entity.Services
{
    public interface IBookApiClient
    {
        Task<List<BookVm>> GetBooks();
    }
}
