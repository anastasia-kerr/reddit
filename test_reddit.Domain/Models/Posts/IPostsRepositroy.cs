using System.Collections.Generic;
using test_reddit.Domain.Models;
using test_reddit.Domain.SeedWork;

namespace test_reddit.Domain
{
    public interface IPostsRepositroy : IRepository<Post>
    {
        IList<Post> GetPosts(string subreddit, int take, int skip);
    }
}
