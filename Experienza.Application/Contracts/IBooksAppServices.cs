using EntitiesDTOs;

namespace Experienza.Application.Contracts
{
    public interface IBooksAppServices
    {
        Task<IEnumerable<BookDTO>> GetAsync();
    }
}
