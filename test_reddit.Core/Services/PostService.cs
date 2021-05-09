using Microsoft.Extensions.Options;
using System.Collections.Generic;
using test_reddit.Domain.Models;

namespace test_reddit.Domain.Services
{
    public class PostService : IPostService
    {
        private readonly IPostsRepositroy _postsRepostiry;
        private readonly string _subredditName;
        private static int defaultNumberOfPost=100;

        public PostService(IPostsRepositroy postsRepostiry, IOptions<GlobalSettings> settings)
        {
            _subredditName = settings.Value.SubRedditName;
            _postsRepostiry = postsRepostiry;
        }

        public IList<Post> GetPosts(int? take, int? skip = 0)
        {
            if (take is null || take == 0)
            {
                take = defaultNumberOfPost;
            }
            return _postsRepostiry.GetPosts(_subredditName, (int)take, (int)skip);
        }
    }
}
