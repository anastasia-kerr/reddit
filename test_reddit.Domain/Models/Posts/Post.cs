using test_reddit.Domain.SeedWork;

namespace test_reddit.Domain.Models
{
    public class Post : IAggregateRoot
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Author PostAuthor { get; set; }
        public Comment PostComment { get; set; }

    }
}
