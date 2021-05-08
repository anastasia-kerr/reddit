using NUnit.Framework;
using test_reddit.Domain;

namespace test_reddit.Tests
{
    public class Tests
    {
        private IPostsRepositroy _repository;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void get_posts_for_subreddit()
        {
            _repository = new PostsRepositroy();
            var result = _repository.GetPosts(9);
            Assert.Equals(result, null);
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