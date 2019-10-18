using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoApi.Models.Entities
{
    public class Log
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime? LogDate { get; set; }
        public Guid UserID { get; set; }


        public Log()
        {
            LogDate = DateTime.Now;
        }


        public virtual User User { get; set; }
    }
}