using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ToDoUI.Models.Entities;

namespace ToDoUI.Models.Map
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            ToTable("dbo.Logs");
        }
    }
}