using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentHubAPI.Controllers
{
    //https://localhost:7157/api/BlogPost
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBlogPosts()
        {
            var posts = new string[] { "Blog1", "Blog2", "Blog3" };
            return Ok(posts);
        }
    }
}
