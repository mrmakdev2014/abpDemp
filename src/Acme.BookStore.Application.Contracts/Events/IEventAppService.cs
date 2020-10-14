using Acme.BookStore.Events;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IEventAppService :
        ICrudAppService< //Defines CRUD methods
            EventDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEventDto> //Used to create/update a book
    {
      
    }
}