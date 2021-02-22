using CoolRatings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.ViewModels
{
    public class ShowViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string CoverImage { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public List<CastModel> Cast { get; set; }

        public int Type { get; set; }

        public decimal Ratings { get; set; }

    }
}
