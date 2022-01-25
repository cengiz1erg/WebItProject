using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebItProject.Extensions;
using WebItProject.Models.Identity;
using WebItProject.ViewModels;

namespace WebItProject.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class UserApiController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;

        public UserApiController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetUsers(DataSourceLoadOptions loadOptions)
        {
            //var users = _userManager.Users.OrderBy(user => user.CreatedDate).ToList();
            var data = _userManager.Users;

            //return Ok(users);
            //return Ok(new JsonResponseViewModel()
            //{
            //    Data = users
            //});
            return Ok(DataSourceLoader.Load(data, loadOptions));
        }

        [HttpGet]
        public IActionResult GetTest()
        {
            var users = new List<UserProfileViewModel>();
            for (int i = 0; i < 10000; i++)
            {
                users.Add(new()
                {
                    Email = "Deneme" + i,
                    Surname = "soyad" + i,
                    Name = "ad" + i
                });
            }

            //return Ok(users);

            return Ok(new JsonResponseViewModel()
            {
                Data = users
            });
        }
    }
}
