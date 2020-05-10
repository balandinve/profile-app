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
        [EmailAddress]
        [Display(Name = "Электронная почта")]
        [UIHint("EmailAddress")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [RegularExpression(@"\p{L}", ErrorMessage = "Некорректные ФИО")]
        [Display(Name = "ФИО")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Город")]
        public int CityId { get; set; }

        public CityDTO City { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
