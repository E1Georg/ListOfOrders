using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("existingOrders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан город отправителя")]
        public string citySender { get; set; }
        [Required(ErrorMessage = "Не указан адрес отправителя")]
        public string addressSender { get; set; }
        [Required(ErrorMessage = "Не указан город получателя")]
        public string cityRecipient { get; set; }
        [Required(ErrorMessage = "Не указан адрес получателя")]
        public string addressRecipient { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Неверное значение для массы груза")]
        public float cargoWeight { get; set; }
        [BindProperty, DataType(DataType.Date)]
        [Required(ErrorMessage = "Не указана дата забора груза")]
        public DateOnly pickUpDate { get; set; }
    }
}
