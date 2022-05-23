using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1_DS1.Entity
{
    public class User:AireBNB
    {
        private string id= ObjectId.GenerateNewId().ToString();
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
    }
}
