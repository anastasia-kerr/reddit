using NUnit.Framework;
using test_reddit.Domain;
using test_reddit.Domain.Services;

namespace test_reddit.Tests
{
    public class Tests
    {
        private IPostService _postsService;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void get_posts_for_subreddit()
        {
            var numberOfPosts = 9;
            _postsService = new PostService(null,null);
            var result = _postsService.GetPosts(numberOfPosts, null);
            Assert.Greater(result.Count, numberOfPosts);
        }

        [Test]
        public void search_posts_for_subreddit()
        {
            Assert.Pass();
        }

        [Test]
        public void filter_posts_for_subreddit()
        {
            Assert.Pass();
        }

        [Test]
        public void view_subscribed()
        {
            Assert.Pass();
        }
    }
}