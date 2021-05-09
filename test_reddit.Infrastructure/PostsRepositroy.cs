using System.Collections.Generic;
using test_reddit.Domain;
using test_reddit.Domain.Models;

namespace test_reddit
{
    ///to do use reddit api

    public class PostsRepositroy : IPostsRepositroy
    {
        public IList<Post> GetPosts(string subreddit, int take, int skip)
        {
            throw new System.NotImplementedException();
        }

    }
}
