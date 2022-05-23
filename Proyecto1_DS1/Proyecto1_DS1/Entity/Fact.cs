using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1_DS1.Entity
{
    public class Fact:User
    {
        private string id;
        public int idOwner { get { return idOwner; } set { idOwner = value; } }
        public int idPost { get { return idPost; } set { idPost = value; } }
        public float total { get { return total; } set { total = value; } }
    }
}
