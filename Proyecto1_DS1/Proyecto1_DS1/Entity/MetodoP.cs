
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1_DS1.Entity
{
    public class MetodoP:User
    {
        private string id;
        public int idOwner { get; set; }
        public string entidadBancaria { get; set; }
        public string info { get; set; }
    }
}
