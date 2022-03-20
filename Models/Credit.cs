using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCreditApp1_Lab_8.Models
{
    public class Credit
    {
        // ID кредита
        [DisplayName("ID кредита")]
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Название кредита")]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период, на который выдается кредит")]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [Required]
        [DisplayName("Максимальная сумма кредита")]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [Required]
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}