using Lab3_NgoHuuTai_2087700051.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab3_NgoHuuTai_2087700051.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        
    }
}
