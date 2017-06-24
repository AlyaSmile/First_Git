using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Имя должно быть заполнено!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email должнен быть заполнен!")]
        [RegularExpression (".+\\@.+\\..+",ErrorMessage ="Введите корректный Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите телефон!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Введите ждать ли вас!")]
        public bool? WillAttend { get; set; }
    }
}
