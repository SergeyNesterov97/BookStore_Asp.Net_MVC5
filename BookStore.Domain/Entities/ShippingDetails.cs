using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите вашу фамилию")]
        public string Fam { get; set; }

        [Required(ErrorMessage = "Укажите ваше отчество")]
        public string ndName { get; set; }

        [Required(ErrorMessage = "Введите адрес доставки")]
        public string Line1 { get; set; }

        [Required(ErrorMessage = "Укажите ваш номер телефона")]
        public string Number { get; set; }

        public bool CheckWrap { get; set; }
    }
}