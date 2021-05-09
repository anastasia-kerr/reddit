using System.Collections.Generic;
using test_reddit.Domain.Models;

namespace test_reddit.Domain.Services
{
    public interface IPostService
    {
        IList<Post> GetPosts(int? take, int? skip);
    }
}
