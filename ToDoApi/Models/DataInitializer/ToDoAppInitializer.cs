using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApi.Models.Context;
using ToDoApi.Models.Entities;

namespace ToDoApi.Models.DataInitializer
{
    public class ToDoAppInitializer : DropCreateDatabaseIfModelChanges<ToDoAppContext>
    {
        protected override void Seed(ToDoAppContext context)
        {
            var id1 = new Guid();
            var id2 = new Guid();
            List<User> users = new List<User>()
            {
                new User(){ ID=id1, Firstname="Murat",Lastname="Başeren", Email="murat@gmail.com", Password="12345", ConfirmPassword="12345"},
                new User(){ ID=id2, Firstname ="Ertuğrul",Lastname="Güler", Email="ertugrul@gmail.com", Password="1234567", ConfirmPassword="1234567"},

            };

            foreach (var item in users)
            {
                context.Users.Add(item);
            }
            context.SaveChanges();

           

            List<Entities.Task> tasks = new List<Entities.Task>()
            {
                new Task(){ID=1, Text="Bu görev tamamlandı.", DueDate=DateTime.Now.AddDays(-10), IsCompleted=true,UserID=id1},
                new Task(){ID=2, Text="Bu görev tamamlanmadı.", DueDate=DateTime.Now.AddDays(-2), IsCompleted=false,UserID=id1},
                new Task(){ID=3, Text="Bu görev tamamlandı.", DueDate=DateTime.Now.AddDays(-6), IsCompleted=true, UserID=id2},
                new Task(){ID=4, Text="Bu görev tamamlanmadı.", DueDate=DateTime.Now.AddDays(-1),IsCompleted=false, UserID=id2}


            };
            foreach (var item in tasks)
            {
                context.Tasks.Add(item);
            }
            context.SaveChanges();

            List<Log> logs = new List<Log>()
            {
                new Log(){ ID=1,LogDate=DateTime.Now.AddDays(-10), UserID=id1, Text="Murat Başeren tarafından "},
                new Log() { ID = 2,LogDate = DateTime.Now.AddDays(-3)},
                new Log() { ID = 3,LogDate = DateTime.Now.AddDays(-4)},
                new Log() { ID = 4,LogDate = DateTime.Now.AddDays(-5)},
            };

            foreach (var item in logs)
            {
                context.Logs.Add(item);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}