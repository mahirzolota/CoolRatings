using CoolRatings.Interfaces;
using CoolRatings.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Helpers
{
    public class RatingHelper : IRatingInterface
    {
        private readonly DBContext _context;

        public RatingHelper(DBContext context)
        {
            _context = context;
        }

        public ActionResult<IEnumerable<RatingsModel>> GetratingsModels()
        {
            return _context.ratingsModels.ToList();
        }

        public void PostRatingsModel([FromBody] RatingsModel ratingsModel)
        {
            _context.ratingsModels.Add(ratingsModel);
            _context.SaveChanges();
        }
    }
}
