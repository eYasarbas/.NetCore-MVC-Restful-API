using WebAPIApp.Models;

namespace WebAPIApp.Service
{
    public interface IPostService
    {
        Posts Create(Posts posts);
        Posts GetPost(int id);

        List<Posts> GetAll();
    }
}