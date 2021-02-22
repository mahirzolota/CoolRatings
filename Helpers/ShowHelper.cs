using CoolRatings.Interfaces;
using CoolRatings.Models;
using CoolRatings.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Helpers
{
    public class ShowHelper : IShowInterface
    {
        private readonly DBContext dBContext;

        public ShowHelper(DBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<ShowModel> GetAllShows()
        {
          return dBContext.showModels.Include(x=>x.Type).Include(y=>y.Ratings).ToList();
        }
        public List<ShowViewModel> GetShowsByRating(int rating)
        {
            List<ShowViewModel> svm = new List<ShowViewModel>();
            return svm;
        }
        public List<ShowModel> GetShowsByType(int type)
        {
            return dBContext.showModels.Where(x => x.Type.Code == type).ToList();
        }

        public void UpdateRating(int showId, int rating)
        {
            ShowModel sm = new ShowModel();
            sm = dBContext.showModels.Where(x => x.Id == showId).FirstOrDefault();
            sm.Ratings.Add(new RatingsModel { isUser = false, Rating = rating }
            );
            dBContext.Update(sm);
            dBContext.SaveChanges();
        }

    }
}
