using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolRatings.Interfaces;
using CoolRatings.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoolRatings.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingInterface _ratingInterface;
        public RatingController(IRatingInterface ratingInterface)
        {
            _ratingInterface = ratingInterface;
          
        }
        [HttpGet]
        public ActionResult<IEnumerable<RatingsModel>> GetratingsModels()
        {
            return _ratingInterface.GetratingsModels();
        }

        [HttpPost]
        public void PostRatingsModel([FromBody] RatingsModel ratingsModel)
        {
            _ratingInterface.PostRatingsModel(ratingsModel);
        }
    }
}
