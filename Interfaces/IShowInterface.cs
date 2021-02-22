
using CoolRatings.Models;
using CoolRatings.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Interfaces
{
    public interface IShowInterface
    {
        List<ShowModel> GetAllShows();

        List<ShowModel> GetShowsByType(int type);

        List<ShowViewModel> GetShowsByRating(int rating);

        void UpdateRating(int showId, int rating);


    }
}
