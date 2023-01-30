using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        private DateTime _createdDate=DateTime.Now;
        public DateTime CreatedDate 
        { get { return _createdDate; }
            set { _createdDate = value; }
        }
        public DateTime? UpdateDate { get; set; } //bu alan boş bırakılabilir bir alan
        public DateTime? DeletedDate { get; set; }
        private Statu _statu = Statu.Active;
        public Statu Statu
        { get { return _statu; }
          set { _statu = value; }
        
        }


    }
}
