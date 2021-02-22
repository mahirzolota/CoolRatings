using CoolRatings.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolRatings.Interfaces
{
    public interface IRatingInterface
    {
        public ActionResult<IEnumerable<RatingsModel>> GetratingsModels();

        public void PostRatingsModel([FromBody] RatingsModel ratingsModel);
    }
}
