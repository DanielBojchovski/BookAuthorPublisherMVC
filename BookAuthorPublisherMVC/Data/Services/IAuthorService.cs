using BookAuthorPublisherMVC.Models;

namespace BookAuthorPublisherMVC.Data.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author actor);
        Task<Author> UpdateAsync(int id, Author newActor);
        Task DeleteAsync(int id);
    }
}
