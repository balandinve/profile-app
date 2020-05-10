using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace profile.data
{
    public class ProfileDTO: IBaseEntity<int>
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указан электронный адрес")]
        [MinLength(5, ErrorMessage = "Минимум 5 знаков")]
        public string Email { get; set; }

        //[RegularExpression(@"\p{L}", ErrorMessage = "Некорректные ФИО")]
        [Required(ErrorMessage = "Не указан электронный адрес")]
        //[RegularExpression(@"S""[\p{IsCyrillic}\p{P}\p{N}\s]*""", ErrorMessage = "Неверный формат")]
        [RegularExpression(@"^[\u0400-\u04FF\s]+$", ErrorMessage = "Неверный формат")]
        [MinLength(2)]
        public string FullName { get; set; }

        //[Display(Name = "Телефон")]
        //[DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Не указан номер телефона")]
        [RegularExpression(@"^(?:8(?:(?:21|22|23|24|51|52|53|54|55)|(?:15\d\d))?|\+?7)?(?:(?:3[04589]|4[012789]|8[^89\D]|9\d)\d)?\d{7}$")]
        //[MinLength(12, ErrorMessage = "Номер должен содержать 12 знаков"), MaxLength(12, ErrorMessage ="Номер должен содержать 12 знаков")]
        [Phone]
        public string PhoneNumber { get; set; }

        //[Display(Name = "Город")]
        [Required(ErrorMessage = "Не указан электронный адрес")]
        public int CityId { get; set; }

        public CityDTO City { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
