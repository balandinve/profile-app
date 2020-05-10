using System;
using System.ComponentModel.DataAnnotations;

namespace profile.data
{
    public class City: IBaseEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
