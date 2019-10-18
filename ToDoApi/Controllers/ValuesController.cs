using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ToDoApi.Controllers
{
    public class ValuesController : ApiController
    {
        //public IHttpActionResult Get()
        //{
        //    //try
        //    //{
               
        //    //    if (users==null)
        //    //    {
        //    //        return NotFound();
        //    //    }
        //    //    else
        //    //    {
        //    //        return Ok(users);
        //    //    }
        //    //}
        //    //catch (Exception e)
        //    //{

        //    //    throw new Exception(e.Message);
        //    //}
            
            
            
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
