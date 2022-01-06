using System.Collections.Generic;

namespace PCO.Domain.Entities
{
    public class Ministry : Entity
    {
        public string Name { get; set; }
        public bool External { get; set; }
        public int MinitryId { get; set; }
        public ICollection<MinistryUser> MinistriesUsers { get; set; }
    }
}
