using WebAPIApp.Models;
using WebAPIApp.Repository;

namespace WebAPIApp.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;
        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }
        public Posts Create(Posts posts)
        {
            return _repository.Add(posts);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }
    }
}