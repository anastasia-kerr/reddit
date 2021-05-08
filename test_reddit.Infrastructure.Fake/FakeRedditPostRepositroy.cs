using Bogus;
using System.Collections.Generic;
using System.Linq;
using test_reddit.Domain;
using test_reddit.Domain.Models;

namespace test_reddit.Infrastructure.Fake
{
    public class FakeRedditPostRepositroy : IPostsRepositroy
    {

        public IList<Post> GetPosts(string subreddit, int take, int skip)
        {
            var testBlogPosts = new Faker<Post>()
            .RuleFor(bp => bp.Text, f => f.Lorem.Paragraphs())
            .RuleFor(bp => bp.Title, f => f.Lorem.Sentence(10))
            .RuleFor(bp => bp.PostComment, f => new Comment(new Author(f.IndexFaker, f.Name.FullName()), f.Lorem.Sentence(10)))
            .RuleFor(bp => bp.PostAuthor, f => new Author(f.IndexFaker, f.Name.FullName()));

            var result = testBlogPosts.Generate(take + skip);
            return result.Take(take).ToList();
        }
    }
}
