using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoUI.Models.Entities
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Lütfen yapılacak görev hakkında bilgi veriniz.")]
        [MaxLength(300, ErrorMessage = "Maksimum 300 karakter kullanmalısınız.")]
        public string Text { get; set; }
        [Required(ErrorMessage = "İşleminizi onaylıyor iseniz lüften kutucuğu işaretleyiniz.")]
        public bool IsCompleted { get; set; }
        public DateTime? DueDate { get; set; }

        
        public Guid UserID { get; set; }



        public Task()
        {
            if (DueDate == null)
            {
                DueDate = DateTime.Now;
            }
        }


        public virtual User User { get; set; }
        public virtual Log Log { get; set; }
    }
}