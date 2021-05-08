using System.Collections.Generic;
using test_reddit.Domain;
using test_reddit.Domain.Models;

namespace test_reddit
{         
    ///to do use reddit api

    public class PostsRepositroy : IPostsRepositroy
    {
        IList<Post> IPostsRepositroy.GetPosts(int subreddit)
        {
            return new List<Post>();
        }
    }
}
