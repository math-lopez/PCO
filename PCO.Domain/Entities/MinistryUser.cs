using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCO.Domain.Entities
{
    public class MinistryUser : Entity
    {
        public int MinistryId { get; set; }
        public Ministry Ministry { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
