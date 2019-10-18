using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoApi.Models.DataInitializer;
using ToDoApi.Models.Entities;

namespace ToDoApi.Models.Context
{
    public class ToDoAppContext:DbContext
    {
        public ToDoAppContext()
        {
            Database.Connection.ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ToDoAppProject;Integrated Security=True;";
            Database.SetInitializer(new ToDoAppInitializer());
        }

        /*DESKTOP-M9NVTPB\SQLEXPRESS*/

        public DbSet<Log> Logs { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
 