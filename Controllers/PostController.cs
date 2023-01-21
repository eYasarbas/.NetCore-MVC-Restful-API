using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;
using WebAPIApp.Service;

namespace WebAPIApp.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postservice;
        public PostController(IPostService postservice)
        {
            _postservice = postservice;
        }
        [HttpPost]

        public ActionResult Create(Posts posts)
        {
            var response = _postservice.Create(posts);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            //logic işlemler
            var response = _postservice.GetPost(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _postservice.GetAll();
            return Ok(response);
        }
    }
}