using AutoMapper;
using Domain.DomainServices;
using Domain.Models;
using EntitiesDTOs;
using Experienza.Application.Contracts;

namespace Experienza.Application.AplicationServices
{
    public class BooksAppServices : IBooksAppServices
    {
        #region Properties
        private readonly IRepository<Book> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region Builders
        public BooksAppServices(IRepository<Book> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<BookDTO>> GetAsync()
        {
            IEnumerable<BookDTO> result = _mapper.Map<IEnumerable<BookDTO>>(await _repository.GetAsync());
            return result;
        }
        #endregion

    }
}
