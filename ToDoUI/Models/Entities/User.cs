using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoUI.Models.Entities
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "İsim girilmesi zorunludur.Lütfen bir isim giriniz.")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Soyisim girilmesi zorunludur.Lütfen bir soyisim giriniz.")]

        public string Lastname { get; set; }

        [Required(ErrorMessage = "Mail adresi girilmesi zorunludur.Lütfen bir mail adresi giriniz.")]
        [EmailAddress(ErrorMessage = "Girdiğiniz veri mail adresi tiplerine uyumlu değildir.")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 karakter girilmelidir."), MinLength(5, ErrorMessage = "Minimum 5 karakter girilmelidir.")]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public int LogID { get; set; }


        public virtual List<Log> Logs { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}