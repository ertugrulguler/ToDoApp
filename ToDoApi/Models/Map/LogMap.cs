using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ToDoApi.Models.Entities;

namespace ToDoApi.Models.Map
{
    public class LogMap: EntityTypeConfiguration<Log>
    {
        public LogMap()
        {
            ToTable("dbo.Logs");
        }
    }
}