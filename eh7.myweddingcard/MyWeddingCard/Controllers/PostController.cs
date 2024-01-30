using Microsoft.AspNetCore.Mvc;
using MyWeddingCard.Models;
using MyWeddingCard.Repositorys;

using System.Diagnostics;

namespace MyWeddingCard.Controllers
{
    [ApiController]
    [Route("post")]
    public class PostController : Controller
    {
        private IPostRepository postRepository;

        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet]
        public ActionResult<List<Post>> GetAllPosts()
        {
            return postRepository.findAllPosts();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Post> GetPost(int id)
        {
            Post post = postRepository.findPost(id);
            if (post == null)
            {
                return new NotFoundResult();
            }

            return postRepository.findPost(id);
        }

        [HttpPost]
        public ActionResult<Post> Post(Post post)
        {
            return postRepository.post(post);
        }

        [HttpDelete]
        public ActionResult DeletePost(int id)
        {
            Post post = postRepository.findPost(id);
            if (post != null)
            {
                return new NotFoundResult();
            }

            return NoContent();
        }
    }
}
