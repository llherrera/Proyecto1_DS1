using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1_DS1.Entity
{
    public class Pago
    {
        private string id { get; set; }
        public int idOwner { get; set; }
        public int idFact { get; set; }
        public float total { get; set; }
        public DateTime fecha { get; set; }
    }
}
