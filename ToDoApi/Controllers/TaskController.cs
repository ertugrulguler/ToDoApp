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
    public class TaskController : ApiController
    {
        ToDoAppContext db = new ToDoAppContext();


        public IHttpActionResult MyTask(User user)
        {
            try
            {
                if (db.Users.Any(i=>i.Email==user.Email && i.Password==user.Password))
                {
                    var tasks = db.Tasks.Where(i => i.UserID == user.ID).ToList();
                    return Json(tasks);
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

    }
}
