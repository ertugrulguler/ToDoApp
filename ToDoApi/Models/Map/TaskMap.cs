using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ToDoApi.Models.Map
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            ToTable("dbo.Tasks");
        }
    }
}