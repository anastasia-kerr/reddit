using System.Collections.Generic;
using test_reddit.Domain.SeedWork;

namespace test_reddit.Domain.Models
{
    public class Author : ValueObject
    {
        public Author(int id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }
        public Author() { }

        public int Id { get; private set; }

        public string DisplayName { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
            yield return DisplayName;
        }
    }
}
