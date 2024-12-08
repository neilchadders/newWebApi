using System.Data;
using Dapper;
using newWebAPI.Data;
using newWebAPI.Dtos;
using newWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace newWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly DataContextDapper _dapper;
        public TestController(IConfiguration config)
        {
            _dapper = new DataContextDapper(config);
        }

        [HttpGet("TestConnection")]
        public DateTime GetPosts(int postId = 0, int userId = 0, string searchParam = "None")
        {
            return _dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
        }

        [HttpGet]
        public string GetMyPosts()
        {
            return "Your application is up and runnning";
        }
    }
}