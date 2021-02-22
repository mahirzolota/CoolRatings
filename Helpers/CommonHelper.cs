using CoolRatings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Helpers
{
    public static class CommonHelper
    {

        public static decimal GetAvrRating(List<RatingsModel> rm)
        {
            List<int> brojac = new List<int>();
            foreach (var r in rm)
            {
                brojac.Add(r.Rating);
            }
            if (brojac.Count > 0)
            {
                return brojac.Sum() / brojac.Count;
            }
            else
            {
                return 0;
            }

        }
    }
}
