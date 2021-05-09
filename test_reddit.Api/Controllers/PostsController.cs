using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using test_reddit.Domain.Services;
using test_reddit.Domain.Models;

namespace test_reddit.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger, IPostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        [HttpGet]
        public IEnumerable<Post> Get(int? take, int? skip)
        {
            try
            {
                return _postService.GetPosts(take, skip);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + "Some meaningful details");
                return null;
            }
        }
    }
}