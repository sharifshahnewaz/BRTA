using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public abstract class EntityBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private bool isDirty;

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }
        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
    }
}
