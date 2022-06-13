using EntitiesDTOs;
using Experienza.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Experienza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        #region Properies
        private readonly IBooksAppServices _booksAppServices;

        #endregion

        #region Builders

        public BooksController(IBooksAppServices booksAppServices)
        {
            _booksAppServices = booksAppServices;
        }
        #endregion

        #region Methods
        [HttpGet]
        public async Task<IEnumerable<BookDTO>> GetAsync()
        {
            return await _booksAppServices.GetAsync();
        }

        #endregion
    }
}
