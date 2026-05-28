using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookStore_API_Entity.Catalog;

namespace BookStore_API_Entity.Services
{
    public class BookApiClient : IBookApiClient
    {
        private readonly HttpClient _httpClient;

        public BookApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BookVm>> GetBooks()
        {
            return await _httpClient.GetFromJsonAsync<List<BookVm>>("api/books");
        }
    }
}
