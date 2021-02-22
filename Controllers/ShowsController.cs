using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolRatings.Helpers;
using CoolRatings.Interfaces;
using CoolRatings.Models;
using CoolRatings.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoolRatings.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private static ShowModel ShowModel = new ShowModel();
        private readonly IShowInterface _showInterface;

        public ShowsController(IShowInterface showInterface)
        {
            _showInterface = showInterface;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //TODO:
            List<ShowModel> ls = new List<ShowModel>();
            ls = _showInterface.GetAllShows();
            List<ShowViewModel> svm = new List<ShowViewModel>();
            foreach(var item in ls)
            {
                svm.Add(new ShowViewModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    Tags = item.Tags,
                    CoverImage = item.CoverImage,
                    Description = item.Description,
                    Type = item.Type.Code,
                    Ratings = CommonHelper.GetAvrRating(item.Ratings),
                    Cast = item.Cast
                });
            }
            return Ok(svm);
        }
    
    }
}
