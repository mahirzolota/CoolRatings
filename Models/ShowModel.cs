
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Models
{
    public class ShowModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string CoverImage { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<CastModel> Cast { get; set; }

        public TypeModel Type { get; set; }

        public List<RatingsModel> Ratings { get; set; }


    }
}
