using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
   public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string UserName{ get; set; }

        [Required(ErrorMessage = "Укажите ваш пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Укажите ваш email")]
        public string EmailId { get; set; }

        public int RoleId { get; set; }
    }
}
