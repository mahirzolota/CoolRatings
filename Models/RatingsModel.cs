using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Models
{
    public class RatingsModel 
    {
        public int Id { get; set; }
        public bool isUser { get; set; }
        public int Rating { get; set; }
        public int? UserId { get; set; }
        public virtual UserModel User { get; set; }

        public int ShowModelId { get; set; }

        public virtual ShowModel ShowModel { get; set; }

    }
}
