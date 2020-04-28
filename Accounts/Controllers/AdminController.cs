using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Accounts.Models;
using Accounts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Accounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration configuration;

        private readonly IAccount _repo;
        public AdminController(IAccount repo, IConfiguration configuration)
        {
            this.configuration = configuration;
            _repo = repo;
        }
        [HttpPost]
        [Route("SellerRegister")]
        public IActionResult SellerRegister(Seller seller)
        {
            try
            {
                _repo.SellerRegister(seller);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        //[HttpGet]
        //[Route("logins/{name}/{pass}")]
        //public IActionResult SellerLogin(string name, string pass)
        //{
        //    Tokens token = null;
        //    try
        //    {
        //        Seller seller = _repo.SellerLogin(name, pass);
        //        if (seller != null)
        //        {
        //            token = new Tokens() { sellerid = seller.Id, token = GenerateJwtToken(name), message = "success" };
        //        }
        //        //return Ok(_repo.BuyerLogin(username, password));
        //        else
        //        {
        //            token = new Tokens() { token = null, message = "Unsucess" };
        //        }
        //        return Ok(token);
        //    }
        //    catch (Exception e)
        //    {
        //        return NotFound(e.Message);
        //    }
        //}
    }
}