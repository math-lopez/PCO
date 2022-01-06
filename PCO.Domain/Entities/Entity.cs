using System;

namespace PCO.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
