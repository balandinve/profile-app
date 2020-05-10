using System;
using System.Collections.Generic;
using System.Text;

namespace profile.data
{
    public class CityDTO: IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
