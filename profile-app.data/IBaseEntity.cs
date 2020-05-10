using System;
using System.Collections.Generic;
using System.Text;

namespace profile.data
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime InsertedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        DateTime? DeletedDate { get; set; }
    }
}
