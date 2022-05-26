using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите имя")]
        public string name { get; set; }
        
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите фамилию")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(100)]
        [Required(ErrorMessage = "Введите адрес")]
        public string adress { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите телефон")]
        public string phone { get; set; }

        [Display(Name = "email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Введите email")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }



    }
}
