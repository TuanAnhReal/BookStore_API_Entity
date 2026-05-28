using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore_API_Entity.Services
{
    public interface IBookApiClient
    {
        Task<List<BookViewModel>> GetBooks();
    }
}
