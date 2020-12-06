using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active,
            Delete
        }
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanged { get; set; }
        public bool IsValid => Validate();
        public abstract bool Validate();
        
    }
}
