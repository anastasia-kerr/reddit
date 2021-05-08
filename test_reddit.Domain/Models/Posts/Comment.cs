using System.Collections.Generic;
using test_reddit.Domain.SeedWork;

namespace test_reddit.Domain.Models
{
    public class Comment : ValueObject
    {
        public Comment() { }
        public Comment(Author commentAuthor, string text)
        {
            CommentAuthor = commentAuthor;
            Text = text;
        }

        public Author CommentAuthor { get; private set; }
        
        public string Text { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CommentAuthor;
            yield return Text;
        }
    }
}