using Microsoft.AspNetCore.Mvc;
using MPPorfolioWebsite.Data;
using MPPorfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPPorfolioWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Technologies> GetTechnologies()
        {
            return MockData.Technologies();
        }

        [HttpGet]
        public List<Testimonials> GetTestimonials()
        {
            return MockData.Testimonials();
        }
    }
}
