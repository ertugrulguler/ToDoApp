using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoApi.Models.Context;
using ToDoApi.Models.Entities;


namespace ToDoApi.Controllers
{
    public class UserController : ApiController
    {
        ToDoAppContext db = new ToDoAppContext();


        [HttpGet]
        public IHttpActionResult UserList()
        {
            var users = db.Users.ToList();
            return Json(users);
        }



        [HttpPost]
        public IHttpActionResult UserLogin(User user)
        {
            try
            {
                if (db.Users.Any(i=>i.Email==user.Email && i.Password==user.Password))
                {
                    return Json(user);
                    
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
           
        }


        [HttpPost]
        public IHttpActionResult UserRegister(User user)
        {

            try
            {
                db.Users.Add(user);
                if (db.SaveChanges() > 0)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
